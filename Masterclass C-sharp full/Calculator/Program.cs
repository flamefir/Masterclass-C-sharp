namespace Calculator
{
	enum Action : int
	{
		add = 1,
		sub = 2,
		mult = 3,
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello");
			Console.WriteLine("Input the first number:");
			var firstNumber = int.Parse(Console.ReadLine()!);

			Console.WriteLine("Input the second number:");
			var secondNumber = int.Parse(Console.ReadLine()!);

			Console.WriteLine("What do you want to do with those numbers?\r\n	1 -> Add\r\n	2 -> Subtract\r\n	3 -> Multiply\r\n");
			var action = int.Parse(Console.ReadLine()!);

			switch (action)
			{
				case (int)Action.add:
					Console.WriteLine(firstNumber + secondNumber);
					break;
				case (int)Action.sub:
					Console.WriteLine((firstNumber > 0 && secondNumber < 0)? secondNumber + firstNumber : firstNumber - secondNumber);
					break;
				case (int)Action.mult:
					Console.WriteLine(firstNumber * secondNumber);
					break;
				default:
					Console.WriteLine("Invalid calculator action taken.");
					break;
			}
			Console.WriteLine("Press any key to close");
			Console.ReadKey();
		}

		public int CalculateSubtraction(int firstNumber, int secondNumber)
		{
			if (firstNumber > 0 && secondNumber < 0)
			{
				return secondNumber - firstNumber;
			}
			return firstNumber - secondNumber;
		}
	}
}
