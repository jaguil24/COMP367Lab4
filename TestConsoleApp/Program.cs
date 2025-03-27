using System;
using StringExtensions;

class Program
{
    static void Main(string[] args)
    {
        // Test 1: String starting with an uppercase letter
        string testString1 = "Hello";
        Console.WriteLine($"Does '{testString1}' start with uppercase? {testString1.StartsWithUpperCase()}");  // Expected: True

        // Test 2: String starting with a lowercase letter
        string testString2 = "hello";
        Console.WriteLine($"Does '{testString2}' start with uppercase? {testString2.StartsWithUpperCase()}");  // Expected: False

        // Test 3: Empty string
        string testString3 = "";
        Console.WriteLine($"Does '{testString3}' start with uppercase? {testString3.StartsWithUpperCase()}");  // Expected: False

        // Test 4: Null string
        string testString4 = null;
        Console.WriteLine($"Does '{testString4}' start with uppercase? {testString4.StartsWithUpperCase()}");  // Expected: False
    }
}
