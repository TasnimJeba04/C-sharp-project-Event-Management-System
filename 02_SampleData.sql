-- =============================================================
-- Event Management System  ::  Sample Data
-- Run AFTER 01_CreateDatabase.sql
-- =============================================================

USE EventManagementDB;
GO

-- -----------------------------
-- USERS
-- -----------------------------
INSERT INTO Users (FullName, Email, Password, Phone, UserType) VALUES
('System Owner',     'super@event.com',    'super123', '01700000000', 'SuperAdmin'),
('Rahim Organizer',  'admin@event.com',    'admin123', '01711111111', 'Admin'),
('Karim Organizer',  'admin2@event.com',   'admin123', '01722222222', 'Admin'),
('Azmain Customer',  'customer@event.com', 'cust123',  '01733333333', 'Customer'),
('Nabila Customer',  'nabila@event.com',   'cust123',  '01744444444', 'Customer'),
('Sadia Customer',   'sadia@event.com',    'cust123',  '01755555555', 'Customer');
GO

-- -----------------------------
-- EVENTS  (OrganizerID 2 = Rahim, 3 = Karim)
-- -----------------------------
INSERT INTO Events (EventName, Description, EventDate, Location, Price, AvailableSeats, Category, OrganizerID) VALUES
('Tech Summit 2026',    'Annual technology conference featuring AI, ML and Cloud talks.', '2026-06-15 10:00', 'Dhaka ICT Tower', 1500.00, 200, 'Technology', 2),
('Music Fest Live',     'Open-air music festival with top local bands.',                  '2026-07-04 18:00', 'Army Stadium',    2500.00, 500, 'Music',      2),
('Startup Pitch Night', 'Pitch your idea in front of investors.',                         '2026-05-20 17:00', 'Banani Club',      800.00,  80, 'Business',   3),
('Food Carnival',       'Taste the best street food from across the country.',            '2026-08-10 12:00', 'Hatirjheel',      300.00, 1000, 'Food',       3),
('Marathon Run',        '10k city marathon for charity.',                                 '2026-09-22 06:00', 'Manik Mia Avenue', 500.00, 300, 'Sports',     2);
GO

-- -----------------------------
-- DISCOUNTS / COUPONS
-- -----------------------------
INSERT INTO Discounts (CouponCode, DiscountPercent, ExpiryDate, IsActive) VALUES
('NEW10',    10.00, '2026-12-31', 1),
('SUMMER20', 20.00, '2026-09-30', 1),
('VIP30',    30.00, '2026-12-31', 1),
('OLD50',    50.00, '2024-01-01', 0); -- expired/inactive on purpose
GO

-- -----------------------------
-- BOOKINGS  (CustomerID 4 = Azmain)
-- -----------------------------
INSERT INTO Bookings (CustomerID, EventID, NumberOfTickets, TotalAmount, DiscountID, BookingDate, Status) VALUES
(4, 1, 2, 2700.00, 1, '2026-04-10', 'Confirmed'),  -- 2 x 1500 = 3000, 10% off = 2700
(4, 4, 4, 1200.00, NULL, '2026-04-15', 'Confirmed'),
(5, 2, 1, 2000.00, 2, '2026-04-18', 'Confirmed'),  -- 2500 - 20% = 2000
(6, 3, 1,  800.00, NULL, '2026-04-20', 'Pending');
GO

-- -----------------------------
-- PAYMENTS
-- -----------------------------
INSERT INTO Payments (BookingID, Amount, PaymentMethod, PaymentStatus) VALUES
(1, 2700.00, 'bKash',       'Paid'),
(2, 1200.00, 'Credit Card', 'Paid'),
(3, 2000.00, 'Nagad',       'Paid');
GO

-- -----------------------------
-- REVIEWS
-- -----------------------------
INSERT INTO Reviews (CustomerID, EventID, Rating, Comment) VALUES
(4, 1, 5, 'Amazing tech sessions! Learned a lot.'),
(5, 2, 4, 'Great music but a bit crowded.'),
(4, 4, 5, 'Best food carnival ever, will come again.');
GO

PRINT 'Sample data inserted successfully.';
