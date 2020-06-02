Overview

This is an example of a Human Resources Application written in C#, Javacript, and HTML that was made as part of an interview process with the intent of showcasing:
1) SOLID principles
2) Continuous integration
3) Continous deployment
4) Automated unit testing
5) APIs for individual parts (e.g. Authentication, Authorization)

Use Cases (created from requirements document which I cannot show so as to respect the employers interview process intellectual property)

Users
- Can log in
- Can log out

Administrators
- Can create user
- Can read user
- Can edit user (including username and password)
- Can delete user
- Can assign user permissions --- groups that use custom permissions
- Can remove user permissions
- Cannot delete their own user *
- Cannot edit their own user *

Employees
- Can view their own information
- Cannot view any other users information

Managers
- Can view information of employees that report to them
- Cannot view information of employees that do not report to them
- Can edit information of employees that report to them
- Cannot edit information of employees that do not report to them

Human Resource Personnel
- Can view all employee information except other Human Resource Personnel, unless they report to them
- Can view Human Resource Personnel information that report to them

Setup
1) A valid connection string must be provided, please see:
    
XXX_ENTER A VALID CONNECTION STRING_XXX
