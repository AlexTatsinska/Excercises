/*
 * Created by SharpDevelop.
 * User: AlexT
 * Date: 4/1/2017
 * Time: 08:23 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
/*По въведено число N от клавиатурата, напишете програма с името:
   Task3c_PrintChristmasTree, която отпечатва елхичка с височина N, използвайки знака *. 
   „Поставката“ е винаги с височина 1 и дължина 3, а стъблото с височина 1 и дължина 1.
   Всеки ред на „короната“ е с дължина 2 звезди повече от предходния, като първия е с дължина 1 звезда.
  */
 
using System;

namespace Task3c_PrintChristmasTree
{
	class Program
	{
		public static void Main(string[] args)
		{
			int number;
			String tree = "*";
			String tree1 = tree;
        
			number = int.Parse(Console.ReadLine());
        
			for (int i = 1; i <= number; i++) {
				for (int j = 1; j <= number - i; j++) {
					System.Console.Write(" ");
				}
				System.Console.WriteLine(tree);
				tree = tree + "**";
            
			}
			for (int i = 1; i <= 2; i++) {
				for (int j = 1; j <= number - i; j++) {
					System.Console.Write(" ");
				}
				System.Console.WriteLine(tree1);
				tree1 = tree1 + "**";
        
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}