using OnlineSatisPlatformu.ProductClasses;

namespace OnlineSatisPlatformu.Forms
{
    public partial class frmAddProduct : Form
    {
        public clsProduct Product;

        public frmAddProduct(ref clsProduct product)
        {
            InitializeComponent();
            Product = product;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbKat.Text == "")
            {
                MessageBox.Show("Kategori seçiniz.");
                return;
            }

            string a, k, m;
            float f;

            a = txtName.Text;
            k = cmbKat.Text;
            m = txtMarka.Text;

            f = Convert.ToSingle(txtFiyat.Text.Replace(".", ","));

            Product.Ad = a;
            Product.Fiyat = f;
            Product.Kategori = k;
            Product.Marka = m;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
