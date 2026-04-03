# Task-1 Factorial Console App

## Overview

This is a simple C# console application that calculates the **factorial of a given number**.

The program:

* Takes input from the user
* Validates the input (must be a positive integer)
* Calculates factorial using a loop
* Displays the result

---

## Logic Used

* Input handling (`Console.ReadLine`)
* Validation (`int.TryParse`)
---

## How It Works

1. User enters a number
2. Program checks:

   * Is it a number?
   * Is it ≥ 0?
3. Calls `CalculateFactorial()`
4. Prints result

---

## How to Run

### Step 1: Open Terminal

Navigate to your project folder:

```bash
cd FactorialApp
```

---

### Step 2: Run the Program

```bash
dotnet run
```

---