namespace Greeter.Tests;

public class HelloWorlsTests
{
    [Fact]
    public void GetGreetingReturHelloWorld()
    {
        //Arrnge 

       
            string expected = "Hello,World";


        //Act 

        string actual = Program.GetGreeting();

        //Assert 

        Assert.Equal(expected,actual);

    }
}
