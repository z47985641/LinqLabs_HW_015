
namespace LinqLabs
{
    partial class HW_04
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lINQGroupByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.int分三群NoLINQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lINQToFileInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.依檔案大小分組檔案大小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.依年分組檔案大小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lINQToNorthwindEntityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nWProducts低中高價產品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersGroupBy年ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersGroupBy年月ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.總銷售金額ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bySelelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.銷售最好的top5業務員ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nW產品最高單價前5筆包括類別名稱ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nW產品有任何一筆單價大於300ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.每年銷售分析PlotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.年銷售成長率ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nvDataSet1 = new LinqLabs.NVDataSet();
            this.productsTableAdapter1 = new LinqLabs.NVDataSetTableAdapters.ProductsTableAdapter();
            this.ordersTableAdapter1 = new LinqLabs.NVDataSetTableAdapters.OrdersTableAdapter();
            this.order_DetailsTableAdapter1 = new LinqLabs.NVDataSetTableAdapters.Order_DetailsTableAdapter();
            this.employeeTerritoriesTableAdapter1 = new LinqLabs.NVDataSetTableAdapters.EmployeeTerritoriesTableAdapter();
            this.employeesTableAdapter1 = new LinqLabs.NVDataSetTableAdapters.EmployeesTableAdapter();
            this.categoriesTableAdapter1 = new LinqLabs.NVDataSetTableAdapters.CategoriesTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 1061);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.treeView1);
            this.splitContainer1.Size = new System.Drawing.Size(1924, 1037);
            this.splitContainer1.SplitterDistance = 1000;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer2.Size = new System.Drawing.Size(1000, 1037);
            this.splitContainer2.SplitterDistance = 500;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.08065F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.91936F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(996, 496);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(990, 440);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(990, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Master";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.39698F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.60303F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(996, 529);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 58);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(990, 468);
            this.dataGridView2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(990, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Detail";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(916, 1033);
            this.treeView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PeachPuff;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lINQGroupByToolStripMenuItem,
            this.lINQToFileInfoToolStripMenuItem,
            this.lINQToNorthwindEntityToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lINQGroupByToolStripMenuItem
            // 
            this.lINQGroupByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.int分三群NoLINQToolStripMenuItem});
            this.lINQGroupByToolStripMenuItem.Name = "lINQGroupByToolStripMenuItem";
            this.lINQGroupByToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.lINQGroupByToolStripMenuItem.Text = "LINQ - GroupBy";
            // 
            // int分三群NoLINQToolStripMenuItem
            // 
            this.int分三群NoLINQToolStripMenuItem.Name = "int分三群NoLINQToolStripMenuItem";
            this.int分三群NoLINQToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.int分三群NoLINQToolStripMenuItem.Text = "int[]  分三群 - No LINQ";
            this.int分三群NoLINQToolStripMenuItem.Click += new System.EventHandler(this.int分三群NoLINQToolStripMenuItem_Click);
            // 
            // lINQToFileInfoToolStripMenuItem
            // 
            this.lINQToFileInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.依檔案大小分組檔案大小ToolStripMenuItem,
            this.依年分組檔案大小ToolStripMenuItem});
            this.lINQToFileInfoToolStripMenuItem.Name = "lINQToFileInfoToolStripMenuItem";
            this.lINQToFileInfoToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.lINQToFileInfoToolStripMenuItem.Text = "LINQ to FileInfo[]";
            // 
            // 依檔案大小分組檔案大小ToolStripMenuItem
            // 
            this.依檔案大小分組檔案大小ToolStripMenuItem.Name = "依檔案大小分組檔案大小ToolStripMenuItem";
            this.依檔案大小分組檔案大小ToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.依檔案大小分組檔案大小ToolStripMenuItem.Text = "依 檔案大小 分組檔案 (大=>小)";
            this.依檔案大小分組檔案大小ToolStripMenuItem.Click += new System.EventHandler(this.依檔案大小分組檔案大小ToolStripMenuItem_Click);
            // 
            // 依年分組檔案大小ToolStripMenuItem
            // 
            this.依年分組檔案大小ToolStripMenuItem.Name = "依年分組檔案大小ToolStripMenuItem";
            this.依年分組檔案大小ToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.依年分組檔案大小ToolStripMenuItem.Text = "依 年 分組檔案 (大=>小)";
            this.依年分組檔案大小ToolStripMenuItem.Click += new System.EventHandler(this.依年分組檔案大小ToolStripMenuItem_Click);
            // 
            // lINQToNorthwindEntityToolStripMenuItem
            // 
            this.lINQToNorthwindEntityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nWProducts低中高價產品ToolStripMenuItem,
            this.ordersGroupBy年ToolStripMenuItem,
            this.ordersGroupBy年月ToolStripMenuItem,
            this.總銷售金額ToolStripMenuItem,
            this.銷售最好的top5業務員ToolStripMenuItem,
            this.nW產品最高單價前5筆包括類別名稱ToolStripMenuItem,
            this.nW產品有任何一筆單價大於300ToolStripMenuItem,
            this.每年銷售分析PlotToolStripMenuItem,
            this.年銷售成長率ToolStripMenuItem});
            this.lINQToNorthwindEntityToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.PeachPuff;
            this.lINQToNorthwindEntityToolStripMenuItem.Name = "lINQToNorthwindEntityToolStripMenuItem";
            this.lINQToNorthwindEntityToolStripMenuItem.Size = new System.Drawing.Size(160, 20);
            this.lINQToNorthwindEntityToolStripMenuItem.Text = "LINQ to Northwind Entity";
            // 
            // nWProducts低中高價產品ToolStripMenuItem
            // 
            this.nWProducts低中高價產品ToolStripMenuItem.Name = "nWProducts低中高價產品ToolStripMenuItem";
            this.nWProducts低中高價產品ToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.nWProducts低中高價產品ToolStripMenuItem.Text = "NW Products 低中高 價產品 ";
            this.nWProducts低中高價產品ToolStripMenuItem.Click += new System.EventHandler(this.nWProducts低中高價產品ToolStripMenuItem_Click);
            // 
            // ordersGroupBy年ToolStripMenuItem
            // 
            this.ordersGroupBy年ToolStripMenuItem.Name = "ordersGroupBy年ToolStripMenuItem";
            this.ordersGroupBy年ToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.ordersGroupBy年ToolStripMenuItem.Text = "Orders -  Group by 年";
            this.ordersGroupBy年ToolStripMenuItem.Click += new System.EventHandler(this.ordersGroupBy年ToolStripMenuItem_Click);
            // 
            // ordersGroupBy年月ToolStripMenuItem
            // 
            this.ordersGroupBy年月ToolStripMenuItem.Name = "ordersGroupBy年月ToolStripMenuItem";
            this.ordersGroupBy年月ToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.ordersGroupBy年月ToolStripMenuItem.Text = "Orders -  Group by 年 / 月";
            this.ordersGroupBy年月ToolStripMenuItem.Click += new System.EventHandler(this.ordersGroupBy年月ToolStripMenuItem_Click);
            // 
            // 總銷售金額ToolStripMenuItem
            // 
            this.總銷售金額ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byYearToolStripMenuItem,
            this.bySelelsToolStripMenuItem});
            this.總銷售金額ToolStripMenuItem.Name = "總銷售金額ToolStripMenuItem";
            this.總銷售金額ToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.總銷售金額ToolStripMenuItem.Text = "總銷售金額";
            // 
            // byYearToolStripMenuItem
            // 
            this.byYearToolStripMenuItem.Name = "byYearToolStripMenuItem";
            this.byYearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.byYearToolStripMenuItem.Text = "by Year";
            this.byYearToolStripMenuItem.Click += new System.EventHandler(this.byYearToolStripMenuItem_Click);
            // 
            // bySelelsToolStripMenuItem
            // 
            this.bySelelsToolStripMenuItem.Name = "bySelelsToolStripMenuItem";
            this.bySelelsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bySelelsToolStripMenuItem.Text = "by Selels";
            this.bySelelsToolStripMenuItem.Click += new System.EventHandler(this.bySelelsToolStripMenuItem_Click);
            // 
            // 銷售最好的top5業務員ToolStripMenuItem
            // 
            this.銷售最好的top5業務員ToolStripMenuItem.Name = "銷售最好的top5業務員ToolStripMenuItem";
            this.銷售最好的top5業務員ToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.銷售最好的top5業務員ToolStripMenuItem.Text = "銷售最好的top 5業務員";
            this.銷售最好的top5業務員ToolStripMenuItem.Click += new System.EventHandler(this.銷售最好的top5業務員ToolStripMenuItem_Click);
            // 
            // nW產品最高單價前5筆包括類別名稱ToolStripMenuItem
            // 
            this.nW產品最高單價前5筆包括類別名稱ToolStripMenuItem.Name = "nW產品最高單價前5筆包括類別名稱ToolStripMenuItem";
            this.nW產品最高單價前5筆包括類別名稱ToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.nW產品最高單價前5筆包括類別名稱ToolStripMenuItem.Text = "NW 產品最高單價前 5 筆 (包括類別名稱)";
            this.nW產品最高單價前5筆包括類別名稱ToolStripMenuItem.Click += new System.EventHandler(this.nW產品最高單價前5筆包括類別名稱ToolStripMenuItem_Click);
            // 
            // nW產品有任何一筆單價大於300ToolStripMenuItem
            // 
            this.nW產品有任何一筆單價大於300ToolStripMenuItem.Name = "nW產品有任何一筆單價大於300ToolStripMenuItem";
            this.nW產品有任何一筆單價大於300ToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.nW產品有任何一筆單價大於300ToolStripMenuItem.Text = "NW 產品有任何一筆單價大於300 ?";
            this.nW產品有任何一筆單價大於300ToolStripMenuItem.Click += new System.EventHandler(this.nW產品有任何一筆單價大於300ToolStripMenuItem_Click);
            // 
            // 每年銷售分析PlotToolStripMenuItem
            // 
            this.每年銷售分析PlotToolStripMenuItem.Name = "每年銷售分析PlotToolStripMenuItem";
            this.每年銷售分析PlotToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.每年銷售分析PlotToolStripMenuItem.Text = "每年 銷售分析 &&　plot";
            // 
            // 年銷售成長率ToolStripMenuItem
            // 
            this.年銷售成長率ToolStripMenuItem.Name = "年銷售成長率ToolStripMenuItem";
            this.年銷售成長率ToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.年銷售成長率ToolStripMenuItem.Text = "年 銷售成長率";
            // 
            // nvDataSet1
            // 
            this.nvDataSet1.DataSetName = "NVDataSet";
            this.nvDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // order_DetailsTableAdapter1
            // 
            this.order_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // employeeTerritoriesTableAdapter1
            // 
            this.employeeTerritoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // employeesTableAdapter1
            // 
            this.employeesTableAdapter1.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter1
            // 
            this.categoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // HW_04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HW_04";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lINQGroupByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem int分三群NoLINQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lINQToFileInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 依檔案大小分組檔案大小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 依年分組檔案大小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lINQToNorthwindEntityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nWProducts低中高價產品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersGroupBy年ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersGroupBy年月ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 總銷售金額ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 銷售最好的top5業務員ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nW產品最高單價前5筆包括類別名稱ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nW產品有任何一筆單價大於300ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 每年銷售分析PlotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 年銷售成長率ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem byYearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bySelelsToolStripMenuItem;
        private NVDataSet nvDataSet1;
        private NVDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private NVDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private NVDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter1;
        private NVDataSetTableAdapters.EmployeeTerritoriesTableAdapter employeeTerritoriesTableAdapter1;
        private NVDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter1;
        private NVDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter1;
    }
}