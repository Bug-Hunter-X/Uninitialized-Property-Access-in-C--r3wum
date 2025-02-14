# Uninitialized Property Access in C#

This repository demonstrates a common, yet subtle, error in C#: accessing an uninitialized property.  Uninitialized properties can lead to unexpected behavior, making debugging challenging.  The `bug.cs` file illustrates the problem, while `bugSolution.cs` provides a corrected version.

## Problem

In C#, class properties are not automatically initialized. Attempting to read the value of a property before assigning it a value results in accessing its default value (0 for integers, null for reference types, etc.). This can cause issues if you expect a specific value or haven't handled the default properly.

## Solution

The best practice is to initialize properties within the constructor or assign a value before accessing them. The `bugSolution.cs` demonstrates how to solve this by initializing the `MyProperty` in the constructor. 
