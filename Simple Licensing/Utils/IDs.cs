﻿using System;
using System.Management;

namespace Simple_Licensing.Utils
{
	class IDs
	{

		//Thanks to: https://stackoverflow.com/a/36125728
		public static string GetHardDiskSerialNo()
		{
			ManagementClass mangnmt = new ManagementClass("Win32_LogicalDisk");
			ManagementObjectCollection mcol = mangnmt.GetInstances();
			string result = "";
			foreach (ManagementObject strt in mcol)
			{
				result += Convert.ToString(strt["VolumeSerialNumber"]);
			}
			return result;
		}
	}
}