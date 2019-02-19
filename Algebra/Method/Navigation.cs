using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algebra.Model;

namespace Algebra.Method
{
	class Navigation
	{
		// Changes the foreground and background color of text so that it appears highlighted, prints it and then resets the color and returns the cursor to position it just printed
		public void HighlightOption(string Name)
		{
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.White;

			Console.WriteLine(Name);
			Console.ResetColor();
			Console.CursorTop -= 1;
		}


		// Writes the menu with the current option highlighted
		public void WriteMenu(List<Option> Menu, int CurrentOption)
		{
			foreach (Option Option in Menu)
			{
				Console.WriteLine(Option.Name);
			}
			Console.SetCursorPosition(0, Console.CursorTop - Menu.Count());
			HighlightOption(Menu[CurrentOption].Name);

		}

		
		// "Goes down" in the menu, that is increments CurrentOption, writes the the option that the cursor was before normal (without highlight), 
		// then writes the next option highlighted (takes into account going from last to first menu option) 
		public int GoDown(List<Option> Menu, int CurrentOption)
		{
			CurrentOption++;
			Console.WriteLine(Menu[CurrentOption - 1].Name);
			

			if (CurrentOption == Menu.Count())
			{
				Console.CursorTop -= Menu.Count();
				CurrentOption -= Menu.Count();
			}
			HighlightOption(Menu[CurrentOption].Name);

			return CurrentOption;
		}


		// "Goes up" in the menu, that is updates and returnes the CurrentOption (takes into account going from first to last menu option) 
		public int GoUp(List<Option> Menu, int CurrentOption)
		{
			if (CurrentOption == 0)
			{
				Console.WriteLine(Menu[CurrentOption].Name);
				CurrentOption = Menu.Count() - 1;
				Console.CursorTop += Menu.Count() - 2;

				HighlightOption(Menu[CurrentOption].Name);				
			}
			else
			{
				CurrentOption--;

				Console.WriteLine(Menu[CurrentOption + 1].Name);
				Console.CursorTop -= 2;
				HighlightOption(Menu[CurrentOption].Name);


			}

			return CurrentOption;
		}
	}
}
