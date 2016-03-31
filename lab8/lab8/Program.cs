using System;

namespace lab8
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			greeting ("Smith", "VW");
			double priceTotal = total ("Smith", "VW");
			double priceWithTax = taxTotal (priceTotal);
			timeTook (priceWithTax, 4);
		}

		public static void greeting(String name, String carMake)
		{
			Console.WriteLine ("Welcome to our shop Ms." + name + ".  We will be happy to service your " + carMake + " today.");
		}

		public static double total(String name, String carMake)
		{
			double totalPrice = 0;

			String[] services = {"Oil Change", "Tire Rotation", "Air Filter", "Check Fluids"};
			double[] prices = {39.99, 49.99, 19.99, 10.99};

			for (int index = 0; index < services.Length; index++) {
				Console.WriteLine ("Do you want an " + services [index] + " for your " + carMake + "?");
				String answer = Console.ReadLine ();
				if (answer == "yes") {
					totalPrice += prices [index];
				} else {
				}
			}

			return totalPrice;
		}

		public static double taxTotal(double priceTotal)
		{
			return Math.Round((priceTotal * .93), 2);
		}

		public static double timeTook(double total, double time)
		{
			double timeSpent = 0;

			for (int index = 1; index <= time; index++) {
				if (index == 1) {
					timeSpent += 30;
				} else if (index == 2) {
					timeSpent += 20;
				} else {
					timeSpent += 10;
				}
			}
			//To display the total price just wanted to make sure it was right.
			Console.WriteLine ("Your total payment is " + (total + timeSpent) + ".");
			return total + timeSpent;
		}

	}
}
