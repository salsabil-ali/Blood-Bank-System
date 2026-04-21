CREATE TABLE Donor (
    Donor_ID INT PRIMARY KEY,
    Name VARCHAR(100),
    Gender VARCHAR(10),
    Date_of_Birth DATE,
    Blood_Type VARCHAR(5),
    Phone_Number VARCHAR(15),
    Address VARCHAR(255)
);

CREATE TABLE Donation (
    Donation_ID INT PRIMARY KEY,
    Donation_Date DATE,
    Quantity INT,
    Donor_ID INT,
    FOREIGN KEY (Donor_ID) REFERENCES Donor(Donor_ID)
);

CREATE TABLE Blood_Unit (
    BloodUnit_ID INT PRIMARY KEY,
    Blood_Type VARCHAR(5),
    Collection_Date DATE,
    Expiration_Date DATE,
    Donation_ID INT UNIQUE, -- عشان 1:1
    FOREIGN KEY (Donation_ID) REFERENCES Donation(Donation_ID)
);

CREATE TABLE Hospital (
    Hospital_ID INT PRIMARY KEY,
    Hospital_Name VARCHAR(100),
    Phone_Number VARCHAR(15),
    Address VARCHAR(255)
);

CREATE TABLE Blood_Request (
    Request_ID INT PRIMARY KEY,
    Request_Date DATE,
    Blood_Type VARCHAR(5),
    Quantity_Requested INT,
    Hospital_ID INT,
    FOREIGN KEY (Hospital_ID) REFERENCES Hospital(Hospital_ID)
);

CREATE TABLE Request_Details (
    Request_ID INT,
    BloodUnit_ID INT UNIQUE, 
    Quantity_Allocated INT,
    
    PRIMARY KEY (Request_ID, BloodUnit_ID),
    
    FOREIGN KEY (Request_ID) REFERENCES Blood_Request(Request_ID),
    FOREIGN KEY (BloodUnit_ID) REFERENCES Blood_Unit(BloodUnit_ID)
);


INSERT INTO Donor VALUES
(1, 'Ahmed Hassan', 'Male', '1995-03-15', 'A+', '01012345678', 'Cairo'),
(2, 'Sara Ali', 'Female', '1998-07-22', 'O+', '01123456789', 'Giza'),
(3, 'Mohamed Adel', 'Male', '1992-11-05', 'B+', '01234567890', 'Alexandria'),
(4, 'Mona Khaled', 'Female', '1996-01-30', 'AB+', '01098765432', 'Cairo'),
(5, 'Omar Tarek', 'Male', '1990-09-12', 'O-', '01111222333', 'Nasr City'),
(6, 'Youssef Nabil', 'Male', '1993-02-14', 'A-', '01055566677', 'Cairo'),
(7, 'Nour Ahmed', 'Female', '1999-08-19', 'O-', '01166677788', 'Giza'),
(8, 'Karim Samy', 'Male', '1991-12-25', 'AB-', '01277788899', 'Alexandria'),
(9, 'Hassan Ali', 'Male', '1988-05-10', 'B-', '01044455566', 'Cairo'),
(10, 'Fatma Yasser', 'Female', '1997-09-18', 'A+', '01155566677', 'Giza'),
(11, 'Ali Mahmoud', 'Male', '1994-03-03', 'O+', '01266677788', 'Alexandria'),
(12, 'Salma Hany', 'Female', '2000-01-20', 'AB+', '01077788899', 'Cairo');


INSERT INTO Donation VALUES
(101, '2026-04-01', 450, 1),
(102, '2026-04-03', 500, 2),
(103, '2026-04-05', 450, 3),
(104, '2026-04-07', 500, 4),
(105, '2026-04-10', 450, 5),
(106, '2026-04-11', 500, 6),
(107, '2026-04-12', 450, 7),
(108, '2026-04-13', 500, 8),
(109, '2026-04-17', 450, 9),
(110, '2026-04-18', 500, 10),
(111, '2026-04-19', 450, 11),
(112, '2026-04-20', 500, 12),
(113, '2026-04-21', 450, 10),   
(114, '2026-04-21', 500, 11);


INSERT INTO Blood_Unit VALUES
(1001, 'A+', '2026-04-01', '2026-06-01', 101),
(1002, 'O+', '2026-04-03', '2026-06-03', 102),
(1003, 'B+', '2026-04-05', '2026-06-05', 103),
(1004, 'AB+', '2026-04-07', '2026-06-07', 104),
(1005, 'O-', '2026-04-10', '2026-06-10', 105),
(1006, 'A-', '2026-04-11', '2026-06-11', 106),
(1007, 'O-', '2026-04-12', '2026-06-12', 107),
(1008, 'AB-', '2026-04-13', '2026-06-13', 108),
(1009, 'B-', '2026-04-17', '2026-06-17', 109),
(1010, 'A+', '2026-04-18', '2026-06-18', 110),
(1011, 'O+', '2026-04-19', '2026-06-19', 111),
(1012, 'AB+', '2026-04-20', '2026-06-20', 112),
(1013, 'A+', '2026-04-21', '2026-06-21', 113),
(1014, 'O-', '2026-04-21', '2026-06-21', 114);

INSERT INTO Hospital VALUES
(201, 'Cairo General Hospital', '0223456789', 'Cairo'),
(202, 'Giza Central Hospital', '0234567891', 'Giza'),
(203, 'Alexandria Medical Center', '0345678912', 'Alexandria'),
(204, 'Nasr City Hospital', '0222223333', 'Cairo'),
(205, '6th October Hospital', '0233334444', 'Giza'),
(206, 'El Salam Hospital', '0228889999', 'Cairo'),
(207, 'El Noor Hospital', '0239990000', 'Giza');

INSERT INTO Blood_Request VALUES
(301, '2026-04-12', 'A+', 2, 201),
(302, '2026-04-13', 'O+', 1, 202),
(303, '2026-04-14', 'B+', 1, 203),
(304, '2026-04-15', 'O-', 2, 204),
(305, '2026-04-16', 'AB-', 1, 205),
(306, '2026-04-18', 'A+', 2, 206),
(307, '2026-04-19', 'O+', 2, 207),
(308, '2026-04-20', 'B-', 1, 206);

INSERT INTO Request_Details VALUES
(301, 1001, 1),
(301, 1004, 1),
(302, 1002, 1),
(303, 1003, 1),
(304, 1005, 1),
(304, 1007, 1),
(305, 1008, 1),
(306, 1013, 1),   
(307, 1011, 1), 
(308, 1009, 1);

