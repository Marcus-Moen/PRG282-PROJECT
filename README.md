# StudentManagementSystem

## Description

This project is a C# Windows Forms application designed for managing student records. It stores student data in text files and utilizes Git for version control, integrating with GitHub for collaboration and tracking. This system allows users to add, view, update, and delete student records through an intuitive interface, with real-time file handling and error management. A summary report feature calculates the total student count and average age, saving the report to a text file.

Technologies Used: C#, Windows Forms, Git, GitHub

Github link: https://github.com/Marcus-Moen/PRG282-PROJECT

## Table of Contents
- [Project Description](#description)
- [Usage](#usage)
- [Features](#features)
- [Creators](#creators)

## Usage

### Passwords for use:
#### Login Passwords:
| Username | Password  |
|----------|-----------|
| admin    | admin123  |
| 1        | 1         |

#### Data Password:
wanttobeaproblem

## Features

### Login Form

![image](https://github.com/user-attachments/assets/3d62dcb6-8a19-448a-84a4-d0e00df15663)

User enters the username and password and the given information is checked to be correct. The Login information is stored in a textfile. User can choose to view password through a checkbox.

### Students Form

![image](https://github.com/user-attachments/assets/454cc1ef-7727-4fb7-ae73-76a8cd749e4b)

In the Main Students form a user must first type the data password to view the student data. This is because the student data is stored in an encrypted textfile for security, the password is needed to decrypt the data.

Features of the main student form:
- Add Students
- Update Students
- Delete Students
- View Students
- Change the data Password

### Statistics Form

![image](https://github.com/user-attachments/assets/04bcb3e9-8a9a-4413-b259-96e740d56c62)

![image](https://github.com/user-attachments/assets/abcf103f-e549-4bbc-91d5-b5da26d677cd)

Features of the statistics form:
- Pi chart of amount of students in each course
- Bar graph of average age of students in each course
- Print preview of Summary
- Print Summary
- Save Summary to textfile

## Creators

Renaldo Jardim 601333@student.belgiumcampus.ac.za

Marcus Cornelis Moen 577916@student.belgiumcampus.ac.za

Gito Gerardo Martin 600966@student.belgiumcampus.ac.za

Muhammad Toufeeq Parker 600947@student.belgiumcampus.ac.za
