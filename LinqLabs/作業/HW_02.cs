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
    public partial class HW_02 : Form
    {
        public HW_02()
        {
            InitializeComponent();
            productPhotoTableAdapter1.Fill(dataSet11.ProductPhoto);
            int[] nums = { 1, 2, 3, 4, };
            foreach (int n in nums)
                Q_search.Items.Add(n);

            var O_show = dataSet11.ProductPhoto.OrderBy(o => o.ModifiedDate).GroupBy(o => o.ModifiedDate.Year);
            //篩選資料表中的年份
            dataGridView1.DataSource = O_show.ToList();
            //將資料顯示在dataGridView1
            foreach (DataGridViewRow R in dataGridView1.Rows)
                Y_search.Items.Add(R.Cells[0].Value.ToString());
            //將dataGridView1的資料匯入combo box
            dataGridView1.DataSource = null;
        }

        int _positon;
        private void button1_Click(object sender, EventArgs e)
        {
            var PP = from n in dataSet11.ProductPhoto
                     select n;
            dataGridView1.DataSource = PP.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Y_search.Text == "")
            {
                MessageBox.Show("欄位不得為空值");
                return;
            }
            var PP = dataSet11.ProductPhoto.OrderBy(n => n.ModifiedDate).Where(n => n.ModifiedDate.Year.ToString() == Y_search.Text);
            dataGridView1.DataSource = PP.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Q_search.Text == "")
            {
                MessageBox.Show("欄位不得為空值");
                return;
            }
            var PP = dataSet11.ProductPhoto.OrderBy(n => n.ModifiedDate).Where(n => Quarter(n.ModifiedDate.Month).ToString() == Q_search.Text);

            dataGridView1.DataSource = PP.ToList();
        }
        public int Quarter(int Q)
        {
            if (Q < 4 && Q > 0)
                return 1;
            else if (Q < 7)
                return 2;
            else if (Q < 10)
                return 3;
            else if (Q < 13)
                return 4;

            return 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var PP = dataSet11.ProductPhoto.OrderBy(n => n.ModifiedDate).Where(n => n.ModifiedDate > dateTimePicker1.Value && n.ModifiedDate < dateTimePicker2.Value);
            dataGridView1.DataSource = PP.ToList();

        }

    }
}


