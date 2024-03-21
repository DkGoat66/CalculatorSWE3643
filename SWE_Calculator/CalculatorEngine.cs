namespace SWE_Calculator;

public class CalculatorEngine
{
    public float AddTwoNumbers(float float1, float float2)
    {
        return
            float1 + float2;
    }

    public float SubtractTwoNumber(float float1, float float2)
    {
        return float1 - float2;
    }

    public float MultiplyTwoFloatNumbers(float float1, float float2)
    {
        return float1 * float2;
    }

    public float DivideTwoNumbers(float float1, float float2)
    {
        if (float2 == 0)
        {
            return -1;
        }
        return float1 / float2;
    }

    public bool CompareTwoNumbers(float float1, float float2)
    {
        return float1 == float2;
    }

    public double PowerFunction(float float1, float float2)
    {
        return Math.Pow(float1, float2);
    }

    //It is possible to have the factorial of a decimal so that case is captured in this recursive method
    //to calculate the factorial of a floating point number
    public double FactorialOfFloat(float float1)
    {
        if (float1 >= 0 && float1 <= 1)
        {
            return 1;
        }
        return float1 * FactorialOfFloat(float1 - 1);
    }

    public double SinOfFloat(float float1)
    {
        return Math.Sin(float1);
    }

    public double CosOfFloat(float float1)
    {
        return Math.Cos(float1);
    }

    public double TanOfFloat(float float1)
    {
        return Math.Tan(float1);
    }

    public double InverseOfFloat(float float1)
    {
        return (1 / float1);
    }

    public double LogOfTwoFloats(float float1, float float2)
    {
        return Math.Log(float1, float2);
    }

    //changes
    public double RootOfTwoFloats(float float1, float float2)
    {
        return Math.Sqrt(float1);
    }
}