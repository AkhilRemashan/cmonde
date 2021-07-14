using System;

public class Hello
{
	public Hello()
	{
		Console.WriteLine("hey, there!");

		Console.ReadLine();

	}
}

public class DrawShape
{
	public DrawShape()
	{
		Console.WriteLine("   /|");
		Console.WriteLine("  / |");
		Console.WriteLine(" /  |");
		Console.WriteLine("/___|");

		Console.ReadLine();

	}
}

public class Variable1
{
	public Variable1()
	{
		string characterName = "Joseph";
		int characterAge;
		characterAge = 70;

		Console.WriteLine("There once was a man named " + characterName);
		Console.WriteLine("He was " + characterAge + " years old");
		Console.WriteLine("He really liked the name " + characterName);
		Console.WriteLine("But didnt like being " + characterAge);

		Console.ReadLine();

	}
}

public class Variable2
{
	public Variable2()
	{
		string tuitionName = "CS Noob";
		char maxGrade = 'A'; // Single character only, used in sigle quotes

		int maxStrength = 18;
		float minScore = 2.0F; // Least accurate for decimals, suffix F
		double maxScore = 5.0; // Medium accurate for decimals
		decimal feesPaid = 600.25M; // Most accurate for decimals, suffix M

		bool isCompleted = false;

	}
}

public class UserInput
{
	public UserInput()
	{
		Console.Write("Please enter your name: ");
		string name = Console.ReadLine();

		Console.Write("Enter your age: ");
		string age = Console.ReadLine();

		Console.WriteLine("Hello " + name + " you're " + age + " years old ;)");

		Console.ReadLine();

	}
}

public class SimpleCalculator
{
	public SimpleCalculator()
	{

		// Integer addition

		Console.Write("Enter a number: ");
		int num1 = Convert.ToInt32(Console.ReadLine());

		Console.Write("Enter another number: ");
		int num2 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine(num1 + num2);

		Console.ReadLine();

		// Addition to accomodate doubles

		Console.Write("Enter a number: ");
		double num1 = Convert.ToDouble(Console.ReadLine());

		Console.Write("Enter another number: ");
		double num2 = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine(num1 + num2);

		Console.ReadLine();

	}
}

public class Madlib
{
	public Madlib()
	{
		string color, pluralNoun, celebrity;

		Console.Write("Enter a color: ");
		color = Console.ReadLine();

		Console.Write("Enter a plural noun: ");
		pluralNoun = Console.ReadLine();

		Console.Write("Enter a celebrity  name: ");
		celebrity = Console.ReadLine();

		Console.WriteLine("Roses are " + color);
		Console.WriteLine(pluralNoun + " are blue");
		Console.WriteLine("I love " + celebrity);

		Console.ReadLine();

	}
}

public class Array
{
	public Array()
	{
		// Integer array

		int[] luckyNumbers = { 12, 15, 26, 358, 555 };
		Console.WriteLine(luckyNumbers[3]);

		// String array : method 1

		string[] euroSemi = { "England", "Italia", "Denmark", "Belgium" };
		Console.WriteLine(euroSemi[0]);

		// String array : method 2 // define string, and number of values it can accomodate

		string[] euroFinal = new string[2];
		euroFinal[0] = "England";
		euroFinal[1] = "Italia";
		Console.WriteLine(euroFinal[1]);


		Console.ReadLine();

	}
}

public class MethodsCS
{
	public MethodsCS()
	{

		static void Main(string[] args)
		{

			SayHi();

			SayThings("Akhil", 28);
			SayThings("Oliver", 35);

			Console.ReadLine();

		}

		// Simple method
		static void SayHi()
		{
			Console.WriteLine("Hello, there");
		}

		// Method passing parameters

		static void SayThings(string name, int age)
		{
			Console.WriteLine("Hello " + name + " you are " + age + "!!");
		}

	}
}

public class ReturnMethod
{
	public ReturnMethod()
	{

		static void Main(String[] args)
		{
			CubeNum(25);

			Console.ReadLine();
		}

		// Return statement - an Integer

		static int CubeNum(int num)
		{
			int result = num * num * num;
			return result;
		}

	}
}

public class IfElseCondition1
{
	public IfElseCondition1()
	{

		static void Main(String[] args)
		{
			bool isMale = true;
			bool isTall = true;

			if (isMale & isTall)
			{
				Console.WriteLine("You're a tall male");
			}
			else if (isMale && !isTall)
			{
				Console.WriteLine("You're a short male");
			}
			else if (!isMale & isTall)
			{
				Console.WriteLine("You're now a male, but you are tall");
			}
			else
			{
				Console.WriteLine("You're not male, and not tall");
			}

			Console.ReadLine();
		}

	}
}

public class IfElseCondition1
{
	public IfElseCondition1()
	{

		static void Main(String[] args)
		{
			bool isMale = true;
			bool isTall = true;

			if (isMale & isTall)
			{
				Console.WriteLine("You're a tall male");
			}
			else if (isMale && !isTall)
			{
				Console.WriteLine("You're a short male");
			}
			else if (!isMale & isTall)
			{
				Console.WriteLine("You're now a male, but you are tall");
			}
			else
			{
				Console.WriteLine("You're not male, and not tall");
			}

			Console.ReadLine();
		}

	}
}

public class IfElseCondition2
{
	public IfElseCondition2()
	{

		static void Main(String[] args)
		{
			Console.Write("Enter a number: ");
			double num1 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Enter operator: ");
			string opr = Console.ReadLine();

			Console.Write("Enter a number: ");
			double num2 = Convert.ToDouble(Console.ReadLine());

			if (opr == "+")
			{
				Console.WriteLine(num1 + num2);
			}
			else if (opr == "-")
			{
				Console.WriteLine(num1 - num2);
			}
			else if (opr == "/")
			{
				Console.WriteLine(num1 / num2);
			}
			else if (opr == "*")
			{
				Console.WriteLine(num1 * num2);
			}
			else if (opr == "%")
			{
				Console.WriteLine(num1 % num2);
			}
			else
			{
				Console.WriteLine("Invalid operator");
			}
		}

	}
}

public class IfElseCondition1
{
	public IfElseCondition1()
	{

		static void Main(string[] args)
		{
			Console.WriteLine(GetDay(1));

			Console.ReadLine();
		}

		static string GetDay(int dayNum)
		{
			string dayName;

			switch (dayNum)
			{
				case 0:
					dayName = "Sunday";
					break;
				case 1:
					dayName = "Monday";
					break;
				case 2:
					dayName = "Tuesday";
					break;
				case 3:
					dayName = "Wednesday";
					break;
				case 4:
					dayName = "Thursday";
					break;
				case 5:
					dayName = "Friday";
					break;
				case 6:
					dayName = "Saturday";
					break;
				default:
					dayName = "invalid day number";
					break;
			}


			return dayName;
		}

	}
}



