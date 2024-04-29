using System;
using System.Text;

namespace TODOApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Todo todo = new Todo();

			bool exitFlag = false;
			do
			{
				Console.WriteLine(UserInterface());
				var UserInput = Console.ReadLine();

				var commands = new List<TodoCommand>();

				switch (UserInput)
				{
					case "s":
					case "S":
						commands.Add(new TodoCommand(todo, Action.ListItems, null));
						break;
					case "a":
					case "A":
						Console.WriteLine("Enter the TODO description:");
						var todoItem = Console.ReadLine();
						commands.Add(new TodoCommand(todo, Action.AddItem, todoItem));
						break;
					case "r":
					case "R":
						Console.WriteLine("Select the index of the TODO you want to remove:");
						commands.Add(new TodoCommand(todo, Action.ListItems, null));
						var todoIndex = Console.ReadLine();
						commands.Add(new TodoCommand(todo, Action.DeleteItem, todoIndex));
						break;
					case "e":
					case "E":
						exitFlag = true;
						break;
					default:
						Console.WriteLine("Incorrect input");
						break;
				}
				foreach (var cmd in commands)
				{
					cmd.Call();
				}
			}
			while (!exitFlag);
		}

		public static string UserInterface()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("\n[S]ee all TODOs");
			sb.AppendLine("[A]dd a TODO");
			sb.AppendLine("[R]emove a TODO");
			sb.AppendLine("[E]xit\n");
			return sb.ToString();
		}
	}
}
