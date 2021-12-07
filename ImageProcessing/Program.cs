/*
 * Created by SharpDevelop.
 * User: Азриэль
 * Date: 07.12.2021
 * Time: 16:40
 */
using System;
using System.Windows.Forms;

namespace ImageProcessing
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
