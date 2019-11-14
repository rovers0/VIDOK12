/*
 * Created by SharpDevelop.
 * User: VienDong
 * Date: 10/31/2019
 * Time: 1:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace QuanLyHocSinh
{
	/// <summary>
	/// Description of clsHocSinh.
	/// </summary>
	public class clsHocSinh
	{
		string sMSHS, sHoTen, sLop;
		public string MSHS
		{
			get
			{
				return sMSHS;
			}
			set
			{
				sMSHS = value;
			}
		}
		public string HoTen
		{
			get
			{
				return sHoTen;
			}
			set
			{
				sHoTen = value;
			}
		}
		public string Lop
		{
			get
			{
				return sLop;
			}
			set
			{
				sLop = value;
			}
		}
		public clsHocSinh()
		{
		}
		public void NhapThongTin()
		{
			Console.Write("Nhap MSSH: ");
			sMSHS = Console.ReadLine();
			Console.Write("Nhap Ho Ten: ");
			sHoTen = Console.ReadLine();
			Console.Write("Nhap Lop: ");
			sLop = Console.ReadLine();
		}
		public void InThongTin()
		{
			Console.WriteLine("MSSH: {0}, Ho Ten: {1}, Lop: {2}", sMSHS,sHoTen,sLop);
		}
	}
}
