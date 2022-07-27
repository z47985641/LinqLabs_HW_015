using LinqLabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Starter
{
    public partial class FrmLangForLINQ : Form
    {
        public FrmLangForLINQ()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int N1 = 100, N2 = 200;
            string S1 = "AAA", S2 = "BBB";
            MessageBox.Show(N1 + "," + N2 + "\n" + S1 + "," + S2);
            Cls_try.Swap(ref N1, ref N2);//ref 傳址
            Cls_try.Swap(ref S1, ref S2);//ref 傳址
            MessageBox.Show(N1 + "," + N2 + "\n" + S1 + "," + S2);
            MessageBox.Show(SystemInformation.ComputerName);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            int N1 = 100, N2 = 200;
            string S1 = "AAA", S2 = "BBB";
            MessageBox.Show(N1 + "," + N2 + "\n" + S1 + "," + S2);
            Cls_try.AnyTypeSwap(ref N1, ref N2);//ref 傳址
            Cls_try.AnyTypeSwap<string>(ref S1, ref S2);//ref 傳址 <>可以不用寫
            MessageBox.Show(N1 + "," + N2 + "\n" + S1 + "," + S2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //具名
            buttonX.Click += ButtonX_Click;
            //buttonX.Click += aaa;
            //錯誤  CS0123  'aaa' 沒有任何多載符合委派 'EventHandler'
            //=====================

            //匿名
            buttonX.Click += delegate (object sender1, EventArgs e1)
                             {
                                 MessageBox.Show("匿名方法");
                             };
        }
        private void ButtonX_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ButtonX_Click");
        }

        bool test(int num)
        {
            return num > 5;
        }
        internal delegate bool delegatenew(int num);
        private void button9_Click(object sender, EventArgs e)
        {
            bool result = test(10);
            MessageBox.Show("result =" + result);

            //=============================
            //C#1.0 具名
            delegatenew obj = test;//delegatenew obj = new delegatenew(test);
            result = obj(5);
            MessageBox.Show("C#1.0 具名--result =" + result);

            //==============================
            //C#2.0 匿名
            obj = delegate (int num)
            {
                return test(num);
            };
            result = obj(20);
            MessageBox.Show("C#2.0 匿名--result =" + result);
            //==============================
            //C#3.0匿名簡潔版
            obj = n => n % 2 == 0;
            result = obj(100);
            MessageBox.Show("C#3.0 匿名簡潔版--result =" + result);
        }
        internal static  List<int> Mywhere(int[] nums, delegatenew obj)
        {
            List<int> list = new List<int>();
            foreach (int n in nums)
            {
                if (obj(n))
                {
                    list.Add(n);
                }
            }

            return list;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> result = Mywhere(nums, test);
            List<int> R_odd = Mywhere(nums, n => n % 2 == 0);
            List<int> R_even = Mywhere(nums, n => n % 2 == 1);

            foreach (int n in R_even)
                listBox1.Items.Add(n);

            foreach (int n in R_odd)
                listBox2.Items.Add(n);

        }
        //private void aaa(缺少簽名'EventHandler')
        //{
        //    MessageBox.Show("aaa");
        //} //錯誤1

        internal static IEnumerable<int> MyIterator(int[] nums, delegatenew obj)
        {
            foreach (int n in nums)
            {
                if (obj(n))
                {
                    yield return n;
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> q = MyIterator(nums, n => n % 2 == 0);
            foreach (int n in q)
                listBox1.Items.Add(n);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> q = nums.Where(n => n > 6);
            //寫法等於
            //IEnumerable<int> q = from n in nums
            //                     where n > 6
            //                     select n;
            foreach (int n in q)
                listBox1.Items.Add(n);

            string[] words = { "a","bb","ccc","dddd","eeeee","ffffff" };
            IEnumerable<string> j = words.Where<string>(w => w.Length >4);
            foreach (string n in j)
                listBox2.Items.Add(n);
            //===================================================================
            productsTableAdapter1.Fill(dataSet11.Products);
            //var P = from n in dataSet11.Products
            //                     where n.UnitPrice >30
            //                     select n;
            var P2 = dataSet11.Products.Where(p3 => p3.UnitPrice > 30);
            dataGridView1.DataSource = P2.ToList();


        }

        private void button45_Click(object sender, EventArgs e)
        {
            int n = 100;
            var n1 = 200;
            var s = "aswd";

            MessageBox.Show(s.ToUpper());

            var p = new Point(1, 10);
            MessageBox.Show(p.X + ","+ p.Y);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Mypoint pt1 = new Mypoint();
            Mypoint pt2 = new Mypoint(32);
            Mypoint pt3 = new Mypoint(45, 38);

            pt1.P1 = 100;
            pt1.P2 = 200;

            List<Mypoint> list = new List<Mypoint>();
            
            list.Add(pt1);
            list.Add(pt2);
            list.Add(pt3);
            list.Add(new Mypoint { P1 = 1, P2 = 20 });
            list.Add(new Mypoint { P2 = 20 });


            dataGridView1.DataSource = list;

            List<Mypoint> list2 = new List<Mypoint>()
            {
                new Mypoint { P1 = 80, P2=90 },
                new Mypoint { P2 = 50 }
            };

            

            dataGridView2.DataSource = list2;

        }

        private void button43_Click(object sender, EventArgs e)
        {
            var pt1 = new { P1 = 20, P2 = 30 };
            var pt2 = new { P1 = "32", P2 = "68" };

            listBox1.Items.Add(pt1.GetType());
            listBox1.Items.Add(pt2.GetType());
            //==================================
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var p = from n in nums
            //        where n > 5
            //        select new { n = n, s = n * n, c = n * n * n };
            var p = nums.Where(n => n > 5).Select(n => new { n = n, s = n * n, c = n * n * n });
            dataGridView1.DataSource = p.ToList();
            //=========================================
            var p2 = from o in dataSet11.Products
                     where o.UnitPrice > 10
                     select new
                     {
                         品名 = o.ProductName,
                         o.UnitPrice,
                         o.UnitsInStock,
                         總價 = o.UnitsInStock * o.UnitPrice
                     };

            dataGridView2.DataSource = p2.ToList();
        }
    }
    class Mypoint
    {
        public Mypoint() { }

        public Mypoint(int p1)
        {
            P1 = p1;
        }

        public Mypoint(int p1,int p2)
        {
            P1 = p1;
            P2 = p2;
        }
        private int m_p1;
        public int P1
        {
            get 
            {
                return m_p1;
            }
            set 
            {
                m_p1 = value;
            }
        }
        public int P2 {get;set;}
    }
}
