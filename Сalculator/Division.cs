namespace Calculator;

public class Division : IDivision
{
    public float Calculate(float num1, float num2)
    {
        if (num2 == 0) throw new DivideByZeroException();
        return num1 / num2;
    }
}