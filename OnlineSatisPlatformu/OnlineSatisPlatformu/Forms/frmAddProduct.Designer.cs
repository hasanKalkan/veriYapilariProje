namespace OnlineSatisPlatformu.Forms
{
    partial class frmAddProduct
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtFiyat = new TextBox();
            label3 = new Label();
            txtMarka = new TextBox();
            label4 = new Label();
            cmbKat = new ComboBox();
            btnEkle = new Button();
            btnCancel = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(txtName);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(txtFiyat);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(txtMarka);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(cmbKat);
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(453, 158);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 0;
            label1.Text = "ÜRÜN ADI:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            txtName.Location = new Point(130, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(309, 29);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Size = new Size(121, 32);
            label2.TabIndex = 2;
            label2.Text = "FİYATI:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(130, 38);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(309, 29);
            txtFiyat.TabIndex = 3;
            // 
            // label3
            // 
            label3.Location = new Point(3, 70);
            label3.Name = "label3";
            label3.Size = new Size(121, 32);
            label3.TabIndex = 4;
            label3.Text = "MARKASI:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(130, 73);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(309, 29);
            txtMarka.TabIndex = 5;
            // 
            // label4
            // 
            label4.Location = new Point(3, 105);
            label4.Name = "label4";
            label4.Size = new Size(121, 32);
            label4.TabIndex = 6;
            label4.Text = "KATEGORİ:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbKat
            // 
            cmbKat.FormattingEnabled = true;
            cmbKat.Items.AddRange(new object[] { "TV", "BUZDOLABI", "ÇAMAŞIR MAK." });
            cmbKat.Location = new Point(130, 108);
            cmbKat.Name = "cmbKat";
            cmbKat.Size = new Size(240, 29);
            cmbKat.TabIndex = 7;
            // 
            // btnEkle
            // 
            btnEkle.DialogResult = DialogResult.OK;
            btnEkle.Location = new Point(471, 12);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(133, 58);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(471, 76);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 58);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "KAPAT";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 179);
            Controls.Add(btnCancel);
            Controls.Add(btnEkle);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmAddProduct";
            Text = "ÜRÜN EKLEME";
            Load += frmAddProduct_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnEkle;
        private Button btnCancel;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtFiyat;
        private Label label3;
        private TextBox txtMarka;
        private Label label4;
        private ComboBox cmbKat;
    }
}