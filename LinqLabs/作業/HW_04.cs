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
    public partial class HW_04 : Form
    {
        public HW_04()
        {
            InitializeComponent();
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");
            files = dir.GetFiles();
            productsTableAdapter1.Fill(nvDataSet1.Products);
            ordersTableAdapter1.Fill(nvDataSet1.Orders);
            order_DetailsTableAdapter1.Fill(nvDataSet1.Order_Details);
            employeesTableAdapter1.Fill(nvDataSet1.Employees);

        }

        NorthwindEntities2 dbContext = new NorthwindEntities2();

        private void int分三群NoLINQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            int[] nums = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            var q = from p in nums
                    group p by XXXXXX(p) into g
                    select new { mykey = g.Key, mygroup = g };

            foreach (var n in q)
            {
                string first = $"{n.mykey}({n.mygroup.Count()})";
                TreeNode X = treeView1.Nodes.Add(first);
                foreach (var iterm in n.mygroup)
                {
                    X.Nodes.Add(iterm.ToString());
                }
            }
        }

        private string XXXXXX(decimal n)
        {
            if (n >= 60)
                return "高";
            else if (n > 20 && n < 60)
                return "中";
            else
                return "低";
        }

        System.IO.FileInfo[] files;

        private void 依檔案大小分組檔案大小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var F_show = files.OrderByDescending(f => f.Length);
            dataGridView1.DataSource = F_show.ToList();
        }

        private void 依年分組檔案大小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var F_show = files.OrderByDescending(f => f.CreationTime.Year);
            dataGridView1.DataSource = F_show.ToList();
        }

        private void nWProducts低中高價產品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            var q = from p in nvDataSet1.Products
                    group p by XXXXXX(p.UnitPrice) into g
                    select new { mykey = g.Key, mygroup = g };

            foreach (var n in q)
            {
                string first = $"{n.mykey}({n.mygroup.Count()})";
                TreeNode X = treeView1.Nodes.Add(first);
                foreach (var iterm in n.mygroup)
                {
                    X.Nodes.Add(iterm.ProductName.ToString());
                }
            }
        }

        private void ordersGroupBy年ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var q = nvDataSet1.Orders.GroupBy(n => n.OrderDate.Year);
            dataGridView1.DataSource = q.ToList();
        }

        private void ordersGroupBy年月ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            var q = from p in nvDataSet1.Orders
                    group p by p.OrderDate.Year into g
                    select new { mykey = g.Key, mygroup = g };

            var q2 = from p in nvDataSet1.Orders
                     orderby p.OrderDate.Month
                     group p by p.OrderDate.Month into g
                     select new { mykey = g.Key, mygroup = g };

            foreach (var n in q)
            {
                string first = $"{n.mykey} 年 ({n.mygroup.Count()})";
                TreeNode X = treeView1.Nodes.Add(first);
                foreach (var p in q2)
                {
                    string sec = $"{p.mykey} 月 ({p.mygroup.Count()})";
                    TreeNode X2 = X.Nodes.Add(sec);
                    foreach (var iterm in p.mygroup)
                    {
                        X2.Nodes.Add(iterm.OrderID.ToString());
                    }
                }

            }
        }
        private void 銷售最好的top5業務員ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            var q3 = from o in nvDataSet1.Orders
                     join od in nvDataSet1.Order_Details
                     on o.OrderID equals od.OrderID
                     group od by od.OrderID into p
                     orderby p.Key descending
                     select new { orderID = p.Key, TotalPrice = p.Sum(o => o.UnitPrice * o.Quantity) };

            var q = from p in q3
                    join o in nvDataSet1.Orders
                    on p.orderID equals o.OrderID
                    join ee in nvDataSet1.Employees
                    on o.EmployeeID equals ee.EmployeeID
                    orderby o.OrderDate
                    select new { Sales = ee.FirstName, year = o.OrderDate.Year, myprice = p.TotalPrice };

            var s1 = from o in q
                     group o by o.Sales into g
                     orderby g.Sum(o => o.myprice) descending
                     select new { Sales = g.Key, myprice = $"{g.Sum(o => o.myprice):C2}" };

            dataGridView1.DataSource = s1.Take(5).ToList();
        }


        private void nW產品有任何一筆單價大於300ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var q = nvDataSet1.Products.Where(o => o.UnitPrice > 100);
            dataGridView1.DataSource = q.ToList();
        }

        private void nW產品最高單價前5筆包括類別名稱ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var q = from n in dbContext.Products
                    join p in dbContext.Categories
                    on n.CategoryID equals p.CategoryID
                    orderby n.UnitPrice descending
                    select new { p.CategoryName, n.UnitPrice };
            dataGridView1.DataSource = q.Take(5).ToList();
        }


        private void bySelelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            var q3 = from o in nvDataSet1.Orders
                     join od in nvDataSet1.Order_Details
                     on o.OrderID equals od.OrderID
                     group od by od.OrderID into p
                     orderby p.Key descending
                     select new { orderID = p.Key, TotalPrice = p.Sum(o => o.UnitPrice * o.Quantity) };

            var q = from p in q3
                    join o in nvDataSet1.Orders
                    on p.orderID equals o.OrderID
                    join ee in nvDataSet1.Employees
                    on o.EmployeeID equals ee.EmployeeID
                    orderby o.OrderDate
                    select new { Sales = ee.FirstName, year = o.OrderDate.Year, myprice = p.TotalPrice };

            var s1 = from o in q 
                     group o by o.Sales into g
                     orderby g.Sum(o => o.myprice) descending
                     select new { Sales = g.Key, myprice = $"{g.Sum(o => o.myprice):C2}" };
            
            foreach (var n in s1)
            {
                string first = $"{n.Sales}個人總銷售量 : {n.myprice:C2}";
                TreeNode X = treeView1.Nodes.Add(first);
            }
        }

        private void byYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var q = from o in nvDataSet1.Orders
                     join od in nvDataSet1.Order_Details
                     on o.OrderID equals od.OrderID
                     group od by od.OrderID into p
                     orderby p.Key descending
                     select new { orderID = p.Key, TotalPrice = p.Sum(o => o.UnitPrice * o.Quantity) };
            var q2 = from o in q
                     join od in nvDataSet1.Orders
                     on o.orderID equals od.OrderID
                     select new { Year = od.OrderDate.Year, mounth = od.OrderDate.Month , Totalprice =o.TotalPrice};
            var q3 = from o in q2
                     group o by o.Year into g
                     select new { Year = g.Key, Totalprice = $"{g.Sum(o => o.Totalprice):C2}" };
            
            dataGridView1.DataSource = q3.Distinct().ToList();
        }

      
    }
}
