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
		// Highlights the selected option
		public void HighlightOption()
		{
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.White;
		}


		// Writes the menu with the current option highlighted
		public void WriteMenu(List<Option> Menu, int CurrentOption)
		{
			//Loops through menu objects and highlights the selected option, writes the other options normally
			for (int i = 0; i < Menu.Count(); i++)
			{
				if (CurrentOption == i)
				{
					HighlightOption();
					Console.WriteLine(Menu[i].Name);
					Console.ResetColor();
				}
				else
				{
					Console.WriteLine(Menu[i].Name);
				}
			}

		}

		
		// "Goes down" in the menu, that is updates and returnes the CurrentOption (takes into account going from last to first menu option) 
		public int GoDown(List<Option> Menu, int CurrentOption)
		{
			Console.Clear();
			// Increments the current option, then if CurrentOption is at max index resets it
			CurrentOption++;

			if (CurrentOption == Menu.Count())
			{
				CurrentOption = 0;
				WriteMenu(Menu, CurrentOption);
			}
			else
			{
				WriteMenu(Menu, CurrentOption);
			}

			return CurrentOption;
		}


		// "Goes up" in the menu, that is updates and returnes the CurrentOption (takes into account going from first to last menu option) 
		public int GoUp(List<Option> Menu, int CurrentOption)
		{
			Console.Clear();
			CurrentOption--;
			if (CurrentOption == -1)
			{
				CurrentOption = Menu.Count() - 1;
			}
			WriteMenu(Menu, CurrentOption);

			return CurrentOption;
		}


	}
}
