-- ==========================================================
-- HARDWARETRACK INVENTORY DATABASE SETUP
-- Matches the exact VB.NET codebase requirements
-- ==========================================================

DROP DATABASE IF EXISTS HardwareTrackInventory;
CREATE DATABASE HardwareTrackInventory CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE HardwareTrackInventory;

-- ----------------------------------------------------------
-- 1. CORE LOOKUP TABLES
-- ----------------------------------------------------------
CREATE TABLE Roles (
    RoleID INT AUTO_INCREMENT PRIMARY KEY,
    RoleName VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE Branches (
    BranchID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL
);

-- ----------------------------------------------------------
-- 2. USERS & SUPPLIERS
-- ----------------------------------------------------------
CREATE TABLE Users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL, -- Note: Currently plaintext in the code
    FullName VARCHAR(100) NOT NULL,
    RoleID INT NOT NULL,
    BranchID INT NULL,
    Status VARCHAR(20) NOT NULL DEFAULT 'Active',
    LastLogin DATETIME NULL,
    FOREIGN KEY (RoleID) REFERENCES Roles(RoleID),
    FOREIGN KEY (BranchID) REFERENCES Branches(BranchID)
);

CREATE TABLE Suppliers (
    SupplierID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    ContactInfo VARCHAR(150) NULL
);

-- ----------------------------------------------------------
-- 3. HARDWARE MASTER LIST & STOCK
-- ----------------------------------------------------------
CREATE TABLE Hardware (
    HardwareID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(150) NOT NULL,
    Category VARCHAR(50) NOT NULL,
    Status VARCHAR(20) NOT NULL DEFAULT 'Active'
);

CREATE TABLE BranchStock (
    BranchID INT NOT NULL,
    HardwareID INT NOT NULL,
    Quantity INT NOT NULL DEFAULT 0,
    PRIMARY KEY (BranchID, HardwareID), -- Composite PK enables ON DUPLICATE KEY UPDATE
    FOREIGN KEY (BranchID) REFERENCES Branches(BranchID),
    FOREIGN KEY (HardwareID) REFERENCES Hardware(HardwareID)
);

-- ----------------------------------------------------------
-- 4. TRANSACTIONS: RECEIVING (IN)
-- ----------------------------------------------------------
CREATE TABLE Receivings (
    ReceivingID INT AUTO_INCREMENT PRIMARY KEY,
    SupplierID INT NOT NULL,
    BranchID INT NOT NULL,
    ReceivedBy VARCHAR(50) NOT NULL,
    DateReceived DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    Status VARCHAR(20) NOT NULL DEFAULT 'Pending',
    ApprovedBy VARCHAR(50) NULL,
    ApprovalDate DATETIME NULL,
    FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID),
    FOREIGN KEY (BranchID) REFERENCES Branches(BranchID)
);

CREATE TABLE ReceivingItems (
    ReceivingItemID INT AUTO_INCREMENT PRIMARY KEY,
    ReceivingID INT NOT NULL,
    HardwareID INT NOT NULL,
    Quantity INT NOT NULL,
    FOREIGN KEY (ReceivingID) REFERENCES Receivings(ReceivingID) ON DELETE CASCADE,
    FOREIGN KEY (HardwareID) REFERENCES Hardware(HardwareID)
);

-- ----------------------------------------------------------
-- 5. TRANSACTIONS: ISSUANCE (OUT) & RETURNS
-- ----------------------------------------------------------
CREATE TABLE Issuances (
    IssuanceID INT AUTO_INCREMENT PRIMARY KEY,
    HardwareID INT NOT NULL,
    BranchID INT NOT NULL,
    IssuedTo VARCHAR(100) NOT NULL,
    QuantityIssued INT NOT NULL,
    IssuedBy VARCHAR(50) NOT NULL,
    IssuedDate DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    Status VARCHAR(20) NOT NULL DEFAULT 'Approved',
    FOREIGN KEY (HardwareID) REFERENCES Hardware(HardwareID),
    FOREIGN KEY (BranchID) REFERENCES Branches(BranchID)
);

CREATE TABLE Returns (
    ReturnID INT AUTO_INCREMENT PRIMARY KEY,
    IssuanceID INT NOT NULL,
    QuantityReturned INT NOT NULL,
    IsDefective TINYINT(1) NOT NULL DEFAULT 0,
    Status VARCHAR(20) NOT NULL DEFAULT 'Pending',
    ReturnDate DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (IssuanceID) REFERENCES Issuances(IssuanceID)
);

-- ----------------------------------------------------------
-- 6. SYSTEM LOGS & NOTIFICATIONS
-- ----------------------------------------------------------
CREATE TABLE Notifications (
    NotificationID INT AUTO_INCREMENT PRIMARY KEY,
    RecipientUsername VARCHAR(50) NOT NULL,
    Message VARCHAR(500) NOT NULL,
    IsRead TINYINT(1) NOT NULL DEFAULT 0,
    DateCreated DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE Activities (
    ActivityID INT AUTO_INCREMENT PRIMARY KEY,
    Username VARCHAR(50) NOT NULL,
    UserRole VARCHAR(50) NOT NULL,
    Action VARCHAR(255) NOT NULL,
    ActivityDate DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
);

-- ----------------------------------------------------------
-- 7. SEED DATA (INITIAL REQUIREMENTS TO RUN THE APP)
-- ----------------------------------------------------------

-- A. Roles (RoleID=1 MUST be Administrator for notification queries)
INSERT INTO Roles (RoleName) VALUES 
('Administrator'), 
('Inventory Manager'), 
('Staff');

-- B. Branches (Internal Storage Locations)
INSERT INTO Branches (Name) VALUES 
('Main Office'), 
('Storage Room'), 
('Warehouse');

-- C. Default Users
-- Password is 'admin123' (Matches the User Manual documentation)
INSERT INTO Users (Username, PasswordHash, FullName, RoleID, BranchID, Status) VALUES 
('admin', 'admin123', 'System Administrator', 1, 1, 'Active'),
('manager', 'manager123', 'Inventory Manager', 2, 2, 'Active'),
('staff', 'staff123', 'Staff Member', 3, 1, 'Active');

-- D. Default Suppliers (Required because there is no UI to add them)
INSERT INTO Suppliers (Name, ContactInfo) VALUES 
('Tech Distribution PH', 'sales@techdist.ph'),
('Global IT Solutions', 'support@globalit.com'),
('Local Hardware Trading', '0917-123-4567');

-- E. Sample Hardware (So the dashboard isn't empty on first run)
INSERT INTO Hardware (Name, Category, Status) VALUES 
('Dell XPS 15', 'Laptop', 'Active'),
('HP EliteDesk', 'Desktop', 'Active'),
('Logitech MX Master 3', 'Peripheral', 'Active'),
('Cisco 24-Port Switch', 'Network', 'Active');

-- F. Sample Initial Stock
INSERT INTO BranchStock (BranchID, HardwareID, Quantity) VALUES 
(1, 1, 10), -- 10 Dell XPS in Main Office
(2, 2, 5),  -- 5 HP EliteDesk in Storage Room
(1, 3, 20), -- 20 Logitech Mice in Main Office
(3, 4, 2);  -- 2 Cisco Switches in Warehouse (Low Stock)