using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algebra.Model;
using Algebra.Method;
using Algebra.Exercises.ChapterFourOneExercises;


namespace Algebra.Method
{

	class Initialize
	{
		// Takes a CSV file path and reads from it, creates an object for every value in CSV file and returns created objects in a list
		public List<Option> FillWithMenuOptions (string FullPath)
		{
			string line;
			List<Option> ListOfMenuOptions = new List<Option>();		
			
			System.IO.StreamReader file = new System.IO.StreamReader(FullPath);

			while((line = file.ReadLine()) != null )
			{
				string[] name = line.Split(',');
				
				ListOfMenuOptions.Add(new Option(name[0]));
				
			}
			ListOfMenuOptions.Add(new Option("Nazad"));
			return ListOfMenuOptions;
		}


		public int Menu(List<Option> Meni, int CurrentOption)
		{
			Navigation Navigation = new Navigation();

			CurrentOption = 0;
			Console.Clear();
			Navigation.WriteMenu(Meni, CurrentOption);
			

			while (true)
			{
				
				System.ConsoleKeyInfo key = Console.ReadKey();
				Console.SetCursorPosition(0, Console.CursorTop);

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
					else if (Meni[CurrentOption].NoSubMenu == true || Meni[CurrentOption].Name == "Ponovi Zadatak")
					{
						ExecuteExercise(Meni[CurrentOption], CurrentOption);
						Console.Clear();
						foreach (Option Option in Meni)
						{
							Console.WriteLine(Option.Name);
						}
						Console.SetCursorPosition(0, 0);
						Navigation.HighlightOption(Meni[CurrentOption].Name);
						
					}
					else
					{
						Menu(Meni[CurrentOption].SubMenu, CurrentOption);
						Console.Clear();
						foreach (Option Option in Meni)
						{
							Console.WriteLine(Option.Name);
						}
						Console.SetCursorPosition(0, 0);
						Navigation.HighlightOption(Meni[CurrentOption].Name);
						
					}
					
				}
			}
		}

		public void ExecuteExercise(Option Exercise, int CurrentOption)
		{
			Console.Clear();
			Exercise.Method();
			Console.WriteLine("\n\n");
			if(AfterExerciseMenu(Exercise.SubMenu, 0) == 1)
			{
				ExecuteExercise(Exercise, 0);
			}
				
		}


		public int AfterExerciseMenu(List<Option> Meni, int CurrentOption)
		{
			Navigation Navigation = new Navigation();

			Navigation.WriteMenu(Meni, CurrentOption);
			

			while (true)
			{								
				System.ConsoleKeyInfo key = Console.ReadKey();
				Console.SetCursorPosition(0, Console.CursorTop);

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
					if (Meni[CurrentOption].Name == "Nazad")
					{
						return 0;
					}
					else if (Meni[CurrentOption].Name == "Ponovi zadatak")
					{
						return 1;
					}
				}
			}
		}

		public void InitalizeMenues(out List<Option> MainMenu, out List<Option> ExercisesMenu, out List<Option> ChapterFour, out List<Option> ChapterFourOne, out List<Option> AfterExerciseMenu)
		{
			Paths Paths = new Paths();

			MainMenu = new List<Option>();
			MainMenu = FillWithMenuOptions(Paths.MainMenu());

			ExercisesMenu = new List<Option>();
			ExercisesMenu = FillWithMenuOptions(Paths.ExercisesMenu());

			ChapterFour = new List<Option>();
			ChapterFour = FillWithMenuOptions(Paths.ChapterFour());

			ChapterFourOne = new List<Option>();
			ChapterFourOne = FillWithMenuOptions(Paths.ChapterFourOne());

			AfterExerciseMenu = new List<Option>();
			AfterExerciseMenu = FillWithMenuOptions(Paths.AfterExerciseMenu());

		}

		public void LinkMenues(List<Option> MainMenu, List<Option> ExercisesMenu, List<Option> ChapterFourOne)
		{
			MainMenu[0].SubMenu = ExercisesMenu;
			ExercisesMenu[0].SubMenu = ChapterFourOne;
		}


		public void LinkFunctions(List<Option> ChapterFourOne, List<Option> AfterExerciseMenu)
		{
			ChapterFourOneExercises ChapterFourOneExercises = new ChapterFourOneExercises();
			List<Action> ListOfMethods = ChapterFourOneExercises.ReturnListOfFunctions();
			for (int i = 0; i < ChapterFourOne.Count; i++)
			{
				ChapterFourOne[i].Method = ListOfMethods[i];
				ChapterFourOne[i].SubMenu = AfterExerciseMenu;
				ChapterFourOne[i].NoSubMenu = true;
			}
		}
	}
}
