# C# Questions and Answers
## Mike Schmitt

### 1. What is a namespace?
####  A namespace is something used to organize the many different classes in a program. Namespaces help the compiler break up what pieces of information belong together.
### 2. What are value types?
#### A value type is something that stores data. It can be in the form of numbers, alphabets, and floating point numbers(numbers with decimals).
### 3. What are reference types?
#### A reference type is something that references where the data is stored, rather than storing the actual data. For example if you use a reference type and then change the variable, the reference will also change sense the memory being referenced changed.
### 4. What is an automatic property and how is it useful?
#### An automatic property is something used to simplify code when no additional logic is needed. It is useful because it is basically a coding shortcut that helps you condense your code.
### 5. What is the purpose of **using** statement?
#### A using statement is useful when you would need to dispose of something, or clean up after a messy class. It's another way of simplifying a block of code to something smaller and easier to read.
### 6. What are dynamic type variables?
#### Dynamic type variables are variables that can change all the way up until runtime. It's useful when you are working with code that's coming from other runtimes, the compiler is prepared for whatever it receives when it hits runtime.
### 7. What is the purpose of the **is** operator?
#### The **is** operator helps determine compatibility at runtime. It checks whether an object is compatible with a given type.
### 8. What are generics and how is using them useful?
#### Generics allow you to write a class or method that can work with any data type. This is helpful when it comes to reusing code, because you never specified the data type, it is easy to transfer and implement the classes and methods elsewhere.
### 9. What is the scope of a public member of a class?
#### The scope is that a public member can be used by the public, rather the functions can be accessed from outside the class.
### 10. Can you create a function that can accept a varying number of arguments?
#### Yes, a function can accept multiple arguments, however it will only return one argument.
### 11. How do you sort an array?
#### To sort an array in C# you would use Array.Sort().
### 12. What is a nullable type and what purpose does it serve?
#### A nullable type allows you to enter a numerical value or a null value which is useful when you don't know the value, however you want to ensure the program is able to run.
### 13. What is an enumeration?
#### An enumeration is a constant value type which is useful when you want to assign a name and a value to an integer. A good example is representing months of the year with a string name and a value e.g. Jan also equals 01.
### 14. What is inheritance?
#### Inheritance is used when you want classes to have base properties, but each class to have their own specific properties. It makes coding faster because you can have a bunch of classes inherit the basic properties you want all classes/ a group of classes, to have.
### 15. Is multiple inheritance supported?
#### Unfortunately multiple inheritance is not supported so classes can only inherit from one parent class.
### 16. What is the purpose of as operator?
#### The as operator performs conversion between compatible reference types or null types. In other words it attempts to convert an object to a specific type and returns null if it fails.
### 17. What is an object?
#### An object is a block of memory that can be stored in a variable or collection/array.
### 18. What is the difference between a struct and a class?
#### Members of a struct are public, and members of a class are private. A struct is also a value type, while a class is a reference type.
### 19. What is the difference between **continue** and **break** statements?
#### Continue will cause the loop to begin another iteration, whereas break immediately exits the loop.
### 20. What is **this** and how is it used?
#### You would use **this** when you want to refernece the current state of the instance. You could also use it pass an object to other methods, or declare indexers.
### 21. What is **try** and **catch** and when are they used?
#### They are used to find exceptions in the code, however instead of crashing the program they just return an error statement.
### 22. How is exception handling done?
#### Exception handling is done with try, catch, finally and throw, it's useful because it won't crash the program rather it will catch the error and essentially allow you to determine where the exception happened.
### 23. What is **finally** and what is its purpose?
#### Finally is a keyword that is executed after the try and catch block. No matter what stops the execution of try and catch, or if it executes normally finally will always be executed after.
### 24. List the differences between Array and ArrayList.
#### Array can only store specific things, one datatype, and cannot accept null. ArrayList can store anything, will accept multiple datatypes, and accepts null.
### 25. What is an object?
#### An object is a block of memory that can be stored in a variable or collection/array.
### 26. Define **constructor**.
#### A constructor is used to set variables to objects, and contains the instructions that are executed at the time of object creation.
### 27. When can **var** be used to declare a variable and how is the type for the variable determined?
#### Var is used when the type is the same as the variable. The var keyword tells the compiler to infer and determine the type based on the expression.
### 28. What is an abstract class?
#### An abstract class is a class that is designed to be inherited from.
### 29. What is an interface?
#### An interface is something that declares methods and properties but not their implementation.
### 30. What is a method?
#### A method is block of code that performs a task; every program in C# has one or more.
### 31. What is a property?
#### A property provides a way to read and write a private field.
### 32. What is an access specifier?
#### An access specifier is similar to a guest list, it tells the program what code has access to other functions, variables, or data.
### 33. What access specifiers are supported and what do they mean?
#### C# has five access specifiers: private, limits the accessibility within the defined type; public, has no limits; internal, allows access within the assembly; protected, plays a role with inheritance; protected internal, is accessible in the assembly when inheritance is used.
### 34. What is a collection?
#### A collection is an easier way to work with groups of objects, it also is useful in dynamically assigning memory, and working with the index.
### 35. What is a Hash Table?
#### A hash table is a class that works with key and value pairs and is sorted using the hash of the key. You would use a hash table when you have elements that can only be accessed using a key.
