using System;

public class Program
{
	public static void Main()
	{
		int[] prices = new int[20]; 
		for (int i = 0; i < prices.Length; i++)
		{
			Console.Write("Введите значение товара {0}: ", i + 1);
			prices[i] = Convert.ToInt32(Console.ReadLine());
		}

		int sum = 0;
		for (int i = 0; i < prices.Length; i++)
		{
			sum += prices[i];
		}

		double average = (double)sum / prices.Length;
		int count = 0;
		for (int i = 0; i < prices.Length; i++)
		{
			if (prices[i] < average)
			{
				count++;
			}
		}

		Console.WriteLine("Средняя стоимость всех товаров: {0}", average);
		Console.WriteLine("Количество товаров со стоимостью меньше средней: {0}", count);
	}
}