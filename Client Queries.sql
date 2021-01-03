-- View training session names that are assigned to a specific user
-- Can be used to populate a dropdown list
SELECT ts.id, ts.SessionName AS [Name], ts.sessionDescription AS [Description], ts.sessionSets AS [Sets], ts.sessionReps AS [Reps]
FROM client_training_session AS cts
JOIN training_session AS ts ON ts.id = cts.sessionId
WHERE cts.clientId = 1;

-- View exercises & instructions for a specific training session
SELECT e.name AS [Name], e.instruction AS [Instructions]
FROM exercises AS e
JOIN session_exercises AS se ON se.exerciseId = e.id
WHERE se.sessionId = 1

-- Get names of exercises that are in the workout
SELECT e.name AS [Name]
FROM exercises AS e
JOIN session_exercises AS se ON se.exerciseId = e.id
WHERE se.sessionId = 1

-- View session name/description/sets/reps for a specific training session
USE exercise_tracker
SELECT ts.id, ts.SessionName AS [Name], ts.sessionDescription AS [Description], ts.sessionSets AS [Sets], ts.sessionReps AS [Reps]
FROM training_session AS ts
WHERE ts.id = 1;

-- Returns exercise name, and blank columns for sets, reps, weight, and time
USE exercise_tracker
SELECT e.id AS [ID], e.name AS [Name], '' AS [Sets], '' AS [Reps], '' AS [Weight], '' AS [Time]
FROM exercises AS e
JOIN session_exercises AS se ON se.exerciseId = e.id
WHERE se.sessionId = 1;
