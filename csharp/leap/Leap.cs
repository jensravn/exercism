using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        switch (year)
        {
            case var _ when year % 400 == 0:
                return true;
            case var _ when year % 100 == 0:
                return false;
            case var _ when year % 4 == 0:
                return true;
            default:
                return false;
        }
    }
}