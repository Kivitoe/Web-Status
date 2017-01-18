using System;
using System.Net;
using System.Windows.Forms;

namespace Web_Stats
{
	/// <summary>
	/// Tools for web addresses and IP addresses.
	/// </summary>
	public static class WebTools
	{
		/// <summary>
		/// Get the IP address for the input address.
		/// </summary>
		/// <param name="str">The input address</param>
		/// <param name="rtb">RichTextBox to print to</param>
		public static void GetIP(string str, RichTextBox rtb)
		{
			
			IPAddress addr = Dns.GetHostAddresses(str)[0];
			
			
			rtb.AppendText("IP address " + addr + " returned successfully. [" + str +"]\n");
			
			
		}
	}
}
