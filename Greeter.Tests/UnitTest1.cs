namespace Greeter.Tests;

public class HelloWorlsTests
{
    [Fact]
    public void GetGreetingReturHelloWorld()
    {
        //Arrnge 
        
        string expected= "Hello,Shahad!";

        //Act 

        string actual = Program.GetGreeting("Shahad");

        //Assert 

        Assert.Equal(expected,actual);

    }
}
