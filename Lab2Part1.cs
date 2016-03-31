using System;

namespace Lab2RaviPatel
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Course crse1 = new Course ();
			Console.WriteLine(crse1.ToString ());
			Console.WriteLine ();
			Console.WriteLine ();
			Course crse2 = new Course ("This course teaches you about the importance of C#\nand its awesomeness",
				               1101, 3, "CSE");
			Console.WriteLine(crse2.ToString ());
		}
	}
}
