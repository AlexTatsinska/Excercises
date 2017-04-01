/*
 * Created by SharpDevelop.
 * User: AlexT
 * Date: 4/1/2017
 * Time: 05:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
/*По въведено от клавиатурата естествено число N и N на брой числа на следващия ред, напишете програма:
 Task2b_PrintReversedSequence, която след приключване на въвеждането отпечатва числата в обратен ред*/
 
using System;

namespace Task2b_PrintReversedSequence
{
	class Program
	{
		public static void Main(string[] args)
		{
			int startNumber;
			int inputNumber;
			string mirrorNumbers = "";
        
			startNumber = int.Parse(Console.ReadLine());

			for (int i = 0; i < startNumber; i++) {
				inputNumber = int.Parse(Console.ReadLine());
				mirrorNumbers = inputNumber + " " + mirrorNumbers;

			}
			System.Console.WriteLine(mirrorNumbers);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}