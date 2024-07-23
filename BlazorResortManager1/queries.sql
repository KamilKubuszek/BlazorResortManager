USE [testDb6]
GO

-- Insert into resort
INSERT INTO resort (id, name, description, address, phoneNumber, email, webpage, yrNoCityCodeId) VALUES
(newid(), 'Resort A', 'Description for Resort A', '1234 Mountain St.', '123-456-7890', 'resortA@example.com', 'www.resortA.com', null),
(newid(), 'Resort B', 'Description for Resort B', '5678 Alpine Rd.', '987-654-3210', 'resortB@example.com', 'www.resortB.com', null);

-- Insert into lift
INSERT INTO lift (id, name, lengthMeters, estimatedDurationTimeMinutes, type, peoplePerHour, capacityPerSeat, resortId) VALUES
(newid(), 'Lift 1-1', 1200, 10, 'Gondola', 2400, 8, (SELECT id FROM resort WHERE name = 'Resort A')),
(newid(), 'Lift 1-2', 800, 7, 'Chairlift', 1800, 4, (SELECT id FROM resort WHERE name = 'Resort A')),
(newid(), 'Lift 1-3', 1000, 8, 'Chairlift', 2000, 4, (SELECT id FROM resort WHERE name = 'Resort A')),
(newid(), 'Lift 2-1', 1500, 12, 'Gondola', 3000, 10, (SELECT id FROM resort WHERE name = 'Resort B')),
(newid(), 'Lift 2-2', 900, 9, 'Chairlift', 2200, 6, (SELECT id FROM resort WHERE name = 'Resort B')),
(newid(), 'Lift 2-3', 1100, 10, 'Chairlift', 2400, 6, (SELECT id FROM resort WHERE name = 'Resort B'));

-- Insert into track
INSERT INTO track (id, name, totalHeightMeters, inclination, illuminated, snowGroomed, marking, lengthMeters, difficulty, resortId) VALUES
(newid(), 'Track 1-1', 500, 30, 1, 1, 'Red', 1200, 'Intermediate', (SELECT id FROM resort WHERE name = 'Resort A')),
(newid(), 'Track 1-2', 300, 20, 0, 0, 'Blue', 800, 'Beginner', (SELECT id FROM resort WHERE name = 'Resort A')),
(newid(), 'Track 1-3', 400, 25, 1, 1, 'Black', 1000, 'Advanced', (SELECT id FROM resort WHERE name = 'Resort A')),
(newid(), 'Track 2-1', 600, 35, 1, 1, 'Red', 1500, 'Intermediate', (SELECT id FROM resort WHERE name = 'Resort B')),
(newid(), 'Track 2-2', 350, 22, 0, 0, 'Blue', 900, 'Beginner', (SELECT id FROM resort WHERE name = 'Resort B')),
(newid(), 'Track 2-3', 450, 28, 1, 1, 'Black', 1100, 'Advanced', (SELECT id FROM resort WHERE name = 'Resort B'));

-- Insert into camera
INSERT INTO camera (id, name, link) VALUES
(newid(), 'Camera 1', 'http://camera1.link'),
(newid(), 'Camera 2', 'http://camera2.link'),
(newid(), 'Camera 3', 'http://camera3.link'),
(newid(), 'Camera 4', 'http://camera4.link'),
(newid(), 'Camera 5', 'http://camera5.link'),
(newid(), 'Camera 6', 'http://camera6.link');

INSERT INTO cameraResortBinding (id, resortId, cameraId)
VALUES
    (NEWID(), (SELECT id FROM resort WHERE name = 'Resort A'), (SELECT id FROM camera WHERE name = 'Camera 1')),
    (NEWID(), (SELECT id FROM resort WHERE name = 'Resort A'), (SELECT id FROM camera WHERE name = 'Camera 2')),
    (NEWID(), (SELECT id FROM resort WHERE name = 'Resort A'), (SELECT id FROM camera WHERE name = 'Camera 3')),
    (NEWID(), (SELECT id FROM resort WHERE name = 'Resort B'), (SELECT id FROM camera WHERE name = 'Camera 4')),
    (NEWID(), (SELECT id FROM resort WHERE name = 'Resort B'), (SELECT id FROM camera WHERE name = 'Camera 5')),
    (NEWID(), (SELECT id FROM resort WHERE name = 'Resort B'), (SELECT id FROM camera WHERE name = 'Camera 6'))


