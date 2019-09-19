/*
 * Created by SharpDevelop.
 * User: C5-D01
 * Date: 9/12/2019
 * Time: 3:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BaiTapPhanSo
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			clsPhanSo a, b, c, d, e, f, g;
			a = new clsPhanSo();
			b = new clsPhanSo(1,6);
			c = new clsPhanSo(1,3);
			//d = clsPhanSo.Cong(b,c);
			d = b + c;
			e = clsPhanSo.Tru(b,c);
			try
			{
				f = clsPhanSo.Chia(b,c);
				f.In();
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			
			
			a.In();
			d.In();
			e.In();
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}