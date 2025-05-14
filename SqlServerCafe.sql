
CREATE DATABASE CafeShopDB;
GO

USE CafeShopDB;
GO


-- Xóa bảng nếu đã tồn tại (tránh lỗi khi chạy lại)
IF OBJECT_ID('dbo.customers', 'U') IS NOT NULL DROP TABLE dbo.customers;
IF OBJECT_ID('dbo.orders', 'U') IS NOT NULL DROP TABLE dbo.orders;
IF OBJECT_ID('dbo.products', 'U') IS NOT NULL DROP TABLE dbo.products;
IF OBJECT_ID('dbo.users', 'U') IS NOT NULL DROP TABLE dbo.users;
GO

-- Bảng users
CREATE TABLE users (
    id INT PRIMARY KEY IDENTITY(1,1),
    username VARCHAR(100) NULL,
    password VARCHAR(100) NULL,
    profile_image VARCHAR(255) NULL,
    role VARCHAR(50) NULL,
    status VARCHAR(50) NULL,
    date_reg DATE NULL
);

-- Dữ liệu mặc định
INSERT INTO users (username, password, profile_image, role, status, date_reg)
VALUES ('admin', 'admin123', 'admin.png', 'Admin', 'Active', '2025-05-11'),
('john_doe', '123456', 'john.png', 'Cashier', 'Active', '2025-05-01'),
('jane_smith', 'password', 'jane.jpg', 'Cashier', 'Inactive', '2025-04-28'),
('employee1', 'emp123', 'emp1.png', 'Cashier', 'Active', '2025-05-05'),
('test', '123123123', 'emp1.png', 'Cashier', 'Active', '2025-05-05');



-- Bảng products
CREATE TABLE products (
    id INT PRIMARY KEY IDENTITY(1,1),
    prod_id VARCHAR(50) NULL,
    prod_name VARCHAR(100) NULL,
    prod_type VARCHAR(50) NULL,
    prod_stock INT NULL,
    prod_price FLOAT NULL,
    prod_status VARCHAR(MAX) NULL,
    prod_image VARCHAR(MAX) NULL,
    date_insert DATE NULL,
    date_update DATE NULL,
    date_delete DATE NULL
);

-- Bảng orders
CREATE TABLE orders (
    id INT PRIMARY KEY IDENTITY(1,1),
    customer_id INT NULL,
    prod_id VARCHAR(MAX) NULL,
    prod_name VARCHAR(MAX) NULL,
    prod_type VARCHAR(MAX) NULL,
    prod_price FLOAT NULL,
    order_date DATE NULL,
    delete_order DATE NULL,
    qty INT NULL
);

-- Bảng customers
CREATE TABLE customers (
    id INT PRIMARY KEY IDENTITY(1,1),
    customer_id INT NULL,
    total_price FLOAT NULL,
    date DATE NULL,
    amount FLOAT NULL,
    change FLOAT NULL,
    users VARCHAR(MAX) NULL
);
GO





