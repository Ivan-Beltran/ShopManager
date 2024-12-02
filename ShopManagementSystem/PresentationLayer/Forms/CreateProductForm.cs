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
using Microsoft.VisualBasic.Logging;
using PresentationLayer.Validations;
using FluentValidation.Results;

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
            productsDataGridView.Columns[0].Visible = false;
            productsDataGridView.Columns["Precio"].DefaultCellStyle.Format = "C2";
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
                    string fileName = Path.GetFileName(openFileImgDialog.FileName);
                    string destinationPath = Path.Combine(Application.StartupPath, "ProductsIMG", fileName);

                    // Crear carpeta si no existe
                    if (!Directory.Exists(Path.Combine(Application.StartupPath, "ProductsIMG")))
                    {
                        Directory.CreateDirectory(Path.Combine(Application.StartupPath, "ProductsIMG"));
                    }


                    File.Copy(openFileImgDialog.FileName, destinationPath, true);


                    productImgPictureBox.Image = Image.FromFile(destinationPath);


                    imgPath = Path.Combine("ProductsIMG", fileName);
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
                MessageBox.Show("No se puede agregar mientras hay una fila seleccionada");
            }
            else
            {
                if (productImgPictureBox.Image == null)
                {
                    MessageBox.Show("Por favor, selecciona una imagen antes de continuar.");
                    return;
                }
                decimal productPrice;
                bool isValidPrice = decimal.TryParse(productPriceTextBox.Text, out productPrice);

                // Verificar si la conversión fue exitosa
                if (!isValidPrice)
                {
                    // Si la conversión falla, mostrar el error y salir del método
                    validationErrorProvider.SetError(productPriceTextBox, "Por favor ingrese un precio válido");
                    return;
                }
                else
                {
                    // Limpiar el error si la validación es correcta
                    validationErrorProvider.SetError(productPriceTextBox, string.Empty);
                }
                var product = new Products()
                {
                    ProductTypeId = Convert.ToInt32(productTypeComboBox.SelectedValue),
                    ProductBrand = productBrandTextBox.Text,
                    ProductModel = productModeltextBox.Text,
                    ProductVersion = productVersionTextBox.Text,
                    ProductColor = productColorTextBox.Text,
                    ProductPrice = productPrice,
                    ImageUrl = imgPath
                };

                CreateProductValidator createProductValidator = new CreateProductValidator();
                ValidationResult result = createProductValidator.Validate(product);
                if (!result.IsValid)
                {
                    DisplayValidationErrors(result);

                    return;
                }

                else
                {
                    try
                    {

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
        }
        private void DisplayValidationErrors(ValidationResult result)
        {
            validationErrorProvider.Clear();

            foreach (var error in result.Errors)
            {
                switch (error.PropertyName)
                {
                    case nameof(Products.ProductTypeId):
                        validationErrorProvider.SetError(productTypeComboBox, error.ErrorMessage);
                        break;
                    case nameof(Products.ProductBrand):
                        validationErrorProvider.SetError(productBrandTextBox, error.ErrorMessage);
                        break;
                    case nameof(Products.ProductModel):
                        validationErrorProvider.SetError(productModeltextBox, error.ErrorMessage);
                        break;
                    case nameof(Products.ProductVersion):
                        validationErrorProvider.SetError(productVersionTextBox, error.ErrorMessage);
                        break;
                    case nameof(Products.ProductColor):
                        validationErrorProvider.SetError(productColorTextBox, error.ErrorMessage);
                        break;

                    case nameof(Products.ProductPrice):
                        validationErrorProvider.SetError(productPriceTextBox, error.ErrorMessage);
                        break;

                }
            }

        }

        private void editProductButton_Click(object sender, EventArgs e)
        {
            if (productsDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Ninguna fila seleccionada para editar");
            }
            else
            {

                if (string.IsNullOrEmpty(imgPath))
                {
                    MessageBox.Show("Por favor, selecciona una imagen antes de continuar.");
                    return;
                }

                var product = new Products()
                {
                    ProductId = Convert.ToInt32(productsDataGridView.CurrentRow.Cells[0].Value.ToString()),
                    ProductTypeId = Convert.ToInt32(productTypeComboBox.SelectedValue),
                    ProductBrand = productBrandTextBox.Text,
                    ProductModel = productModeltextBox.Text,
                    ProductVersion = productVersionTextBox.Text,
                    ProductColor = productColorTextBox.Text,
                    ProductPrice = Convert.ToDecimal(productPriceTextBox.Text),
                    ImageUrl = imgPath
                };

                CreateProductValidator createProductValidator = new CreateProductValidator();
                ValidationResult result = createProductValidator.Validate(product);

                if (!result.IsValid)
                {
                    DisplayValidationErrors(result);


                    return;
                }
                else
                {
                    try
                    {

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

                // Ruta de la imagen
                string imageRelativePath = selectedRow.Cells[7].Value.ToString();

                // Construir ruta completa
                string projectBasePath = AppDomain.CurrentDomain.BaseDirectory;
                string imgUrl = Path.GetFullPath(Path.Combine(projectBasePath, @"..\..\..\..\..\", imageRelativePath));

                try
                {
                    if (File.Exists(imgUrl))
                    {
                        productImgPictureBox.Image = Image.FromFile(imgUrl);
                        imgPath = imageRelativePath;
                    }
                    else
                    {
                        MessageBox.Show($"Archivo no encontrado: {imgUrl}");
                        productImgPictureBox.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la imagen: {ex.Message}\nRuta: {projectBasePath}");
                    productImgPictureBox.Image = null;
                }
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

        private void productBrandTextBox_TextChanged(object sender, EventArgs e)
        {
            validationErrorProvider.Clear();
        }

        private void productModeltextBox_TextChanged(object sender, EventArgs e)
        {
            validationErrorProvider.Clear();
        }

        private void productVersionTextBox_TextChanged(object sender, EventArgs e)
        {
            validationErrorProvider.Clear();
        }

        private void productColorTextBox_TextChanged(object sender, EventArgs e)
        {
            validationErrorProvider.Clear();
        }

        private void productPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            validationErrorProvider.Clear();
        }

        private void productTypeComboBox_Click(object sender, EventArgs e)
        {
            validationErrorProvider.Clear();
        }
    }
}
