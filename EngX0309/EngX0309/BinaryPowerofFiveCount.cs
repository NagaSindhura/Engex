using System;
using System.Text.RegularExpressions;
public class BinaryPowerofFiveCount
{
    private static readonly string _pattern = @"101";
    public static void Main()
    {
        Console.WriteLine("Please enter your input:");
        var input = Console.ReadLine();

        Console.Write("Matched Pattern Count : {0}", PowerofFiveCount(input));
        Console.ReadKey();
    }

    public static int PowerofFiveCount(string input)
    {
        var regexp = new Regex(_pattern, RegexOptions.IgnoreCase);

        var matchedCollection = regexp.Matches(input);
        var matchCount = matchedCollection.Count;

        return matchCount == 0 ? -1 : matchCount;
    }
}