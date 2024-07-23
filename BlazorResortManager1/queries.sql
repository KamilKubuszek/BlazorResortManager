USE [testDb5]
GO

INSERT INTO resort (id, name, description, address, phoneNumber, email, webpage) VALUES
(newid(), 'Resort 1', 'Description 1', 'Address 1', '123456789', 'email1@example.com', 'http://resort1.com'),
(newid(), 'Resort 2', 'Description 2', 'Address 2', '987654321', 'email2@example.com', 'http://resort2.com');

INSERT INTO track (id, name, resortId) VALUES
(newid(), 'Track 1-1', (SELECT id FROM resort WHERE name = 'Resort 1')),
(newid(), 'Track 1-2', (SELECT id FROM resort WHERE name = 'Resort 1')),
(newid(), 'Track 1-3', (SELECT id FROM resort WHERE name = 'Resort 1')),
(newid(), 'Track 2-1', (SELECT id FROM resort WHERE name = 'Resort 2')),
(newid(), 'Track 2-2', (SELECT id FROM resort WHERE name = 'Resort 2')),
(newid(), 'Track 2-3', (SELECT id FROM resort WHERE name = 'Resort 2'));

INSERT INTO trackParameter (id, name, value, trackId) VALUES
(newid(), 'totalHeightMeters', '1000', (SELECT id FROM track WHERE name = 'Track 1-1')),
(newid(), 'inclination', '30', (SELECT id FROM track WHERE name = 'Track 1-1')),
(newid(), 'marking', 'Blue', (SELECT id FROM track WHERE name = 'Track 1-1')),
(newid(), 'totalHeightMeters', '1200', (SELECT id FROM track WHERE name = 'Track 1-2')),
(newid(), 'inclination', '40', (SELECT id FROM track WHERE name = 'Track 1-2')),
(newid(), 'marking', 'Red', (SELECT id FROM track WHERE name = 'Track 1-2')),
(newid(), 'totalHeightMeters', '1500', (SELECT id FROM track WHERE name = 'Track 1-3')),
(newid(), 'inclination', '50', (SELECT id FROM track WHERE name = 'Track 1-3')),
(newid(), 'marking', 'Black', (SELECT id FROM track WHERE name = 'Track 1-3')),
(newid(), 'totalHeightMeters', '1100', (SELECT id FROM track WHERE name = 'Track 2-1')),
(newid(), 'inclination', '35', (SELECT id FROM track WHERE name = 'Track 2-1')),
(newid(), 'marking', 'Green', (SELECT id FROM track WHERE name = 'Track 2-1')),
(newid(), 'totalHeightMeters', '1300', (SELECT id FROM track WHERE name = 'Track 2-2')),
(newid(), 'inclination', '45', (SELECT id FROM track WHERE name = 'Track 2-2')),
(newid(), 'marking', 'Yellow', (SELECT id FROM track WHERE name = 'Track 2-2')),
(newid(), 'totalHeightMeters', '1600', (SELECT id FROM track WHERE name = 'Track 2-3')),
(newid(), 'inclination', '55', (SELECT id FROM track WHERE name = 'Track 2-3')),
(newid(), 'marking', 'Purple', (SELECT id FROM track WHERE name = 'Track 2-3'));

INSERT INTO lift (id, name, resortId) VALUES
(newid(), 'Lift 1-1', (SELECT id FROM resort WHERE name = 'Resort 1')),
(newid(), 'Lift 1-2', (SELECT id FROM resort WHERE name = 'Resort 1')),
(newid(), 'Lift 1-3', (SELECT id FROM resort WHERE name = 'Resort 1')),
(newid(), 'Lift 2-1', (SELECT id FROM resort WHERE name = 'Resort 2')),
(newid(), 'Lift 2-2', (SELECT id FROM resort WHERE name = 'Resort 2')),
(newid(), 'Lift 2-3', (SELECT id FROM resort WHERE name = 'Resort 2'));

