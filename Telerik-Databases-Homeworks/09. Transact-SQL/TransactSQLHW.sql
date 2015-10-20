--1. Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN) and Accounts(Id(PK), PersonId(FK), Balance).
--	Insert few records for testing.
--	Write a stored procedure that selects the full names of all persons.
CREATE DATABASE BankingSystem
GO

USE BankingSystem

CREATE TABLE Persons(
Id int IDENTITY,
FirstName nvarchar(100) NOT NULL,
LastName nvarchar(100) NOT NULL,
SSN nvarchar(100) NOT NULL,
CONSTRAINT PK_Id PRIMARY KEY (Id)
)

CREATE TABLE Accounts(
Id int IDENTITY,
PersonId int NOT NULL,
Balance money NOT NULL,
CONSTRAINT PK_AccountId PRIMARY KEY (Id),
CONSTRAINT FK_PersonId FOREIGN KEY (PersonId) REFERENCES Persons (Id)
)

GO

INSERT INTO Persons(FirstName, LastName, SSN) 
VALUES
('Isaac', 'Newton', '111111'),
('Albert', 'Einstein', '222222'),
('Alan', 'Turing', '1048576')


INSERT INTO Accounts(PersonId, Balance)
VALUES
(1, 9806.65),
(2, 2997924.58),
(3, 10485.76)

GO

--2. Create a stored procedure that accepts a number as a parameter and returns all persons who have more money in their accounts than the supplied number.

CREATE PROC usp_SelectPeopleWithBalanceGreaterThan ( @minBalance money = 0 )
AS
SELECT *
FROM Persons p
JOIN Accounts a
ON p.Id = a.PersonId
WHERE a.Balance > @minBalance
ORDER BY a.Balance

GO

EXEC usp_SelectPeopleWithBalanceGreaterThan  @minBalance = 10000

GO
--3. Create a function that accepts as parameters – sum, yearly interest rate and number of months.
--	It should calculate and return the new sum.
--	Write a SELECT to test whether the function works as expected.

CREATE FUNCTION ufn_CalculateCompoundInterest (@sum money, @yearlyInterestRate decimal, @months int) RETURNS money
AS
BEGIN
RETURN @sum * (1 + @yearlyInterestRate /12) * @months
END

GO

--4. Create a stored procedure that uses the function from the previous example to give an interest to a person's account for one month.
--	It should take the AccountId and the interest rate as parameters.

CREATE PROCEDURE usp_CalculateCompoundInterestForOneMonth(
	@accountId int, @yearlyInterestRate float)
AS
	DECLARE @balance money
	SELECT @balance = Balance FROM Accounts WHERE Id = @accountId
	
	DECLARE @newBalance money = (SELECT dbo.ufn_CalculateCompoundInterest(@balance, @yearlyInterestRate, 1))
	
	SELECT p.FirstName, p.LastName, a.Balance, @newBalance AS [New Balance]
	FROM Persons p
	JOIN Accounts a
	ON p.Id = a.PersonId
	WHERE a.Id = @accountId

GO

EXEC usp_CalculateCompoundInterestForOneMonth 1, 0.1

GO

--5. Add two more stored procedures WithdrawMoney(AccountId, money) and DepositMoney(AccountId, money) that operate in transactions.

CREATE PROCEDURE usp_WithdrawMoney(@accountId int, @money money)
AS
    BEGIN TRAN
        UPDATE Accounts
        SET Balance -= @money
        WHERE Id = @accountId
    COMMIT TRAN
GO

CREATE PROCEDURE dbo.usp_DepositMoney(@accountId int, @money money)
AS
    BEGIN TRAN
        UPDATE Accounts
        SET Balance += @money
        WHERE Id = @accountId
    COMMIT TRAN
GO

EXEC dbo.usp_WithdrawMoney 1, 1000
GO

EXEC dbo.usp_DepositMoney 2, 2000
GO

--6. Create another table – Logs(LogID, AccountID, OldSum, NewSum).
--	Add a trigger to the Accounts table that enters a new entry into the Logs table every time the sum on an account changes.

CREATE TABLE Logs (
    LogId int IDENTITY PRIMARY KEY,
    AccountId int NOT NULL FOREIGN KEY REFERENCES Accounts(Id),
    OldSum money NOT NULL,
    NewSum money NOT NULL
)

GO

CREATE TRIGGER tr_UpdateAccountBalance ON Accounts FOR UPDATE
AS
    DECLARE @oldSum money;
    SELECT @oldSum = Balance FROM deleted;

    INSERT INTO Logs(AccountId, OldSum, NewSum)
        SELECT Id, @oldSum, Balance
        FROM inserted
GO

EXEC usp_WithdrawMoney 1, 1000
GO

EXEC usp_DepositMoney 2, 2000
GO
--7. Define a function in the database TelerikAcademy that returns all Employee's names (first or middle or last name) and all town's names that are comprised of given set of letters.
--	Example: 'oistmiahf' will return 'Sofia', 'Smith', … but not 'Rob' and 'Guy'.
USE TelerikAcademy
GO

CREATE FUNCTION ufn_SearchForWordsInGivenPattern(@pattern nvarchar(300))
RETURNS @MatchedNames TABLE (Name varchar(50))
AS
BEGIN
INSERT @MatchedNames
SELECT * 
FROM
(SELECT e.FirstName FROM Employees e
UNION
SELECT e.LastName FROM Employees e
UNION 
SELECT t.Name FROM Towns t) as temp(name)
WHERE PATINDEX('%[' + @pattern + ']', Name) > 0
RETURN
END
GO

