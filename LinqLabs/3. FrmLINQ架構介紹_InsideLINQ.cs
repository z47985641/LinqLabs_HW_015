using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Starter
{
    public partial class FrmLINQ架構介紹_InsideLINQ : Form
    {
        public FrmLINQ架構介紹_InsideLINQ()
        {
            InitializeComponent();
            productsTableAdapter1.Fill(dataSet11.Products);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            list.Add(0);
            list.Add(1);

            var q = from n in list.Cast<int>()//.Cast 將非泛型轉成可帶出的型態
                    select new { N = n };// new{} 若不使用會造成沒有欄位名稱(屬性)無法輸出

            dataGridView1.DataSource = q.ToList();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            var q = (from n in dataSet11.Products
                     orderby n.UnitsInStock descending
                     select n).Take(5);

            dataGridView1.DataSource = q.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            listBox1.Items.Add("Sum="+nums.Sum());
            listBox1.Items.Add("Count="+nums.Count());
            listBox1.Items.Add("Max="+nums.Max());
            listBox1.Items.Add("Min="+nums.Min());
            listBox1.Items.Add("Average="+nums.Average());

            listBox1.Items.Add($"UnitPrice Average =  {dataSet11.Products.Average(p => p.UnitPrice):c2}");
            listBox1.Items.Add("UnitsInStock Max = " + dataSet11.Products.Max(p => p.UnitsInStock));

        }
    }
}