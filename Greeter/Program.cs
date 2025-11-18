
namespace Greeter;
public class Program
{
    public static void Main()
    {
        
    }
    const string EnglishGreeting ="Hello";
    const string SpanishGreeting ="Hola";
    const string SwedishGreeting ="Hej";


   
    
   
    public static string GetGreeting(string name ,string language)
    {
        return name + "," + language;
    }
}