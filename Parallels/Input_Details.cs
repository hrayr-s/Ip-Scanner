using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parallels
{
    public partial class Input_Details : Form
    {
        public Input_Details()
        {
            InitializeComponent();
            this.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parallels.Monitor mm = new Parallels.Monitor();
            int[] k = new int[4];
            k[0] = Int32.Parse(ipfrom1.Text);
            k[1] = Int32.Parse(ipfrom2.Text);
            k[2] = Int32.Parse(ipfrom3.Text);
            k[3] = Int32.Parse(ipfrom4.Text);
            int[] k2 = new int[4];
            k2[0] = Int32.Parse(ipto1.Text);
            k2[1] = Int32.Parse(ipto2.Text);
            k2[2] = Int32.Parse(ipto3.Text);
            k2[3] = Int32.Parse(ipto4.Text);
            int t = Int32.Parse(threadsq.Text);
            mm.Show();
            mm.Activate();
            mm.start_load(k,k2,t);
            Thread.Sleep(2000);
            this.Hide();
            //this.Close();
        }
    }
}
