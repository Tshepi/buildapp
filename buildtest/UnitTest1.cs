namespace buildtest;
using buildapp.Modules;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

    }

    [Fact]
    public void AddTest()
    {
        Functions functions = new Functions();
        int result = functions.Add(3, 2);
        bool outcome = false;

        if (result == 5) outcome = true;
        Assert.True(outcome, "The value should be 5");
    }
}