INSERT INTO liftParameter (id, name, value, liftId) VALUES
(newid(), 'lengthMeters', '500', (SELECT id FROM lift WHERE name = 'Lift 1-1')),
(newid(), 'estimatedDurationTimeMinutes', '5', (SELECT id FROM lift WHERE name = 'Lift 1-1')),
(newid(), 'type', 'Chairlift', (SELECT id FROM lift WHERE name = 'Lift 1-1')),
(newid(), 'lengthMeters', '600', (SELECT id FROM lift WHERE name = 'Lift 1-2')),
(newid(), 'estimatedDurationTimeMinutes', '6', (SELECT id FROM lift WHERE name = 'Lift 1-2')),
(newid(), 'type', 'Gondola', (SELECT id FROM lift WHERE name = 'Lift 1-2')),
(newid(), 'lengthMeters', '700', (SELECT id FROM lift WHERE name = 'Lift 1-3')),
(newid(), 'estimatedDurationTimeMinutes', '7', (SELECT id FROM lift WHERE name = 'Lift 1-3')),
(newid(), 'type', 'Draglift', (SELECT id FROM lift WHERE name = 'Lift 1-3')),
(newid(), 'lengthMeters', '550', (SELECT id FROM lift WHERE name = 'Lift 2-1')),
(newid(), 'estimatedDurationTimeMinutes', '5.5', (SELECT id FROM lift WHERE name = 'Lift 2-1')),
(newid(), 'type', 'Chairlift', (SELECT id FROM lift WHERE name = 'Lift 2-1')),
(newid(), 'lengthMeters', '650', (SELECT id FROM lift WHERE name = 'Lift 2-2')),
(newid(), 'estimatedDurationTimeMinutes', '6.5', (SELECT id FROM lift WHERE name = 'Lift 2-2')),
(newid(), 'type', 'Gondola', (SELECT id FROM lift WHERE name = 'Lift 2-2')),
(newid(), 'lengthMeters', '750', (SELECT id FROM lift WHERE name = 'Lift 2-3')),
(newid(), 'estimatedDurationTimeMinutes', '7.5', (SELECT id FROM lift WHERE name = 'Lift 2-3')),
(newid(), 'type', 'Draglift', (SELECT id FROM lift WHERE name = 'Lift 2-3'));

INSERT INTO statusSheet (id, dateTime, productionVersion, resortId) VALUES
(newid(), '2024-06-24 10:00:00', 1, (SELECT id FROM resort WHERE name = 'Resort 1')),
(newid(), '2024-06-24 11:00:00', 0, (SELECT id FROM resort WHERE name = 'Resort 1')),
(newid(), '2024-06-24 12:00:00', 1, (SELECT id FROM resort WHERE name = 'Resort 1')),
(newid(), '2024-06-24 13:00:00', 1, (SELECT id FROM resort WHERE name = 'Resort 2')),
(newid(), '2024-06-24 14:00:00', 0, (SELECT id FROM resort WHERE name = 'Resort 2')),
(newid(), '2024-06-24 15:00:00', 1, (SELECT id FROM resort WHERE name = 'Resort 2'));

