/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 18/11/2019
 * Time: 8:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SnakeGame
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
			this.components = new System.ComponentModel.Container();
			this.pbMap = new System.Windows.Forms.PictureBox();
			this.gbStatistics = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.sbSpeed = new System.Windows.Forms.HScrollBar();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tbHeight = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbWidth = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
			this.gbStatistics.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbMap
			// 
			this.pbMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pbMap.Location = new System.Drawing.Point(12, 12);
			this.pbMap.Name = "pbMap";
			this.pbMap.Size = new System.Drawing.Size(664, 552);
			this.pbMap.TabIndex = 0;
			this.pbMap.TabStop = false;
			// 
			// gbStatistics
			// 
			this.gbStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.gbStatistics.BackColor = System.Drawing.SystemColors.Control;
			this.gbStatistics.Controls.Add(this.groupBox3);
			this.gbStatistics.Controls.Add(this.groupBox2);
			this.gbStatistics.Controls.Add(this.groupBox1);
			this.gbStatistics.Location = new System.Drawing.Point(682, 12);
			this.gbStatistics.Name = "gbStatistics";
			this.gbStatistics.Size = new System.Drawing.Size(343, 552);
			this.gbStatistics.TabIndex = 1;
			this.gbStatistics.TabStop = false;
			this.gbStatistics.Text = "Game Statistics";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.sbSpeed);
			this.groupBox3.Location = new System.Drawing.Point(6, 78);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(331, 51);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Speed";
			// 
			// sbSpeed
			// 
			this.sbSpeed.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.sbSpeed.LargeChange = 1;
			this.sbSpeed.Location = new System.Drawing.Point(3, 23);
			this.sbSpeed.Maximum = 10;
			this.sbSpeed.Minimum = 1;
			this.sbSpeed.Name = "sbSpeed";
			this.sbSpeed.Size = new System.Drawing.Size(325, 25);
			this.sbSpeed.TabIndex = 0;
			this.sbSpeed.Value = 1;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tbHeight);
			this.groupBox2.Location = new System.Drawing.Point(182, 21);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(155, 51);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Height";
			// 
			// tbHeight
			// 
			this.tbHeight.Location = new System.Drawing.Point(6, 21);
			this.tbHeight.Name = "tbHeight";
			this.tbHeight.Size = new System.Drawing.Size(143, 22);
			this.tbHeight.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbWidth);
			this.groupBox1.Location = new System.Drawing.Point(6, 21);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(155, 51);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Width";
			// 
			// tbWidth
			// 
			this.tbWidth.Location = new System.Drawing.Point(6, 23);
			this.tbWidth.Name = "tbWidth";
			this.tbWidth.Size = new System.Drawing.Size(143, 22);
			this.tbWidth.TabIndex = 0;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1037, 576);
			this.Controls.Add(this.gbStatistics);
			this.Controls.Add(this.pbMap);
			this.Name = "MainForm";
			this.Text = "SnakeGame";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.SizeChanged += new System.EventHandler(this.MainFormSizeChanged);
			this.Resize += new System.EventHandler(this.MainFormResize);
			((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
			this.gbStatistics.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.HScrollBar sbSpeed;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox tbWidth;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tbHeight;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox gbStatistics;
		private System.Windows.Forms.PictureBox pbMap;
	}
}
