/*
 * Created by SharpDevelop.
 * User: VienDong
 * Date: 10/17/2019
 * Time: 1:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Security.Cryptography;
using System.Text;

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
		public clsUser(string psUserName)
		{
			sUserName = psUserName;
		}
		public void SetPassword(string psPassword)
		{
			sPassword = ComputeSha256Hash(psPassword);
		}
		string ComputeSha256Hash(string rawData)  
        {  
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())  
            {  
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));  
  
                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();  
                for (int i = 0; i < bytes.Length; i++)  
                {  
                    builder.Append(bytes[i].ToString("x2"));  
                }  
                return builder.ToString();  
            }  
        }  
		
		public bool CheckPassword(string psPassword)
		{
			bool bResult = false;
			string sHash = ComputeSha256Hash(psPassword);
			if(sHash == sPassword)
				bResult = true;
			return bResult;
		}
	}
}
