# Task-7 Async Programming Simulator

## Overview

This console application demonstrates how **asynchronous programming in C#** enables multiple operations to run concurrently without blocking the main thread.

---

## Concepts Used

### Asynchronous Programming (`async` / `await`)

* Enables non-blocking execution
* Allows the program to continue running while waiting for tasks to complete

### Task-based Programming

* Uses `Task<T>` to represent asynchronous operations that return data
* Each data source runs as an independent task

### Concurrency with `Task.WhenAll()`

* Executes multiple tasks **simultaneously**
* Waits until all tasks complete before proceeding


---

## How It Works

1. Three asynchronous methods simulate fetching data from different sources using `Task.Delay`.

2. In the `Main` method:

   * All tasks are started concurrently
   * No task blocks the execution of others

3. `Task.WhenAll()` is used to:

   * Wait for all tasks to complete
   * Collect their results into an array

4. If all tasks succeed:

   * Results are printed to the console

5. If any task fails:

   * The exception is caught and handled gracefully

6. Finally:

   * The program prints a completion message

---
