using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProcesiiiiV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInternet_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe");

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Process.Start("excel.exe");
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            Process.Start("winword.exe");
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("chrome.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = "web2.ss-zcrnje-rovinj.skole.hr";
            Process.Start(startInfo);

        }
    }
}
