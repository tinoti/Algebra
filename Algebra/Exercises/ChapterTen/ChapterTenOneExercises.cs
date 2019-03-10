using System;
using System.Collections.Generic;
using System.IO;
using Algebra.Exercises.Method;

namespace Algebra.Exercises.ChapterTen
{
	class ChapterTenOneExercises
	{
		Entry Entry = new Entry();

		public void Parni()
		{
			Console.WriteLine("Napišite program koji sve parne brojeve iz intervala [1, 100] zapisuje u datoteku Parni.txt i zatvara ju. Nakon toga otvara tu istu datoteku i njezin sadržaj ispisuje na ekran. \n");

			FileStream fs = new FileStream("Proba.txt", FileMode.Create);
			StreamWriter sw = new StreamWriter(fs);

			for(int i = 1; i <= 100; i++)
			{
				if(i % 2 == 0)
				{
					sw.WriteLine(i);
				}
			}
			sw.Flush();
			sw.Close();
			fs.Close();

			FileStream fs1 = new FileStream("Proba.txt", FileMode.Open);

			StreamReader sr = new StreamReader(fs1);
			string procitano = sr.ReadToEnd();
			fs1.Close();
			sr.Close();

			Console.WriteLine(procitano);


		}

		public void TriSedam()
		{
			Console.WriteLine("Napišite program koji zapisuje u datoteke: \n3or7uNoviRed.txt - svaki broj u novi red \n3or7SaZarezima.text - svaki broj odvojen zarezom \nsve brojeve iz intervala [0,100] koji su djeljivi s brojem 3 ili s brojem 7.\n");
			FileStream fs = new FileStream("3or7uNoviRed.txt", FileMode.Create);
			StreamWriter sw = new StreamWriter(fs);
			FileStream fs1 = new FileStream("3or7SaZarezima.txt", FileMode.Create);
			StreamWriter sw1 = new StreamWriter(fs1);

			for(int i = 1; i <= 100; i++)
			{
				if(i % 3 == 0 || i % 7 == 0)
				{
					sw.WriteLine(i);
					sw1.Write(i + ", ");
				}
			}

			sw.Flush();
			sw1.Flush();

			sw.Close();
			sw1.Close();

			fs.Close();
			fs1.Close();

			Console.WriteLine("\n\nPogledati txt datoteke u folderu!");
			
			
		}

		public void ParNepar()
		{
			Console.WriteLine("Napišite program koji traži unos prirodnih brojeva sve dok se ne unese broj 0. Nakon toga unesene parne brojeve sprema u datoteku parni.txt, a neparne u datoteku neparni.txt. \n");
			List<int> brojevi = new List<int>();
			int broj;
			while (true)
			{
				broj = Entry.NaturalNumberOrZero();
				if(broj == 0)
				{
					break;
				}
				else
				{
					brojevi.Add(broj);
				}


			}
			FileStream fs = new FileStream("Parni.txt", FileMode.Create);
			StreamWriter sw = new StreamWriter(fs);
			FileStream fs1 = new FileStream("Neparni.txt", FileMode.Create);
			StreamWriter sw1 = new StreamWriter(fs1);

			foreach(int br in brojevi)
			{
				if(br % 2 == 0)
				{
					sw.WriteLine(br);
				}
				else
				{
					sw1.WriteLine(br);
				}
			}

			sw.Flush();
			sw1.Flush();

			sw.Close();
			sw1.Close();

			fs.Close();
			fs1.Close();

			Console.WriteLine("\n\nPogledati txt datoteke u folderu!");
		}

		public void Dir()
		{
			Console.WriteLine("Napravite program koji će za unesenu putanju ispisati sve datoteke i sve direktorije u toj mapi. \n");

			string path = Entry.OneWord("Unesi putanju:");
			string[] directories = Directory.GetDirectories(path);

			string[] files = Directory.GetFiles(path);

			foreach(string dir in directories)
			{
				Console.WriteLine(dir);
			}
			foreach(string file in files)
			{
				Console.WriteLine(file);
			}
		}

		public void DirectoryInfo()
		{
			Console.WriteLine("Napišite program koji će za unesenu putanju ispisati sve direktorije koje ta putanja sadrži te koliko svaki sadrži datoteka a koliko poddirektorija.\n");

			string path = Entry.OneWord("Upišite putanju:");
			string[] dirs = Directory.GetDirectories(path);

			foreach(string dir in dirs)
			{
				Console.WriteLine(Path.GetFileName(dir) + ", " + Directory.GetFiles(dir).GetLength(0) + ", " + Directory.GetDirectories(path).Length);
			}

		}

		public void DirectoryTree()
		{
			Console.WriteLine("Napišite program koji će za unesenu putanju ispisati sve poddirektorije na toj putanji.\n");

			GetFolders(Entry.OneWord("Upiši putanju:"));


		}

		public void GetFolders(string sPath)
		{
			int b = 0;
			Console.WriteLine("{0}{1}", new string(' ', GetDepth(sPath) * 2), Path.GetFileName(sPath));
			b++;

			string[] sDirs = Directory.GetDirectories(sPath);

			foreach(string sD in sDirs)
			{
				GetFolders(sD);
			}
			b--;
		}

		private static int GetDepth(string sPath)
		{
			int a = 0;
			foreach(char c in sPath)
			{
				if(c== '\\')
				{
					a++;
				}
			}
			return a;
		}

		public List<Action> ReturnListOfFunctions()
		{
			List<Action> Methods = new List<Action>();
			Methods.Add(Parni);
			Methods.Add(TriSedam);
			Methods.Add(ParNepar);
			Methods.Add(Dir);
			Methods.Add(DirectoryInfo);
			Methods.Add(DirectoryTree);

			return Methods;
		}
	}
}
