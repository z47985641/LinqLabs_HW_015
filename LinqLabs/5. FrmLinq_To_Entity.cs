using LinqLabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starter
{
    public partial class FrmLinq_To_Entity : Form
    {
        public FrmLinq_To_Entity()
        {
            InitializeComponent();
            dbContext.Database.Log = Console.WriteLine;
        }
        NorthwindEntities dbContext = new NorthwindEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            
            var q = from p in dbContext.Products
                    where p.UnitPrice > 30
                    select p;

            this.dataGridView1.DataSource = q.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource= dbContext.Categories.First().Products.ToList();

            MessageBox.Show(dbContext.Products.First().ProductName);





        }

        private void button22_Click(object sender, EventArgs e)
        {
            var q = from p in dbContext.Products
                    orderby p.UnitsInStock descending, p.ProductID
                    select p;
            this.dataGridView1.DataSource = q.ToList();

            var q2 = dbContext.Products.OrderByDescending(p => p.UnitsInStock).ThenBy(p => p.ProductID);

            this.dataGridView2.DataSource = q2.ToList();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //var q = from p in dbContext.Products
            //        group p by p.Category.CategoryName into g
            //        select new { CategoryName = g.Key, Avg = g.Average(p => p.UnitPrice) };

            //dataGridView1.DataSource = q.ToList();

            //.AsEnumerable() 防止無法辨讀"物件"之型別

            var q = from p in dbContext.Products.AsEnumerable()
                    group p by p.Category.CategoryName into g
                    select new { CategoryName = g.Key, Avg = $"{g.Average(p => p.UnitPrice):c2}" };

            dataGridView1.DataSource = q.ToList();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            var q = from p in dbContext.Orders
                    group p by p.OrderDate.Value.Year into g
                    select new { CategoryName = g.Key, Count = g.Count() };
            dataGridView1.DataSource = q.ToList();

        }

        private void button55_Click(object sender, EventArgs e)
        {
            Product prod = new Product { ProductName = "xxx", Discontinued = false };
            dbContext.Products.Add(prod);

            dbContext.SaveChanges();
        }

        private void button53_Click(object sender, EventArgs e)
        {

        }
    }
}
