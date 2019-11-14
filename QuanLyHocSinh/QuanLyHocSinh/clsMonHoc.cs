/*
 * Created by SharpDevelop.
 * User: VienDong
 * Date: 10/31/2019
 * Time: 2:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace QuanLyHocSinh
{
	/// <summary>
	/// Description of clsMonHoc.
	/// </summary>
	public class clsMonHoc
	{
		public string MSMH{get;set;}
		public string TenMH{get;set;}
		public string TenGiaoVien{get;set;}
		public clsMonHoc()
		{
		}
		public void NhapThongTin()
		{
			Console.Write("Nhap MSMH: ");
			MSMH = Console.ReadLine();
			Console.Write("Nhap Ten MH: ");
			TenMH = Console.ReadLine();
			Console.Write("Nhap Giao Vien: ");
			TenGiaoVien = Console.ReadLine();
		}
		public void InThongTin()
		{
			Console.WriteLine("MSMH: {0}, Ten MH: {1}, Ten Giao Vien: {2}", MSMH,TenMH,TenGiaoVien);
		}
	}
}
