using System;

namespace Lab07
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			String answer1 = numberone (3);
			Console.WriteLine (answer1);

			Console.WriteLine ();
			int answer3 = minOfThree (5, 4, 6);
			Console.WriteLine ("The minimum number of the three is " + answer3);

			Console.WriteLine ();
			int answer4 = Summation (3, 7);
			Console.WriteLine ("The summation of 3 and 7 is " + answer4);

			Console.WriteLine ();
			double answer7 = grossPay (7.25, 42);
			Console.WriteLine ("The gross pay you will recieve is: " + Math.Round(answer7, 2) + " dollars.");

		}

		public static string numberone(int input)
		{
			if (input == 1) {
				return "Roast beef";
			} else if (input == 2) {
				return "Bologna Sandwich";
			} else if (input == 3) {
				return "Chocolate Ice Cream";
			} else if (input == 4) {
				return "Chocolate Chip Cookie Dough Ice Cream";
			} else {
				return "Invalid Choice but Bon Appetit!";
			}
		}

		public static int minOfThree(int num1, int num2, int num3)
		{
			int answer = 0;

			if (num1 <= num2 && num1 <= num3) {
				return answer = num1;
			} else if (num2 <= num1 && num2 <= num3) {
				return answer = num2;
			} else if (num3 <= num1 && num3 <= num2) {
				return answer = num3;
			}

			return answer;
		}

		public static int Summation(int start, int end)
		{
			int answer = 0;

			for (int i = start; i <= end; i++) {
				answer = answer + i;
			}

			return answer;
		}

		public static double grossPay(double rate, double hours)
		{
			double sum = 0;

			if (hours <= 40) {
				sum = rate * hours;
			} else if (hours > 40) {
				double overTime = hours - 40;
				double overRate = rate * 1.5;
				double newSum = rate * 40;
				sum = newSum + (overTime * overRate);
			}

			return sum;
		}
			
	}
}
