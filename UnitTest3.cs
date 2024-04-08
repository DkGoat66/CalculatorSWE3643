using Calculator_App;


namespace CalculatorTestProject1;

public class UnitTest3
{

    [Test]
    public void MultiplyTwoFloatNumbers_BothPositive_ReturnsPositive()
    {
        // Arrange
        var calculator = new CalculatorEngine();
        float num1 = 5f;
        float num2 = 10f;
        float expected = 50f;

        // Act
        float result = calculator.MultiplyTwoFloatNumbers(num1, num2);

        // Assert
        Assert.That(expected, Is.EqualTo(result), "Multiplying two positive numbers should return a positive result.");
    }
    [Test]
    public void MultiplyTwoFloatNumbers_OnePositiveOneNegative_ReturnsNegative()
    {
        // Arrange
        var calculator = new CalculatorEngine();
        float num1 = -5f;
        float num2 = 10f;
        float expected = -50f;

        // Act
        float result = calculator.MultiplyTwoFloatNumbers(num1, num2);

        // Assert
        Assert.That(expected, Is.EqualTo(result), "Multiplying a positive number by a negative number should return a negative result.");
    }

    [Test]
    public void MultiplyTwoFloatNumbers_BothNegative_ReturnsPositive()
    {
        // Arrange
        var calculator = new CalculatorEngine();
        float num1 = -5f;
        float num2 = -10f;
        float expected = 50f;

        // Act
        float result = calculator.MultiplyTwoFloatNumbers(num1, num2);

        // Assert
        Assert.That(expected, Is.EqualTo(result), "Multiplying two negative numbers should return a positive result.");
    }

    [Test]
    public void MultiplyTwoFloatNumbers_WithZero_ReturnsZero()
    {
        // Arrange
        var calculator = new CalculatorEngine();
        float num1 = 0f;
        float num2 = 10f;
        float expected = 0f;

        // Act
        float result = calculator.MultiplyTwoFloatNumbers(num1, num2);

        // Assert
        Assert.That(expected, Is.EqualTo(result), "Multiplying any number by zero should return zero.");
    }

}
