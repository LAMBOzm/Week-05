﻿using System;
public class TryCatch
{
    static void Main(string[] args)
    {
        int a = 0;
        try
        {
            Console.WriteLine(100 / a);
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.ReadKey();
    }
}