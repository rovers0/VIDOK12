/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 18/11/2019
 * Time: 8:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SnakeGame
{
	/// <summary>
	/// Description of GameStatistics.
	/// </summary>
	public class GameStatistics
	{
		public static int Width{get;set;}
		public static int Height{get;set;}
		public static int Speed{get;set;}
		public static bool GameIsRunning{get;set;}
		
		public GameStatistics()
		{
			Speed = 1;
			Width = 1;
			Height = 1;
		}
	}
}
