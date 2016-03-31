using System;

namespace Lab1RaviPatel
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("What is your name: ");
			string name = Console.ReadLine ();
			Console.WriteLine ("What is your current GPA (grade point average): ");
			double gpa = double.Parse(Console.ReadLine ());

			if (gpa >= 3.5) {
				Console.WriteLine (name + ", your GPA which is " + gpa + " tells us that you will graduate with honors.");
			} else if (gpa < 2.0) {
				Console.WriteLine (name + ", your GPA which is " + gpa + " tells us that you are on probation and are on the verge of failing out");
			}

		}
	}
}
