namespace OnlineSatisPlatformu
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabProducts = new TabPage();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label1 = new Label();
            cmbKat = new ComboBox();
            label2 = new Label();
            cmbSort = new ComboBox();
            label3 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAddProduct = new Button();
            btnSepet = new Button();
            flpProducts = new FlowLayoutPanel();
            tabKargolar = new TabPage();
            flpKargolar = new FlowLayoutPanel();
            label4 = new Label();
            btnYrtTemizle = new Button();
            flpYurtici = new FlowLayoutPanel();
            label5 = new Label();
            btnMngTemizle = new Button();
            flpMNG = new FlowLayoutPanel();
            label6 = new Label();
            btnPttTemizle = new Button();
            flpPTT = new FlowLayoutPanel();
            tabControl1.SuspendLayout();
            tabProducts.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            tabKargolar.SuspendLayout();
            flpKargolar.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.Controls.Add(tabProducts);
            tabControl1.Controls.Add(tabKargolar);
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.ItemSize = new Size(200, 40);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1517, 943);
            tabControl1.TabIndex = 7;
            // 
            // tabProducts
            // 
            tabProducts.Controls.Add(flowLayoutPanel3);
            tabProducts.Controls.Add(flpProducts);
            tabProducts.Location = new Point(4, 44);
            tabProducts.Name = "tabProducts";
            tabProducts.Padding = new Padding(3);
            tabProducts.Size = new Size(1509, 895);
            tabProducts.TabIndex = 0;
            tabProducts.Text = "ÜRÜNLER";
            tabProducts.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label1);
            flowLayoutPanel3.Controls.Add(cmbKat);
            flowLayoutPanel3.Controls.Add(label2);
            flowLayoutPanel3.Controls.Add(cmbSort);
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.Controls.Add(txtSearch);
            flowLayoutPanel3.Controls.Add(btnSearch);
            flowLayoutPanel3.Controls.Add(btnAddProduct);
            flowLayoutPanel3.Controls.Add(btnSepet);
            flowLayoutPanel3.Location = new Point(6, 9);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(1211, 40);
            flowLayoutPanel3.TabIndex = 3;
            // 
            // label1
            // 
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 29);
            label1.TabIndex = 2;
            label1.Text = "Kategori:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbKat
            // 
            cmbKat.FormattingEnabled = true;
            cmbKat.Items.AddRange(new object[] { "HEPSİ", "TV", "BUZDOLABI", "ÇAMAŞIR MAK." });
            cmbKat.Location = new Point(106, 3);
            cmbKat.Name = "cmbKat";
            cmbKat.Size = new Size(157, 29);
            cmbKat.TabIndex = 1;
            cmbKat.Text = "HEPSİ";
            cmbKat.SelectedIndexChanged += cmbKat_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Location = new Point(269, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 29);
            label2.TabIndex = 4;
            label2.Text = "Sırala:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbSort
            // 
            cmbSort.FormattingEnabled = true;
            cmbSort.Items.AddRange(new object[] { "Fiyata göre artan", "Fiyata göre azalan", "En ucuz", "En pahalı" });
            cmbSort.Location = new Point(354, 3);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(181, 29);
            cmbSort.TabIndex = 3;
            cmbSort.Text = "Fiyata göre artan";
            cmbSort.SelectedIndexChanged += cmbSort_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Location = new Point(541, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 29);
            label3.TabIndex = 5;
            label3.Text = "Ara:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(626, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(192, 29);
            txtSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(824, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(93, 29);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Filtrele";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddProduct.Location = new Point(923, 3);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(124, 30);
            btnAddProduct.TabIndex = 8;
            btnAddProduct.Text = "ÜRÜN EKLE";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click_1;
            // 
            // btnSepet
            // 
            btnSepet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSepet.Location = new Point(1053, 3);
            btnSepet.Name = "btnSepet";
            btnSepet.Size = new Size(124, 30);
            btnSepet.TabIndex = 9;
            btnSepet.Text = "SEPET";
            btnSepet.UseVisualStyleBackColor = true;
            btnSepet.Click += btnSepet_Click_1;
            // 
            // flpProducts
            // 
            flpProducts.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpProducts.Dock = DockStyle.Bottom;
            flpProducts.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            flpProducts.Location = new Point(3, 52);
            flpProducts.Name = "flpProducts";
            flpProducts.Size = new Size(1503, 840);
            flpProducts.TabIndex = 0;
            // 
            // tabKargolar
            // 
            tabKargolar.Controls.Add(flpKargolar);
            tabKargolar.Location = new Point(4, 44);
            tabKargolar.Name = "tabKargolar";
            tabKargolar.Padding = new Padding(3);
            tabKargolar.Size = new Size(1509, 895);
            tabKargolar.TabIndex = 1;
            tabKargolar.Text = "KARGOLAR";
            tabKargolar.UseVisualStyleBackColor = true;
            // 
            // flpKargolar
            // 
            flpKargolar.Controls.Add(label4);
            flpKargolar.Controls.Add(btnYrtTemizle);
            flpKargolar.Controls.Add(flpYurtici);
            flpKargolar.Controls.Add(label5);
            flpKargolar.Controls.Add(btnMngTemizle);
            flpKargolar.Controls.Add(flpMNG);
            flpKargolar.Controls.Add(label6);
            flpKargolar.Controls.Add(btnPttTemizle);
            flpKargolar.Controls.Add(flpPTT);
            flpKargolar.Dock = DockStyle.Fill;
            flpKargolar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            flpKargolar.Location = new Point(3, 3);
            flpKargolar.Name = "flpKargolar";
            flpKargolar.Size = new Size(1503, 889);
            flpKargolar.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 30);
            label4.TabIndex = 0;
            label4.Text = "YURTİÇİ";
            // 
            // btnYrtTemizle
            // 
            btnYrtTemizle.Location = new Point(99, 3);
            btnYrtTemizle.Name = "btnYrtTemizle";
            btnYrtTemizle.Size = new Size(75, 23);
            btnYrtTemizle.TabIndex = 7;
            btnYrtTemizle.Text = "Gönder";
            btnYrtTemizle.UseVisualStyleBackColor = true;
            btnYrtTemizle.Click += btnYrtTemizle_Click;
            // 
            // flpYurtici
            // 
            flpYurtici.Location = new Point(3, 33);
            flpYurtici.Name = "flpYurtici";
            flpYurtici.Size = new Size(1722, 213);
            flpYurtici.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 249);
            label5.Name = "label5";
            label5.Size = new Size(64, 30);
            label5.TabIndex = 2;
            label5.Text = "MNG";
            // 
            // btnMngTemizle
            // 
            btnMngTemizle.Location = new Point(73, 252);
            btnMngTemizle.Name = "btnMngTemizle";
            btnMngTemizle.Size = new Size(75, 23);
            btnMngTemizle.TabIndex = 8;
            btnMngTemizle.Text = "Gönder";
            btnMngTemizle.UseVisualStyleBackColor = true;
            btnMngTemizle.Click += btnMngTemizle_Click;
            // 
            // flpMNG
            // 
            flpMNG.Location = new Point(3, 282);
            flpMNG.Name = "flpMNG";
            flpMNG.Size = new Size(1722, 213);
            flpMNG.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 498);
            label6.Name = "label6";
            label6.Size = new Size(49, 30);
            label6.TabIndex = 4;
            label6.Text = "PTT";
            // 
            // btnPttTemizle
            // 
            btnPttTemizle.Location = new Point(58, 501);
            btnPttTemizle.Name = "btnPttTemizle";
            btnPttTemizle.Size = new Size(75, 23);
            btnPttTemizle.TabIndex = 8;
            btnPttTemizle.Text = "Gönder";
            btnPttTemizle.UseVisualStyleBackColor = true;
            btnPttTemizle.Click += btnPttTemizle_Click;
            // 
            // flpPTT
            // 
            flpPTT.Location = new Point(3, 531);
            flpPTT.Name = "flpPTT";
            flpPTT.Size = new Size(1722, 213);
            flpPTT.TabIndex = 5;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1536, 845);
            Controls.Add(tabControl1);
            Name = "frmMain";
            Text = "ANA SAYFA";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabProducts.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            tabKargolar.ResumeLayout(false);
            flpKargolar.ResumeLayout(false);
            flpKargolar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabProducts;
        private TabPage tabKargolar;
        private FlowLayoutPanel flpProducts;
        private Label label1;
        private ComboBox cmbKat;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label2;
        private ComboBox cmbSort;
        private Label label3;
        private TextBox txtSearch;
        private Button btnSearch;
        private FlowLayoutPanel flpKargolar;
        private Label label4;
        private FlowLayoutPanel flpYurtici;
        private Label label5;
        private FlowLayoutPanel flpMNG;
        private Label label6;
        private FlowLayoutPanel flpPTT;
        private Button btnYrtTemizle;
        private Button btnMngTemizle;
        private Button btnPttTemizle;
        private Button btnAddProduct;
        private Button btnSepet;
    }
}