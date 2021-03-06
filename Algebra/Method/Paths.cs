﻿using System;
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

		// Returns a full path for the eight chapter, Objekti
		public string ChapterEight()
		{
			return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Menues\ChapterEight.txt"));
		}

		// Returns a full path for the eight chapter, Svojstva i metoda exercises
		public string ChapterEightOne()
		{
			return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Menues\ChapterEightOne.txt"));
		}

		// Returns a full path for the eight chapter, doseg varijabli exercises
		public string ChapterEightTwo()
		{
			return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Menues\ChapterEightTwo.txt"));
		}

		// Returns a full path for the eight chapter, Nasljedivanje i dogadaji exercises
		public string ChapterEightThree()
		{
			return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Menues\ChapterEightThree.txt"));
		}

		// Returns a full path for the ninth chapter, Rad s tekstom exercises
		public string ChapterNine()
		{
			return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Menues\ChapterNine.txt"));
		}

		// Returns a full path for the tenth chapter, Datoteke
		public string ChapterTen()
		{
			return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Menues\ChapterTen.txt"));
		}

		//Returns a full path for the eleventh chapter, LINQ
		public string ChapterEleven()
		{
			return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Menues\ChapterEleven.txt"));
		}

		//Returns a full path for the twelth chapter, DATUMI
		public string ChapterTwelve()
		{
			return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Menues\ChapterTwelve.txt"));
		}

		public string AfterExerciseMenu()
		{
			return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Menues\AfterExerciseMenu.txt"));
		}
	}
}
