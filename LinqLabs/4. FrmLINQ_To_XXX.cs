using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Starter
{
    public partial class FrmLINQ_To_XXX : Form
    {
        public FrmLINQ_To_XXX()
        {
            InitializeComponent();

        }
        private void button6_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //IEnumerable<IGrouping< string, int>> q = from n in nums
            //        group n by n % 2 == 0 ? "偶數" : "奇數";
            var q = from n in nums
                    group n by n % 2 == 0 ? "偶數" : "奇數" into g
                    select new { Mykey = g.Key,Mycount = g.Count(),Myavg = g.Average(),Mygroup = g};
            dataGridView1.DataSource = q.ToList();
            //=============================================
            foreach(var group in q)
            {
                string s = $"{group.Mykey}({group.Mycount})";
                TreeNode x = treeView1.Nodes.Add(s); //(group.Key.ToString());
                foreach (var iterm in group.Mygroup)
                {
                    x.Nodes.Add(iterm.ToString());
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //IEnumerable<IGrouping< string, int>> q = from n in nums
            //        group n by n % 2 == 0 ? "偶數" : "奇數";
            var q = from n in nums
                    group n by Mymeth(n) into g
                    select new { Mykey = g.Key, Mycount = g.Count(), Myavg = g.Average(), Mygroup = g };
            dataGridView1.DataSource = q.ToList();
            //=============================================
            foreach (var group in q)
            {
                string s = $"{group.Mykey}({group.Mycount})";
                TreeNode x = treeView1.Nodes.Add(s); //(group.Key.ToString());
                foreach (var iterm in group.Mygroup)
                {
                    x.Nodes.Add(iterm.ToString());
                }
            }
            //==========================================
            chart1.DataSource = q.ToList();
            chart1.Series[0].XValueMember = "Mykey";
            chart1.Series[0].YValueMembers = "Mycount";
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            chart1.Series[1].XValueMember = "Mykey";
            chart1.Series[1].YValueMembers = "Myavg";
            chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

        }
        private object Mymeth(int n)
        {
            if (n < 4)
                return "小";
            else if (n < 8)
                return "中";
            else
                return "大";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");
            System.IO.FileInfo[] files = dir.GetFiles();

            dataGridView2.DataSource = files.ToList();
            //foreach (var group in q)
            //{
            //    string s = $"{group.Mykey}({group.Mycount})";
            //    TreeNode x = treeView1.Nodes.Add(s); //(group.Key.ToString());
            //    foreach (var iterm in group.Mygroup)
            //    {
            //        x.Nodes.Add(iterm.ToString());
            //    }
            //}

            var q = from n in files
                    group n by n.Extension into g
                    orderby g.Count() descending
                    select new { Mykey = g.Key, MyExe = g.Count()};
            dataGridView1.DataSource = q.ToList();



        }

        private void FrmLINQ_To_XXX_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'dataSet1.Product' 資料表。您可以視需要進行移動或移除。
            this.productTableAdapter.Fill(this.dataSet1.Product);
            productsTableAdapter1.Fill(dataSet1.Products);
            categoriesTableAdapter1.Fill(dataSet1.Categories);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            var q = from n in dataSet1.Product
                    group n by n.SellStartDate.Year into g
                    orderby g.Count() descending
                    select new { Mykey = g.Key, MyExe = g.Count() };

            dataGridView1.DataSource = q.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");
            System.IO.FileInfo[] files = dir.GetFiles();

            var q = from n in files
                    let s = n.Extension
                    where s ==".exe"
                    select n;
            dataGridView1.DataSource = q.ToList();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int[] nums1 = { 1, 5, 9, 7, 4, 6, 8, 56, 48, 9, 563 };
            int[] nums2 = { 1, 53, 9, 78, 4, 6, 98, 5, 4, 98, 5 };
            IEnumerable<int> q = nums1.Intersect(nums2);
            q = nums2.Distinct();

            bool result = nums1.Any(n => n > 100);
            bool result2 = nums2.All(n => n >= 20);


            int N = nums1.First();
            int N2 = nums2.ElementAt(2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var q = from n in dataSet1.Products
                    group n by n.CategoryID into g
                    select new { CategoryID = g.Key, Ave = g.Average(n => n.UnitPrice) };

            dataGridView1.DataSource = q.ToList();
            //====================================

            var q2 = from c in dataSet1.Categories
                    join p in dataSet1.Products
                    on c.CategoryID equals p.CategoryID 
                    group p by c.CategoryName into g
                     select new { CategoryName = g.Key , Ave = g.Average(n => n.UnitPrice) };

            dataGridView2.DataSource = q2.ToList();
        }
    }
}
