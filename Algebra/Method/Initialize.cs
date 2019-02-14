﻿using System;
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


		public int Menu(List<Option> Meni, int CurrentOption)
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
					if(Meni[CurrentOption].Name == "Nazad")
					{
						return 0;
					}
					else if (Meni[CurrentOption].NoSubMenu == true)
					{
						ExecuteExercise(Meni[CurrentOption].Method, CurrentOption);
						continue;
					}
					else
					{
						Menu(Meni[CurrentOption].SubMenu, CurrentOption);
					}
					
				}
			}
		}

		public void ExecuteExercise(Action Exercise, int CurrentOption)
		{		

			Exercise();
		
		}







	}
}
