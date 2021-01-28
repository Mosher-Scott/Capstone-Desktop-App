CREATE TABLE [client](
[id] INTEGER PRIMARY KEY IDENTITY(1,1) NOT NULL, 
[firstName] VARCHAR(30) NOT NULL, 
[lastName] VARCHAR(30) NOT NULL,
[active] BOOLEAN
);

CREATE TABLE [client_info](
[id] INTEGER PRIMARY KEY IDENTITY(1,1) NOT NULL, 
[clientId] INTEGER NOT NULL REFERENCES [client]([id]),
[streetAddress] VARCHAR(255) NOT NULL, 
[city] VARCHAR(255) NOT NULL,
[state] VARCHAR(255) NOT NULL,
[zipcode] INTEGER NOT NULL,
[phone] INTEGER NOT NULL,
[email] VARCHAR(40) NOT NULL,
[registrationDate] DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE [training_session](
[id] INTEGER PRIMARY KEY IDENTITY(1,1) NOT NULL, 
[SessionName] VARCHAR(30) NOT NULL, 
[sessionDescription] VARCHAR(255) NOT NULL, 
[sessionSets] INTEGER NOT NULL, 
[sessionReps] INTEGER NOT NULL),
[active] BOOLEAN;

CREATE TABLE [muscle_group](
[id] INTEGER PRIMARY KEY IDENTITY(1,1) NOT NULL, 
[Name] VARCHAR(20) NOT NULL);

CREATE TABLE [exercises](
[id] INTEGER PRIMARY KEY IDENTITY(1,1) NOT NULL, 
[name] VARCHAR(30) NOT NULL, 
[muscleGroup] INTEGER NOT NULL REFERENCES [muscle_group]([id]), 
[instruction] VARCHAR(255) NOT NULL)
[active] BOOLEAN;

CREATE TABLE [session_exercises](
[id] INTEGER PRIMARY KEY IDENTITY(1,1) NOT NULL, 
[exerciseId] INTEGER NOT NULL REFERENCES [exercises]([id]), 
[sessionId] INTEGER NOT NULL REFERENCES [training_session]([id]));

CREATE TABLE [client_training_session](
[id] INTEGER PRIMARY KEY IDENTITY(1,1) NOT NULL, 
[clientId] INTEGER NOT NULL REFERENCES [client]([id]), 
[sessionId] INTEGER NOT NULL REFERENCES [training_session]([id]));

CREATE TABLE [client_workout_history] (
[id] INTEGER PRIMARY KEY IDENTITY(1,1) NOT NULL, 
[clientId] INTEGER NOT NULL REFERENCES [client]([id]), 
[sessionId] INTEGER NOT NULL REFERENCES [training_session]([id]),
[sessionDate] DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE [client_workout_history_exercises] (
[id] INTEGER PRIMARY KEY IDENTITY(1,1) NOT NULL,
[workoutHistoryId] INTEGER NOT NULL REFERENCES [client_workout_history]([id]),
[exerciseId] INTEGER NOT NULL REFERENCES [exercises]([id]),
[sets] INTEGER NOT NULL,
[reps] INTEGER,
[weight] INTEGER,
[seconds] INTEGER
);

-- Seed users
INSERT INTO client (firstName, lastName, active) VALUES ('Scott', 'Mosher', true);
INSERT INTO client (firstName, lastName, active) VALUES ('Sara', 'Mosher', true);
INSERT INTO client (firstName, lastName, active) VALUES ('Steve', 'Pett', false);
INSERT INTO client (firstName, lastName, active) VALUES ('Shane', 'Truskolaski', false);

-- Seed user info
INSERT INTO client_info (streetAddress, city, state, zipcode, phone, email, clientId) VALUES ('563N 450E', 'Springville', 'UT', 84663, '408-476-5779', 'scott@scottmosherphotography.com', 1);
INSERT INTO client_info (streetAddress, city, state, zipcode, phone, email, clientId) VALUES ('563N 450E', 'Springville', 'UT', 84663, '408-250-2517', 'smosher05@gmail.com', 1);


-- Seed Training Sessions
INSERT INTO training_session (sessionName, sessionSets, sessionReps, sessionDescription, active) VALUES ('Full Body', '3', '7', 'Works your entire body. Hits all the main muscle groups', true);
INSERT INTO training_session (sessionName, sessionSets, sessionReps, sessionDescription, active) VALUES ('Back & Biceps', '3', '7', 'Concentrate on working your back, and also your bicep muscle groups', true);
INSERT INTO training_session (sessionName, sessionSets, sessionReps, sessionDescription, active) VALUES ('Chest, Triceps, Shoulders', '3', '7', 'A great upper body workout. We''ll be focusing on your chest, triceps, and your shoulders', true);
INSERT INTO training_session (sessionName, sessionSets, sessionReps, sessionDescription, active) VALUES ('Legs', '3', '7', 'Infamous leg day. We''ll be targeting the main muscle groups in the legs, plus a few minor ones', true);
INSERT INTO training_session (sessionName, sessionSets, sessionReps, sessionDescription, active) VALUES ('Chest & Back', '3', '7', 'We''ll be targeting the opposites, being able to work on both pushing & pulling muscles in your chest and back', true);
INSERT INTO training_session (sessionName, sessionSets, sessionReps, sessionDescription, active) VALUES ('Arms', '3', '7', 'Focuses on the arms, such as forearms, biceps, triceps, and a little bit of shoulders', true);
INSERT INTO training_session (sessionName, sessionSets, sessionReps, sessionDescription, active) VALUES ('HIIT - Full Body', '3', '10', 'Full body workout, but we''ll be doing more reps at lower weights.  Also less break time in between sets', true);
INSERT INTO training_session (sessionName, sessionSets, sessionReps, sessionDescription, active) VALUES ('Make It Up', '3', '8', 'Misc Exercises for when you just want to record a workout', true);

-- Seed muscle_groups
INSERT INTO muscle_group(name) VALUES ('Legs');
INSERT INTO muscle_group(name) VALUES ('Arms');
INSERT INTO muscle_group(name) VALUES ('Back');
INSERT INTO muscle_group(name) VALUES ('Chest');
INSERT INTO muscle_group(name) VALUES ('Abs');
INSERT INTO muscle_group(name) VALUES ('Shoulders');
INSERT INTO muscle_group(name) VALUES ('Full Body');

-- Seed Exercises
INSERT INTO exercises (name, muscleGroup, instruction, active) VALUES ('Hamstring Curls', 1, 'Sit on machine with your ankles over the bar. Pull your legs in.', true);
INSERT INTO exercises (name, muscleGroup, instruction, active) VALUES ('Lunge', 1, 'Stand straight up holding a weight at your sides. Step forward, and lower your back leg to the ground', true);
INSERT INTO exercises (name, muscleGroup, instruction) VALUES ('Pistol Squat', 1, 'With one leg in the air in front of you, squat down into a seated position', true);
INSERT INTO exercises (name, muscleGroup, instruction, active) VALUES ('Calf Raises', 1, 'Stand on a step with your heels off the edge. Lower your heels to towards the ground, and then bring them up as high as they can', true);
INSERT INTO exercises (name, muscleGroup, instruction, active) VALUES ('Hip Bridges', 1, 'Lie on on the ground on your back. Bend your knees so your feet ar flat on the ground. Pushing into your feet, lift your hips off the ground', true);
INSERT INTO exercises (name, muscleGroup, instruction, active) VALUES ('Goblin Squat', 1, 'Stand up with legs shoulder width apart. Hold weight just under your chin. Squat down and back up', true);
INSERT INTO exercises (name, muscleGroup, instruction, active) VALUES ('Bicep Curl', 2, 'Hold a weight with your arm straight by your body. Keeping your upper body still, bend at the elbow and bring the weight up', true);
INSERT INTO exercises (name, muscleGroup, instruction, active) VALUES ('Tricep Curl', 2, 'Lean forwards holding a weight in your hand, with your arm making a T. While leaning forward, straighten your arm and hold for 2 seconds', true);
INSERT INTO exercises (name, muscleGroup, instruction, active) VALUES ('Chin Ups', 2, 'Stand under a bar, and grab it with your palms facing you. Make sure your feet are off the ground, and pull yourself up', true);
INSERT INTO exercises (name, muscleGroup, instruction, active) VALUES ('Pullups', 3, 'Grab onto a bar above your head, with arms about shoulder width apart.  With your feet off the ground, use your back to pull yourself up so your chin is even with the bar', true);
INSERT INTO exercises (name, muscleGroup, instruction, active) VALUES ('Single Arm Row', 3, 'Stand up and bend at the hips keeping your back straight.  Grab a weight with one arm, and then pull your arm straight back with your back', true);
INSERT INTO exercises (name, muscleGroup, instruction, active) VALUES ('Bench Press', 4, 'Lie on the bench, with the bar above your chest. Put both hands on the bar, and lift it off the rack, and bring it down to your chest.  Now push the bar all the way up', true);
INSERT INTO exercises (name, muscleGroup, instruction, active) VALUES ('Sven Press', 4, 'Stand up, and hold a weight plate between your hands. Straighten your arms, hold for 2-3 seconds, then bring them back', true);
INSERT INTO exercises (name, muscleGroup, instruction, active) VALUES ('Chest Fly', 4, 'Stand up, and bend at the hips so you are bending over with a flat back. Hold a weight in each hand. Pull your arms to the side/back like you were gonna give someone a hug', true);
INSERT INTO exercises (name, muscleGroup, instruction, active) VALUES ('Pushups', 4, 'Get into a plank position.  Now bending your elbows, lower yourself to the floor and back up again', true);
INSERT INTO exercises (name, muscleGroup, instruction, active) VALUES ('Russian Twists', 5, 'Sit on the ground with your knees bent.  Grab onto a weight, and twist your upper body from side to side.  Make sure to keep your back straight', true);
INSERT INTO exercises (name, muscleGroup, instruction, active) VALUES ('Leg Raises', 5, 'Lie on the ground on your back with your legs straight. Keeping your knees straight, bring your feet up as high as they go', true);
INSERT INTO exercises (name, muscleGroup, instruction, active) VALUES ('Plank', 5, 'Get into pushup position, or on your elbows instead of your hands. Now hold it for 30+ seconds', true);
INSERT INTO exercises (name, muscleGroup, instruction, active) VALUES ('Shoulder Press', 6, 'Stand up, holding a weight in each hand.  Make field goals with your arms to start.  Now push the weight up', true);
INSERT INTO exercises (name, muscleGroup, instruction, active) VALUES ('Front Shoulder Raise', 6, 'Stand up, holding a weight in each hand. Keeping your arms straight, bring your arms up so they are parallel with the ground', true);
INSERT INTO exercises (name, muscleGroup, instruction, active) VALUES ('Mountain Climbers', 6, 'Get into plan position. Now run in place', true);
INSERT INTO exercises (name, muscleGroup, instruction, active) VALUES ('Straight Leg Deadlift', 6, 'With knees slightly bend, bend over at the waist, grab the weights, and stand up', true);


-- Seed session_exercises
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (1, 2);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (1, 4);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (1, 6);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (1, 22);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (1, 7);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (1, 8);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (1, 9);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (1, 10);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (1, 11);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (1, 12);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (1, 13);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (1, 15);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (1, 16);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (1, 17);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (1, 19);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (2, 7);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (2, 9);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (2, 10);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (2, 11);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (3, 12);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (3, 13);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (3, 14);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (3, 15);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (3, 8);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (3, 21);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (4, 1);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (4, 2);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (4, 4);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (4, 5);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (4, 6);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (4, 22);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (5, 10);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (5, 11);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (5, 12);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (5, 13);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (5, 15);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (6, 7);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (6, 8);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (6, 9);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (6, 19);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (6, 20);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (6, 21);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (7, 2);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (7, 4);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (7, 6);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (7, 22);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (7, 7);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (7, 8);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (7, 9);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (7, 10);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (7, 11);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (7, 12);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (7, 13);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (7, 15);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (7, 16);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (7, 17);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (7, 19);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (7, 21);
INSERT INTO session_exercises(sessionId, exerciseId) VALUES (3, 20);

-- Assign training sessions to clients
INSERT INTO client_training_session(clientId, sessionId) VALUES (1, 1);
INSERT INTO client_training_session(clientId, sessionId) VALUES (1, 3);
INSERT INTO client_training_session(clientId, sessionId) VALUES (1, 5);
INSERT INTO client_training_session(clientId, sessionId) VALUES (1, 7);
INSERT INTO client_training_session(clientId, sessionId) VALUES (2, 1);

