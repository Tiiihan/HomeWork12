using System;
using System.ComponentModel.DataAnnotations;

int parameter = 11;

Console.Write(Recursion.Fibonacci(parameter));

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
}