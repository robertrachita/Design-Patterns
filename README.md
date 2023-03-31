# Design-Patterns

## Introduction
This document serves as a start  document and project  planning for the practical group assignment, part  of  the “Design  Patterns”course.  The  scope  of  the  course  is  to  enable  students  to  understand various design patterns.Design patterns are a toolkit of solutions to common problems in software design.  It  specifically  concerns  with  communication  between  objects. This  group  project will  be created in accordance and requirementsof the “OIDP -Design Patterns” Module book version 5.0 of 2022.

## Application description
The group intends to create a Social Media Platform. Such a platform will allow users to create posts and  comments,  and  to  like  said  posts.  Additionally, it  can  notify  users  of  new  posts, comments,or reactions to already existing posts. The application will be presented as a web application and will be written in C# ASP.NET.

## Features
- Creating a post via GUI
- Displaying a list of posts
- Liking a post (self-created or another users)
- Commenting on a post (self-created or another users)

## Technology& Patterns Applied
The project will make use of different threading methods and techniques, as part of the course and required in implementing some of the features. These are as follows:
- GitHub
- C# ASP.NET
- Iterator - For iterating over the list of possible posts, comments and for filteringthem by different criteria (for instance date or length of the post). This will be manually implemented.
- Factory - For creating and managing the different types of objects (posts, comments, likes etc). The Factory pattern helps to encapsulate the creation and initialization of complex objects, and to provide a consistent interface for users to interact with them.
- Observer - For notifying users of new posts, comments, and likes. The Observer pattern helps to decouple the different components of the social media platform, and to provide a flexible and extensible architecture for handling user interactions and updates.Another use caseis analytics –
- Template - Different posts (image/text/video/hybrid)
- MVC - Forseparation of Concerns and Logic, and to ease the GUI interaction from a coding point of view.

The code can be found in the following public GitHub repository.The software used is Visual Studio 2022, and Figma for the UML.

## Group
The “Group” chapter provides an overview into the team responsible for the application development. 

Christopher Sulistiyo - christopher.sulistiyo@student.nhlstenden.com - 4850025
Stefan Untura - stefan.untura@student.nhlstenden.com - 4839161
Robert Răchită - robert.rachita@student.nhlstenden.com - 4859367
