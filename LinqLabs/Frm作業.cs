using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqLabs
{
    public partial class Frm作業 : Form
    {
        public Frm作業()
        {
            InitializeComponent();
            ordersTableAdapter1.Fill(DsOrder.Orders);
            order_DetailsTableAdapter1.Fill(DsOrder.Order_Details);
        }
        private void Frm作業_Load(object sender, EventArgs e)
        {
            num = int.Parse(textBox1.Text);

            var O_show = DsOrder.Orders.GroupBy(o => o.OrderDate.Year);
            //篩選資料表中的年份
            dataGridView1.DataSource = O_show.ToList();
            //將資料顯示在dataGridView1
            foreach (DataGridViewRow R in dataGridView1.Rows)
                Cb_year.Items.Add(R.Cells[0].Value.ToString());
            //將dataGridView1的資料匯入combo box
            dataGridView1.DataSource = null;
            //清除dataGridView1的值

            //foreach (var R in O_show)
            //    Cb_year.Items.Add(R);
            //使用此方式會使帶出的值非int
        }
        int front, num, back;
        private void btn_DataShow(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            var O_show = DsOrder.Orders;
            var Od_show = DsOrder.Order_Details;
            dataGridView1.DataSource = O_show.Take(num).ToList();
            dataGridView2.DataSource = Od_show.Take(num).ToList();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (Cb_year.Text == "")
            {
                MessageBox.Show("請選擇年份");
                return;
            }
            groupBox1.Enabled = true;

            var O_show = DsOrder.Orders.Where(o => o.OrderDate.Year.ToString() == Cb_year.Text);
            //var Od_show = DsOrder.Order_Details.Join(DsOrder.Orders, DsOrder.Order_Details, DsOrder.Order_Details => new { })
            //var O_show = from o in DsOrder.Orders
            //             where o.OrderDate.Year.ToString() == Cb_year.Text
            //             select o;
            var Od_show = from od in DsOrder.Order_Details
                          join o in DsOrder.Orders
                          on od.OrderID equals o.OrderID
                          where o.OrderDate.Year.ToString() == Cb_year.Text
                          select od;

            dataGridView1.DataSource = O_show.Take(num).ToList();
            dataGridView2.DataSource = Od_show.Take(num).ToList();
            //選取特定條件的資料
        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");
            System.IO.FileInfo[] files = dir.GetFiles();
            this.dataGridView1.DataSource = files;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");
            System.IO.FileInfo[] files = dir.GetFiles();
            var F_show = from f in files
                         where f.CreationTime.Year == 2019
                         select f;
            dataGridView1.DataSource = F_show.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");
            System.IO.FileInfo[] files = dir.GetFiles();
            var F_show = from f in files
                         where f.Length > 3000000
                         orderby f.Length
                         select f;
            dataGridView1.DataSource = F_show.ToList();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            page(0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            page(1);

        }
        private void button9_Click(object sender, EventArgs e)
        {
            num = int.Parse(textBox1.Text);
        }
        void page(int N) 
        {
            back = num;
            if (N == 1)
            {
                front += num;
                if (DsOrder.Orders.Rows.Count <= front)
                {
                    front -= num;
                    back = DsOrder.Orders.Rows.Count - front;
                    MessageBox.Show("資料已顯示到底");
                }
            }
            else if (N == 0 && front >= num)
            {
                front -= num;
            }
            else
                MessageBox.Show("資料已顯示到頂");
            //判定是上/下頁及輸入值及是否到達資料極限(頂及尾)
            var O_show = from o in DsOrder.Orders
                         select o;

            var Od_show = from od in DsOrder.Order_Details
                          select od;

            dataGridView1.DataSource = O_show.Skip(front).Take(num).ToList();
            dataGridView2.DataSource = Od_show.Skip(front).Take(num).ToList();
        }


    }
}
