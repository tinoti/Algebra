using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algebra.Method;
using Algebra.Model;
using Algebra.Exercises.Exercise4;

namespace Algebra
{
	class Program
	{
		static void Main(string[] args)
		{

			//TO DO:
			// refacture below code to a InitializeMenues function that initializes all menues in the data menues folder (returns to a single list here),
			// and LinkMenues() that links all the menues and sub menues


			Paths Paths = new Paths();
			Initialize Initialize = new Initialize();
			Navigation Navigation = new Navigation();
			Exercise4 Exercise4 = new Exercise4();


			//Initialize Exercises menu 
			List<Option> ExercisesMenu = new List<Option>();
			ExercisesMenu = Initialize.FillWithObjects(Paths.ExercisesMenu());

			//Initialize Sub exercises menu
			List<Option> SubExercisesMenu = new List<Option>();
			SubExercisesMenu = Initialize.FillWithObjects(Paths.SubExercisesMenu());
			

			//Initialize main menu and link "Zadaci" with sub menu
			List<Option> MainMenu = new List<Option>();
			MainMenu = Initialize.FillWithObjects(Paths.MainMenu());
			MainMenu[0].SubMenu = ExercisesMenu;


			//Link sub exercises menu with exercises menu
			ExercisesMenu[0].SubMenu = SubExercisesMenu;



			List<Action> ListOfFunctions = Exercise4.ReturnListOfFunctions();
			for (int i = 0; i < SubExercisesMenu.Count; i++)
			{

				SubExercisesMenu[i].Method = ListOfFunctions[i];
				SubExercisesMenu[i].NoSubMenu = true;
			}


			List<Option> ListOfMenues = new List<Option>();
			ListOfMenues.Add(LinkMenues(MainMenu, ExercisesMenu));



			Initialize.Menu(MainMenu, 0);
						
		}
	}
}
