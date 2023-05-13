namespace OnlineSatisPlatformu.Forms
{
    partial class frmKargoSor
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
            label1 = new Label();
            cmbKtip = new ComboBox();
            cmbKad = new ComboBox();
            label2 = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 36);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 0;
            label1.Text = "KARGO TİPİ:";
            // 
            // cmbKtip
            // 
            cmbKtip.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbKtip.FormattingEnabled = true;
            cmbKtip.Items.AddRange(new object[] { "ÇOK ACİL", "ACİL", "NORMAL" });
            cmbKtip.Location = new Point(168, 33);
            cmbKtip.Name = "cmbKtip";
            cmbKtip.Size = new Size(192, 29);
            cmbKtip.TabIndex = 1;
            cmbKtip.Text = "NORMAL";
            // 
            // cmbKad
            // 
            cmbKad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbKad.FormattingEnabled = true;
            cmbKad.Items.AddRange(new object[] { "YURTİÇİ", "MNG", "PTT" });
            cmbKad.Location = new Point(168, 68);
            cmbKad.Name = "cmbKad";
            cmbKad.Size = new Size(192, 29);
            cmbKad.TabIndex = 3;
            cmbKad.Text = "YURTİÇİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 71);
            label2.Name = "label2";
            label2.Size = new Size(135, 21);
            label2.TabIndex = 2;
            label2.Text = "KARGO FİRMASI:";
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(394, 12);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(127, 42);
            btnOK.TabIndex = 4;
            btnOK.Text = "TAMAM";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(394, 67);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(127, 42);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "İPTAL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmKargoSor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 121);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(cmbKad);
            Controls.Add(label2);
            Controls.Add(cmbKtip);
            Controls.Add(label1);
            Name = "frmKargoSor";
            Text = "KARGO İŞLEMLERİ";
            Load += frmKargoSor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbKtip;
        private ComboBox cmbKad;
        private Label label2;
        private Button btnOK;
        private Button btnCancel;
    }
}