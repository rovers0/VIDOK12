/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 10/10/2019
 * Time: 3:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Web.Script.Serialization;

namespace QuanLyQuanCafe
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		List<clsUser> listUser;
		string sFileName = @"D:\user.json";
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			listUser = new List<clsUser>();
			if(System.IO.File.Exists(sFileName))
			{
				string sJson;
				sJson = System.IO.File.ReadAllText(sFileName);
				if(sJson != null)
				{
					JavaScriptSerializer serial = new JavaScriptSerializer();
					listUser = serial.Deserialize<List<clsUser>>(sJson);
				}
			}
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtLoginClick(object sender, System.EventArgs e)
		{
			//string sMessage = string.Format("UserName={0}, Password = {1}", tbUserName.Text, tbPassword.Text);
			//MessageBox.Show(sMessage);
			foreach (var user in listUser) 
			{
				if(user.UserName == tbUserName.Text && user.CheckPassword(tbPassword.Text) == true)
				{
					MessageBox.Show("Login ok");
					return;
				}
			}
			MessageBox.Show("Login fail");
		}
		
		void BtAddUserClick(object sender, EventArgs e)
		{
//			clsUser newUser = new clsUser();
//			newUser.UserName = tbUserName.Text;
//			newUser.Password = tbPassword.Text;
			clsUser newUser = new clsUser(tbUserName.Text);
			newUser.SetPassword(tbPassword.Text);
			listUser.Add(newUser);
			JavaScriptSerializer serial = new JavaScriptSerializer();
			string sJson = serial.Serialize(listUser);
			MessageBox.Show(sJson);
			System.IO.File.WriteAllText(sFileName, sJson);
		}
		
		void BtCancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
