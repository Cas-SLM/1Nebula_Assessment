// See https://aka.ms/new-console-template for more information

namespace BackendCodeChallenge;

public class Question1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the BackendCode Challenge System!");
        Console.WriteLine(Likes(new List<string>()));
        Console.WriteLine(Likes(new List<string> { "Peter" }));
        Console.WriteLine(Likes(new List<string> { "Jacob", "Alex" }));
        Console.WriteLine(Likes(new List<string> { "Max", "John", "Mark" }));
        Console.WriteLine(Likes(new List<string> { "Alex", "Jacob", "Mark", "Max" }));
    }

    private static string Likes(List<string> names)
    {
        return names.Count switch
        {
            0 => "no one likes this",
            1 => $"{names[0]} likes this",
            2 => $"{names[0]} and {names[1]} like this",
            3 => $"{names[0]}, {names[1]} and {names[2]} like this",
            _ => $"{names[0]}, {names[1]} and {names.Count - 2} others like this"
        };
    }
}