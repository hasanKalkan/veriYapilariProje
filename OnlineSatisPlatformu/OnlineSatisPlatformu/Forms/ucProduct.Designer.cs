namespace OnlineSatisPlatformu.Forms
{
    partial class ucProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblProduct = new Label();
            label1 = new Label();
            lblFiyat = new Label();
            label2 = new Label();
            lblKategori = new Label();
            label3 = new Label();
            lblMarka = new Label();
            btnAl = new Button();
            btnOde = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(lblProduct);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(lblFiyat);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(lblKategori);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(lblMarka);
            flowLayoutPanel1.Controls.Add(btnAl);
            flowLayoutPanel1.Controls.Add(btnOde);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(150, 216);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // lblProduct
            // 
            lblProduct.BackColor = Color.Blue;
            lblProduct.Dock = DockStyle.Top;
            lblProduct.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblProduct.ForeColor = Color.White;
            lblProduct.Location = new Point(3, 0);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(150, 40);
            lblProduct.TabIndex = 1;
            lblProduct.Text = "---";
            lblProduct.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 40);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 4;
            label1.Text = "FİYAT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFiyat
            // 
            lblFiyat.BackColor = Color.Transparent;
            lblFiyat.Dock = DockStyle.Top;
            lblFiyat.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFiyat.ForeColor = Color.Black;
            lblFiyat.Location = new Point(3, 60);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(150, 25);
            lblFiyat.TabIndex = 2;
            lblFiyat.Text = "0.0";
            lblFiyat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(3, 85);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 5;
            label2.Text = "KATEGORİ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKategori
            // 
            lblKategori.BackColor = Color.FromArgb(255, 255, 192);
            lblKategori.Dock = DockStyle.Top;
            lblKategori.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblKategori.ForeColor = Color.FromArgb(255, 128, 0);
            lblKategori.Location = new Point(3, 105);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(150, 25);
            lblKategori.TabIndex = 6;
            lblKategori.Text = "kategori";
            lblKategori.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(192, 255, 255);
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(3, 130);
            label3.Name = "label3";
            label3.Size = new Size(150, 20);
            label3.TabIndex = 7;
            label3.Text = "MARKA";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMarka
            // 
            lblMarka.BackColor = Color.FromArgb(192, 255, 255);
            lblMarka.Dock = DockStyle.Top;
            lblMarka.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMarka.ForeColor = Color.Green;
            lblMarka.Location = new Point(3, 150);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(150, 25);
            lblMarka.TabIndex = 8;
            lblMarka.Text = "marka";
            lblMarka.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAl
            // 
            btnAl.BackColor = Color.Lime;
            btnAl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAl.Location = new Point(3, 178);
            btnAl.Name = "btnAl";
            btnAl.Size = new Size(146, 34);
            btnAl.TabIndex = 9;
            btnAl.Text = "SEPETE EKLE";
            btnAl.UseVisualStyleBackColor = false;
            btnAl.Click += btnAl_Click;
            // 
            // btnOde
            // 
            btnOde.BackColor = Color.FromArgb(255, 128, 0);
            btnOde.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOde.Location = new Point(3, 218);
            btnOde.Name = "btnOde";
            btnOde.Size = new Size(146, 34);
            btnOde.TabIndex = 10;
            btnOde.Text = "SATIN AL";
            btnOde.UseVisualStyleBackColor = false;
            btnOde.Visible = false;
            btnOde.Click += btnOde_Click;
            // 
            // ucProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(flowLayoutPanel1);
            Name = "ucProduct";
            Size = new Size(150, 216);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblProduct;
        private Label lblFiyat;
        private Label label1;
        private Label label2;
        private Label lblKategori;
        private Label label3;
        private Label lblMarka;
        private Button btnAl;
        private Button btnOde;
    }
}
