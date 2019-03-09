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

		// Returns a full path for the fifth chapter, Varijable exercises menu option
		public string ChapterFiveOne()
		{
			return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Menues\ChapterFiveOne.txt"));
		}

		// Returns a full path for the fifth chapter, Uvjetno grananje exercises menu option
		public string ChapterFiveTwo()
		{
			return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Menues\ChapterFiveTwo.txt"));
		}

		// Returns a full path for the fifth chapter, ciklične petlje exercises menu option
		public string ChapterFiveThree()
		{
			return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Menues\ChapterFiveThree.txt"));
		}

		// Returns a full path for the sixth chapter
		public string ChapterSix()
		{
			return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Menues\ChapterSix.txt"));
		}

		// Returns a full path for the sixth chapter, nizovi exercises menu option
		public string ChapterSixOne()
		{
			return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Menues\ChapterSixOne.txt"));
		}

		// Returns a full path for the sixth chapter, Liste exercises menu option
		public string ChapterSixTwo()
		{
			return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Menues\ChapterSixTwo.txt"));
		}

		// Returns a full path for the seventh chapter
		public string ChapterSeven()
		{
			return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Menues\ChapterSeven.txt"));
		}

		// Returns a full path for the seventh chapter, Potprogrami exercises
		public string ChapterSevenOne()
		{
			return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Menues\ChapterSevenOne.txt"));
		}

		// Returns a full path for the seventh chapter, Funkcije exercises
		public string ChapterSevenTwo()
		{
			return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Menues\ChapterSevenTwo.txt"));
		}

		public string AfterExerciseMenu()
		{
			return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Menues\AfterExerciseMenu.txt"));
		}
	}
}
