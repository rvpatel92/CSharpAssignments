using System;

namespace Lab5RaviPatel
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//declares variables - 10 Points
			string name;
			double height, weight; 
			int userAge;
			string gender;
			double BMR = 0;
			double exerciseFactor;
			double allowedCalories = 0;

			//asks for and stores data appropriately - 20 points
			Console.Write("Enter your name: ");
			name = Console.ReadLine ();
			Console.Write("Enter your height in inches: ");
			height = Convert.ToDouble(Console.ReadLine ());
			Console.Write ("Enter your weight in pounds: ");
			weight = Convert.ToDouble(Console.ReadLine ());
			Console.Write ("Enter your age: ");
			userAge = Convert.ToInt32(Console.ReadLine ());
			Console.Write ("Enter your gender as M or F: ");
			gender = Console.ReadLine ();

			//Conditional calculation of BMR - 20 Points
			if(gender == "F")
			{
				BMR = 655+(4.35 * weight) + (4.7 * height) - (4.7 * userAge );
			}
			else if(gender == "M")
			{
				BMR = 66+(6.23 * weight) + (12.7 * height) - (6.8 * userAge);
			}
				
			Console.Write ("1 - You don't exercise. \n2 - You engage in light exercise one to three days a week." +
			"\n3 - You exercise moderately three to five times a week.\n4 - You exercise intensely six to seven days a week." +
			"\n5 - You exercise intensely six to seven days a week and have a physically active job.\n");

			Console.Write("What is your level of activity: ");

			exerciseFactor = Convert.ToDouble(Console.ReadLine());
			//when user chooses number, it calculates the allowed calories
			if (exerciseFactor == 1) {
				allowedCalories = BMR * 1.2;
			} else if (exerciseFactor == 2) {
				allowedCalories = BMR * 1.375;
			} else if (exerciseFactor == 3) {
				allowedCalories = BMR * 1.55;
			} else if (exerciseFactor == 4) {
				allowedCalories = BMR * 1.725;
			} else if (exerciseFactor == 5) {
				allowedCalories = BMR * 1.725;
			} else {
				Console.WriteLine ("You need to input a value between 1 - 5.");
			}
			Console.WriteLine ();



			//Appropriate output as required by the lab - 20 Points
			Console.WriteLine (name + " you entered: \nHeight: " + height + "\nWeight: " + weight + "\nAge: " + userAge + "\nGender: " + gender);
			Console.WriteLine ("Your BMR is " + BMR);
			Console.WriteLine ("The allowed calories you can have per day is " + allowedCalories);

			Console.WriteLine ();

			string response = "YES";
			//given in the lab
			while (response == "YES") 
			{
				int caloriesNow;
				Console.Write ("Enter the amount of calories you just ate: ");
				caloriesNow = Convert.ToInt32 (Console.ReadLine ());
				allowedCalories = allowedCalories - caloriesNow;
				Console.WriteLine ("The amount of calories left to eat is " + allowedCalories);
				Console.Write ("Would you like to continue? ");
				response = Console.ReadLine ();
				response = response.ToUpper ();
				//this is an if statement to show that if allowed calories is below 0, it tells user you went below zero
				//but it also asks if they want to continue, because they can enter in more information.
				if (allowedCalories < 0) {
					Console.WriteLine ("You have went passed the amount of calories.  You are at " + allowedCalories + "calories.");
					Console.Write ("Would you like to continue? ");
					response = Console.ReadLine ();
					response = response.ToUpper ();
				}
			}
			//displays the final allowed calories 
			Console.WriteLine ();
			Console.WriteLine ("The amount of calories you have left is " + allowedCalories);
		}
	}
}
