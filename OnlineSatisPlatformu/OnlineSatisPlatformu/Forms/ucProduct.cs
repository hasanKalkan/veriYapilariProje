using OnlineSatisPlatformu.ProductClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineSatisPlatformu.Forms
{
    public partial class ucProduct : UserControl
    {
        public clsProduct Prod;


        public event EventHandler<clsProduct> SepeteEkle;

        protected virtual void onSepeteEkle(clsProduct p)
        {
            EventHandler<clsProduct> handler = SepeteEkle;
            if (handler != null)
            {
                handler(this, p);
            }
        }

        public event EventHandler<clsProduct> KargoyaEkle;

        protected virtual void onKargoyaEkle(clsProduct p)
        {
            EventHandler<clsProduct> handler = KargoyaEkle;
            if (handler != null)
            {
                handler(this, p);
            }
        }


        public ucProduct(clsProduct Prod)
        {
            InitializeComponent();
            this.Prod = Prod;
            Display();
        }

        public void Display()
        {
            lblProduct.Text = Prod.Ad;
            lblFiyat.Text = Prod.Fiyat.ToString("0.00");
            lblKategori.Text = Prod.Kategori;
            lblMarka.Text = Prod.Marka;
            btnAl.Visible = Prod.status == 0;
            btnOde.Visible = Prod.status == 1;

            switch (Prod.Kategori)
            {
                case "TV":
                    lblProduct.BackColor = Color.DarkBlue;
                    lblProduct.ForeColor = Color.Yellow;
                    break;

                case "BUZDOLABI":
                    lblProduct.BackColor = Color.DarkGreen;
                    lblProduct.ForeColor = Color.Yellow;
                    break;
                default:
                    lblProduct.BackColor = Color.DarkRed;
                    lblProduct.ForeColor = Color.White;
                    break;
            }

        }

        private void btnAl_Click(object sender, EventArgs e)
        {
            onSepeteEkle(Prod);
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            onKargoyaEkle(Prod);
        }
    }
}
