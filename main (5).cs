/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
   Console.WriteLine("Введите количество элементов массива");
	  int colvo = int.Parse(Console.ReadLine());
	  int[] mass = new int[colvo];
	  Console.WriteLine("Введите значения первого массива");
	  for(int i = 0; i < mass.Length; i++)
	  {
		 mass[i] = int.Parse(Console.ReadLine());
	  }
	  int[] mass1 = new int[colvo];
	  Console.WriteLine("введи значения второго массива");
	  for(int i = 0; i < mass1.Length; i++)
	  {
		 mass1[i] = int.Parse(Console.ReadLine());
	  }
	  int[] result = new int[colvo];
        for (int i = 0; i < colvo; i++)
        {
            result[i] = mass[i] * mass1[i];
        }

        Console.WriteLine("Результат: " + string.Join(" ", result));
	  
	  
  }
}
