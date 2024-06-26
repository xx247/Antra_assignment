### Test your Knowledge

#### 1. When to use String vs. StringBuilder in C# ?

'String' is immutable. So use String when have a fixed or relatively small number of string manipulations.

'StringBuilder' is mutable.  Use it when you need to perform extensive manipulations or concatenations on strings.

#### 2. What is the base class for all arrays in C#?

'System.Array' . Which is an abstract class.

#### 3. How do you sort an array in C#?

using the 'Array.Sort' method

#### 4. What property of an array object can be used to get the total number of elements in an array?

the 'Length' property

#### 5. Can you store multiple data types in System.Array?

No

 However, you can store multiple data types in an array if you use an array of type 'object'

#### 6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?

'Array.CopyTo()': Copies elements to an existing array. Used to copy elements to a specified position in the target array.

'Array.Clone()': Creates a new array that is a shallow copy of the original.



