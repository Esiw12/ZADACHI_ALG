using System;

public class Program {
    public static void Main() {
		int chet = 0;
        Console.Write("Введите первое число: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Выберите действие:1.Сложить.2.Вычесть.3.Умножить.4.Разделить.5.Остаток");
		int action = Convert.ToInt32(Console.ReadLine());
		double result = 0;
		if(action == 1)
		{
			result = number1 + number2;
			
		}
		if(action == 2)
		{
			result = number1 - number2;
			
		}
		if(action == 3)
		{
			result = number1 * number2;
		}
		if(action == 4)
		{
			if(number2 == 0)
			{
				chet++;
				Console.WriteLine("Делить на ноль нельзя...");
				
			}
			else
			{
				result = number1 / number2;
			}
		
		}
		if(action == 5)
		{
			result = number1 % number2;
		}
		if(chet == 1)
		{
			Console.WriteLine();
		}
		else
		{
		
		Console.Write(result);
		}
		
		
		
		
    }
}
