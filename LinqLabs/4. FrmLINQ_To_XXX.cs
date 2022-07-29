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
                    select (Mykey = g.Key,Mycount = g.Count(),Myavg =g.Aggregate());

            dataGridView1.DataSource = q.ToList();
            //=============================================

            foreach(var group in q)
            {
               TreeNode x = treeView1.Nodes.Add(group.Key.ToString());
                foreach (var iterm in group)
                {
                    x.Nodes.Add(iterm.ToString());
                }

            }

                    
        }
    }
}
