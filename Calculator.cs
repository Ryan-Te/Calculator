using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	class Calculator
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Calculator");
			double Ans;
			string Op = "";

			while (Op != "+" && Op != "-" && Op != "*" && Op != "/")
			{
				Console.WriteLine("Please choose an operation from the following list: +, -, *, / ");
				Op = Console.ReadLine();
			}

			double num1 = double.PositiveInfinity;
			while (num1 == double.PositiveInfinity)
			{
				try
				{
					Console.WriteLine("Please choose first number");
					double number = double.Parse(Console.ReadLine());
					num1 = number;
				}
				catch
				{
					Console.WriteLine("That is not a number. Please try again");
				}
				
			}

			double num2 = double.PositiveInfinity;
			while (num2 == double.PositiveInfinity)
			{
				try
				{
					Console.WriteLine("Please choose second number");
					double number = double.Parse(Console.ReadLine());
					num2 = number;
				}
				catch
				{
					Console.WriteLine("That is not a number. Please try again");
				}
				if(Op == "+")
				{
					Ans = num1 + num2;
				}else
					if(Op == "-")
				{
					Ans = num1 - num2;
				}else
					if(Op == "*")
				{
					Ans = num1 * num2;
				}else
					if(Op == "/")
				{
					if (num2 == 0)
					{
						Console.WriteLine("ERROR! Divide by 0 01, Press any key to close");
						Console.ReadKey();
						return;
					}
					Ans = num1 / num2;
				}else
				{
					Console.WriteLine("ERROR! Incorrect Calculation Operator 00, Press any key to close");
					Console.ReadKey();
					return;
				}
				Console.WriteLine($"{num1} {Op} {num2} = {Ans}");
			}

			Console.WriteLine("Program finished. Press any key to close");
			Console.ReadKey();
		}
	}
}
