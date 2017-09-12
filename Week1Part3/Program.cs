using System;

namespace HomeworkWeek1DeclaringVariablesPart3
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int x = 7;
			string y = "5";
			string myFirstTry = x.ToString();

			// this try did not work becasue we did
			// not convert the data yet and it still 
			//didnt because bob did is able to be converted.
			//int mySecondTry = x + y;
			int mySecondTry = x + int.Parse(y);
			Console.WriteLine(mySecondTry);

			Console.ReadLine();

		}
	}
}