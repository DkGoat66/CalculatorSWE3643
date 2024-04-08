using Calculator_App;


namespace CalculatorTestProject1;

public class UnitTest2
{
    [Test]
    public void SubtractTwoNumbers()
    {
        // Arrange
        var calculator = new CalculatorEngine(); 
        float number1 = 5.5f;
        float number2 = 3.0f;
        float expectedDifference = 2.5f;

        // Act
        float result = calculator.SubtractTwoNumber(number1, number2);

        // Assert
        Assert.That(expectedDifference, Is.EqualTo(result),  "The difference between the two numbers does not match the expected value.");
    }
} 