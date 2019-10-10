/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 03/10/2019
 * Time: 1:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BaiTapSo4
{
	/// <summary>
	/// Description of clsThiSinh.
	/// </summary>
	public class clsThiSinh
	{
		protected string sSoBaoDanh,sHoTen,sDiaChi;
		protected int iUuTien;
		public string SoBaoDanh
		{
			get{
				return sSoBaoDanh;
			}
			set{
				sSoBaoDanh = value;
			}
		}
		public string HoTen{
			get{
				return sHoTen;
			}
			set{
				sHoTen = value;
			}
		}
		public string DiaChi
		{
			get{
				return sDiaChi;
			}
			set{
				sDiaChi = value;
			}
		}
		public int UuTien
		{
			get{
				return iUuTien;
			}
			set{
				iUuTien = value;
			}
		}
		public virtual void NhapThongTin()
		{
			Console.Write("Nhap So Bao Danh:");
			sSoBaoDanh = Console.ReadLine();
			Console.Write("Nhap Ho Ten:");
			sHoTen = Console.ReadLine();
			Console.Write("Nhap Dia Chi:");
			sDiaChi = Console.ReadLine();
			Console.Write("Nhap Uu Tien:");
			iUuTien = int.Parse(Console.ReadLine());
			
		}
		public virtual void HienThiThongTin()
		{
			Console.WriteLine("| {0,-11} | {1,-20} | {2,-20} | {3,7} |", sSoBaoDanh, sHoTen, sDiaChi,iUuTien);
		}
		public override string ToString()
		{
			return string.Format("| {0,-11} | {1,-20} | {2,-20} | {3,7} |", sSoBaoDanh, sHoTen, sDiaChi,iUuTien);
			//return string.Format("[clsThiSinh SSoBaoDanh={0}, SHoTen={1}, SDiaChi={2}, IUuTien={3}]", sSoBaoDanh, sHoTen, sDiaChi, iUuTien);
		}

		public clsThiSinh()
		{
		}
	}
}
