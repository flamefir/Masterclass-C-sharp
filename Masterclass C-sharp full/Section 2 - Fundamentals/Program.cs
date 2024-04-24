namespace Section_2___Fundamentals
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello");
			//Console.WriteLine("[S]ee all TODOs");
			//Console.WriteLine("[A]dd a TODO");
			//Console.WriteLine("[R]emove a TODO");
			//Console.WriteLine("[E]xit");

			//string userInput = "A";
			//Console.WriteLine(userInput);

			//userInput = "AB";
			//Console.WriteLine(userInput);

			// DLL = Dynamic Link Library
			// Source code -> Compiler -> DLL

			int foo; // Declaration
			foo = 42; // Initialization
			int bar = 43; // Initialization at declaration

			int number = 2; // explicitly typed variables
			var num = 2; // implicitly typed variables

			var k = number + num; // Shift + F9 = quickwatch
			//Console.WriteLine(number);

			var isSmallerThanFoo = foo < 100 || (bar * 5) < 100; // As the first condition is met, "(bar * 5) < 100" wont be compiled, this is Short-Circuit

			//Console.WriteLine("C# is a statically-typed language, unlike python which is dynamically-typed language");
			//Console.WriteLine("Therefore " +
			//"\n var word = \"abc\" " +
			//"\n word = 5 " +
			//"\n is dynamically typed and cannot be used in c#");

			// Exercise
			//var sum = CalculateSumOfNumbersBetween(5, 10);

			// Exercise
			//var repeatedChar1 = RepeatCharacter('A', 4);
			//var repeatedChar2 = RepeatCharacter('!', -1);

			// Exercise
			//var factNumber = Factorial(5);

			// Exercise
			//string[] collection = { "one", "two", "three" };
			//var isTrue = IsWordPresentInCollection(collection, "two");

			// Exercise
			int[,] numbers = 
				{	{ 1, 2, 3, 4, 5, 12},
					{ 1, 2, 3, 4, 5, 7},
				};
			var max = FindMax(numbers);

			Console.ReadKey();
		}


		public static int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
		{
			if (lastNumber < firstNumber)
			{
				return 0;
			}

			var sum = 0;
			while (firstNumber < (lastNumber + 1))
			{
				sum += firstNumber;
				firstNumber += 1;
			}

			return sum;
		}

		public static string RepeatCharacter(char character, int targetLength)
		{
			var result = "";
			do
			{
				result += character;
			}
			while (2 <= targetLength && result.Length < targetLength); 

			return result;
		}

		public static int Factorial(int number)
		{
			var result = 1;
			for (int i = 1; i <= number; i++)
			{
				result *= i;
			}
			
			return result;
		}

		public static bool IsWordPresentInCollection(string[] words, string wordToBeChecked)
		{
			for (int i = 0; i < words.Length; i++)
			{
				if (words[i] == wordToBeChecked)
				{
					return true;
				}
			}
			return false;		
			
			//return words.Contains(wordToBeChecked);
		}

		public static int FindMax(int[,] numbers)
		{
			var rows = numbers.GetLength(0);
			var cols = numbers.GetLength(1);

			if (rows <= 0 || cols <= 0)
			{
				return -1;
			}


			int biggestNumber = numbers[0,0];
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					if (numbers[i, j] > biggestNumber)
					{
						biggestNumber = numbers[i, j];
					}
				}
			}

			return biggestNumber;
		}

		public static bool IsAnyWordLongerThan(int length, string[] words)
		{
			foreach (string word in words)
			{
				if (word.Length > length)
				{
					return true;
				}
			}
			return false;
		}

		public List<string> GetOnlyUpperCaseWords(List<string> words)
		{
			var uppercaseList = new List<string>();

            foreach (var word in words)
            {
				if (word.All(character => char.IsUpper(character)) && !uppercaseList.Contains(word))
				{
					uppercaseList.Add(word);
				}
            }
			return uppercaseList;
        }
	}
}
