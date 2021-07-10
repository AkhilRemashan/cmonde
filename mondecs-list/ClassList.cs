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



