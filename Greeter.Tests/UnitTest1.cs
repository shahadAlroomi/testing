namespace Greeter.Tests;
using Greeter;
using Xunit;

public class HelloWorldTests
{
    /*[Theory]
    [InlineData("shahad", "Hej", "shahad,Hej")]
    [InlineData("shahad", "Hello", "shahad,Hello")]
    [InlineData("shahad", "Hola", "shahad,Hola")]
    [InlineData("shahad", "Bonjour", "shahad,Bonjour")]*/
    [Fact]

    public void GetGreetingReturHelloWorld()
    {
        //Arrnge 




       
            string name = "shahad" ;
        string language = "Bonjour" ;
        string expected = name + "," + language ;



        //Act 

        string actual = Program.GetGreeting(name, language);

        //Assert 

        Assert.Equal(expected,actual);

    }
}
