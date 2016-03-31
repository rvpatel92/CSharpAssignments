using System;

namespace BMILabPart2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("What is your gender? ");
			string gender = Console.ReadLine ();
			Console.WriteLine ("How much do you currently weigh? ");
			double weight = double.Parse (Console.ReadLine ());
			Console.WriteLine ("What is your current height? (inches): ");
			double height = double.Parse (Console.ReadLine ());
			Console.WriteLine ("How old are you currently: ");
			double age = double.Parse (Console.ReadLine ());

			if (gender == "male") {
				double bmi = (66 + (6.23 * weight) + (12.7 * height) - (6.8 * age));
				Console.WriteLine ("Your weight is: " + weight + " pounds." + "\nYour height is: " + height +" inches." 
					+ "\nYour age is: " + age + "\nYour current BMI is " + bmi);

			} else if (gender == "female") {
				double bmi = (665 + (4.35 * weight) + (4.7 * height) - (4.7 * age));
				Console.WriteLine ("Your weight is: " + weight +" pounds." + "\nYour height is: " + height + " inches." 
					+ "\nYour age is: " + age + "\nYour current BMI is " + bmi);
			} else
				Console.WriteLine ("You need to enter the correct gender.  Either enter female, or male.");
		}
	}
}
