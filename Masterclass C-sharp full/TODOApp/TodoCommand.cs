using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ICommand = TODOApp.Interfaces.ICommand;

namespace TODOApp
{
	public enum Action
	{
		ListItems,
		AddItem,
		DeleteItem,
		Exit,
	}

	public class TodoCommand : ICommand
	{
		private Todo Todo;

		private Action Action;

		private string Text;

		public bool Success { get; set; }

        public TodoCommand(Todo todo, Action action, string? text)
        {
            Todo = todo ?? throw new ArgumentNullException(nameof(todo)); 
			Action = action;
			Text = text;
		}


		public void Call()
		{
			switch (Action)
			{
				case Action.ListItems:
					Console.WriteLine(Todo.ToString());
					break;
				case Action.AddItem:
					Success = Todo.AddTodo(Text);
					if (Success)
					{
						Console.WriteLine($"TODO successfully added: {Text}");
					}
					break;
				case Action.DeleteItem:
					Success = Todo.RemoveTodo(Text);
					if (Success)
					{
						Console.WriteLine($"TODO successfully removed: {Text}");
					}
					break;
				case Action.Exit:
					
					break;
				default:
					break;
			}
		}

		public void Undo()
		{
			if (!Success)
			{
				return;
			}

			switch (Action)
			{
				case Action.AddItem:
					break;
				case Action.DeleteItem:
					break;
				default:
					break;
			}
		}
	}
}
