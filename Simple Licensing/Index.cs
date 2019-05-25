using Simple_Licensing.Utils;
using System;
using System.Net;
using System.Windows.Forms;

namespace Simple_Licensing
{
	class Index
	{
		[STAThread]
		static void Main(string[] args)
		{
			Init();
		}

		public static void Init()
		{
			WebClient wc = new WebClient();

			//Getting strings from an online file
			var result = wc.DownloadString("http://downloader.altervista.org/Simple-Licensing");

			//Checking if the online file contains our HWID
			if (result.Contains(IDs.GetHardDiskSerialNo()))
			{
				setResult("Success!");
				setColor(ConsoleColor.Green);
			}
			else
			{
				Clipboard.SetText(IDs.GetHardDiskSerialNo());
				setResult("You are not whitelisted - HWID COPIED!");
				setColor(ConsoleColor.Red);
			}
			Console.ReadLine();
		}

		public static void setResult(string result)
		{
			Console.WriteLine(result);
		}

		public static void setColor(ConsoleColor consoleColor)
		{
			Console.ForegroundColor = consoleColor;
		}
	}
}