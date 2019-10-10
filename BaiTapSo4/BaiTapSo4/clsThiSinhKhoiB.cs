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
	/// Description of clsThiSinhKhoiB.
	/// </summary>
	public class clsThiSinhKhoiB:clsThiSinh
	{
		protected double dDiemToan, dDiemSinh, dDiemHoa;
		public double DiemToan
		{
			get{
				return dDiemToan;
			}
			set
			{
				dDiemToan = value;
			}
		}
		public double DiemSinh
		{
			get{
				return dDiemSinh;
			}
			set{
				dDiemSinh = value;
			}
		}
		public double DiemHoa{
			get{
				return dDiemHoa;
			}
			set{
				dDiemHoa = value;
			}
		}
		public override void NhapThongTin()
		{
			base.NhapThongTin();
			Console.Write("Nhap Diem Toan: ");
			dDiemToan = double.Parse(Console.ReadLine());
			Console.Write("Nhap Diem Sinh: ");
			dDiemSinh = double.Parse(Console.ReadLine());
			Console.Write("Nhap Diem Hoa: ");
			dDiemHoa = double.Parse(Console.ReadLine());
		}
		public override void HienThiThongTin()
		{
			Console.WriteLine("| {0,-11} | {1,-18} | {2,-18} | {3,7} | {4,4} | {5,4} | {6,4} |", sSoBaoDanh, sHoTen, sDiaChi,iUuTien,dDiemToan,dDiemSinh,dDiemHoa);
		}
		public override string ToString()
		{
			return string.Format("| {0,-11} | {1,-18} | {2,-18} | {3,7} | {4,4} | {5,4} | {6,4} |", sSoBaoDanh, sHoTen, sDiaChi,iUuTien,dDiemToan,dDiemSinh,dDiemHoa);
		}

		public clsThiSinhKhoiB()
		{
		}
	}
}
