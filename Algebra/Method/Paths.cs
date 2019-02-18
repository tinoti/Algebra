using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebra.Method
{
	class Paths
	{
		//Returns a full path for the main menu options
		public string MainMenu()
		{
			return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Menues\MainMenu.txt"));
		}

		//Returns a full path for the exercises menu option
		public string ExercisesMenu()
		{
			return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Menues\Exercises.txt"));
		}

		// Returns a full path for the fourth chapter exercises menu option
		public string ChapterFour()
		{
			return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Menues\ChapterFour.txt"));
		}
		// Returns a full path for the FOUR ONE  exercises menu option
		public string ChapterFourOne()
		{
			return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Menues\ChapterFourOne.txt"));
		}

		// Returns a full path for the fourth chapter exercises menu option
		public string ChapterFive()
		{
			return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Menues\ChapterFive.txt"));
		}

		public string AfterExerciseMenu()
		{
			return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Menues\AfterExerciseMenu.txt"));
		}
	}
}
