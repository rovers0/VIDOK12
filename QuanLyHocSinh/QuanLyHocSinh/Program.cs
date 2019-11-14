/*
 * Created by SharpDevelop.
 * User: VienDong
 * Date: 10/31/2019
 * Time: 1:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace QuanLyHocSinh
{
	class Program
	{
		
		public static void Main(string[] args)
		{
			List<clsHocSinh> lstHocSinh = new List<clsHocSinh>();
			List<clsMonHoc> lstMonHoc = new List<clsMonHoc>();
			List<clsDiem> lstDiem = new List<clsDiem>();
			clsMenu menu = new clsMenu();
			int iLuaChon;
			string sSoBaoDanh = "";
			menu.AddItem("Nhap Hoc Sinh");
			menu.AddItem("Nhap Mon Hoc");
			menu.AddItem("Nhap Diem");
			menu.AddItem("Danh Sach Diem Theo Mon Hoc");
			menu.AddItem("Danh Sach Diem Theo Hoc Sinh");
			menu.AddItem("Thoat");
			
			do{
				iLuaChon = menu.DisplayMenu();
				if(iLuaChon==0)
				{
					clsHocSinh hs = new clsHocSinh();
					hs.NhapThongTin();
					lstHocSinh.Add(hs);
				}
				else if (iLuaChon == 1) 
				{
					clsMonHoc mh = new clsMonHoc();
					mh.NhapThongTin();
					lstMonHoc.Add(mh);
				} 
				else if (iLuaChon == 2) 
				{
					clsDiem diem = new clsDiem();
					diem.NhapDiem(lstMonHoc,lstHocSinh);
					lstDiem.Add(diem);
				} 
				else if (iLuaChon == 3) 
				{
					foreach (clsDiem diem in lstDiem) 
					{
						diem.InThongTin();
					}
					Console.ReadKey();
				} 
				else if (iLuaChon == 4)
				{
					foreach (var element in lstHocSinh) 
					{
						element.InThongTin();
					}
					Console.ReadKey(true);
				}
			}while (iLuaChon != 5);
		}
	}
}