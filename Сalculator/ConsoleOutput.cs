namespace Calculator;

public class ConsoleOutput : IOutput
{
    public void Print(string text, float num)
    {
        Console.WriteLine(text + ' ' + num);
    }
}