--8. Using database cursor write a T-SQL script that scans all employees and their addresses and prints all pairs of employees that live in the same town.
DECLARE eCursor CURSOR READ_ONLY FOR
SELECT e1.FirstName, e1.LastName, t1.Name, e2.FirstName, e2.LastName
FROM Employees e1
JOIN Addresses a1
ON e1.AddressID = a1.AddressID
JOIN Towns t1
ON a1.TownID = t1.TownID,
Employees e2
JOIN Addresses a2
ON e2.AddressID = a2.AddressID
JOIN Towns t2
ON a2.TownID = t2.TownID
WHERE t1.TownID = t2.TownID AND e1.EmployeeID != e2.EmployeeID
ORDER BY e1.FirstName, e2.FirstName

OPEN eCursor

DECLARE @firstName1 nvarchar(100), 
        @lastName1 nvarchar(100),
        @townName nvarchar(100),
        @firstName2 nvarchar(100),
        @lastName2 nvarchar(100)
FETCH NEXT FROM eCursor INTO @firstName1, @lastName1, @townName, @firstName2, @lastName2

DECLARE @counter int;
SET @counter = 0;

WHILE @@FETCH_STATUS = 0
BEGIN
SET @counter = @counter + 1;
PRINT @firstName1 + ' ' + @lastName1 + '     ' + @townName + '       ' + @firstName2 + ' ' + @lastName2;

FETCH NEXT FROM eCursor 
INTO @firstName1, @lastName1, @townName, @firstName2, @lastName2
END

print 'Total records: ' + CAST(@counter AS nvarchar(10));

CLOSE eCursor
DEALLOCATE eCursor

--9. *Write a T-SQL script that shows for each town a list of all employees that live in it.
--	Sample output:
--		Sofia -> Martin Kulov, George Denchev
--		Ottawa -> Jose Saraiva
IF NOT EXISTS (
SELECT value
FROM sys.configurations
WHERE name = 'clr enabled' AND value = 1
)
BEGIN
EXEC sp_configure @configname = clr_enabled, @configvalue = 1
RECONFIGURE
END
GO

IF (OBJECT_ID('concat') IS NOT NULL) 
DROP Aggregate concat; 
GO 

IF EXISTS (SELECT * FROM sys.assemblies WHERE name = 'concat_assembly') 
DROP assembly concat_assembly; 
GO      

CREATE Assembly concat_assembly 
AUTHORIZATION dbo 
FROM 'C:\Path\SqlStringConcatenation.dll' -- change path!
WITH PERMISSION_SET = SAFE; 
GO 

CREATE AGGREGATE concat ( 
@Value nvarchar(MAX),
@Delimiter nvarchar(4000) 
) 
RETURNS nvarchar(MAX) 
EXTERNAL Name concat_assembly.concat; 
GO 

DECLARE eCursor CURSOR READ_ONLY FOR
SELECT t.Name, concat(e.FirstName + ' ' + e.LastName, ', ')
FROM Towns t
JOIN Addresses a
ON t.TownID = a.TownID
JOIN Employees e
ON a.AddressID = e.AddressID
GROUP BY t.Name
ORDER BY t.Name

OPEN eCursor

DECLARE @townName nvarchar(50), 
        @employeesNames nvarchar(max)        
FETCH NEXT FROM empCursor INTO @townName, @employeesNames

WHILE @@FETCH_STATUS = 0
BEGIN
PRINT @townName + ' - ' + @employeesNames;

FETCH NEXT FROM empCursor 
INTO @townName, @employeesNames
END

CLOSE eCursor
DEALLOCATE eCursor
GO

DROP Aggregate concat; 
DROP assembly concat_assembly; 
GO

--10. Define a .NET aggregate function StrConcat that takes as input a sequence of strings and return a single string that consists of the input strings separated by ','.
--	For example the following SQL statement should return a single string:
--		SELECT StrConcat(FirstName + ' ' + LastName)
--		FROM Employees
IF NOT EXISTS (
SELECT value
FROM sys.configurations
WHERE name = 'clr enabled' AND value = 1
)
BEGIN
EXEC sp_configure @configname = clr_enabled, @configvalue = 1
RECONFIGURE
END
GO

IF (OBJECT_ID('concat') IS NOT NULL) 
DROP Aggregate concat; 
GO 

IF EXISTS (SELECT * FROM sys.assemblies WHERE name = 'concat_assembly') 
DROP assembly concat_assembly; 
GO      

CREATE Assembly concat_assembly 
AUTHORIZATION dbo 
FROM 'C:\Path\SqlStringConcatenation.dll' -- change path!
WITH PERMISSION_SET = SAFE; 
GO 

CREATE AGGREGATE concat ( 
@Value nvarchar(MAX),
@Delimiter nvarchar(4000) 
) 
RETURNS nvarchar(MAX) 
EXTERNAL Name concat_assembly.concat; 
GO 

SELECT concat(FirstName + ' ' + LastName, ', ')
FROM Employees
GO

DROP Aggregate concat; 
DROP assembly concat_assembly; 
GO		