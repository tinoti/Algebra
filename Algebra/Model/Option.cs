﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebra.Model
{
	class Option
	{
		public string Name { get; set; }
		public List<Option> SubMenu { get; set; }
		public bool NoSubMenu { get; set; }
		public List<Exercise> Exercises { get; set; }

		public Option(string OptionName)
		{
			Name = OptionName;
		}

	}
}
