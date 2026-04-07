# Task-6 Event Delegate Simulator

## Overview

This project demonstrates the **use of Delegates and Events in C#** through a simple counter-based simulation.

When a counter reaches a predefined threshold, multiple event handlers are triggered.

---

## Concepts Used

* Delegates in C#
* Events and Event Handling
* Publisher-Subscriber Model

---


## How It Works

1. A **delegate** defines the method signature.
2. The **Counter class (Publisher)**:

   * Tracks count
   * Raises an event when threshold is reached
3. The **Handlers class (Subscribers)**:

   * Contains multiple methods that respond to the event
4. In `Main()`:

   * Handlers are subscribed to the event
   * Counter increments in a loop
   * Event triggers when threshold is met

---