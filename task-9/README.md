# Task-9 Reflection & Custom Attributes App 

## Overview

This is a C# console application that demonstrates the use of **Reflection and Custom Attributes** to dynamically discover and execute methods at runtime.

The program:

* Defines a custom attribute `[Runnable]`
* Marks specific methods using this attribute
* Uses reflection to scan the assembly
* Dynamically executes only the marked methods

---

## Concepts Used

* Reflection (`Assembly`, `Type`, `MethodInfo`)
* Custom Attributes
* Dynamic Method Invocation (`Invoke`)
* Metadata (`AttributeUsage`)

---

## How It Works

1. A custom attribute `[Runnable]` is created

2. Methods inside classes (`TaskOne`, `TaskTwo`) are decorated with `[Runnable]`

3. The program:

   * Scans the current assembly
   * Finds all classes
   * Inspects their methods
   * Checks for `[Runnable]`

4. If found:

   * Creates an instance of the class
   * Invokes the method dynamically

---
