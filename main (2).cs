/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
	int[] mass = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write("Введите число: ");
    mass[i] = Convert.ToInt32(Console.ReadLine());
}

int max_num = mass[0];
int min_num = mass[0];

for (int i = 1; i < 5; i++)
{
    if (mass[i] > max_num)
    {
        max_num = mass[i];
    }
    if (mass[i] < min_num)
    {
        min_num = mass[i];
    }
}

Console.WriteLine("Максимальное число: " + max_num);
Console.WriteLine("Минимальное число: " + min_num);
	  
  }
}
