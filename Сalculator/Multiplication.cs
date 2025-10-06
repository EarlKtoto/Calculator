namespace Calculator;

public class Multiplication : IOperation
{
    public float Calculate(float num1, float num2)
    {
        return num1 * num2;
    }
}