USE EventManagementDB;

-- Find and delete the duplicate Radisson Blu (the latest one added)
DECLARE @id INT;
SELECT @id = MAX(EventID) FROM Events WHERE EventName = 'Radisson Blu';

-- Delete in correct order
DELETE FROM Reviews  WHERE EventID = @id;
DELETE FROM Payments WHERE BookingID IN (SELECT BookingID FROM Bookings WHERE EventID = @id);
DELETE FROM Bookings WHERE EventID = @id;
DELETE FROM Events   WHERE EventID = @id;

PRINT 'Duplicate Radisson Blu deleted! Only one remains now.';

-- Also fix the supported event types so "Good for: —" goes away
UPDATE Events
SET SupportedEventTypes = 'Wedding,Corporate Conference,Seminar'
WHERE EventName = 'Radisson Blu';

PRINT 'Event types updated!';