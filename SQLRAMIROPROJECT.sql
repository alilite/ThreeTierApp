USE College1en;

-- Create the Programs table
CREATE TABLE Programs (
    ProgId VARCHAR(5) NOT NULL PRIMARY KEY,
    ProgName VARCHAR(50) NOT NULL
);

-- Create the Courses table
CREATE TABLE Courses (
    CId VARCHAR(7) NOT NULL PRIMARY KEY,
    CName VARCHAR(50) NOT NULL,
    ProgId VARCHAR(5) NOT NULL
);

-- Create the Students table
CREATE TABLE Students (
    StId VARCHAR(10) NOT NULL PRIMARY KEY,
    StName VARCHAR(50) NOT NULL,
    ProgId VARCHAR(5) NOT NULL
);

-- Create the Enrollments table
CREATE TABLE Enrollments (
    StId VARCHAR(10) NOT NULL,
    CId VARCHAR(7) NOT NULL,
    FinalGrade INT,
    PRIMARY KEY (StId, CId)
);

-- Add Foreign Keys and Constraints
ALTER TABLE Courses
ADD CONSTRAINT FK_Courses_Programs FOREIGN KEY (ProgId) REFERENCES Programs(ProgId);

ALTER TABLE Students
ADD CONSTRAINT FK_Students_Programs FOREIGN KEY (ProgId) REFERENCES Programs(ProgId);

ALTER TABLE Enrollments
ADD CONSTRAINT FK_Enrollments_Students FOREIGN KEY (StId) REFERENCES Students(StId);

ALTER TABLE Enrollments
ADD CONSTRAINT FK_Enrollments_Courses FOREIGN KEY (CId) REFERENCES Courses(CId);

-- Insert some sample data
INSERT INTO Programs (ProgId, ProgName) VALUES
('P0001', 'Computer Science'),
('P0002', 'Electrical Engineering');

INSERT INTO Courses (CId, CName, ProgId) VALUES
('C000001', 'Introduction to Programming', 'P0001'),
('C000002', 'Circuit Design', 'P0002');

INSERT INTO Students (StId, StName, ProgId) VALUES
('S000000001', 'John Doe', 'P0001'),
('S000000002', 'Jane Smith', 'P0002');

INSERT INTO Enrollments (StId, CId, FinalGrade) VALUES
('S000000001', 'C000001', 85),
('S000000002', 'C000002', 90);
