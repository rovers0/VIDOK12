/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 03/10/2019
 * Time: 1:34 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BaiTapSo4
{
	class Program
	{
		public static void Main(string[] args)
		{
			clsMenu menu = new clsMenu();
			int iLuaChon;
			menu.AddItem("Nhap TS Khoi A");
			menu.AddItem("Nhap TS Khoi B");
			menu.AddItem("Nhap TS Khoi C");
			menu.AddItem("Danh Sach Thi Sinh");
			menu.AddItem("Tim Thi Sinh");
			menu.AddItem("Thoat");
			
			do{
				iLuaChon = menu.DisplayMenu();
				if(iLuaChon==0)
				{
					
				}
			}while (iLuaChon != 5);
//			
			clsThiSinhKhoiA tsA = new clsThiSinhKhoiA();
//			Console.WriteLine("Bai Tap 4");
//			
//			// TODO: Implement Functionality Here
//			
//			tsA.NhapThongTin();
//			Console.WriteLine("----------------------------------------------------------------------------------------");
//			Console.WriteLine("| {0,-11} | {1,-18} | {2,-18} | {3,7} | {4,4} | {5,4} | {6,4} |", "So Bao Danh", "Ho Ten", "Dia Chi","Uu Tien","Mon1", "Mon2", "Mon3");
//			Console.WriteLine("----------------------------------------------------------------------------------------");
//			tsA.HienThiThongTin();
//			Console.WriteLine("----------------------------------------------------------------------------------------");
//			
//			Console.Write("Press any key to continue . . . ");
//			Console.ReadKey(true);
		}
	}
}