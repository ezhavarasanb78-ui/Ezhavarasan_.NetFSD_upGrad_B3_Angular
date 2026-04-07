create database day36;
use day36;
CREATE TABLE Courses (
    CourseId INT PRIMARY KEY IDENTITY,
    CourseName NVARCHAR(100)
);

CREATE TABLE Students (
    StudentId INT PRIMARY KEY IDENTITY,
    StudentName NVARCHAR(100),
    CourseId INT,
    FOREIGN KEY (CourseId) REFERENCES Courses(CourseId)
);