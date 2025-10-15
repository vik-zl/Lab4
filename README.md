# Lab4_grading

## Overview
Lab4_grading is a C# console application designed to manage and grade Champlain College students. It demonstrates object-oriented programming concepts such as abstract classes, interfaces, and partial classes, and reads student and course data from text files to compute and display grading reports.

## Features
- Loads student data from `students.txt` and course data from `courses.txt`
- Uses an abstract `Person` class for common attributes
- Implements an `IGrading` interface for grade calculations
- Splits the `ChamplainStudent` class across two partial files
- Calculates and displays each student's Average, GPA, and R-Score in a readable report

## Project Structure
- `Person.cs`: Abstract base class for people
- `IGrading.cs`: Interface for grading methods
- `ChamplainStudent_Part1.cs` & `ChamplainStudent_Part2.cs`: Partial class implementation for students
- `Program.cs`: Main program logic and report generation

## Requirements
- .NET 8 SDK
- Visual Studio 2022 or later

## Getting Started

1. **Clone the repository:**
