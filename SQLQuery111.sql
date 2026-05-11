USE EventManagementDB;
GO

-- Add new column for multiple supported event types per hall
IF COL_LENGTH('Events','SupportedEventTypes') IS NULL
BEGIN
    ALTER TABLE Events ADD SupportedEventTypes NVARCHAR(500) NULL;
END
GO

-- Map each hall to multiple event types based on your spec
UPDATE Events SET SupportedEventTypes = 'Wedding,Engagement'                                 WHERE EventName = 'Sena Kunjo';
UPDATE Events SET SupportedEventTypes = 'Wedding,Seminar,Corporate Conference'               WHERE EventName = 'Army Golf Club';
UPDATE Events SET SupportedEventTypes = 'Wedding,Engagement'                                 WHERE EventName = 'Sena Malancha';
UPDATE Events SET SupportedEventTypes = 'Wedding,Birthday,Seminar,Corporate Conference,Engagement' WHERE EventName = 'Dhaka Club';
UPDATE Events SET SupportedEventTypes = 'Wedding'                                            WHERE EventName = 'Police Convention Hall';
UPDATE Events SET SupportedEventTypes = 'Wedding,Birthday'                                   WHERE EventName = 'RAOWA Convention Hall';
UPDATE Events SET SupportedEventTypes = 'Wedding,Seminar,Corporate Conference'               WHERE EventName = 'International Convention City Bashundhara';
UPDATE Events SET SupportedEventTypes = 'Wedding,Seminar,Corporate Conference'               WHERE EventName = 'Bangabandhu International Conference Center';
UPDATE Events SET SupportedEventTypes = 'Wedding,Birthday'                                   WHERE EventName = 'Officers Club Dhaka';
UPDATE Events SET SupportedEventTypes = 'Wedding,Birthday,Cultural Program'                  WHERE EventName = 'Ladies Club Dhaka';
GO

PRINT 'Smart category mapping done!';