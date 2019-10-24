/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 10/10/2019
 * Time: 3:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace QuanLyQuanCafe
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.tbUserName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.btLogin = new System.Windows.Forms.Button();
			this.btCancel = new System.Windows.Forms.Button();
			this.btAddUser = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(36, 26);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "UserName";
			// 
			// tbUserName
			// 
			this.tbUserName.Location = new System.Drawing.Point(106, 26);
			this.tbUserName.Margin = new System.Windows.Forms.Padding(2);
			this.tbUserName.Name = "tbUserName";
			this.tbUserName.Size = new System.Drawing.Size(201, 20);
			this.tbUserName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(36, 61);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "Password";
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(106, 58);
			this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.Size = new System.Drawing.Size(201, 20);
			this.tbPassword.TabIndex = 3;
			// 
			// btLogin
			// 
			this.btLogin.Location = new System.Drawing.Point(36, 109);
			this.btLogin.Margin = new System.Windows.Forms.Padding(2);
			this.btLogin.Name = "btLogin";
			this.btLogin.Size = new System.Drawing.Size(74, 32);
			this.btLogin.TabIndex = 4;
			this.btLogin.Text = "Login";
			this.btLogin.UseVisualStyleBackColor = true;
			this.btLogin.Click += new System.EventHandler(this.BtLoginClick);
			// 
			// btCancel
			// 
			this.btCancel.Location = new System.Drawing.Point(232, 109);
			this.btCancel.Margin = new System.Windows.Forms.Padding(2);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(75, 32);
			this.btCancel.TabIndex = 5;
			this.btCancel.Text = "Cancel";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new System.EventHandler(this.BtCancelClick);
			// 
			// btAddUser
			// 
			this.btAddUser.Location = new System.Drawing.Point(131, 109);
			this.btAddUser.Name = "btAddUser";
			this.btAddUser.Size = new System.Drawing.Size(76, 32);
			this.btAddUser.TabIndex = 6;
			this.btAddUser.Text = "Add User";
			this.btAddUser.UseVisualStyleBackColor = true;
			this.btAddUser.Click += new System.EventHandler(this.BtAddUserClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(353, 178);
			this.Controls.Add(this.btAddUser);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.btLogin);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbUserName);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btAddUser;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.Button btLogin;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbUserName;
		private System.Windows.Forms.Label label1;
		
		
	}
}
