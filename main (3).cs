/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
using System;

class HelloWorld
{
	static void Main()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		for (int i = 1; i <= n; i++)
		{
			for (int j = 1; j <= i; j++)
			{
				Console.Write(j);
			}

			Console.WriteLine();
		}
	}
}