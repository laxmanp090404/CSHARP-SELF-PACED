# Task-5 File Processor

## Overview

This is a C# console application that demonstrates **File I/O and Exception Handling** using a real-world dataset (`anime.csv`).

The program:

* Reads data from a CSV file
* Processes the content (counts lines, words, and entries)
* Filters high-rated anime (rating ≥ 8)
* Writes the results to an output file
* Handles file-related exceptions

---

## Concepts Used

* File I/O (`ReadAllLines`, `ReadAllText`, `WriteAllText`)
* Exception Handling (`try-catch`)
* LINQ (`Where`, `Skip`, `Count`)
* String Manipulation (`Split`)

---

## How It Works

1. Reads `anime.csv` file from a specified path
2. Counts:

   * Total number of lines
   * Total number of words
   * Total number of anime entries (excluding header)
3. Filters anime with ratings ≥ 8 using LINQ
4. Writes results to `output.txt`
5. Displays results in console

---