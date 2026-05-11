USE EventManagementDB;
GO

IF COL_LENGTH('Bookings','PreferredDate') IS NULL
BEGIN
    ALTER TABLE Bookings ADD
        PreferredDate   DATETIME      NULL,
        StartTime       NVARCHAR(20)  NULL,
        EndTime         NVARCHAR(20)  NULL,
        EventType       NVARCHAR(50)  NULL,
        ContactPhone    NVARCHAR(20)  NULL,
        SpecialRequest  NVARCHAR(500) NULL;
END
GO

PRINT 'Booking detail columns added!';