-- Insert into statusSheet
INSERT INTO statusSheet (id, dateTime, productionVersion, resortId) VALUES
(newid(), '2024-06-24 10:00:00', 1, (SELECT id FROM resort WHERE name = 'Resort A')),
(newid(), '2024-06-24 11:00:00', 1, (SELECT id FROM resort WHERE name = 'Resort A')),
(newid(), '2024-06-24 12:00:00', 1, (SELECT id FROM resort WHERE name = 'Resort A')),
(newid(), '2024-06-24 13:00:00', 1, (SELECT id FROM resort WHERE name = 'Resort B')),
(newid(), '2024-06-24 14:00:00', 1, (SELECT id FROM resort WHERE name = 'Resort B')),
(newid(), '2024-06-24 15:00:00', 1, (SELECT id FROM resort WHERE name = 'Resort B'));

-- Insert into liftStatus
INSERT INTO liftStatus (id, opened, openingTime, closingTime, parentLiftId, statusSheetId) VALUES
(newid(), 1, '08:00:00', '16:00:00', (SELECT id FROM lift WHERE name = 'Lift 1-1'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 10:00:00')),
(newid(), 0, '08:00:00', '16:00:00', (SELECT id FROM lift WHERE name = 'Lift 1-2'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 10:00:00')),
(newid(), 1, '08:00:00', '16:00:00', (SELECT id FROM lift WHERE name = 'Lift 1-3'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 10:00:00')),
(newid(), 1, '08:00:00', '16:00:00', (SELECT id FROM lift WHERE name = 'Lift 1-1'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 11:00:00')),
(newid(), 0, '08:00:00', '16:00:00', (SELECT id FROM lift WHERE name = 'Lift 1-2'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 11:00:00')),
(newid(), 1, '08:00:00', '16:00:00', (SELECT id FROM lift WHERE name = 'Lift 1-3'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 11:00:00')),
(newid(), 1, '08:00:00', '16:00:00', (SELECT id FROM lift WHERE name = 'Lift 1-1'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 12:00:00')),
(newid(), 0, '08:00:00', '16:00:00', (SELECT id FROM lift WHERE name = 'Lift 1-2'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 12:00:00')),
(newid(), 1, '08:00:00', '16:00:00', (SELECT id FROM lift WHERE name = 'Lift 1-3'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 12:00:00')),
(newid(), 1, '08:00:00', '16:00:00', (SELECT id FROM lift WHERE name = 'Lift 2-1'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 13:00:00')),
(newid(), 0, '08:00:00', '16:00:00', (SELECT id FROM lift WHERE name = 'Lift 2-2'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 13:00:00')),
(newid(), 1, '08:00:00', '16:00:00', (SELECT id FROM lift WHERE name = 'Lift 2-3'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 13:00:00')),
(newid(), 1, '08:00:00', '16:00:00', (SELECT id FROM lift WHERE name = 'Lift 2-1'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 14:00:00')),
(newid(), 0, '08:00:00', '16:00:00', (SELECT id FROM lift WHERE name = 'Lift 2-2'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 14:00:00')),
(newid(), 1, '08:00:00', '16:00:00', (SELECT id FROM lift WHERE name = 'Lift 2-3'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 14:00:00')),
(newid(), 1, '08:00:00', '16:00:00', (SELECT id FROM lift WHERE name = 'Lift 2-1'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 15:00:00')),
(newid(), 0, '08:00:00', '16:00:00', (SELECT id FROM lift WHERE name = 'Lift 2-2'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 15:00:00')),
(newid(), 1, '08:00:00', '16:00:00', (SELECT id FROM lift WHERE name = 'Lift 2-3'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 15:00:00'));

-- Insert into trackStatus
INSERT INTO trackStatus (id, opened, openingTime, closingTime, snowCover, parentTrackId, statusSheetId) VALUES
(newid(), 1, '09:00:00', '17:00:00', 50, (SELECT id FROM track WHERE name = 'Track 1-1'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 10:00:00')),
(newid(), 0, '09:00:00', '17:00:00', 30, (SELECT id FROM track WHERE name = 'Track 1-2'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 10:00:00')),
(newid(), 1, '09:00:00', '17:00:00', 70, (SELECT id FROM track WHERE name = 'Track 1-3'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 10:00:00')),
(newid(), 1, '09:00:00', '17:00:00', 55, (SELECT id FROM track WHERE name = 'Track 1-1'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 11:00:00')),
(newid(), 0, '09:00:00', '17:00:00', 35, (SELECT id FROM track WHERE name = 'Track 1-2'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 11:00:00')),
(newid(), 1, '09:00:00', '17:00:00', 75, (SELECT id FROM track WHERE name = 'Track 1-3'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 11:00:00')),
(newid(), 1, '09:00:00', '17:00:00', 60, (SELECT id FROM track WHERE name = 'Track 1-1'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 12:00:00')),
(newid(), 0, '09:00:00', '17:00:00', 40, (SELECT id FROM track WHERE name = 'Track 1-2'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 12:00:00')),
(newid(), 1, '09:00:00', '17:00:00', 80, (SELECT id FROM track WHERE name = 'Track 1-3'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 12:00:00')),
(newid(), 1, '09:00:00', '17:00:00', 65, (SELECT id FROM track WHERE name = 'Track 2-1'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 13:00:00')),
(newid(), 0, '09:00:00', '17:00:00', 45, (SELECT id FROM track WHERE name = 'Track 2-2'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 13:00:00')),
(newid(), 1, '09:00:00', '17:00:00', 85, (SELECT id FROM track WHERE name = 'Track 2-3'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 13:00:00')),
(newid(), 1, '09:00:00', '17:00:00', 70, (SELECT id FROM track WHERE name = 'Track 2-1'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 14:00:00')),
(newid(), 0, '09:00:00', '17:00:00', 50, (SELECT id FROM track WHERE name = 'Track 2-2'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 14:00:00')),
(newid(), 1, '09:00:00', '17:00:00', 90, (SELECT id FROM track WHERE name = 'Track 2-3'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 14:00:00')),
(newid(), 1, '09:00:00', '17:00:00', 75, (SELECT id FROM track WHERE name = 'Track 2-1'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 15:00:00')),
(newid(), 0, '09:00:00', '17:00:00', 55, (SELECT id FROM track WHERE name = 'Track 2-2'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 15:00:00')),
(newid(), 1, '09:00:00', '17:00:00', 95, (SELECT id FROM track WHERE name = 'Track 2-3'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 15:00:00'));

-- Insert into resortStatus
INSERT INTO resortStatus (id, opened, openingTime, closingTime, parentResortId, statusSheetId) VALUES
(newid(), 1, '07:00:00', '18:00:00', (SELECT id FROM resort WHERE name = 'Resort A'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 10:00:00')),
(newid(), 0, '07:00:00', '18:00:00', (SELECT id FROM resort WHERE name = 'Resort A'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 11:00:00')),
(newid(), 1, '07:00:00', '18:00:00', (SELECT id FROM resort WHERE name = 'Resort A'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 12:00:00')),
(newid(), 1, '07:00:00', '18:00:00', (SELECT id FROM resort WHERE name = 'Resort B'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 13:00:00')),
(newid(), 0, '07:00:00', '18:00:00', (SELECT id FROM resort WHERE name = 'Resort B'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 14:00:00')),
(newid(), 1, '07:00:00', '18:00:00', (SELECT id FROM resort WHERE name = 'Resort B'), (SELECT id FROM statusSheet WHERE dateTime = '2024-06-24 15:00:00'));

GO

