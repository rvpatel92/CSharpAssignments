using System;

namespace LabFourRaviPatel
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string name;
			int numWidgets;
			string state;
			double cost = 0;
			double total;
			double dcharge = 0;
			double tax;
			double totalCost;
			string doubleChance = "";

			Console.WriteLine ("What is your name: ");
			name = Console.ReadLine ();
			Console.WriteLine ("How many number of widgets would you like to purchase: ");
			numWidgets = Convert.ToInt32(Console.ReadLine ());
			Console.WriteLine ("Which state are you in (Express in Two Letters): ");
			state = Console.ReadLine ();

			Console.WriteLine ("Would you like to change your order (Answer y for yes or n for no): ");
			doubleChance = Console.ReadLine ();

			if (doubleChance == "y") {
				Console.WriteLine ("Enter the new number of widgets: ");
				numWidgets = Convert.ToInt32 (Console.ReadLine ());
			} else if (doubleChance == "n") {
			}

			if (numWidgets <= 20) {
				cost = 3.00;
			} else if (numWidgets > 20 && numWidgets <= 50) {
				cost = 2.25;
			} else if (numWidgets > 50 && numWidgets <= 100) {
				cost = 1.75;
			} else if (numWidgets > 100) {
				cost = 1.25;
			}

			Console.WriteLine (name + ", the cost per widget will be " + cost + ".");

			total = numWidgets * cost;

			if (total <= 50.00) {
				dcharge = 9.99;
			} else if (total > 50 && total <= 100) {
				dcharge = 6.99;
			} else if (total > 100) {
				dcharge = 0.00;
			}
				

			Console.WriteLine (name + ", the cost of the delivery will be " + dcharge + ".");

			if (state == "GA" || state == "ga") {
				tax = total * .07;
			} else {
				tax = total * .05;
			}

			totalCost = (total + dcharge + tax);

			Random rd = new Random ();

			int reciptNumber = rd.Next () + 1;

			Console.WriteLine ();
			Console.WriteLine ();
			Console.WriteLine ();
			Console.WriteLine ("Reciept: " + reciptNumber);
			Console.WriteLine ("State: " + state);
			Console.WriteLine ("Number of Widgets: " + numWidgets);
			Console.WriteLine ("Price Per Widget: " + cost);
			Console.WriteLine ("Delivery Cost: " + dcharge);
			Console.WriteLine ("Total Due: " + totalCost);
		}
	}
}
