using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqLabs.作業
{
    public partial class HW_main : Form
    {
        public HW_main()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            HW_01 HW01 = new HW_01();
            HW01.MdiParent = this;
            HW01.WindowState = FormWindowState.Maximized;
            HW01.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            HW_02 HW02 = new HW_02();
            HW02.MdiParent = this;
            HW02.WindowState = FormWindowState.Maximized;
            HW02.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            HW_03 HW03 = new HW_03();
            HW03.MdiParent = this;
            HW03.WindowState = FormWindowState.Maximized;
            HW03.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            HW_04 HW04 = new HW_04();
            HW04.MdiParent = this;
            HW04.WindowState = FormWindowState.Maximized;
            HW04.Show();
        }
    }
}
