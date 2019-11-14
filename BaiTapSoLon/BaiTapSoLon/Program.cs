/*
 * Created by SharpDevelop.
 * User: VienDong
 * Date: 11/14/2019
 * Time: 1:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BaiTapSoLon
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			
			
			clsBigInt A = new clsBigInt("-1232134");
			clsBigInt B = new clsBigInt("-435789634583749");
			
			if(A == B)
			{
				Console.WriteLine("A is: {0} == B: {1}", A.Value, B.Value);
			}
			else if(A > B)
			{
				Console.WriteLine("A is: {0} > B: {1}", A.Value, B.Value);
			}
			else
			{
				Console.WriteLine("A is: {0} < B: {1}", A.Value, B.Value);
			}
			clsBigInt C = A + B ;
			Console.WriteLine("A is: {0} + B: {1} = C: {2}", A.Value, B.Value, C.Value);
			//Console.WriteLine("A is: {0} have ABS: {1}", A.Value, A.ABS().Value);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}