using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace HalfLife2
{
    public partial class IDIOT : Form
    {

        string desktop = @"D:\Users\" + Environment.UserName + @"\Desktop\";
        string localFilename = @"D:\Users\" + Environment.UserName + @"\Desktop\installation.gif";

        public IDIOT()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "IDIOT";

            try
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile("https://media.tenor.com/images/cf7ab758e219d53145d7fbcd1f2e76d6/tenor.gif", localFilename);
                }

                // Over 200 is EVIL!!!!
                for (int i = 0; i < 5; i++)
                {
                    string num = desktop + i.ToString() + ".gif";
                    File.Copy(localFilename, num, true);
                }
            }
            catch
            {

            }
        }
    }
}
