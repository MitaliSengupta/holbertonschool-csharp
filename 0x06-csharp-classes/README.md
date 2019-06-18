# 0x06. C# - Classes and Namespaces

## Learning Objective

-   How to document C# code with XML comments
-   What is object-oriented programming?
-   What is a namespace
-   What is a class
-   What are objects and instances
-   What is the difference between a class and an object or instance
-   What is a field
-   What is a constructor
-   What is a property
-   How to use get and set
-   When to use a constructor and when to use a property
-   What is this and when to use it
-   What is a method
-   What are access modifiers
-   What is a static class
-   What is a static member
-   What is encapsulation
-   What is polymorphism
-   What is abstraction
-   What does toString do and how to override it
-   What is the difference between a class and a struct
-   When to use a class and when to use a struct

## Tasks

-   [0-enemy](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x06-csharp-classes/0-enemy)
    -   Create a new namespace Enemies. Create an empty public class Zombie within Enemies that defines a zombie.

-   [1-enemy](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x06-csharp-classes/1-enemy)
    -   Based on 0-enemy, write a public class Zombie that defines a zombie by:
        -   public field health
        -   health should be an int and have no value
        -   public constructor: public Zombie()
            -   sets the value of health to 0
    
-   [2-enemy](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x06-csharp-classes/2-enemy)
    -   Based on 1-enemy, write a public class Zombie that defines a zombie by:
        -   public field health
        -   health should be an int and have no value
            -   public constructor: public Zombie()
        -   sets the value of health to 0
        -   a new public constructor: public Zombie(int value)
            -   value must be greater than or equal to 0
            -   if value is less than 0, throw an ArgumentException with the message Health must be greater than or equal to 0

-   [3-enemy](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x06-csharp-classes/3-enemy)
    -   Based on 2-enemy, write a public class Zombie that defines a zombie by:
        -   private field health
        -   health should be an int and have no value
        -   public constructor: public Zombie()
            -   sets the value of health to 0
        -   public constructor: public Zombie(int value)
            -   value must be greater than or equal to 0
        -   public method public int GetHealth() that returns the value of health of the Zombie object

-   [4-enemy](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x06-csharp-classes/4-enemy)
    -   Based on 3-enemy, write a public class Zombie that defines a zombie by:
        -   private field health
        -   health should be an int and have no value
        -   public constructor: public Zombie()
            -   sets the value of health to 0
        -   public constructor: public Zombie(int value)
            -   value must be greater than or equal to 0
        -   private field name
        -   name should be a string and have a default value of (No name)
        -   public property Name
            -   get: retrieve name
            -   set: set name
        -   public method public int GetHealth() that returns the value of health of the Zombie object