## Understanding Data Types

### 1. What type would you choose for the following “numbers”?

a) A person’s telephone number
string
b) A person’s height
double or float
c) A person’s age
int
d) A person’s gender (Male, Female, Prefer Not To Answer)
enum
e) A person’s salary
decimal
f) A book’s ISBN
string
g) A book’s price
decimal
h) A book’s shipping weight
double or float
i) A country’s population
long
j) The number of stars in the universe
ulong
k) The number of employees in each of the small or medium businesses in the
United Kingdom (up to about 50,000 employees per business
int

### 2. What are the difference between value type and reference type variables? What is boxing and unboxing?

| Value Type                             | Reference Type                               |
| -------------------------------------- | -------------------------------------------- |
| directly contain data                  | store reference or memory address for data   |
| stored in stack memory                 | stored in heap memory                        |
| wont be collected by garbage collector | will be collected by garbage collector       |
| created by struct/ enum                | created by class/ interface/ delegate/ array |
| no null values                         | can accept null                              |

**Boxing**: Conversion of value type to reference type.

**Unboxing**: Conversion of reference type to value type.

### 3. What is meant by the terms managed resource and unmanaged resource in .NET

**Managed resources** are resources that the .NET runtime (CLR - Common Language Runtime) manages. These include all objects that are created using .NET and are under the control of the garbage collector (GC).

**Unmanaged resources** are resources that the CLR does not manage directly. These include resources that are not part of the .NET managed environment and typically involve interaction with the operating system or other external systems.

### 4.Whats the purpose of Garbage Collector in .NET?

The Garbage Collector performs a collection cycle when it determines that there is not enough free memory to allocate new objects or when certain thresholds are met.



## Practice number sizes and ranges

```c#

```

