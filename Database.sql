-- ==========================================================
-- HARDWARETRACK v3.0 DATABASE SETUP (SINGLE BRANCH)
-- ==========================================================

DROP DATABASE IF EXISTS HardwareTrackInventory;
CREATE DATABASE HardwareTrackInventory CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE HardwareTrackInventory;

-- ==========================================
-- 1. LOOKUP TABLES
-- ==========================================
CREATE TABLE Roles (
    RoleID INT AUTO_INCREMENT PRIMARY KEY, 
    RoleName VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE Categories (
    CategoryID INT AUTO_INCREMENT PRIMARY KEY,
    CategoryName VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE Suppliers (
    SupplierID INT AUTO_INCREMENT PRIMARY KEY, 
    Name VARCHAR(100) NOT NULL, 
    ContactInfo VARCHAR(150) NULL
);

-- ==========================================
-- 2. USERS
-- ==========================================
CREATE TABLE Users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    FullName VARCHAR(100) NOT NULL,
    RoleID INT NOT NULL,
    Status VARCHAR(20) NOT NULL DEFAULT 'Active',
    LastLogin DATETIME NULL,
    FOREIGN KEY (RoleID) REFERENCES Roles(RoleID)
);

-- ==========================================
-- 3. HARDWARE MASTER
-- ==========================================
CREATE TABLE Hardware (
    HardwareID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(150) NOT NULL UNIQUE, 
    Category VARCHAR(50) NOT NULL,
    Status VARCHAR(20) NOT NULL DEFAULT 'Active',
    Quantity INT NOT NULL DEFAULT 0
);

-- ==========================================
-- 4. TRANSACTIONS (NO BRANCH IDs)
-- ==========================================
CREATE TABLE Receivings (
    ReceivingID INT AUTO_INCREMENT PRIMARY KEY, 
    SupplierID INT NOT NULL,
    ReceivedBy VARCHAR(50) NOT NULL, 
    DateReceived DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    Status VARCHAR(20) NOT NULL DEFAULT 'Pending', 
    ApprovedBy VARCHAR(50) NULL, 
    ApprovalDate DATETIME NULL,
    FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID)
);

CREATE TABLE ReceivingItems (
    ReceivingItemID INT AUTO_INCREMENT PRIMARY KEY, 
    ReceivingID INT NOT NULL, 
    HardwareID INT NOT NULL, 
    Quantity INT NOT NULL,
    FOREIGN KEY (ReceivingID) REFERENCES Receivings(ReceivingID) ON DELETE CASCADE, 
    FOREIGN KEY (HardwareID) REFERENCES Hardware(HardwareID)
);

CREATE TABLE Issuances (
    IssuanceID INT AUTO_INCREMENT PRIMARY KEY, 
    HardwareID INT NOT NULL,
    IssuedTo VARCHAR(100) NOT NULL, 
    QuantityIssued INT NOT NULL, 
    IssuedBy VARCHAR(50) NOT NULL,
    IssuedDate DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP, 
    Status VARCHAR(20) NOT NULL DEFAULT 'Pending',
    ApprovedBy VARCHAR(50) NULL, 
    ApprovalDate DATETIME NULL,
    FOREIGN KEY (HardwareID) REFERENCES Hardware(HardwareID)
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

-- ==========================================
-- 5. LOGS & NOTIFICATIONS
-- ==========================================
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

-- ==========================================
-- 6. SEED DATA (MUST MATCH HARDCODED HASHES)
-- ==========================================

-- Roles (RoleID=1 MUST be Administrator)
INSERT INTO Roles (RoleName) VALUES 
('Administrator'), 
('Inventory Manager'), 
('Staff');

-- Categories (Replaces hardcoded combobox items)
INSERT INTO Categories (CategoryName) VALUES 
('Laptop'), 
('Desktop'), 
('Monitor'), 
('Peripheral'), 
('Printer'), 
('Network');

-- Suppliers
INSERT INTO Suppliers (Name, ContactInfo) VALUES 
('Tech Distribution PH', 'sales@techdist.ph'), 
('Global IT Solutions', 'support@globalit.com');

-- Users (Passwords are SHA-256 hashed)
-- Admin: admin123 | Manager: manager123 | Staff: staff123
INSERT INTO Users (Username, PasswordHash, FullName, RoleID, Status) VALUES 
('admin', '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', 'System Administrator', 1, 'Active'),
('manager', 'b8d3b9e8086f7040f1843b976ab8b46470dee56c4e610db0f308af5bfa38925e', 'Inventory Manager', 2, 'Active'),
('staff', '9525c1e6ebc3b95bd54cf789dc986014b7bf84eb432728b606073c0558f29c85', 'Staff Member', 3, 'Active');

-- Hardware Items (With initial quantities so the grid isn't empty)
INSERT INTO Hardware (Name, Category, Status, Quantity) VALUES 
('Dell Latitude 5420', 'Laptop', 'Active', 15),
('HP EliteDesk 800', 'Desktop', 'Active', 8),
('Logitech MX Master 3', 'Peripheral', 'Active', 25),
('Samsung 24" Monitor', 'Monitor', 'Active', 12),
('Cisco 24-Port Switch', 'Network', 'Active', 3),
('Epson L3110 Printer', 'Printer', 'Active', 5),
('Lenovo ThinkPad T14', 'Laptop', 'Active', 7),
('A4Tech Keyboard', 'Peripheral', 'Active', 40);