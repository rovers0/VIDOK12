/*
 * Created by SharpDevelop.
 * User: VienDong
 * Date: 11/14/2019
 * Time: 1:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BaiTapSoLon
{
	/// <summary>
	/// Description of clsBigInt.
	/// </summary>
	public class clsBigInt
	{
		string sValue;
		public string Value
		{
			get
			{
				return sValue;
			}
			set
			{
				if(CheckVaild(value))
				{
					sValue = value;
				}
				else
				{
					sValue = "0";
				}
			}
		}
		
		public static bool operator == (clsBigInt A, clsBigInt B)
		{
			bool bResult = false;
			if(A.Value.Length != B.Value.Length)
			{
				bResult = false;
			}
			else
			{
				for(int i = 0; i<A.Value.Length; i++)
				{
					if(A.Value.Substring(i,1) != B.Value.Substring(i,1))
					{
						bResult = false;
						break;
					}
					bResult = true;
				}
			}
			return bResult;
		}
		public static bool operator != (clsBigInt A, clsBigInt B)
		{
			bool bResult;
			if(A == B)
				bResult = false;
			else
				bResult = true;
			return bResult;
		}
		public static bool operator > (clsBigInt A, clsBigInt B)
		{
			bool bResult = false;
			int i;
			if(A.IsMinus() == true && B.IsMinus() == false)
			{
				bResult = false;
			}
			else if(A.IsMinus() == false && B.IsMinus() == true)
			{
				bResult = true;
			}
			else if(A.IsMinus() == true && B.IsMinus() == true)
			{
				if(A.Value.Length < B.Value.Length)
				{
					bResult = true;
				}
				else if (A.Value.Length > B.Value.Length)
				{
					bResult = false;
				}
				else //(A.Value.Length == B.Value.Length)
				{
					for(i = 1; i<A.Value.Length;i++)
					{
						if(int.Parse(A.Value.Substring(i,1)) > int.Parse(B.Value.Substring(i,1)) )
						{
							return false;
						}
						else if(int.Parse(A.Value.Substring(i,1)) < int.Parse(B.Value.Substring(i,1)) )
						{
							return true;
						}
					}
				}
			}
			else if(A.IsMinus() == false && B.IsMinus() == false)
			{
				if(A.Value.Length < B.Value.Length)
				{
					bResult = false;
				}
				else if (A.Value.Length > B.Value.Length)
				{
					bResult = true;
				}
				else //(A.Value.Length == B.Value.Length)
				{
					for(i = 0; i<A.Value.Length;i++)
					{
						if(int.Parse(A.Value.Substring(i,1)) > int.Parse(B.Value.Substring(i,1)) )
						{
							return true;
						}
						else if(int.Parse(A.Value.Substring(i,1)) < int.Parse(B.Value.Substring(i,1)) )
						{
							return false;
						}
					}
				}
			}
			return bResult;
		}
		public static bool operator < (clsBigInt A, clsBigInt B)
		{
			if(A>B || A == B)
				return false;
			else
				return true;
		}
		
		public static clsBigInt operator + (clsBigInt A, clsBigInt B)
		{
			int iLength = 0, iA, iB, iC, iMemory;
			clsBigInt C = new clsBigInt();
			string sTemp="";
			if(A.IsMinus()==false && B.IsMinus()==false)
			{
				if(A.Value.Length > B.Value.Length)
				{
					iLength = A.Value.Length;
				}
				else
				{
					iLength = B.Value.Length;
				}
				iMemory = 0;
				for(int i = 0; i<iLength;i++)
				{
					if(i<A.Value.Length)
					{
						iA = int.Parse( A.Value.Substring(A.Value.Length - i - 1, 1));
					}
					else
					{
						iA = 0;
					}
					
					if(i<B.Value.Length)
					{
						iB = int.Parse( B.Value.Substring(B.Value.Length - i - 1, 1));
					}
					else
					{
						iB = 0;
					}
					iC = iA + iB + iMemory;
					if(iC > 10)
					{
						sTemp = string.Format("{0}",iC % 10) + sTemp;
						iMemory = 1;
					}
					else
					{
						sTemp = string.Format("{0}",iC % 10) + sTemp;
						iMemory = 0;
					}
					C.Value = sTemp;
				}
				
			}
			else if(A.IsMinus()==true && B.IsMinus()==true)
			{
				clsBigInt D = A.ABS() + B.ABS();
				C.Value = "-" + D.Value;
			}
			else if(A.IsMinus()==false && B.IsMinus()==true)
			{
				C = A - B.ABS();
			}
			else if(A.IsMinus()==true && B.IsMinus()==false)
			{
				C = B - A.ABS();
			}
			return C;
		}
		
		public static clsBigInt operator - (clsBigInt A, clsBigInt B)
		{
			clsBigInt C = new clsBigInt();
			
			return C;
		}
		
		private bool CheckVaild(string psValue)
		{
			bool bResult = false;
			int iNumber;
			if(string.IsNullOrWhiteSpace(psValue))
			{
				return false;
			}
			//psValue co Length >= 1;
			if(psValue.Substring(0,1) == "-" || int.TryParse(psValue.Substring(0,1), out iNumber) )
			{
				bResult=true;
			}
			if(psValue.Length>1)
			{			
				for(int i = 1; i<psValue.Length;i++)
				{
					if(int.TryParse(psValue.Substring(i,1), out iNumber) == false)
					{
						bResult=false;
					}
				}
			}
			return bResult;
		}
		
		private bool IsMinus()
		{
			bool bResult = false;
			if(Value.Substring(0,1) == "-")
			{
				bResult = true;
			}
			return bResult;
		}
		
		public clsBigInt ABS()
		{
			clsBigInt result = new clsBigInt();
			if(IsMinus())
			{
				result.Value = Value.Substring(1,Value.Length -1);
			}
			else
			{
				result.Value = Value;
			}
			return result;
		}
		
		public clsBigInt()
		{
			Value = "0";
		}
		public clsBigInt(string value)
		{
			if(CheckVaild(value))
			{
				Value = value;
			}
			else
			{
				Value = "0";
			}
		}
		public clsBigInt(clsBigInt bigInt)
		{
			this.Value = bigInt.Value;
		}
		
	}
}
