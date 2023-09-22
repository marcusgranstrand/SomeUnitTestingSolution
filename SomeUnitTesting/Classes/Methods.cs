using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeUnitTesting.Classes
{
	public class Methods
	{
		public static string Formatter(string firstName, string lastName)
		{
			string abbreviation = $"({lastName[0].ToString().ToUpper()}" + 
									$"{lastName[1].ToString().ToUpper()}" + 
									$"{lastName[2].ToString().ToUpper()}" +
									$"{firstName[0].ToString().ToUpper()}" +
									$"{firstName[1].ToString().ToUpper()}" +
									$"{firstName[2].ToString().ToUpper()})"; 

			string last = $"{lastName[0].ToString().ToUpper()}" +
							$"{lastName.Substring(1).ToLower().ToString()}";

			// It feels like I should be able to do this without making a new temp string, but I did not get 
			// it to work properly :-( This needs PRACTICE, this took me like 4,5 hours :-( as you can see 
			// from the variable naming I got a bit frustrated, but in the end I got A solution

			string temp = last;
			string bubba = $"{temp.Insert(0, "#_")}";
			last = bubba;

			string first = $"{firstName[0].ToString().ToUpper()}" + 
							$"{firstName.Substring(1).ToLower().ToString().Insert(8, $" {abbreviation}")}";

			return $"{last}, {first}";			
		}
	}
}
