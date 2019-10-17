/*
 * Created by SharpDevelop.
 * User: VienDong
 * Date: 10/17/2019
 * Time: 1:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace QuanLyQuanCafe
{
	/// <summary>
	/// Description of clsUser.
	/// </summary>
	
	public class clsUser
	{
		string sUserName, sPassword;
		public string UserName
		{
			get{
				return sUserName;
			}
			set {
				sUserName = value;
			}
		}
		public string Password{
			get{
				return sPassword;
			}
			set{
				sPassword = value;
			}
		}
		public clsUser()
		{
		}
	}
}
