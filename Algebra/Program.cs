using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algebra.Method;
using Algebra.Model;

namespace Algebra
{
	class Program
	{
		static void Main(string[] args)
		{
			Paths Paths = new Paths();
			Initialize Initialize = new Initialize();
			Navigation Navigation = new Navigation();

			//Initialize Exercises menu 
			List<Option> ExercisesMenu = new List<Option>();
			ExercisesMenu = Initialize.FillWithObjects(Paths.ExercisesMenu());

			//Initialize Sub exercises menu
			List<Option>
			

			//Initialize main menu and link "Zadaci" with sub menu
			List<Option> MainMenu = new List<Option>();
			MainMenu = Initialize.FillWithObjects(Paths.MainMenu());
			MainMenu[0].SubMenu = ExercisesMenu;

			Initialize.Menu(MainMenu, 0);
						
		}
	}
}
