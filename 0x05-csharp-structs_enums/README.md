# 0x05. C# - Structs, Enumerations

## Learning Objective

-   What is a struct
-   What is a constructor
-   What is a field
-   What is a property
-   What is an enumeration and when to use them
-   What does toString do and how to override it

## Tasks

-   [0-dog](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x05-csharp-structs_enums/0-dog)
    -   Define a new enum Rating with the values Good, Great, Excellent.

-   [1-dog](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x05-csharp-structs_enums/1-dog)
    -   Based on 0-dog, define a new struct Dog with the following members:
        -   name, type: public string
        -   age, type: public float
        -   owner, type: public string
        -   rating, type public Rating
    
-   [2-dog](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x05-csharp-structs_enums/2-dog)
    -   Based on 1-dog, add a constructor to struct Dog that takes parameters.

-   [3-dog](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x05-csharp-structs_enums/3-dog)
    -   Based on 2-dog, override the .ToString() method to print the Dog object’s attributes to stdout.
    ```
        Format:
        Dog Name: <name>
        Age: <age>
        Owner: <owner>
        Rating: <rating>
    ```
