# SOLID

In this project, I explained the Solid principles in theory and coding.

SOLID Principles
There are five SOLID principles:

1-Single Responsibility Principle (SRP)

2-Open Closed Principle (OCP)

3-Liskov Substitution Principle (LSP)

4-Interface Segregation Principle (ISP)

5-Dependency Inversion Principle (DIP)
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Single Responsibility Principle (SRP)

Definition: A class should have only one reason to change.

Robert C. Martin gave this definition in his book Agile Software Development, Principles, Patterns and Practices and later republished in the C# version of the book Agile Principles, Patterns and Practices in C#.

In layman terminology, this means that a class should not be loaded with multiple responsibilities and a single responsibility should not be spread across multiple classes or mixed with other responsibilities. The reason is that more changes requested in the future, the more changes the class need to apply.

Understanding
Single Responsibility Principle is one of the five SOLID principles which guide developers as they write code or design an application.

In simple terms, a module or class should have a very small piece of responsibility in the entire application. Or as it states, a class/module should have not more than one reason to change.

If a class has only a single responsibility, it is likely to be very robust. It’s easy to verify its working as per logic defined. And it’s easy to change in class as it has single responsibility.

The Single Responsibility Principle provides another benefit. Classes, software components and modules that have only one responsibility are much easier to explain, implement and understand than ones that give a solution for everything.

This also reduces number of bugs and improves development speed and most importantly makes developer’s life lot easier.
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Open Closed Principle (OCP)
Definition: Software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification.

Bertrand Meyer is generally credited for having originated the definition of open/closed principle in his book Object-Oriented Software Construction.

Understanding
This principle suggests that the class should be easily extended but there is no need to change its core implementations.

The application or software should be flexible to change. How change management is implemented in a system has a significant impact on the success of that application/ software. The OCP states that the behaviors of the system can be extended without having to modify its existing implementation.

i.e. New features should be implemented using the new code, but not by changing existing code. The main benefit of adhering to OCP is that it potentially streamlines code maintenance and reduces the risk of breaking the existing implementation.
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Liskov Substitution Principle (LSP)
Definition by Robert C. Martin: Functions that use pointers or references to base classes must be able to use objects of derived classes without knowing it.

The Liskov substitution principle (LSP) is a definition of a subtyping relation, called (strong) behavioral subtyping, that was initially introduced by Barbara Liskov in a 1987 conference keynote address titled Data abstraction and hierarchy.

Understanding
LSP states that the child class should be perfectly substitutable for their parent class. If class C is derived from P then C should be substitutable for P.

We can check using LSP that inheritance is applied correctly or not in our code.

LSP is a fundamental principle of SOLID Principles and states that if program or module is using base class then derived class should be able to extend their base class without changing their original implementation.
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Interface Segregation Principle (ISP)
Definition: No client should be forced to implement methods which it does not use, and the contracts should be broken down to thin ones.

The ISP was first used and formulated by Robert C. Martin while consulting for Xerox.

Understanding
Interface segregation principle is required to solve the design problem of the application. When all the tasks are done by a single class or in other words, one class is used in almost all the application classes then it has become a fat class with overburden. Inheriting such class will results in having sharing methods which are not relevant to derived classes but its there in the base class so that will inherit in the derived class.

Using ISP, we can create separate interfaces for each operation or requirement rather than having a single class to do the same work.
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Dependency Inversion Principle (DIP)
This principle is about dependencies among components. The definition of DIP is given by Robert C. Martin is as follows:

High-level modules should not depend on low-level modules. Both should depend on abstractions.

Abstractions should not depend on details. Details should depend on abstractions.

Understanding
The principle says that high-level modules should depend on abstraction, not on the details, of low-level modules. In simple words, the principle says that there should not be a tight coupling among components of software and to avoid that, the components should depend on abstraction.

The terms Dependency Injection (DI) and Inversion of Control (IoC) are generally used as interchangeably to express the same design pattern. The pattern was initially called IoC, but Martin Fowler (known for designing the enterprise software) anticipated the name as DI because all frameworks or runtime invert the control in some way and he wanted to know which aspect of control was being inverted.

Inversion of Control (IoC) is a technique to implement the Dependency Inversion Principle in C#. Inversion of control can be implemented using either an abstract class or interface. The rule is that the lower level entities should join the contract to a single interface and the higher-level entities will use only entities that are implementing the interface. This technique removes the dependency between the entities.
