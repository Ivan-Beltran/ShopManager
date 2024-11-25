using BussinessLayer.Services.ServicesForInventory;
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

namespace PresentationLayer.Forms
{
    public partial class CreateProductForm : Form
    {
        private IInventoryService _inventoryServices;
        private string imgPath = string.Empty;
        public CreateProductForm(IInventoryService inventoryServices)
        {
            _inventoryServices = inventoryServices;
            InitializeComponent();
            LoadProductsCrated();
            LoadProductType();
            this.Shown += (s, e) => productsDataGridView.ClearSelection();

        }

        public void LoadProductsCrated()
        {
            productsDataGridView.DataSource = _inventoryServices.GetProductCreated();
            productsDataGridView.Columns[7].Visible = false;
        }

        public void LoadProductType()
        {
            productTypeComboBox.DataSource = _inventoryServices.GetProductsType();
            productTypeComboBox.DisplayMember = "Categoria";
            productTypeComboBox.ValueMember = "Id";
            productTypeComboBox.SelectedIndex = -1;
        }

        private void loadProductImgButton_Click(object sender, EventArgs e)
        {
            openFileImgDialog.Filter = "Archivos de Imagen | *.jpg; *.png; *.jpeg";

            try
            {
                if (openFileImgDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = Path.GetFileName(openFileImgDialog.FileName); // Nombre del archivo
                    string destinationPath = Path.Combine(Application.StartupPath, "ProductsIMG", fileName); // Ruta a la carpeta ProductsIMG

                    // Crear carpeta si no existe
                    if (!Directory.Exists(Path.Combine(Application.StartupPath, "ProductsIMG")))
                    {
                        Directory.CreateDirectory(Path.Combine(Application.StartupPath, "ProductsIMG"));
                    }

                    // Copiar la imagen seleccionada a ProductsIMG
                    File.Copy(openFileImgDialog.FileName, destinationPath, true);

                    // Asignar la imagen al PictureBox
                    productImgPictureBox.Image = Image.FromFile(destinationPath);

                    // Guardar la ruta relativa
                    imgPath = Path.Combine("ProductsIMG", fileName); // Por ejemplo: ProductsIMG/note9.jpg
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}");
            }
        }

        private void addProducButton_Click(object sender, EventArgs e)
        {
            if (productsDataGridView.SelectedRows.Count > 0)
            {
                MessageBox.Show("no se puede agregar mientras hay una fila seleccionada");
            }
            else
            {
                if (string.IsNullOrEmpty(imgPath))
                {
                    MessageBox.Show("Por favor, selecciona una imagen antes de continuar.");
                    return;
                }

                try
                {
                    var product = new Products()
                    {
                        ProductTypeId = Convert.ToInt32(productTypeComboBox.SelectedValue),
                        ProductBrand = productBrandTextBox.Text,
                        ProductModel = productModeltextBox.Text,
                        ProductVersion = productVersionTextBox.Text,
                        ProductColor = productColorTextBox.Text,
                        ProductPrice = Convert.ToInt32(productPriceTextBox.Text),
                        ImageUrl = imgPath
                    };

                    _inventoryServices.CreateProduct(product);
                    MessageBox.Show("Producto creado exitosamente.");
                    LoadProductsCrated();
                    this.Shown += (s, e) => productsDataGridView.ClearSelection();
                    productsDataGridView.ClearSelection();
                    ClearParameters();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el producto: {ex.Message}");
                }
            }
        }


        private void editProductButton_Click(object sender, EventArgs e)
        {
            if (productsDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("ninguna fila seleccionada para editar");
            }
            else
            {

                if (string.IsNullOrEmpty(imgPath))
                {
                    MessageBox.Show("Por favor, selecciona una imagen antes de continuar.");
                    return;
                }
                try
                {
                    var product = new Products()
                    {
                        ProductId = Convert.ToInt32(productsDataGridView.CurrentRow.Cells[0].Value.ToString()),
                        ProductTypeId = Convert.ToInt32(productTypeComboBox.SelectedValue),
                        ProductBrand = productBrandTextBox.Text,
                        ProductModel = productModeltextBox.Text,
                        ProductVersion = productVersionTextBox.Text,
                        ProductColor = productColorTextBox.Text,
                        ProductPrice = Convert.ToInt32(productPriceTextBox.Text),
                        ImageUrl = imgPath
                    };

                    _inventoryServices.EditProduct(product);
                    MessageBox.Show("Producto editado exitosamente.");
                    LoadProductsCrated();
                    this.Shown += (s, e) => productsDataGridView.ClearSelection();
                    productsDataGridView.ClearSelection();
                    ClearParameters();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el producto: {ex.Message}");
                }
            }
        }

        private void productsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            ClearParameters();
            if (productsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = productsDataGridView.SelectedRows[0];


                productTypeComboBox.Text = selectedRow.Cells[1].Value.ToString();
                productBrandTextBox.Text = selectedRow.Cells[2].Value.ToString();
                productModeltextBox.Text = selectedRow.Cells[3].Value.ToString();
                productVersionTextBox.Text = selectedRow.Cells[4].Value.ToString();
                productColorTextBox.Text = selectedRow.Cells[5].Value.ToString();
                productPriceTextBox.Text = selectedRow.Cells[6].Value.ToString();
                //productImgPictureBox.Image = Image.FromFile(selectedRow.Cells[7].Value.ToString());
                imgPath = selectedRow.Cells[7].Value.ToString();

            }
        }

        public void ClearParameters()
        {
            productTypeComboBox.SelectedIndex = -1;
            productBrandTextBox.Text = "";
            productModeltextBox.Text = "";
            productVersionTextBox.Text = "";
            productColorTextBox.Text = "";
            productPriceTextBox.Text = "";
            productImgPictureBox.Image = null;

        }

        private void removeSelectionButton_Click(object sender, EventArgs e)
        {
            if (productsDataGridView.Rows.Count >= 1)
            {

                this.Shown += (s, e) => productsDataGridView.ClearSelection();
                productsDataGridView.ClearSelection();
                ClearParameters();
            }
            else
            {
                MessageBox.Show("ninguna fila seleccionada",
                            "informacion",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
        }
    }
}
