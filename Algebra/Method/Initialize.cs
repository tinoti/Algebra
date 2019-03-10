using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algebra.Model;
using Algebra.Method;
using Algebra.Exercises.ChapterFourOneExercises;
using Algebra.Exercises.ChapterFive;
using Algebra.Exercises.ChapterSix;
using Algebra.Exercises.ChapterSeven;
using Algebra.Exercises.ChapterEight;




namespace Algebra.Method
{

	class Initialize
	{
		// Takes a CSV file path and reads from it, creates an object for every value in CSV file and returns created objects in a list. Also add the return button to every list.
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
						ExecuteExercise(Meni[CurrentOption], 0);
						CurrentOption = 0;
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
						Menu(Meni[CurrentOption].SubMenu, 0);
						CurrentOption = 0;
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

		public void InitalizeMenues(out List<Option> MainMenu, out List<Option> ExercisesMenu, out List<Option> ChapterFourOne, out List<Option> ChapterFive, out List<Option> ChapterFiveOne, out List<Option> ChapterFiveTwo, out List<Option> ChapterFiveThree, out List<Option> ChapterSix, out List<Option> ChapterSixOne, out List<Option> ChapterSixTwo, out List<Option> ChapterSeven, out List<Option> ChapterSevenOne, out List<Option> ChapterSevenTwo, out List<Option> ChapterEight, out List<Option> ChapterEightOne, out List<Option> ChapterEightTwo, out List<Option> ChapterEightThree, out List<Option> AfterExerciseMenu)
		{
			Paths Paths = new Paths();

			MainMenu = new List<Option>();
			MainMenu = FillWithMenuOptions(Paths.MainMenu());

			ExercisesMenu = new List<Option>();
			ExercisesMenu = FillWithMenuOptions(Paths.ExercisesMenu());

			ChapterFourOne = new List<Option>();
			ChapterFourOne = FillWithMenuOptions(Paths.ChapterFourOne());

			ChapterFive = new List<Option>();
			ChapterFive = FillWithMenuOptions(Paths.ChapterFive());

			ChapterFiveOne = new List<Option>();
			ChapterFiveOne = FillWithMenuOptions(Paths.ChapterFiveOne());

			ChapterFiveTwo = new List<Option>();
			ChapterFiveTwo = FillWithMenuOptions(Paths.ChapterFiveTwo());

			ChapterFiveThree = new List<Option>();
			ChapterFiveThree = FillWithMenuOptions(Paths.ChapterFiveThree());

			ChapterSix = new List<Option>();
			ChapterSix = FillWithMenuOptions(Paths.ChapterSix());

			ChapterSixOne = new List<Option>();
			ChapterSixOne = FillWithMenuOptions(Paths.ChapterSixOne());

			ChapterSixTwo = new List<Option>();
			ChapterSixTwo = FillWithMenuOptions(Paths.ChapterSixTwo());

			ChapterSeven = new List<Option>();
			ChapterSeven = FillWithMenuOptions(Paths.ChapterSeven());

			ChapterSevenOne = new List<Option>();
			ChapterSevenOne = FillWithMenuOptions(Paths.ChapterSevenOne());

			ChapterSevenTwo = new List<Option>();
			ChapterSevenTwo = FillWithMenuOptions(Paths.ChapterSevenTwo());

			ChapterEight = new List<Option>();
			ChapterEight = FillWithMenuOptions(Paths.ChapterEight());

			ChapterEightOne = new List<Option>();
			ChapterEightOne = FillWithMenuOptions(Paths.ChapterEightOne());

			ChapterEightTwo = new List<Option>();
			ChapterEightTwo = FillWithMenuOptions(Paths.ChapterEightTwo());

			ChapterEightThree = new List<Option>();
			ChapterEightThree = FillWithMenuOptions(Paths.ChapterEightThree());



			AfterExerciseMenu = new List<Option>();
			AfterExerciseMenu = FillWithMenuOptions(Paths.AfterExerciseMenu());

		}

		public void LinkMenues(List<Option> MainMenu, List<Option> ExercisesMenu, List<Option> ChapterFourOne, List<Option> ChapterFive, List<Option> ChapterFiveOne, List<Option> ChapterFiveTwo, List<Option> ChapterFiveThree, List<Option> ChapterSix, List<Option> ChapterSixOne, List<Option> ChapterSixTwo, List<Option> ChapterSeven, List<Option> ChapterSevenOne, List<Option> ChapterSevenTwo, List<Option> ChapterEight, List<Option> ChapterEightOne, List<Option> ChapterEightTwo, List<Option> ChapterEightThree)
		{
			//Link main menu with exercise list menu
			MainMenu[0].SubMenu = ExercisesMenu;

			//Link 4 Poglavlje with assosiated exercises
			ExercisesMenu[0].SubMenu = ChapterFourOne;

			//Link  5. Poglavlje with assosiated sub exercises
			ExercisesMenu[1].SubMenu = ChapterFive;

			//Link 5.1 Varijable with assosiated exercises
			ChapterFive[0].SubMenu = ChapterFiveOne;

			//Link 5.2 Uvjetno grananje with assosiated exercises
			ChapterFive[1].SubMenu = ChapterFiveTwo;

			//Link 5.3 Ciklične petlje with assosiated exercises
			ChapterFive[2].SubMenu = ChapterFiveThree;

			//Link 6. Poglavlje with sub exercises
			ExercisesMenu[2].SubMenu = ChapterSix;

			//Link 6.1 Nizovi with sub exercises
			ChapterSix[0].SubMenu = ChapterSixOne;

			//Link 6.2 Liste with sub exercises
			ChapterSix[1].SubMenu = ChapterSixTwo;

			//Link 7. Poglavlje with sub exercises
			ExercisesMenu[3].SubMenu = ChapterSeven;

			//Link 7.1 Potprogrami with sub exercises
			ChapterSeven[0].SubMenu = ChapterSevenOne;

			//Link 7.2 Funkcije with sub exercises
			ChapterSeven[1].SubMenu = ChapterSevenTwo;

			//Link 8 Objekti with sub exercises
			ExercisesMenu[4].SubMenu = ChapterEight;

			//Link 8.1 Svojstva i metode with sub exercises
			ChapterEight[0].SubMenu = ChapterEightOne;

			//Link 8.2 Doseg varijabli with sub exercises
			ChapterEight[1].SubMenu = ChapterEightTwo;

			//Link 8.3 Nasljeđivanje i događaji with sub exercises
			ChapterEight[2].SubMenu = ChapterEightThree;

		}

