﻿using System;
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

			Initialize Initialize = new Initialize();
			
			// INITIALIZATION
			List<Option> MainMenu, ExercisesMenu, ChapterFour, ChapterFourOne, AfterExerciseMenu;
			Initialize.InitalizeMenues(out MainMenu, out ExercisesMenu, out ChapterFour, out ChapterFourOne, out AfterExerciseMenu);


			// LINKING MENUES
			Initialize.LinkMenues(MainMenu, ExercisesMenu, ChapterFourOne);


			// LINKING METHODS
			Initialize.LinkFunctions(ChapterFourOne, AfterExerciseMenu);
			

			Initialize.Menu(MainMenu, 0);
						
		}
	}
}
