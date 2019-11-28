/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 18/11/2019
 * Time: 8:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
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
			GameStatistics.Height = 1;
			GameStatistics.Width = 1;
			GameStatistics.Speed = 1;
			InitializeComponent();
			GameStatistics.Height = pbMap.Height;
			GameStatistics.Width = pbMap.Width;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			//UpdateGameStatistics();
			timer1.Start();
		}
		
		public void UpdateGameStatistics()
		{
			GameStatistics.Height = (pbMap.Height-2)/10;
			GameStatistics.Width = (pbMap.Width-2)/10;

			tbHeight.Text = GameStatistics.Height.ToString();
			tbWidth.Text = GameStatistics.Width.ToString();
			sbSpeed.Value = GameStatistics.Speed;
			Graphics g = pbMap.CreateGraphics();
			g.FillRectangle(Brushes.Gray,0,0,pbMap.Width,pbMap.Height);
			g.FillRectangle(Brushes.White,1,1,GameStatistics.Width*10,GameStatistics.Height*10);
		}
		
		void MainFormResize(object sender, EventArgs e)
		{
			UpdateGameStatistics();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			this.Width ++;
			UpdateGameStatistics();
		}
		
		void MainFormSizeChanged(object sender, EventArgs e)
		{
			UpdateGameStatistics();
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			UpdateGameStatistics();
		}
	}
}
