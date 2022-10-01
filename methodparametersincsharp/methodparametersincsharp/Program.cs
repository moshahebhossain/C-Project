// C# program to illustrate the 
// concept of the named parameters
using System;

public class GFG
{

    // addstr contain three parameters
    public static void addstr(string s1, string s2, string s3)
    {
        string result = s1 + s2 + s3;
        Console.WriteLine("Final string is: " + result);
    }

    // Main Method
    static public void Main()
    {
        // calling the static method with named 
        // parameters without any order
        addstr(s1: "Geeks", s2: "for", s3: "Geeks");

    }
}