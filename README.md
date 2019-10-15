# Technical Exercise Belatrix

This is technical exercise using c# .Net to Belatrix Software.

The code is used to log different messages throughout an application. We want the
ability to be able to log to a text file, the console and/or the database. Messages can be
marked as message, warning or error. We also want the ability to selectively be able to
choose what gets logged, such as to be able to log only errors or only errors and
warnings.


## Code Review

###### General comments:

1. The `JobLogger` class has too many responsibilities and this goes against good programming principles.
2. The `JobLogger` class cannot be extended easily, if another type of log would be added in the future, it would be a very tedious task.
3. The code does not compile because the `LogMessage` method has two parameters that are called the same, and this should never happen.
4. The code is very difficult to maintain, surely a small modification in the code would cause it to fail.
5. The code is difficult to read and understand for the following reasons:
	* The variables are not descriptive.
	* Some variables do not use the standard clean code nomenclature.
	* The call to classes is very long because the libraries to be used in the code header were not declared.
	* There are variables that are declared but never used.
	* There are too many variables without context, it would be better to have an object with these variables as attributes or an enumerator.

###### Specific Comments:

Specific comments can be seen directly in the code [here](LoggerToCodeReview/JobLogger.cs)


## Code Refactoring

The following improvements were implemented for the given code:

1. The Factory Method design pattern was implemented to create the type of log that someone wants to use.
2. Enumerators were created to better manage all variables.
3. The names of the variables and methods were changed to be clearer, and these follow the standard clean code nomenclature.
4. Custom classes were added for handling exceptions of each type of log.
5. Unit tests were added for the functionality of each type of log and for the factory responsible for creating the log types.
6. Several components were created that can easily be extended.


That's it :+1:

