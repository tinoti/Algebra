using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algebra.Model;
using Algebra.Method;
using Algebra.Exercises.Exercise4;

namespace Algebra.Method
{

	class Initialize
	{
		// Takes a CSV file path and reads from it, creates an object for every value in CSV file and returns created objects in a list
		public List<Option> FillWithObjects (string FullPath)
		{
			string line;
			List<Option> ListOfMenuOptions = new List<Option>();		
			
			System.IO.StreamReader file = new System.IO.StreamReader(FullPath);

			while((line = file.ReadLine()) != null )
			{
				string[] name = line.Split(',');
				
				ListOfMenuOptions.Add(new Option(name[0]));
				
			}
			return ListOfMenuOptions;
		}


		public void Menu(List<Option> Meni, int CurrentOption)
		{
			Navigation Navigation = new Navigation();
			while (true)
			{
				Console.Clear();
				Navigation.WriteMenu(Meni, CurrentOption);
				System.ConsoleKeyInfo key = Console.ReadKey();

				if (key.Key == ConsoleKey.DownArrow)
				{
					CurrentOption = Navigation.GoDown(Meni, CurrentOption);
				}
				else if (key.Key == ConsoleKey.UpArrow)
				{
					CurrentOption = Navigation.GoUp(Meni, CurrentOption);
				}
				else if (key.Key == ConsoleKey.Enter)
				{
					if(Meni[CurrentOption].NoSubMenu == true)
					{
						Exercise(Meni[CurrentOption].Exercises, CurrentOption);
						continue;
					}
					Menu(Meni[CurrentOption].SubMenu, CurrentOption);
				}
			}
		}

		public void Exercise(List<Exercise> Exercise, int CurrentOption)
		{
			Exercise[CurrentOption].Method();
		}

		public void PopulateExercises()
		{
			List<Exercise> Exercises = new List<Exercise>();
			Exercise4 exercise4 = new Exercise4();
			Exercise Exercise = new Exercise();
			Exercise.Method = exercise4.HelloWorld;
			Exercises.Add();
		}

		
	}
}