		public void LinkFunctions(List<Option> ChapterFourOne, List<Option> ChapterFiveOne, List<Option> ChapterFiveTwo, List<Option> ChapterFiveThree, List<Option> ChapterSixOne, List<Option> ChapterSixTwo, List<Option> ChapterSevenOne, List<Option> ChapterSevenTwo, List<Option> ChapterEightOne, List<Option> ChapterEightTwo, List<Option> ChapterEightThree, List<Option> AfterExerciseMenu)
		{

			ChapterFourOneExercises ChapterFourOneExercises = new ChapterFourOneExercises();
			List<Action> ListOfMethods = ChapterFourOneExercises.ReturnListOfFunctions();
			LinkFunctionsHelper(ChapterFourOne, AfterExerciseMenu, ListOfMethods);

			ChapterFiveOneExercises ChapterFiveOneExercises = new ChapterFiveOneExercises();
			ListOfMethods = ChapterFiveOneExercises.ReturnListOfFunctions();
			LinkFunctionsHelper(ChapterFiveOne, AfterExerciseMenu, ListOfMethods);

			ChapterFiveTwoExercises ChapterFiveTwoExercises = new ChapterFiveTwoExercises();
			ListOfMethods = ChapterFiveTwoExercises.ReturnListOfFunctions();
			LinkFunctionsHelper(ChapterFiveTwo, AfterExerciseMenu, ListOfMethods);

			ChapterFiveThreeExercises ChapterFiveThreeExercises = new ChapterFiveThreeExercises();
			ListOfMethods = ChapterFiveThreeExercises.ReturnListOfFunctions();
			LinkFunctionsHelper(ChapterFiveThree, AfterExerciseMenu, ListOfMethods);

			ChapterSixOneExercises ChapterSixOneExercises = new ChapterSixOneExercises();
			ListOfMethods = ChapterSixOneExercises.ReturnListOfFunctions();
			LinkFunctionsHelper(ChapterSixOne, AfterExerciseMenu, ListOfMethods);

			ChapterSixTwoExercises ChapterSixTwoExercises = new ChapterSixTwoExercises();
			ListOfMethods = ChapterSixTwoExercises.ReturnListOfFunctions();
			LinkFunctionsHelper(ChapterSixTwo, AfterExerciseMenu, ListOfMethods);

			ChapterSevenOneExercises ChapterSevenOneExercises = new ChapterSevenOneExercises();
			ListOfMethods = ChapterSevenOneExercises.ReturnListOfFunctions();
			LinkFunctionsHelper(ChapterSevenOne, AfterExerciseMenu, ListOfMethods);

			ChapterSevenTwoExercises ChapterSevenTwoExercises = new ChapterSevenTwoExercises();
			ListOfMethods = ChapterSevenTwoExercises.ReturnListOfFunctions();
			LinkFunctionsHelper(ChapterSevenTwo, AfterExerciseMenu, ListOfMethods);

			ChapterEightOneExercises ChapterEightOneExercises = new ChapterEightOneExercises();
			ListOfMethods = ChapterEightOneExercises.ReturnListOfFunctions();
			LinkFunctionsHelper(ChapterEightOne, AfterExerciseMenu, ListOfMethods);

			ChapterEightTwoExercises ChapterEightTwoExercises = new ChapterEightTwoExercises();
			ListOfMethods = ChapterEightTwoExercises.ReturnListOfFunctions();
			LinkFunctionsHelper(ChapterEightTwo, AfterExerciseMenu, ListOfMethods);

			ChapterEightThreeExercises ChapterEightThreeExercises = new ChapterEightThreeExercises();
			ListOfMethods = ChapterEightThreeExercises.ReturnListOfFunctions();
			LinkFunctionsHelper(ChapterEightThree, AfterExerciseMenu, ListOfMethods);

		}

		private static void LinkFunctionsHelper(List<Option> Chapter, List<Option> AfterExerciseMenu, List<Action> ListOfMethods)
		{
			for (int i = 0; i < Chapter.Count - 1; i++)
			{
				Chapter[i].Method = ListOfMethods[i];
				Chapter[i].SubMenu = AfterExerciseMenu;
				Chapter[i].NoSubMenu = true;
			}
		}
	}
}
