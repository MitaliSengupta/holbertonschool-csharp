# 0x08. C# - Inheritance

## Learning Objective

-   What is inheritance
-   How is polymorphism achieved with inheritance
-   What is a base class
-   What is a derived class
-   How to create a derived class
-   How to override a method or property inherited from the base class
-   What is the difference between the override and new modifiers
-   What are is, .GetType(), TypeOf(), .IsInstanceOfType(), and .IsSubclassOf() and when to use them

## Tasks

-   [0-is](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x08-csharp-inheritance/0-is)
    -   Write a method that returns True if the object is an int, otherwise return False.
        -   Class: Obj
        -   Prototype: public static bool IsOfTypeInt(object obj)

-   [1-instance](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x08-csharp-inheritance/1-instance)
    -   Write a method that returns True if the object is an instance of, or if the object is an instance of a class that inherited from, Array, otherwise return False.
        -   Class: Obj
        -   Prototype: public static bool IsInstanceOfArray(object obj)
    
-   [2-subclass](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x08-csharp-inheritance/2-subclass)
    -   Write a method that returns True if the object is an instance of a class that inherits from the specified class, otherwise return False. The object must be a subclass; your method cannot return True if the object is an instance of the base class.
        -   Class: Obj
        -   Prototype: public static bool IsOnlyASubclass(Type derivedType, Type baseType)

-   [3-type_get](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x08-csharp-inheritance/3-type_get)
    -   Write a method that prints the names of the available properties and methods of an object. See example for output format.
        -   Class: Obj
        -   Prototype: public static void Print(object myObj)

-   [4-inherit](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x08-csharp-inheritance/4-inherit)
    -   Write a empty class Dog that inherits from empty class Animal.
        -   Base Class: Animal
        -   Derived Class: Dog

-   [5-shape](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x08-csharp-inheritance/5-shape)
    -   Write a class Shape.
        -   Class: Shape
            -   public method: public virtual int Area()
                -   Throws an NotImplementedException with the message Area() is not implemented

-   [6-shape](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x08-csharp-inheritance/6-shape)
    -   Based on 5-shape, write a class Rectangle that inherits from Shape.
        -   Class: Rectangle
            -   private field: private int width
            -   private field: private int height
            -   public property: public int Width
                -   get: retrieve width
                -   set: if value is negative, throw an ArgumentException with the message Width must be greater than or equal to 0. Otherwise, set width to the value.
        -   public property: public int Height
            -   get: retrieve height
            -   set: if value is negative, throw an ArgumentException with the message Height must be greater than or equal to 0. Otherwise, set Height to the value.

-   [7-shape](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x08-csharp-inheritance/7-shape)
    -   Based on 6-shape, write a class Rectangle that inherits from Shape.
        -   Class: Rectangle
            -   private field: private int width
            -   private field: private int height
            -   public property: public int Width
                -   get: retrieve width
                -   set: if value is negative, throw an ArgumentException with the message Width must be greater than or equal to 0. Otherwise, set width to the value.
            -   public property: public int Height
                -   get: retrieve height
                -   set: if value is negative, throw an ArgumentException with the message Height must be greater than or equal to 0. Otherwise, set Height to the value.
            -   public method: public new int Area()
                -   This will override the Area() method defined in the Shape base class. (Try changing new to override and run the program. What happens?) returns the area of the rectangle
            -   public method: public override ToString()
                -   returns [Rectangle] <width> / <height>

-   [8-shape](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x08-csharp-inheritance/8-shape)
    -   Based on 7-shape, write a class Square that inherits from Rectangle
        -   Class: Square
            -   private field: private int size
            -   public property: public int Size
                -   get: retrieve size
                -   set: if value is negative, throw an ArgumentException with the message Size must be greater than or equal to 0. Otherwise, set size, height, and width to the value.

-   [9-shape](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x08-csharp-inheritance/9-shape)
    -   Based on 8-shape, write a class Square that inherits from Rectangle
        -   Class: Square
            -   private field: private int size
            -   public property: public int Size
                -   get: retrieve size
                -   set: if value is negative, throw an ArgumentException with the message Size must be greater than or equal to 0. Otherwise, set size, Height, and Width to the value.
            -   Area() should work without writing a new Area() method within your Square class
            -   .ToString() should return [Square] <size> / <size>

-  [Blog](https://medium.com/@mitali.s.auger): Blog post that explains the problem with implementing a Square class as a derived class of Rectangle. It covers:
    -   what Liskov’s substitution principle is
    -   why Square inheriting from Rectangle is not an ideal design choice
    -   ways that a given class hierarchy could be improved