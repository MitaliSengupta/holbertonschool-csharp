# 0x01. C# - if/else, loops, functions

## Learning Objective

-  How to use if, else if, else statements
-  How to use while and for loops
-  How to use break and continue statements
-  How to use numeric format strings
-  How to declare methods within a class
-  How to call public methods from another class
-  What is passing by reference and passing by value

## Tasks

- This program will assign a random signed number to the variable number each time it is executed. Complete the source code in order to print whether the number stored in the variable number is positive or negative.
   - You can find the source code here
   - The variable number will store a different value every time you will run this program
   - You don’t have to understand what Random does. Please do not touch this code
   - The output of the program should be:
     - The number, followed by
       - if the number is greater than 0: is positive
       - if the number is 0: is zero
       - if the number is less than 0: is negative
   - followed by a new line

-  This program will assign a random signed number to the variable number each time it is executed. Complete the source code in order to print whether the number stored in the variable number is positive or negative.
   - You can find the source code here
   - The variable number will store a different value every time you will run this program
   - You don’t have to understand what Random does. Please do not touch this code
   - The output of the program should be:
     - The string The last digit of, followed by
       - the number, followed by
       - the string is, followed by
       	 - if the number is greater than 5: the string and is greater than 5
     	 - if the number is 0: the string and is 0
     	 - if the number is less than 6 and not 0: the string and is less than 6 and not 0
     - followed by a new line

- [2-print_alphabet](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x01-csharp-ifelse_loops_methods/2-print_alphabet)
  - Write a program that prints the alphabet, in lowercase, not followed by a new line.
    - You can only use Console.Write once
    - You can only use one loop in your code

- [3-print_alphabt](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x01-csharp-ifelse_loops_methods/3-print_alphabt)
  - Write a program that prints the alphabet, in lowercase, not followed by a new line.
    - Print all the letters except q and e
    - You can only use Console.Write once
    - You can only use one loop in your code

- [4-print_hexa](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x01-csharp-ifelse_loops_methods/4-print_hexa)
  - Write a program that prints all numbers from 0 to 98 in decimal and in hexadecimal (as in the following example)
    - You can only use Console.Write once
    - You can only use one loop in your code

- [5-print_comb](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x01-csharp-ifelse_loops_methods/5-print_comb)
  - Write a program that prints numbers from 0 to 99.
    - Numbers must be separated by ",", followed by a space
    - Numbers should be printed in ascending order, with two digits
    - The last number should be followed by a new line
    - You can only use Console.Write no more than twice
    - You can only use one loop in your code

- [6-print_comb2](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x01-csharp-ifelse_loops_methods/6-print_comb2)
  - Write a program that prints all possible different combinations of two digits.
    - Numbers must be separated by ,, followed by a space
    - The two digits must be different
    - 01 and 10 are considered the same combination of the two digits 0 and 1
    - Print only the smallest combination of two digits
    - Numbers should be printed in ascending order, with two digits
    - The last number should be followed by a new line
    - You can only use Console.Write and Console.WriteLine no more than three times total
    - You can only use no more than 2 loops in your code

- [7-islower](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x01-csharp-ifelse_loops_methods/7-islower)
  - Write a method that checks for lowercase character.
    - Class Name: class Character
    - Prototype: public static bool IsLower(char c)
    - Returns True if c is lowercase
    - Returns False otherwise
    - You are not allowed to use Char.IsLower() or Char.IsUpper()
  
- [8-print_last_digit](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x01-csharp-ifelse_loops_methods/8-print_last_digit)
  - Write a method that prints the last digit of a number.
    - Class Name: class Number
    - Prototype: public static int PrintLastDigit(int number)
    - Returns the value of the last digit

- [9-add](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x01-csharp-ifelse_loops_methods/9-add)
  - Write a method that adds two integers and returns the result.
    - Class Name: class Number
    - Prototype: public static int Add(int a, int b)
    - Returns the value of a + b

- [10-print_line](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x01-csharp-ifelse_loops_methods/10-print_line)
  - Write a method that draws a straight line in the terminal.
    - Class Name: class Line
    - Prototype: public static void PrintLine(int length)
    - Where length is the number of times the character _ should be printed
    - The line should end with a new line
    - If length is 0 or less, the function should only print a new line

- [11-print_diagonal](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x01-csharp-ifelse_loops_methods/11-print_diagonal)
  - Write a method that draws a diagonal line in the terminal.
    - Class Name: class Line
    - Prototype: public static void PrintDiagonal(int length)
    - Where length is the number of times the character \ should be printed
    - The line should end with a new line
    - If length is 0 or less, the function should only print a new line

- [12-fizzbuzz](https://github.com/MitaliSengupta/holbertonschool-csharp/tree/master/0x01-csharp-ifelse_loops_methods/12-fizzbuzz)
  - Write a program that prints the numbers from 1 to 100 separated by a space.
    - For multiples of three print Fizz instead of the number and for multiples of five print Buzz.
    - For numbers which are multiples of both three and five print FizzBuzz.
    - Each element should be followed by a space
    - The last element should be followed by a new line