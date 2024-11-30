using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonLayer.Entities;
using System.Threading.Tasks;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;


namespace PresentationLayer.PdfGenerator
{
    public class PdfGenerate
    {
        public void GenerateClientsTickets(List<Products> products, Clients client,int SalesId,decimal totalPrice)
        {
            try
            {
                List<Products> purchaseProducts = products;


                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string clientsTicketsPath = Path.Combine(desktopPath, "clientsTickects");

                // Crear la carpeta si no existe
                if (!Directory.Exists(clientsTicketsPath))
                {
                    Directory.CreateDirectory(clientsTicketsPath);
                }

                // Ruta del archivo PDF
                string pdfFilePath = Path.Combine(clientsTicketsPath, $"{SalesId}TicketDeCompra.pdf");

                

                Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(50);

                        // Encabezado del PDF
                        page.Header()
                            .Text("Ticket de Productos")
                            .SemiBold()
                            .FontSize(20)
                            .FontColor(Colors.Blue.Medium);

                        // Combinar todo el contenido en una sola llamada
                        page.Content().Column(column =>
                        {
                            // Información del cliente
                            column.Item().Text(text =>
                            {
                                text.Line($"Cliente : {client.ClientName} {client.ClientLastName}");
                                text.Line($"DUI : {client.ClientDUI}");
                            });

                            // Espacio entre contenido
                            column.Item().PaddingVertical(10);

                            // Tabla de productos
                            column.Item().Table(table =>
                            {
                                // Definir las columnas de la tabla
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn(1); // Columna 1: Marca
                                    columns.RelativeColumn(2); // Columna 2: Modelo
                                    columns.RelativeColumn(1); // Columna 3: Versión
                                    columns.RelativeColumn(1); // Columna 4: Color
                                    columns.RelativeColumn(1); // Columna 5: Cantidad
                                    columns.RelativeColumn(1); // Columna 6: Precio
                                });

                                // Encabezados de la tabla
                                table.Header(header =>
                                {
                                    header.Cell().Text("Marca").Bold();
                                    header.Cell().Text("Modelo").Bold();
                                    header.Cell().Text("Versión").Bold();
                                    header.Cell().Text("Color").Bold();
                                    header.Cell().Text("Cantidad").Bold();
                                    header.Cell().Text("Precio").Bold();
                                });

                                // Agregar filas dinámicamente desde la lista
                                foreach (var product in purchaseProducts)
                                {
                                    table.Cell().Text(product.ProductBrand);
                                    table.Cell().Text(product.ProductModel);
                                    table.Cell().Text(product.ProductVersion);
                                    table.Cell().Text(product.ProductColor);
                                    table.Cell().Text(product.ProductAmount.ToString());
                                    table.Cell().Text($"${product.ProductPrice:F2}");
                                }

                                column.Item().PaddingTop(10) // Agregar un espacio encima del texto adicional
                                    .Text($"Total :${totalPrice} ")
                                    .FontSize(12)
                                    .Italic()
                                    .FontColor(Colors.Grey.Darken2);
                            });
                        });

                        // Pie de página con fecha
                        page.Footer()
                            .AlignCenter()
                            .Text($"Generado el {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
                    });
                }).GeneratePdf(pdfFilePath);

                // Notificar al usuario
                MessageBox.Show("PDF con tabla generado exitosamente en: " + pdfFilePath, "PDF Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}