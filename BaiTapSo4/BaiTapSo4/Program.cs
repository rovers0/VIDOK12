/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 03/10/2019
 * Time: 1:34 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace BaiTapSo4
{
	class Program
	{
		public static void Main(string[] args)
		{
			clsMenu menu = new clsMenu();
			int iLuaChon;
			clsThiSinh tsTam;
			List<clsThiSinh> dsThiSinh = new List<clsThiSinh>();
			string sSoBaoDanh = "";
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
					tsTam = new clsThiSinhKhoiA();
					tsTam.NhapThongTin();
					dsThiSinh.Add(tsTam);
				}
				else if (iLuaChon == 1) 
				{
					tsTam = new clsThiSinhKhoiB();
					tsTam.NhapThongTin();
					dsThiSinh.Add(tsTam);
				} 
				else if (iLuaChon == 2) 
				{
					tsTam = new clsThiSinhKhoiC();
					tsTam.NhapThongTin();
					dsThiSinh.Add(tsTam);
				} 
				else if (iLuaChon == 3) 
				{
					Console.WriteLine("------------------------------Danh Sach Thi Sinh----------------------------------");
					Console.WriteLine("| {0,-11} | {1,-15} | {2,-15} | {3,7} | {4,4} | {5,4} | {6,4} |", "So Bao Danh", "Ho Ten", "Dia Chi","Uu Tien","Mon1", "Mon2", "Mon3");
					Console.WriteLine("----------------------------------------------------------------------------------");
					for (int i = 0; i < dsThiSinh.Count; i++) 
					{
						dsThiSinh[i].HienThiThongTin();
					}
					Console.WriteLine("----------------------------------------------------------------------------------");
					Console.Write("Press any key to continue . . . ");
					Console.ReadKey(true);
				} 
				else if (iLuaChon == 4)
				{
					Console.Write("Nhap So Bao Danh Can Tim : ");
					sSoBaoDanh = Console.ReadLine();
					Console.WriteLine("-------------------------------Tim Thi Sinh---------------------------------------");
					Console.WriteLine("| {0,-11} | {1,-15} | {2,-15} | {3,7} | {4,4} | {5,4} | {6,4} |", "So Bao Danh", "Ho Ten", "Dia Chi","Uu Tien","Mon1", "Mon2", "Mon3");
					Console.WriteLine("----------------------------------------------------------------------------------");
					for (int i = 0; i < dsThiSinh.Count; i++) 
					{
						if(dsThiSinh[i].SoBaoDanh == sSoBaoDanh)
						{
							dsThiSinh[i].HienThiThongTin();
						}
					}
					Console.WriteLine("----------------------------------------------------------------------------------");
					Console.Write("Press any key to continue . . . ");
					Console.ReadKey(true);
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