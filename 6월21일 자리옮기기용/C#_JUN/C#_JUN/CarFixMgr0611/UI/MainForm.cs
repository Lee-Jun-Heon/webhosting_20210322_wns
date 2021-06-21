using CarFixMgr0611.Common;
using CarFixMgr0611.UI;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarFixMgr0611
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
            CommUtil.initTheme(this);
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void custFixAdd_Click(object sender, EventArgs e)
        {
            new ReceiptForm().ShowDialog();
        }

        private void custFixView_Click(object sender, EventArgs e)
        {

        }

        private void custFixAdmin_Click(object sender, EventArgs e)
        {

        }

        private void custFixRand_Click(object sender, EventArgs e)
        {

        }

        private void custFixInfo_Click(object sender, EventArgs e)
        {

        }

        private void mainMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
