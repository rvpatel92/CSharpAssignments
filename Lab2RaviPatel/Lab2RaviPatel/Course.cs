using System;

namespace Lab2RaviPatel
{
	public class Course
	{

		protected string description;
		protected int number;
		protected int hours;
		protected string name;

		public string Description
		{
			get 
			{
				return description;
			}
			set
			{
				description = value;
			}
		}

		public int Number
		{
			get 
			{
				return number;
			}
			set 
			{
				number = value;
			}
		}

		public int Hours
		{
			get 
			{
				return hours;
			}
			set 
			{
				hours = value;
			}
		}

		public string Name
		{
			get 
			{
				return name;
			}
			set 
			{
				name = value;
			}
		}

		public Course ()
		{
			this.description = "Class that teaches about the understanding of \n" +
				"programming principles 1 (uses Java)";
			this.number = 1111;
			this.hours = 4;
			this.name = "CS";
		}

		public Course(string description, int number, int hours, string name)
		{
			this.description = description;
			this.number = number;
			this.hours = hours;
			this.name = name;
		}

		public override string ToString ()
		{
			return string.Format ("Description: " + description + "\nNumber: " + number + "\nHours: " + hours
			+ "\nName: " + name);
		}
			
	}
}

