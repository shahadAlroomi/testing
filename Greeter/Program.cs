
namespace Greeter;
using System;
public class Program
{
    public static void Main()
    {

        Console.WriteLine(GetGreeting());
    }
    //const string EnglishGreeting ="Hello";

    public static string GetGreeting(string name ="World!")
    {
        return $"Hello,{name}";
    }


    public static string GetGreeting(string name, string language)

    {

        return language.ToLower() switch
        {
            "spanish"=>$"Hola,{name}!",
            "french"=>$"Bonjour,{name}!",
             _=> GetGreeting(name)


        };
    }
}