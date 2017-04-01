/*
 * Created by SharpDevelop.
 * User: AlexT
 * Date: 4/1/2017
 * Time: 06:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
/*По въведено число N от клавиатурата, напишете програма с името:
   Task3a_PrintSquare, която отпечатва квадрат със страна N, използвайки знака '*'
  */
 
using System;

namespace Task3a_PrintSquare
{
	class Program
	{
		public static void Main(string[] args)
		{
			int number;
			
			number = int.Parse(Console.ReadLine());
			
			for (int i = 1; i <= number; i++) {
				if (i == 1 || i == number) {
					for (int j = 1; j <= number; j++) {
						System.Console.Write("*");
					}
				} else {
					for (int k = 1; k <= number; k++) {
						if (k == 1 || k == number) {
							System.Console.Write("*");
						} else {
							System.Console.Write(" ");
						}
					}
				}
				System.Console.WriteLine();
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}