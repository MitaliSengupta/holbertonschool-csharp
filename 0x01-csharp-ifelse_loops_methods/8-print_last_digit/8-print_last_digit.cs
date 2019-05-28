using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        if (number < 0)
        {
            number = -1 * number;
        }
        number = number % 10;
        Console.Write(number);
        return (number);
    }
}