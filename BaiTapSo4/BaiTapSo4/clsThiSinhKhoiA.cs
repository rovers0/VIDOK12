/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 03/10/2019
 * Time: 2:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BaiTapSo4
{
	/// <summary>
	/// Description of clsThiSinhKhoiA.
	/// </summary>
	public class clsThiSinhKhoiA:clsThiSinh
	{
		protected double dDiemToan, dDiemLy, dDiemHoa;
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
		public double DiemLy
		{
			get{
				return dDiemLy;
			}
			set{
				dDiemLy = value;
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
			Console.Write("Nhap Diem Ly: ");
			dDiemLy = double.Parse(Console.ReadLine());
			Console.Write("Nhap Diem Hoa: ");
			dDiemHoa = double.Parse(Console.ReadLine());
		}
		public override void HienThiThongTin()
		{
			Console.WriteLine("| {0,-11} | {1,-15} | {2,-15} | {3,7} | {4,4} | {5,4} | {6,4} |", sSoBaoDanh, sHoTen, sDiaChi,iUuTien,dDiemToan,dDiemLy,dDiemHoa);
		}
		public override string ToString()
		{
			return string.Format("| {0,-11} | {1,-18} | {2,-18} | {3,7} | {4,4} | {5,4} | {6,4} |", sSoBaoDanh, sHoTen, sDiaChi,iUuTien,dDiemToan,dDiemLy,dDiemHoa);
		}

		public void PhuongThucA()
		{
			Console.WriteLine("Phuong Thuc A");
		}
		public clsThiSinhKhoiA()
		{
			
		}
	}
}
