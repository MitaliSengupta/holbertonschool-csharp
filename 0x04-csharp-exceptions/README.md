# 0x04. C# - Exceptions

## Learning Objective

-   What are exceptions and when to use them
-   What is the purpose of catching exceptions
-   How to handle exceptions
-   How to use try, catch, finally
-   How to raise built-in exceptions
-   When to implement clean-up actions after exceptions

## Tasks

-   [0-safe_list_print](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x04-csharp-exceptions/0-safe_list_print)
    -   Write a method that prints n elements of a list.
        -   Class Name: List
        -   Prototype: public static int SafePrint(List<int> myList, int n)
        -   n represents the number of elements to print
        -   n can be bigger than the length of myList
        -   Returns number of elements actually printed
        -   You have to use try / catch

-   [1-divide_print](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x04-csharp-exceptions/1-divide_print)
    -   Write a function that divides 2 integers and prints the result.
        -   Class Name: Int
        -   Prototype: public static void divide(int a, int b)
        -   You can assume that a and b are integers
        -   You have to use try / catch / finally
        -   The result of the division should print in the finally section in the format shown in the example
    
-   [2-divide_lists](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x04-csharp-exceptions/2-divide_lists)
    -   Write a function that divides element by element 2 lists.
        -   Class Name: List
        -   Prototype: public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
        -   length can be bigger than the length of either list
        -   Returns a new list of all division results
        -   If 2 elements can’t be divided, the division result should be equal to 0
        -   If the division can’t be done (dividing by 0):
            -   print Cannot divide by zero
        -   If either list is too short:
            -   print Out of range
        -   You have to use try / catch

-   [3-throw_exception](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x04-csharp-exceptions/3-throw_exception)
    -   Write a function that throws an Exception.
        -   Class Name: Except
        -   Prototype: public static void Throw()

-   [4-throw_exception_msg](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x04-csharp-exceptions/4-throw_exception_msg)
    -   Write a method that throws an Exception with a message.
        -   Class Name: Except
        -   Prototype: public static void ThrowMsg(string msg)