/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 03/10/2019
 * Time: 3:50 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace BaiTapSo4
{
	/// <summary>
	/// Description of clsMenu.
	/// </summary>
	public class clsMenu
	{
		List<string> Items;
		int index;
		public clsMenu()
		{
			Items = new List<string>();
			index = 0;
		}
		public void AddItem(string psItem)
		{
			Items.Add(psItem);
		}
		public int DisplayMenu()
		{
			if(Items.Count == 0)
			{
				Console.WriteLine("Items is null");
				return -1;
			}
			else
			{
				ConsoleKey key;
				do{
					DisplayItem();
					key = Console.ReadKey().Key;
					if(key == ConsoleKey.UpArrow)
					{
						index = index - 1;
						if (index < 0)
							index = Items.Count - 1;
					}
					else if (key == ConsoleKey.DownArrow) {
						index = index + 1;
						if (index == Items.Count)
							index = 0;
					}
				}while (key != ConsoleKey.Enter);
				return index;
			}
		}
		private void DisplayItem()
		{
			Console.Clear();
			for (int i = 0; i < Items.Count; i++) 
			{
				if(i == index)
				{
					Console.WriteLine("* {1}.{0} *",Items[i],i+1);
				}
				else
				{
					Console.WriteLine("  {1}.{0}  ",Items[i],i+1);
				}
			}
		}
	}
}
