using System;

class Character
{
    public static bool IsLower(char c)
    {
        if ( c >= 97 && c <= 122)
        {
            return true;
        }
        else
            return false;
    }
}
