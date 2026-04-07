# Task-8 Generic Repository Pattern App

## Overview

This is a C# console application that demonstrates the use of **Generics, Interfaces, and the Repository Pattern**.

---

## Concepts Used

* Generics (`<T>`)
* Interfaces (`IEntity`, `IRepository<T>`)
* Repository Pattern
* Collections (`List<T>`)
* LINQ (`FirstOrDefault`)

---

## Key Components

### 1. IEntity Interface

```csharp
interface IEntity
{
    int Id { get; set; }
}
```

---

### 2. Student Entity

```csharp
class Student : IEntity
```

Implements `IEntity` and defines:

* Id
* Name
* Age

---

### 3. IRepository<T> Interface

```csharp
interface IRepository<T> where T : IEntity
```

Defines CRUD operations:

* Add
* GetAll
* GetById
* Update
* Delete

---

### 4. Repository<T> Class

```csharp
class Repository<T> : IRepository<T>
```

* Stores data
* Uses LINQ for searching
* Handles updates and deletions

---
