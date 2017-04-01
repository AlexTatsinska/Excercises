/*
 * Created by SharpDevelop.
 * User: AlexT
 * Date: 4/1/2017
 * Time: 05:34 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
/*По въведено от клавиатурата естествено число N и N на брой числа на следващия ред, напишете програма:
 Task2a_PrintSumOfN, която след приключване на въвеждането отпечатва техния сбор*/
using System;

namespace Task2a_PrintSumOfN
{
	class Program
	{
		public static void Main(string[] args)
		{
			int number;
			int sum = 0;
			
			number = int.Parse(Console.ReadLine());
    
			for (int i = 1; i <= number; i++) {
        
				int n;
				
				n = int.Parse(Console.ReadLine());
				
				sum = sum + n;
			}
			System.Console.WriteLine("Sum = " + sum);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}