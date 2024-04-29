using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TODOApp
{
	public class Todo
	{
		public List<string> TodosList = new List<string>();


		public bool AddTodo(string text)
		{
			if (string.IsNullOrEmpty(text))
			{
				Console.WriteLine("The description cannot be empty.");
				return false;
			}

			if (TodosList.Contains(text))
			{
				Console.WriteLine("The description must be unique.");
				return false;
			}
			TodosList.Add(text);
			return true;
		}

		public bool RemoveTodo(string textIndex)
		{
			int index = 0;
			if(int.TryParse(textIndex, out var result))
			{
				index = result;
			}
			else
			{
				Console.WriteLine("The given index is not valid.");
				return false;
			}

			if (index <= 0)
			{
				Console.WriteLine("Selected index cannot be empty.");
				return false;
			}

			TodosList.RemoveAt(index - 1);
			return true;
		}

		public override string? ToString()
		{
			if (TodosList.Count == 0)
			{
				return "No TODOs have been added yet.";
			}

			StringBuilder sb = new StringBuilder();
			foreach (string todo in TodosList)
			{
				var index = TodosList.FindIndex(list => list.Contains(todo));

				sb.AppendLine($"{index + 1}. {todo}");
			}

			return sb.ToString();
		}
	}
}
