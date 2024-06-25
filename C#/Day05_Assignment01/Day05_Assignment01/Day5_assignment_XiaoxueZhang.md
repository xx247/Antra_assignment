### Understanding Data Types

#### 1. What type would you choose for the following “numbers”?

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

#### 2. What are the difference between value type and reference type variables? What is boxing and unboxing?

| Value Type                             | Reference Type                               |
| -------------------------------------- | -------------------------------------------- |
| directly contain data                  | store reference or memory address for data   |
| stored in stack memory                 | stored in heap memory                        |
| wont be collected by garbage collector | will be collected by garbage collector       |
| created by struct/ enum                | created by class/ interface/ delegate/ array |
| no null values                         | can accept null                              |

**Boxing**: Conversion of value type to reference type.

**Unboxing**: Conversion of reference type to value type.

#### 3. What is meant by the terms managed resource and unmanaged resource in .NET

**Managed resources** are resources that the .NET runtime (CLR - Common Language Runtime) manages. These include all objects that are created using .NET and are under the control of the garbage collector (GC).

**Unmanaged resources** are resources that the CLR does not manage directly. These include resources that are not part of the .NET managed environment and typically involve interaction with the operating system or other external systems.

#### 4.Whats the purpose of Garbage Collector in .NET?

The Garbage Collector performs a collection cycle when it determines that there is not enough free memory to allocate new objects or when certain thresholds are met.



### Controlling Flow and Converting Types

#### 1. What happens when you divide an int variable by 0?

 a runtime exception called ‘DivideByZeroException’.

#### 2. What happens when you divide a double variable by 0?

double a = 10; a/0 will be +inf

double a = -10; a/0 will be -inf

double a = 0; a/0 will be NaN

#### 3. What happens when you overflow an int variable, that is, set it to a value beyond its range?

int a = int.MaxValue;
Console.WriteLine(a+1);

The output is the minvalue of int

#### 4. What is the difference between x = y++; and x = ++y;?

```C#
int x = 1;
int y = x++;
Console.WriteLine(y); //output is 1
x = 1;
y = ++x;
Console.WriteLine(y); //output is 2
```

In x = y++;, the postfix increment operator (++) is used after the variable y.

#### 5.What is the difference between break, continue, and return when used inside a loop statement?

The break statement is used to immediately exit (terminate) the innermost loop in which it appears. It causes the program control to exit the loop and continue execution immediately after the loop.

The continue statement is used to skip the rest of the current iteration of the loop and proceed to the next iteration.

The return statement is used to exit from a method and optionally return a value to the caller.

#### 6. What are the three parts of a for statement and which of them are required?

for (Initialization Expression; Condition Expression; Iterator Expression) {    

// Body of the loop }

#### 7. What is the difference between the = and == operators?

The '=' operator is used to assign a value to a variable or a property.

The '==' operator is used to compare two values for equality.

#### 8. Does the following statement compile? for ( ; true; ) ;

Yes. This results in an infinite loop.

#### 9. What does the underscore _ represent in a switch expression?

the underscore (_) represents the default case handler, matching any value not explicitly handled by other case labels.

#### 10.What interface must an object implement to be enumerated over by using the foreach statement?

for an object to be enumerable and therefore usable in a foreach statement, it must implement the IEnumerable interface or its generic counterpart IEnumerable<T>.



