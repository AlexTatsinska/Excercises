/*
 * Created by SharpDevelop.
 * User: AlexT
 * Date: 4/1/2017
 * Time: 05:56 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
/*По въведено от клавиатурата естествено число N и N на брой числа на следващия ред, напишете програма:
 Task2a_PrintSumOfN, която след приключване на въвеждането отпечатва техния сбор*/
 
using System;

namespace Task2c_PrintOnlyEvenNumbers
{
	class Program
	{
		public static void Main(string[] args)
		{
			int number;
			int inputNumber;
        
			number = int.Parse(Console.ReadLine());

			for (int i = 0; i < number; i++) {
				inputNumber = int.Parse(Console.ReadLine());
				if (inputNumber % 2 == 0) {
					System.Console.Write(inputNumber + " is even");
					System.Console.WriteLine();
				}
			}
        
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}