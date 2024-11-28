using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonLayer.Entities;

namespace PresentationLayer.Controls
{
    public partial class ProductsControl : UserControl
    {
        public Products _Product { get; set; }

        public event EventHandler<Products> ProductAddedToCart;
        public ProductsControl(Products product)
        {
            InitializeComponent();
            _Product = product;
            brandLabel.Text = _Product.ProductBrand;
            modelLabel.Text = _Product.ProductModel;
            versionLabel.Text = _Product.ProductVersion;
            colorLabel.Text = _Product.ProductColor;
            priceLabel.Text = _Product.ProductPrice.ToString("C");
            enableQuanatityLabel.Text= _Product.ProductAmount.ToString();

            string imageRelativePath = _Product.ImageUrl;
            string projectBasePath = AppDomain.CurrentDomain.BaseDirectory;
            string imgUrl = Path.GetFullPath(Path.Combine(projectBasePath, @"..\..\..\..\..\", imageRelativePath));
            try
            {
                if (File.Exists(imgUrl))
                {
                    productPictureBox.Image = Image.FromFile(imgUrl);

                }
                else
                {
                    MessageBox.Show($"Archivo no encontrado: {imgUrl}");
                    productPictureBox.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}\nRuta: {projectBasePath}");
                productPictureBox.Image = null;
            }
        }

        private void addShoppingCarButton_Click(object sender, EventArgs e)
        {
            if(quantitynumericUpDown.Value != 0)
            {
                if (quantitynumericUpDown.Value > _Product.ProductAmount)
                {
                    MessageBox.Show("existencias insuficientes", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    _Product.ProductAmount = Convert.ToInt32( quantitynumericUpDown.Value);

                    MessageBox.Show($"compra agregada : { _Product.ProductBrand}  {_Product.ProductModel} ","notificacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ProductAddedToCart?.Invoke(this, _Product);
                }

            }

            else
            {
                MessageBox.Show("Por favor seleccione una cantidad mayor a 0",
                                "error",
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }


        }
    }
}
