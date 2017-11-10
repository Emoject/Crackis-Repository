using System;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using System.Drawing;

namespace Crackis
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		private void InteractionComponent()
		{
			string[] chars = 
			{"A","B","C","D","E","F","G","H","I","J","K",
			"L","M","N","O","P","Q","R","S","T","U","V",
			"W","X","Y","Z","a","b","c","d","e","f","g",
			"h","i","j","k","l","m","n","o","p","q","r",
			"s","t","u","v","w","x","y","z"};
			int[] nums = {1,2,3,4,5,6,7,8,9,0};
			var u = richTextBox1.Text;
			Random random = new Random();
			int start1 = random.Next(20,chars.Length);
			int start2 = random.Next(7,nums.Length);
			int start3 = random.Next(15,chars.Length);
			int start4 = random.Next(5,nums.Length);
			int start5 = random.Next(28,chars.Length);
			#region encryption-process-1
			string i = chars[start1];
			int x = nums[start2];
			int y = nums[start4];
			string z = chars[start3];
			string a = chars[start5];
			string enrandom = i+x+y+z+a+i;
			var interself = enrandom;
			if (u == enrandom)
			{
				MessageBox.Show("Yes, it is correct");
			}else
			{	
				MessageBox.Show("No, it is not correct");
			}
			#endregion
		}
		void Button1Click(object sender, EventArgs e)
		{
			InteractionComponent();
		}
	}
}
