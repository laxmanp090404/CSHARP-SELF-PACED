# 📘 C# Concepts


## 1. C# vs .NET

**C#** - Programming Language                
**.NET** - Framework for building applications 

### .NET Components

* **CLR (Common Language Runtime)** → Executes code
* **Class Library** → Predefined reusable classes

### Execution Flow

```
C# Code → IL (Intermediate Language) → CLR → Machine Code
```

* CLR uses **JIT (Just-In-Time Compilation)**

---

## 2. Core Architecture

### Class

* Blueprint containing:

  * **Attributes (Data)**
  * **Methods (Behavior)**

### Namespace

* Container for related classes

### Assembly

* Compiled output (.exe / .dll)
* Contains related namespaces

---

## 3. Program Structure

```csharp
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }
}
```

### Key Points:

* `Main()` → Entry point
* Case-sensitive language

---

## 4. Variables & Constants

### Variable

```csharp
int number = 10;
```

* Must be **initialized before use**

### Constant

```csharp
const float PI = 3.14f;
```

* Immutable (cannot change)

---


## 5. Data Types

### Primitive Types

| Category  | Type                   | Example           |
| --------- | ---------------------- | ----------------- |
| Integer   | int, short, long, byte | `int x = 10;`     |
| Real      | float, double, decimal | `float f = 1.2f;` |
| Character | char                   | `'A'`             |
| Boolean   | bool                   | `true/false`      |

### Important:

* Default real type → **double**
* Use suffix:

  * `f` → float
  * `m` → decimal

---

## 6. Non-Primitive Types

* `string`
* `array`
* `enum`
* `class`

---

## 7. Type Conversion

###  Implicit

```csharp
byte b = 1;
int i = b;
```

### Explicit (Casting)

```csharp
int i = 300;
byte b = (byte)i;
```

### Convert Class

```csharp
string s = "123";
int num = Convert.ToInt32(s);
```

### Parse Method

```csharp
int num = int.Parse("123");
```

---

## 8. Exception Handling

```csharp
try
{
    int num = Convert.ToByte("1234");
}
catch (Exception)
{
    Console.WriteLine("Conversion failed");
}
```

---

## 9. Overflow

```csharp
byte b = 255;
b++; // becomes 0 (overflow)
```

### Prevent Overflow:

```csharp
checked
{
    byte b = 255;
    b++; // throws exception
}
```

---

## 10. Scope

* Scope = where variable is accessible

```csharp
{
    int a = 10;
    {
        int b = 20;
    }
}
```

* `a` accessible inside inner block
* `b` NOT accessible outside

---

## 11. Operators

### Arithmetic

```csharp
+, -, *, /, %
```

### Increment/Decrement

```csharp
a++  // postfix
++a  // prefix
```

---

### Comparison

```csharp
==, !=, >, <, >=, <=
```

---

### Logical

```csharp
&& (AND)
|| (OR)
!  (NOT)
```

---

### Assignment

```csharp
=, +=, -=, *=, /=
```

---

## Operator Precedence

```csharp
int result = a + b * c; // * first
```

Use parentheses:

```csharp
(a + b) * c
```

---

## 12. var Keyword

```csharp
var x = 10;  // int
var name = "Laxman"; // string
```

* Compiler decides type
* Still **statically typed**

---

## 13. Comments

```csharp
// Single line

/* Multi-line */
```
