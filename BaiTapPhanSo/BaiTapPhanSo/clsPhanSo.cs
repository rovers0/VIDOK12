/*
 * Created by SharpDevelop.
 * User: C5-D01
 * Date: 9/12/2019
 * Time: 3:40 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BaiTapPhanSo
{
	/// <summary>
	/// Description of clsPhanSo.
	/// </summary>
	public class clsPhanSo
	{
		public int iTuSo, iMauSo;
		public static int USCLN(int a, int b)
		{
			a = Math.Abs(a);
			b = Math.Abs(b);
			if (a == b)
				return a;
			if (a > b)
				return USCLN(b, a - b);
			else
				return USCLN(a, b - a);
		}
		public void ToiGian()
		{
			int i = USCLN(iTuSo, iMauSo);
			iTuSo = iTuSo / i;
			iMauSo = iMauSo / i;
		}
		public static clsPhanSo Cong(clsPhanSo pA, clsPhanSo pB)
		{
			clsPhanSo psC = new clsPhanSo();
			psC.iTuSo = pA.iTuSo* pB.iMauSo + pA.iMauSo * pB.iTuSo;
			psC.iMauSo = pA.iMauSo * pB.iMauSo;
			psC.ToiGian();
			return psC;
		}
		public static clsPhanSo Tru(clsPhanSo pA, clsPhanSo pB)
		{
			clsPhanSo psC = new clsPhanSo();
			psC.iTuSo = pA.iTuSo* pB.iMauSo - pA.iMauSo * pB.iTuSo;
			psC.iMauSo = pA.iMauSo * pB.iMauSo;
			psC.ToiGian();
			return psC;
		}
		public static clsPhanSo Nhan(clsPhanSo pA, clsPhanSo pB)
		{
			clsPhanSo psC = new clsPhanSo();
			psC.iTuSo = pA.iTuSo* pB.iTuSo;
			psC.iMauSo = pA.iMauSo * pB.iMauSo;
			psC.ToiGian();
			return psC;
		}
		public static clsPhanSo Chia(clsPhanSo pA, clsPhanSo pB)
		{
			if(pB.iTuSo == 0)
			{
				throw new Exception("Khong the chia cho 0");
				return null;
			}
			clsPhanSo psC = new clsPhanSo();
			psC.iTuSo = pA.iTuSo* pB.iMauSo;
			psC.iMauSo = pA.iMauSo * pB.iTuSo;
			psC.ToiGian();
			return psC;
		}
		public static clsPhanSo operator +(clsPhanSo pA, clsPhanSo pB)
		{
			return clsPhanSo.Cong(pA, pB);
		}
		public void In()
		{
			Console.WriteLine("{0} / {1}" , this.iTuSo, this.iMauSo);
		}
		public clsPhanSo()
		{
			iTuSo = 0;
			iMauSo = 1;
		}
		public clsPhanSo(int piTuSo, int piMauSo)
		{
			if(piMauSo == 0)
			{
				iTuSo = 0;
				iMauSo = 1;
			}
			else
			{
				iTuSo = piTuSo;
				iMauSo = piMauSo;
			}
		}
		public clsPhanSo(clsPhanSo pA)
		{
			this.iTuSo = pA.iTuSo;
			this.iMauSo = pA.iMauSo;
		}
	}
}
