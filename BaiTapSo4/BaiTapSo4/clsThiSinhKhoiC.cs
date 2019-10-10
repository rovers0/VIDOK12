/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 03/10/2019
 * Time: 3:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BaiTapSo4
{
	/// <summary>
	/// Description of clsThiSinhKhoiC.
	/// </summary>
	public class clsThiSinhKhoiC:clsThiSinh
	{
		protected double dDiemVan, dDiemSu, dDiemDia;
		public double DiemVan
		{
			get{
				return dDiemVan;
			}
			set
			{
				dDiemVan = value;
			}
		}
		public double DiemSu
		{
			get{
				return dDiemSu;
			}
			set{
				dDiemSu = value;
			}
		}
		public double DiemDia{
			get{
				return dDiemDia;
			}
			set{
				dDiemDia = value;
			}
		}
		public override void NhapThongTin()
		{
			base.NhapThongTin();
			Console.Write("Nhap Diem Van: ");
			dDiemVan = double.Parse(Console.ReadLine());
			Console.Write("Nhap Diem Su: ");
			dDiemSu = double.Parse(Console.ReadLine());
			Console.Write("Nhap Diem Dia: ");
			dDiemDia = double.Parse(Console.ReadLine());
		}
		public override void HienThiThongTin()
		{
			Console.WriteLine("| {0,-11} | {1,-18} | {2,-18} | {3,7} | {4,4} | {5,4} | {6,4} |", sSoBaoDanh, sHoTen, sDiaChi,iUuTien,dDiemVan,dDiemSu,dDiemDia);
		}
		public override string ToString()
		{
			return string.Format("| {0,-11} | {1,-18} | {2,-18} | {3,7} | {4,4} | {5,4} | {6,4} |", sSoBaoDanh, sHoTen, sDiaChi,iUuTien,dDiemVan,dDiemSu,dDiemDia);
		}

		public clsThiSinhKhoiC()
		{
		}
	}
}
