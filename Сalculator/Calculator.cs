namespace Calculator;

public static class Calculator
{
    public static void Start()
    {
        ConsoleOutput consoleOutput = new ConsoleOutput();
        
        Addition addition = new Addition();
        Substraction substraction = new Substraction();
        Multiplication multiplication = new Multiplication();
        Division division = new Division();
        
        float num1, num2, result;
        char operation;
        int choice;
        bool isCompleted = false;
        try
        {
            do
            {
                Console.Write("Введите 1-е число (допускается вещественного типа): ");
                if (!float.TryParse(Console.ReadLine(), out num1)) throw new FormatException();
                Console.Write("Введите 2-е число (допускается вещественного типа): ");
                if (!float.TryParse(Console.ReadLine(), out num2)) throw new FormatException();
                Console.Write("Введите арифметическую операцию операцию: ");
                if (!char.TryParse(Console.ReadLine(), out operation)) throw new FormatException();

                result = operation switch
                {
                    '+' => addition.Calculate(num1, num2),
                    '-' => substraction.Calculate(num1, num2),
                    '*' => multiplication.Calculate(num1, num2),
                    '/' => division.Calculate(num1, num2),
                    _ => throw new Exception("Нет такой арифметической операции!")
                };
                
                consoleOutput.Print("Результат операции:", result);
                
                Console.WriteLine("Желаете продолжить?\n" +
                    "1) Да\n" +
                    "2) Нет");
                
                if (!int.TryParse(Console.ReadLine(), out choice)) throw new FormatException();

                isCompleted = choice switch
                {
                    1 => false,
                    2 => true,
                    _ => throw new Exception("Нет такого варианта ответа!")
                };
                
            } while (!isCompleted);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Error: Неправильный тип!");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Error: Делить на 0 нельзя!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}