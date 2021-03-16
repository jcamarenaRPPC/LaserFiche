using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.Modulos;

namespace WindowsFormsApp1
{
    public partial class frmLeerPDF : Form
    {
        // Variables publicas.
        Dictionary<string, System.Drawing.Image> lstDiccionarioImagenes = new Dictionary<string, System.Drawing.Image>();
        ImageList imageList = new ImageList();

        public frmLeerPDF()
        {
            InitializeComponent();
        }
        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                PdfWriter objPDF = new PdfWriter(@"C:\Users\HP DESKTOP\Desktop\ejemplo.pdf");
                iText.Kernel.Pdf.PdfDocument pdfDocument = new iText.Kernel.Pdf.PdfDocument(objPDF);
                Document document = new Document(pdfDocument);
                //document.Add(new Paragraph("Hello World!"));

                // Load image from disk.
                ImageData imageData1 = ImageDataFactory.Create(@"C:\Users\HP DESKTOP\Pictures\escritura.png");
                ImageData imageData2 = ImageDataFactory.Create(@"C:\Users\HP DESKTOP\Pictures\escritura 1.png");
                ImageData imageData3 = ImageDataFactory.Create(@"C:\Users\HP DESKTOP\Pictures\escritura 2.png");
                ImageData imageData4 = ImageDataFactory.Create(@"C:\Users\HP DESKTOP\Pictures\escritura 3.png");

                // Create layout image object and provide parameters. Page number = 1.
                iText.Layout.Element.Image image1 = new iText.Layout.Element.Image(imageData1);
                iText.Layout.Element.Image image2 = new iText.Layout.Element.Image(imageData2);
                iText.Layout.Element.Image image3 = new iText.Layout.Element.Image(imageData3);
                iText.Layout.Element.Image image4 = new iText.Layout.Element.Image(imageData4);

                // This adds the image to the page
                document.Add(image1);
                document.Add(image2);
                document.Add(image3);
                document.Add(image4);

                //pdfDocument.AddNewPage();
                document.Close();
            }
            catch (Exception ex)
            {
                Utilerias.strError = ex.Message;
            }
        }
        private void tbxURL_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string strURL = openFileDialog1.FileName.ToString();
                    tbxURL.Text = strURL;
                }
            }
        }
        private void BtnLeerPDF_Click(object sender, EventArgs e)
        {
            // Validar si esta vacio el URL.
            if (tbxURL.Text != "")
            {
                // Abrir ventana de hojas.
                imgPartidas frmPartidas = new imgPartidas();
                frmPartidas.Text = tbxURL.Text;
                frmPartidas.strNombreArchivo = tbxURL.Text;
                frmPartidas.strUrlArchivo = tbxURL.Text;
                frmPartidas.Show();
            }
            else
            {
                // Desplegar mensaje.
                MessageBox.Show("Solo archivos PDF", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}