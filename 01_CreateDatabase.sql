-- =============================================================
-- Event Management System  ::  Database Creation Script
-- Run this file inside SSMS, after creating database EventManagementDB
-- (localdb)\MSSQLLocalDB
-- =============================================================

USE EventManagementDB;
GO

-- ----------------------------------------------------------------
-- Drop tables in correct order (children first) - safe for re-runs
-- ----------------------------------------------------------------
IF OBJECT_ID('Reviews',  'U') IS NOT NULL DROP TABLE Reviews;
IF OBJECT_ID('Payments', 'U') IS NOT NULL DROP TABLE Payments;
IF OBJECT_ID('Bookings', 'U') IS NOT NULL DROP TABLE Bookings;
IF OBJECT_ID('Discounts','U') IS NOT NULL DROP TABLE Discounts;
IF OBJECT_ID('Events',   'U') IS NOT NULL DROP TABLE Events;
IF OBJECT_ID('Users',    'U') IS NOT NULL DROP TABLE Users;
GO

-- ----------------------------------------------------------------
-- 1. USERS  (Super Admin / Admin / Customer)
-- ----------------------------------------------------------------
CREATE TABLE Users (
    UserID       INT IDENTITY(1,1) PRIMARY KEY,
    FullName     NVARCHAR(100) NOT NULL,
    Email        NVARCHAR(100) NOT NULL UNIQUE,
    Password     NVARCHAR(100) NOT NULL,
    Phone        NVARCHAR(20)  NULL,
    UserType     NVARCHAR(20)  NOT NULL CHECK (UserType IN ('SuperAdmin','Admin','Customer')),
    CreatedDate  DATETIME      NOT NULL DEFAULT GETDATE()
);
GO

-- ----------------------------------------------------------------
-- 2. EVENTS (created by an Organizer = Admin user)
-- ----------------------------------------------------------------
CREATE TABLE Events (
    EventID         INT IDENTITY(1,1) PRIMARY KEY,
    EventName       NVARCHAR(200) NOT NULL,
    Description     NVARCHAR(500) NULL,
    EventDate       DATETIME      NOT NULL,
    Location        NVARCHAR(200) NOT NULL,
    Price           DECIMAL(10,2) NOT NULL CHECK (Price >= 0),
    AvailableSeats  INT           NOT NULL CHECK (AvailableSeats >= 0),
    Category        NVARCHAR(50)  NULL,
    OrganizerID     INT           NOT NULL,
    CONSTRAINT FK_Events_Organizer FOREIGN KEY (OrganizerID)
        REFERENCES Users(UserID)
);
GO

-- ----------------------------------------------------------------
-- 3. DISCOUNTS / COUPONS
-- ----------------------------------------------------------------
CREATE TABLE Discounts (
    DiscountID       INT IDENTITY(1,1) PRIMARY KEY,
    CouponCode       NVARCHAR(50)  NOT NULL UNIQUE,
    DiscountPercent  DECIMAL(5,2)  NOT NULL CHECK (DiscountPercent BETWEEN 0 AND 100),
    ExpiryDate       DATETIME      NOT NULL,
    IsActive         BIT           NOT NULL DEFAULT 1
);
GO

-- ----------------------------------------------------------------
-- 4. BOOKINGS (one customer books one event, optional coupon)
-- ----------------------------------------------------------------
CREATE TABLE Bookings (
    BookingID        INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID       INT           NOT NULL,
    EventID          INT           NOT NULL,
    NumberOfTickets  INT           NOT NULL CHECK (NumberOfTickets > 0),
    TotalAmount      DECIMAL(10,2) NOT NULL,
    DiscountID       INT           NULL,
    BookingDate      DATETIME      NOT NULL DEFAULT GETDATE(),
    Status           NVARCHAR(20)  NOT NULL DEFAULT 'Pending'
                       CHECK (Status IN ('Pending','Confirmed','Cancelled')),
    CONSTRAINT FK_Bookings_Customer FOREIGN KEY (CustomerID) REFERENCES Users(UserID),
    CONSTRAINT FK_Bookings_Event    FOREIGN KEY (EventID)    REFERENCES Events(EventID),
    CONSTRAINT FK_Bookings_Discount FOREIGN KEY (DiscountID) REFERENCES Discounts(DiscountID)
);
GO

-- ----------------------------------------------------------------
-- 5. PAYMENTS  (one payment per booking)
-- ----------------------------------------------------------------
CREATE TABLE Payments (
    PaymentID      INT IDENTITY(1,1) PRIMARY KEY,
    BookingID      INT           NOT NULL,
    Amount         DECIMAL(10,2) NOT NULL,
    PaymentMethod  NVARCHAR(50)  NOT NULL,
    PaymentDate    DATETIME      NOT NULL DEFAULT GETDATE(),
    PaymentStatus  NVARCHAR(20)  NOT NULL DEFAULT 'Paid'
                     CHECK (PaymentStatus IN ('Paid','Failed','Refunded')),
    CONSTRAINT FK_Payments_Booking FOREIGN KEY (BookingID) REFERENCES Bookings(BookingID)
);
GO

-- ----------------------------------------------------------------
-- 6. REVIEWS (customer reviews on attended event)
-- ----------------------------------------------------------------
CREATE TABLE Reviews (
    ReviewID    INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID  INT          NOT NULL,
    EventID     INT          NOT NULL,
    Rating      INT          NOT NULL CHECK (Rating BETWEEN 1 AND 5),
    Comment     NVARCHAR(500) NULL,
    ReviewDate  DATETIME     NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_Reviews_Customer FOREIGN KEY (CustomerID) REFERENCES Users(UserID),
    CONSTRAINT FK_Reviews_Event    FOREIGN KEY (EventID)    REFERENCES Events(EventID)
);
GO

PRINT 'All tables created successfully.';
