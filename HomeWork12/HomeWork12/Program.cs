using System;
using System.ComponentModel.DataAnnotations;

int parameter = 11;

Console.WriteLine(Recursion.Fibonacci(parameter));

static class Recursion
{
	public static int Fibonacci(int parameter)
	{
		int index = parameter - 1;

		if (index == 1)
			return 1;
		if (index == 0)
			return 0;

		int Fn1 = Fibonacci(index);
		int Fn2 = Fibonacci(index - 1);

		return Fn1 + Fn2;
	}

	#region
	//public static int FibonacciStartWith0(int parameter)
	//{
	//	if (parameter == 1)
	//		return 1;
	//	if (parameter == 0)
	//		return 0;

	//	int Fn1 = FibonacciStartWith0(parameter - 1);
	//	int Fn2 = FibonacciStartWith0(parameter - 2);

	//	return Fn1 + Fn2;
	//}

	//public static int Factorial(int number)
	//{
	//	if (number == 0)
	//		return 1;
	//	else if (number == 1)
	//		return 1;

	//	return number * Factorial(number - 1);
	//}

	//public static int SumOfN(int number, int temp = 0)
	//{
	//	temp = number % 10;

	//	if (number == 0)
	//		return 0;

	//	return temp + SumOfN(number / 10);
	//}

	//public static int Power(int number, int power)
	//{
	//	if (power < 1)
	//		return 1;

	//	return number * Power(number, power - 1);
	//}

	//public static bool Palindrome(string str, int i = 0)
	//{
	//	str = str.ToLower();

	//	if (str.Length == 1 || str == "")
	//		return true;

	//	if (str[i] != str[str.Length - 1])
	//		return false;

	//	str = str.Substring(i + 1, str.Length - 2);

	//	return Palindrome(str);
	//}

	//public static int[] PrintReverseNum(int startNumber, int[] reverseNumbers, int i = 0)
	//{
	//	reverseNumbers[i] = startNumber;

	//	if (startNumber == 1)
	//		return reverseNumbers;

	//	return PrintReverseNum(startNumber - 1, reverseNumbers, i + 1);
	//}

	//public static int FindGCD(int firstNumber, int secondNumber)
	//{
	//	if (secondNumber == 0)
	//		return firstNumber;

	//	return FindGCD(secondNumber, firstNumber % secondNumber);
	//}
	#endregion
}