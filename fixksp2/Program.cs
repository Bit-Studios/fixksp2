using Microsoft.Win32;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Registry.CurrentUser.DeleteSubKeyTree(@"SOFTWARE\Intercept Games\Kerbal Space Program 2");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
        Console.WriteLine("you can now run ksp2 again");
        Console.ReadLine();
    }
}