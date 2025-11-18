namespace Greeter.Tests;

public class HelloWorldTests
{
    [Theory]
    [InlineData("shahad", "Hej", "shahad,Hej")]
    [InlineData("shahad", "Hello", "shahad,Hello")]
    [InlineData("shahad", "Hola", "shahad,Hola")]
    public void GetGreetingReturHelloWorld( string name, string language ,string expected)
    {
        //Arrnge 




       
            //string expected = "shahad,Hola";


        //Act 

        string actual = Program.GetGreeting(name, language);

        //Assert 

        Assert.Equal(expected,actual);

    }
}
