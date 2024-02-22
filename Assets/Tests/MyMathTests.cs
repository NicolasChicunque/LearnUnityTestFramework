using MyExercise_1;
using NUnit.Framework;

public class MyMathTests
{    
    [Test]// A Test behaves as an ordinary method
    public void AddsTwoPositiveIntegers()// Use the Assert class to test conditions
    {        
        Assert.AreEqual(MyMath.Add(5, 5), 10);
    }

    [Test]
    public void SubstractTwoPositiveIntegers()
    {
        Assert.AreEqual(MyMath.Subtract(5, 3), 2);
    }
}
