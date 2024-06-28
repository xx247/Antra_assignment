#### 1. What are the six combinations of access modifier keywords and what do they do?

**public**: used for members that need to be accessible  from anywhere.

**private**: used for members that should not be accessible from outside the class or struct.

**protected**: used for members that should be accessible only to the class itself and its derived classes.

**internal**: used for members that should be accessible only within the same assembly, but not from another assembly.

**protected internal**: combines the accessibility of `protected` and `internal` members

**private protected**: combines the accessibility of `private` and `protected` members.

#### 2. What is the difference between the static, const, and readonly keywords when applied to a type member?

**static**: Static members can be accessed using the type name without creating an instance of the type.

(Indicates that the member belongs to the type itself rather than to a specific instance of the type.)

**const**: Defines a constant value that cannot be changed after it is compiled. Commonly used for values that are known at compile time and do not change.

**readonly**: Defines a field that can only be assigned a value during its declaration or in the constructor of the class. Commonly used for fields that should not change after the object is constructed but need to be assigned a value at runtime.

#### 3. What does a constructor do?

A constructor is a special method in a class or struct that is called when an instance of that class or struct is created. The primary purpose of a constructor is to initialize the object's state

#### 4. Why is the partial keyword useful?

The `partial` keyword in C# allows you to split the definition of a class, struct, or interface into multiple files. 

#### 5. What is a tuple?

a tuple is a data structure that provides an easy way to group multiple values together without having to define a specific class or struct. 

#### 6. What does the C# record keyword do?

The `record` keyword introduces a new reference type that provides built-in functionality for immutability and value-based equality.

#### 7. What does overloading and overriding mean?

Overloading allows a class to have multiple methods with the same name but different parameters.

Overriding allows a subclass to provide a specific implementation of a method that is already defined in its base class.

#### 8. What is the difference between a field and a property?

A field is a variable that is declared directly in a class or struct. Fields can be of any type and are used to store data directly.

A property is a member that provides a flexible mechanism to read, write, or compute the value of a private field. Properties can include logic to validate the data before assigning it to the field.

#### 9. How do you make a method parameter optional?

you can make a method parameter optional by providing a default value for the parameter.

#### 10. What is an interface and how is it different from abstract class?

| Interface                                                    | Abstract Class                                               |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| Cannot contain any implementation                            | Can contain both abstract members (without implementation) and non-abstract members (with implementation) |
| A class can implement multiple interfaces.                   | A class can inherit only one abstract class.                 |
| Cannot contain fields, constructors, destructors, or static members. | Can contain fields, constructors, destructors, and static members |
| All members are implicitly public and cannot have access modifiers. | Members can have different access modifiers                  |
| Used to define a contract that other classes must follow.    | Used to provide a common base class with shared functionality that can be inherited and extended by derived classes. |
| Cannot have constructors.                                    | Can have constructors which can be called by derived classes. |

#### 11. What accessibility level are members of an interface?

public

#### 12. True/False. Polymorphism allows derived classes to provide different implementations

of the same method.

True

#### 13. True/False. The override keyword is used to indicate that a method in a derived class is providing its own implementation of a method.

True

#### 14. True/False. The new keyword is used to indicate that a method in a derived class is providing its own implementation of a method.

False

#### 15. True/False. Abstract methods can be used in a normal (non-abstract) class. 

False

#### 16. True/False. Normal (non-abstract) methods can be used in an abstract class.

True

#### 17. True/False. Derived classes can override methods that were virtual in the base class.

True

#### 18. True/False. Derived classes can override methods that were abstract in the base class.

True

#### 19. True/False. In a derived class, you can override a method that was neither virtual non abstract in the
base class.

False

#### 20. True/False. A class that implements an interface does not have to provide an implementation for all of the members of the interface.

False

#### 21. True/False. A class that implements an interface is allowed to have other members that aren’t defined in the interface.

True

#### 22. True/False. A class can have more than one base class.

False

#### 23. True/False. A class can implement more than one interface.

True

