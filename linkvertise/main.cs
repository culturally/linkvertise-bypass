using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace linktree
{
    public partial class bypass : Form
    {
        public bypass()
        {
            InitializeComponent();
        }

        private void bypass_Load(object sender, EventArgs e)
        {

        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }

        private void bypassb_Click(object sender, EventArgs e)
        {
            string url = input.Text;
            string api = "https://soud.me/api/Bypass?url=" + url;

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(api);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            Stream resStream = res.GetResponseStream();
            StreamReader reader = new StreamReader(resStream, Encoding.UTF8);
            String resString = reader.ReadToEnd();
            if (resString.Contains("200") == true)
            {
                DialogResult result = MessageBox.Show("URL Successfuly bypassed", "Success!");
                bypassedtext.Visible = true;
                bypassedlabel.Visible = true;
                bypassedtext.Text = resString;
            }
            else if (resString.Contains("404") == true)
            {
                MessageBox.Show("Invalid URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
