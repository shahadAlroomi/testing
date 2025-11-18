

public class Program
{
    public static void Main()
    {
        
    }
    const string EnglishGreeting ="Hello,";
    
    public static string GetGreeting(string name)
    {
        if(string.IsNullOrWhiteSpace(name)) return "Hello,World";
        return EnglishGreeting + name + "!";
    }
}