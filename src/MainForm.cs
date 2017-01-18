using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Web_Stats
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
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			
			
			string gtIp = textBox1.Text;
			try {
				
				WebTools.GetIP(gtIp, richTextBox1); // Call WebTools and get the ip checking tool.
				
			} catch (Exception e2) {
				MessageBox.Show("Code 100: Unable to locate address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			
			
			// Check to see if log.txt exists.
			if(File.Exists("log.txt")){
			   	
				File.AppendAllText("log.txt", richTextBox1.Text);
			   	
			} else {
				
				
				
				
				// If log.txt doesn't exist, ask the user if they want to create it.
				if(MessageBox.Show("Code 200: log.txt doesn't exist on this computer, do you want to create it?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) == DialogResult.Yes){
					
					File.Create("log.txt");
					
				} else {
					
					
					
				}
				
				
				
				
			}
			
			
		}
	}
}
