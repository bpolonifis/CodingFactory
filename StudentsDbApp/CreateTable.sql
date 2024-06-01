CREATE TABLE STUDENTS(
	ID INT NOT NULL PRIMARY KEY IDENTITY,
	FIRSTNAME NVARCHAR(255) NOT NULL,
	LASTNAME NVARCHAR(255) NOT NULL
);


INSERT INTO STUDENTS (FIRSTNAME, LASTNAME)
VALUES
(N'Αθανάσιος', N'Ανδρουτσός'),
(N'Γεώργιος', N'Παπαδόπουλος'),
(N'Βασίλειος', N'Πολονύφης'), 
(N'Μάκης', N'Καπέτης');