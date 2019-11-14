/*
 * Created by SharpDevelop.
 * User: VienDong
 * Date: 10/31/2019
 * Time: 2:11 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace QuanLyHocSinh
{
	/// <summary>
	/// Description of clsDiem.
	/// </summary>
	public class clsDiem
	{
		public string MSMH{get;set;}
		public string MSHS{get;set;}
		public double Diem{get;set;}
		public clsDiem()
		{
		}
		public void NhapDiem(List<clsMonHoc> plstMonHoc, List<clsHocSinh> plstHocSinh)
		{
			int iLuaChonMH = 0, iLuaChonHS = 0;
			if((plstHocSinh == null)||(plstMonHoc == null)||(plstHocSinh.Count == 0)||(plstMonHoc.Count == 0))
				return;
			clsMenu menuMonHoc = new clsMenu();
			clsMenu menuHocSinh = new clsMenu();
			
			foreach (clsMonHoc mh in plstMonHoc) 
			{
				menuMonHoc.AddItem(mh.MSMH);
			}
			
			iLuaChonMH = menuMonHoc.DisplayMenu();
			MSMH = plstMonHoc[iLuaChonMH].MSMH;
			
			foreach (clsHocSinh hs in plstHocSinh) 
			{
				menuHocSinh.AddItem(hs.MSHS + "-" + hs.HoTen);
			}
			iLuaChonHS = menuHocSinh.DisplayMenu();
			MSHS = plstHocSinh[iLuaChonHS].MSHS;
			
			Console.Write("Nhap diem mon hoc {0} cho hoc sinh {1}: ", MSMH, MSHS);
			Diem = double.Parse(Console.ReadLine());
		}
		public void InThongTin()
		{
			Console.WriteLine("MSMH: {0}, MSHS: {1}, Diem: {2}", MSMH,MSHS,Diem);
		}
	}
}
