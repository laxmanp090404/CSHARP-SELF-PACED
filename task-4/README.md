# Task-4 Student Management App

## Overview

This is a C# console application that demonstrates the use of **collections and LINQ** to manage student data.

The program:

* Defines a `Student` class with properties
* Stores student data using `List<Student>`
* Filters students based on a grade threshold
* Sorts the filtered results
* Displays the final list

---

## Concepts Used

* Classes & Objects
* Collections (`List<T>`)
* LINQ (`Where`, `OrderBy`, `ToList`)

---

## How It Works

1. A `Student` class is created with:

   * `Name` (string)
   * `Grade` (int)
   * `Age` (int)

2. A list of students is populated manually

3. The user enters a **minimum grade threshold**

4. LINQ is used to:

   * Filter students with grade greater than threshold
   * Sort students by name

5. The filtered and sorted students are displayed

---