-- 00_create_database.sql
-- Idempotent: only creates DB if it doesn't already exist

IF DB_ID('MealPlannerDb') IS NULL
BEGIN
    PRINT 'Creating database MealPlannerDb...';
    CREATE DATABASE MealPlannerDb;
END
ELSE
BEGIN
    PRINT 'Database MealPlannerDb already exists. Skipping CREATE.';
END;
GO
