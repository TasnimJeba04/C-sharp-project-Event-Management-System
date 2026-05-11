USE EventManagementDB;
GO

-- 1. Add ImagePath column to Events (skip if already exists)
IF COL_LENGTH('Events','ImagePath') IS NULL
BEGIN
    ALTER TABLE Events ADD ImagePath NVARCHAR(300) NULL;
END
GO

-- 2. Clear existing data so we can reseed with BD halls
DELETE FROM Reviews;
DELETE FROM Payments;
DELETE FROM Bookings;
DELETE FROM Events;

-- Reset identity counters so IDs start from 1
DBCC CHECKIDENT ('Events',   RESEED, 0);
DBCC CHECKIDENT ('Bookings', RESEED, 0);
DBCC CHECKIDENT ('Payments', RESEED, 0);
DBCC CHECKIDENT ('Reviews',  RESEED, 0);
GO

-- 3. Insert BD-themed halls (OrganizerID 2 = Rahim, 3 = Karim from existing Users)
INSERT INTO Events
(EventName, Description, EventDate, Location, Price, AvailableSeats, Category, OrganizerID, ImagePath)
VALUES
('Sena Kunjo',                          'Premium military hall, perfect for grand weddings.',         '2026-06-15 18:00', 'Dhaka Cantonment',     150000.00, 800,  'Wedding',              2, 'Images/sena_kunjo.jpg'),
('Army Golf Club',                      'Elegant club venue with garden setting.',                   '2026-06-20 17:00', 'Kurmitola',            120000.00, 500,  'Wedding',              2, 'Images/army_golf_club.jpg'),
('Sena Malancha',                       'Spacious banquet hall with full service.',                  '2026-07-04 18:00', 'Dhaka Cantonment',     100000.00, 600,  'Wedding',              2, 'Images/sena_malancha.jpg'),
('Dhaka Club',                          'Heritage club, ideal for engagements and anniversaries.',   '2026-07-10 19:00', 'Ramna, Dhaka',          80000.00, 300,  'Engagement',           3, 'Images/dhaka_club.jpg'),
('Police Convention Hall',              'Modern convention hall with AV facilities.',                '2026-08-05 10:00', 'Eskaton, Dhaka',        90000.00, 700,  'Corporate Conference', 3, 'Images/police_convention.jpg'),
('RAOWA Convention Hall',               'Prestigious venue for corporate and family events.',        '2026-08-15 17:00', 'Mohakhali, Dhaka',     110000.00, 600,  'Corporate Conference', 2, 'Images/raowa.jpg'),
('International Convention City Bashundhara', 'Largest convention center for big events.',           '2026-09-01 09:00', 'Bashundhara, Dhaka',   250000.00, 2000, 'Seminar',              3, 'Images/iccb.jpg'),
('Bangabandhu International Conference Center','National-level conference and seminar venue.',       '2026-09-10 09:00', 'Agargaon, Dhaka',      300000.00, 1500, 'Seminar',              2, 'Images/bicc.jpg'),
('Officers Club Dhaka',                 'Sophisticated club for birthdays and family gatherings.',   '2026-09-20 18:00', 'Baridhara, Dhaka',      70000.00, 250,  'Birthday',             3, 'Images/officers_club.jpg'),
('Ladies Club Dhaka',                   'Charming venue for cultural programs and graduations.',     '2026-10-01 17:00', 'Eskaton, Dhaka',        60000.00, 200,  'Cultural Program',     2, 'Images/ladies_club.jpg');
GO

-- 4. Add a few more event categories worth of bookings/coupons (optional refresh)
-- Update existing coupons or add new ones
IF NOT EXISTS (SELECT 1 FROM Discounts WHERE CouponCode='BD25')
    INSERT INTO Discounts (CouponCode, DiscountPercent, ExpiryDate, IsActive)
    VALUES ('BD25', 25.00, '2026-12-31', 1);
GO

PRINT 'Bangladesh hall data inserted successfully!';