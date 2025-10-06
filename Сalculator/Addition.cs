namespace Calculator;

public class Addition : IOperation
{
    public float Calculate(float num1, float num2)
    {
        return num1 + num2;
    }
}