INSERT INTO liftStatus (id, opened, parentLiftId, statusSheetId) VALUES
(newid(), 1, (SELECT id FROM lift WHERE name = 'Lift 1-1'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 10:00:00')),
(newid(), 0, (SELECT id FROM lift WHERE name = 'Lift 1-2'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 10:00:00')),
(newid(), 1, (SELECT id FROM lift WHERE name = 'Lift 1-3'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 10:00:00')),
(newid(), 1, (SELECT id FROM lift WHERE name = 'Lift 1-1'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 11:00:00')),
(newid(), 0, (SELECT id FROM lift WHERE name = 'Lift 1-2'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 11:00:00')),
(newid(), 1, (SELECT id FROM lift WHERE name = 'Lift 1-3'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 11:00:00')),
(newid(), 1, (SELECT id FROM lift WHERE name = 'Lift 1-1'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 12:00:00')),
(newid(), 0, (SELECT id FROM lift WHERE name = 'Lift 1-2'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 12:00:00')),
(newid(), 1, (SELECT id FROM lift WHERE name = 'Lift 1-3'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 12:00:00')),
(newid(), 1, (SELECT id FROM lift WHERE name = 'Lift 2-1'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 13:00:00')),
(newid(), 0, (SELECT id FROM lift WHERE name = 'Lift 2-2'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 13:00:00')),
(newid(), 1, (SELECT id FROM lift WHERE name = 'Lift 2-3'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 13:00:00')),
(newid(), 1, (SELECT id FROM lift WHERE name = 'Lift 2-1'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 14:00:00')),
(newid(), 0, (SELECT id FROM lift WHERE name = 'Lift 2-2'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 14:00:00')),
(newid(), 1, (SELECT id FROM lift WHERE name = 'Lift 2-3'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 14:00:00')),
(newid(), 1, (SELECT id FROM lift WHERE name = 'Lift 2-1'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 15:00:00')),
(newid(), 0, (SELECT id FROM lift WHERE name = 'Lift 2-2'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 15:00:00')),
(newid(), 1, (SELECT id FROM lift WHERE name = 'Lift 2-3'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 15:00:00'));

INSERT INTO trackStatus (id, opened, snowGroomed, illuminated, parentTrackId, statusSheetId) VALUES
(newid(), 1, 1, 1, (SELECT id FROM track WHERE name = 'Track 1-1'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 10:00:00')),
(newid(), 0, 0, 0, (SELECT id FROM track WHERE name = 'Track 1-2'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 10:00:00')),
(newid(), 1, 1, 1, (SELECT id FROM track WHERE name = 'Track 1-3'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 10:00:00')),
(newid(), 1, 1, 1, (SELECT id FROM track WHERE name = 'Track 1-1'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 11:00:00')),
(newid(), 0, 0, 0, (SELECT id FROM track WHERE name = 'Track 1-2'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 11:00:00')),
(newid(), 1, 1, 1, (SELECT id FROM track WHERE name = 'Track 1-3'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 11:00:00')),
(newid(), 1, 1, 1, (SELECT id FROM track WHERE name = 'Track 1-1'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 12:00:00')),
(newid(), 0, 0, 0, (SELECT id FROM track WHERE name = 'Track 1-2'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 12:00:00')),
(newid(), 1, 1, 1, (SELECT id FROM track WHERE name = 'Track 1-3'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 12:00:00')),
(newid(), 1, 1, 1, (SELECT id FROM track WHERE name = 'Track 2-1'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 13:00:00')),
(newid(), 0, 0, 0, (SELECT id FROM track WHERE name = 'Track 2-2'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 13:00:00')),
(newid(), 1, 1, 1, (SELECT id FROM track WHERE name = 'Track 2-3'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 13:00:00')),
(newid(), 1, 1, 1, (SELECT id FROM track WHERE name = 'Track 2-1'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 14:00:00')),
(newid(), 0, 0, 0, (SELECT id FROM track WHERE name = 'Track 2-2'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 14:00:00')),
(newid(), 1, 1, 1, (SELECT id FROM track WHERE name = 'Track 2-3'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 14:00:00')),
(newid(), 1, 1, 1, (SELECT id FROM track WHERE name = 'Track 2-1'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 15:00:00')),
(newid(), 0, 0, 0, (SELECT id FROM track WHERE name = 'Track 2-2'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 15:00:00')),
(newid(), 1, 1, 1, (SELECT id FROM track WHERE name = 'Track 2-3'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 15:00:00'));


INSERT INTO [dbo].[permit]
           ([id]
           ,[userId]
           ,[resortId])
     VALUES
           (NEWID(), 'e4dbaca4-4b53-4940-a5ff-9801ce228208', '74A47F71-1D44-4232-864E-53EFE2371334'),
		   (NEWID(), 'e4dbaca4-4b53-4940-a5ff-9801ce228208', '0DD75E4C-FFE9-4889-99E9-F25B76621E87')


GO


