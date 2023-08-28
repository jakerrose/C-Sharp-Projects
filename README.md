# C-Sharp-Projects
The Tech Academy C# projects

This repository contains projects I made using C# and the .NET framework.

Black Jack

This is a working game of Black Jack that the user plays against a computer dealer. The program includes a TwentyOne game class that inherits from a more generic Game class, a Dealer class, Player class, and more. It includes a method to shuffle the deck. It also includes a Fraud Exception class to catch the user trying to cheat. It connects with a database that records the time the Fraud Exception is induced.

This project is a culmination of everything I've learned about console applications in this course. Many different classes were created to reprent real objects such as dealer and player and they contain properties essential for the game. In the Deck class, a deck of cards is created using a for loop that creates 52 unique cards. Each possible suit and face is defined in the Card class.  The program uses if statements with boolean logic to determine if the player is ready to play. A variable is saved with the money the player brings to the game. If the user enters in a negative amount, an exception will be raised using try catch. A player ID is created using a GUID and that is logged to an external file. In the TwentyGame class, a foreach loop is used to establish a hand for each player. For and foreach loops, if else statements, and boolean logic form the foundation for the game. 

Car Insurance MVC Web App

This is a working app to calculate a quote for car insurance based on user input such as age, car make and model, and speeding tickets. It was built with the .NET framework and uses the MVC structure for web apps. Entity Framework is employed to interact with a Sql Server database. The entity data model was created using database first approach.

Newsletter App MVC

A simple newsletter signup designed with the MVC model using Visual Studio. Uses boostrap design features. User data is automatically sent to a database that can be viewed on a web browswer from the Admin ViewModel.

Lamda Submission Assignment

A C# project in which an Employee class is created with three properties. The program creates a list of new employees and lamda expressions are used to filter out employees by different properties. 

Daily Report

A C# program that asks a student user questions about their studies and records their answers as variables of different data types for use in a report.

Console App Assignment

Uses the console to ask user for number and then performs mathematical calculations on the user's number.

Math and Comparison Operator Assignment

Gets the annual salaries of two users by asking questions about their income. Program performs mathematical operations and compares the salaires of the two users. Uses arithmetic as well as boolean logic.

Boolean Logic Assignment

A simple console app that determines if the user is qualified for car insurance. Takes user input and uses boolean logic to determine if they meet criteria.

Branching Assignment

A console app to calculate shipping for a package. Uses if else branching statement to determine if package weight is exceptable, if so, it goes on to calculate shipping. 

Console App While Statement

A guessing game app in which the user tries to guess the right name. Uses a while statement and a switch to give different responses to user's guess.

Console App Do While Statement

Another guessing game app, this time a user tries to guess the right number. This time uses a do while statement and switch.

String Assignment

Console app using StringBuilder to concatonate longer strings of text.

Console App Array Assignment

An assignment exploring string arrays, number arrays, and string lists. The user is asked to input an index number for the array or string and the word or number prints to the console. Try catch is used for when the user inputs a number outside the index of the array or list.

Console App part 1

The user is asked to search for an item in the array. Uses for loop to search through index. Uses if else statement to let user know if their search term is in the list. A list is created with a duplicate entry. A foreach loop is used to list the unique and duplicate entries.

Calling Methods

An introduction to calling methods which do math operations on arguments. 

Method Submission

Calls a method that is created in its own separate class. Instantiates class in the program.

Abstract Class

Creates objects Employee and abstract class Person which has abstract method SayName() which will print FirstName and LastName properties.

Parameters

Implements generic class Employee, creates generic list for two new Employee objects. Items in list become parameters that are printed using a foreach loop.

Parsing Enums

Created list of enums (days). The user is asked to enter a day of the week, the Parse method is used to determine if there is a match. A try catch is used to create a response if the user is successful or not. 

Input Assignment

A user's input is logged to an external text file.

DateTime submission

The DateTime method is employed including DateTime.Now to print the current date and time and AddHours to add hours to determine a future time and date.


