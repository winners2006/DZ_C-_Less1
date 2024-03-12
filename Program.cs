using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			if (args.Length == 3)
			{
				int result = 0;
				int num1 = int.Parse(args[0]);
				int num2 = int.Parse(args[2]);
				string sym = args[1];
				if (sym == "+")
					result = Amount(num1, num2);
				else if (sym == "-")
					result = Subtraction(num1, num2);
				else if (sym == "/")
					result = Division(num1, num2);
				else if (sym == "*")
					result = Multiplication(num1, num2);
				else Console.WriteLine("Введите корректный символ операции!");

				Console.WriteLine(Convert.ToString(result));
			}
		}
		static int Amount(int a, int b) { return a + b; }
		static int Subtraction(int a, int b) { return a - b; }
		static int Division(int a, int b) { return a / b; }
		static int Multiplication(int a, int b) { return a * b; }
	}
}
