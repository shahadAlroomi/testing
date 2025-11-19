namespace Greeter.Tests;
using Greeter;
using Xunit;

public class HelloWorldTests
{
    [Fact]
    public void GetGreeting_Retrun_H()
    {
        //Arrnge 

        string expected = "Hello,World!";



        //Act 

        string actual = Program.GetGreeting();

        //Assert 

        Assert.Equal(expected,actual);

        
    }
    [Theory]
    [InlineData("spanish", "Hola,shahad!")]
    [InlineData("french", "Bonjour,shahad!")]
    

    public void GetGreetingReturHelloWorld(string language , string expected)
    {
       

        //Act 

        string actual = Program.GetGreeting("shahad", language);

        //Assert 

        Assert.Equal(expected,actual);

    }
}
