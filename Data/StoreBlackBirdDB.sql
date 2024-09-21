-- Active: 1726850418689@@bu2aymciuhchn1emnt1u-mysql.services.clever-cloud.com@3306@bu2aymciuhchn1emnt1u
CREATE TABLE Products(
    Id int AUTO_INCREMENT PRIMARY KEY NOT NULL,
    Name VARCHAR(50) NOT NULL,
    Description TEXT NOT NULL,
    Price DECIMAL NOT NULL,
    StockQuantity INT NOT NULL,
    Color CHAR(25) NOT NULL,
    Status ENUM("Active", "Inactive", "Discontinued") NOT NULL
);

CREATE TABLE ProductsOrderDetail(
    Id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    Color VARCHAR(30) NOT NULL,
    Size VARCHAR(30) NOT NULL,
    OrderDetailsID INT NOT NULL,
    ProductID INT NOT NULL,
    Foreign Key (OrderDetailsID) REFERENCES OrderDetails(Id),
    Foreign Key (ProductID) REFERENCES Products(Id)
);

CREATE TABLE OrderDetails(
    Id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    Quantity INT NOT NULL,
    UnitPrice DECIMAL NOT NULL,
    OrderDate DATE NOT NULL,
    PaymentMethod ENUM("Credit Card", "Saving Card", "Cash") NOT NULL,
    OrderID INT NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES Orders(Id)
);

CREATE TABLE Orders(
    Id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    ShippingAddress DATE NOT NULL,
    TotalAmount DECIMAL NOT NULL,
    OrderStatus ENUM("Pending", "Processing", "Shipped", "Delivered", "Cancelled") NOT NULL,
    UserID INT NOT NULL,
    FOREIGN KEY (UserID) REFERENCES Users(Id)
);

CREATE TABLE Users(
    Id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    FirstName CHAR(50) NOT NULL,
    SecondName CHAR(50) NOT NULL,
    LastFirstName CHAR(50) NOT NULL,
    LastSecondName CHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    PhoneNumber VARCHAR(30) NOT NULL,
    AddressID INT NOT NULL,
    FOREIGN KEY (AddressID) REFERENCES Address(Id)
);

CREATE TABLE Address(
    Id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    NumberAddress INT NOT NULL,
    NameAddress CHAR(25) NOT NULL,
    City CHAR(50) NOT NULL,
    PostalCode CHAR(15) NOT NULL
);

DROP Table Address;
DROP TABLE `OrderDetails`;
DROP Table `Orders`;
DROP Table `Products`;
DROP TABLE `ProductsOrderDetail`;
DROP TABLE `Users`;

show TABLES;
