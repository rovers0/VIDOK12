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

namespace QuanLyQuanCafe
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtLoginClick(object sender, System.EventArgs e)
		{
			string sMessage = string.Format("UserName={0}, Password = {1}", tbUserName.Text, tbPassword.Text);
			MessageBox.Show(sMessage);
		}
	}
}
