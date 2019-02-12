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
	}
}
