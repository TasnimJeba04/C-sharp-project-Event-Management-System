USE EventManagementDB;

SELECT b.BookingID,
       b.CustomerID,
       u.FullName    AS CustomerName,
       u.Phone,
       e.EventName   AS Hall,
       e.OrganizerID AS HallOwnerID,
       org.FullName  AS HallOwnerName,
       b.Status,
       b.BookingDate
FROM Bookings b
JOIN Users u   ON b.CustomerID  = u.UserID
JOIN Events e  ON b.EventID     = e.EventID
JOIN Users org ON e.OrganizerID = org.UserID
ORDER BY b.BookingID DESC;