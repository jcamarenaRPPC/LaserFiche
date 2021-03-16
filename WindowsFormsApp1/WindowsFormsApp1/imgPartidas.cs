using IronPdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText;

namespace WindowsFormsApp1
{
    public partial class imgPartidas : Form
    {
        // Variables publicas.
        public Dictionary<string, System.Drawing.Image> lstDiccionarioHojas = new Dictionary<string, System.Drawing.Image>();
        public string strNombreArchivo = "";
        public string strUrlArchivo = "";

        public imgPartidas()
        {
            InitializeComponent();
        }
        private void imgPartidas_Load(object sender, EventArgs e)
        {
            lstHojas.MouseUp += new MouseEventHandler(lstHojas_MouseClick);
            // Leer PDF.
            LeerPDF();
        }
        public void lstHojas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lstHojas.SelectedItems.Count != 0)
                {
                    // Crear opcion del menú de contexto.
                    ContextMenu objMenuDerecho = new ContextMenu();
                    MenuItem objEliminarHoja = new MenuItem("Eliminar");
                    objEliminarHoja.Click += delegate (object sender2, EventArgs e2) {
                        EliminarHoja(lstHojas.SelectedItems[0].Index);
                    };

                    // Crear opcion del menú de contexto.
                    MenuItem objCopiarHoja = new MenuItem("Copiar");
                    objCopiarHoja.Click += delegate (object sender2, EventArgs e2) {
                        // your code here.
                    };

                    // Crear opcion del menú de contexto.
                    MenuItem objPegarHoja = new MenuItem("Pegar");
                    objPegarHoja.Click += delegate (object sender2, EventArgs e2) {
                        // your code here.
                    };

                    // Agregar items al menú de contexto.
                    objMenuDerecho.MenuItems.Add(objEliminarHoja);
                    objMenuDerecho.MenuItems.Add(objCopiarHoja);
                    objMenuDerecho.MenuItems.Add(objPegarHoja);

                    // Pocisionar el context menu a mouse.
                    objMenuDerecho.Show(lstHojas, new Point(e.X, e.Y));
                }
            }
        }
        private void lstHojas_Click(object sender, EventArgs e)
        {
            // seleccionar hoja.
            seleccionarHoja();
        }
        private void lstHojas_KeyUp(object sender, KeyEventArgs e)
        {
            // Validar que existan hojas seleccionadas.
            if (lstHojas.SelectedItems.Count != 0)
            {
                // Validar que la tecla sea el delete.
                if (e.KeyCode == Keys.Delete)
                {
                    //// Eliminar hoja del pdf
                    //int intHojaEliminar = -1;
                    //string[] array = lstHojas.SelectedItems[0].ImageKey.Split('/');
                    //string strImageKey = array[1];

                    //// Buscar y remover la imagen seleccionada del diccionario de imagenes.
                    //lstDiccionarioHojas.Remove(lstHojas.SelectedItems[0].ImageKey);
                    //lstHojas.SelectedItems[0].Remove();

                    //// Limpiar la el control para la hoja.
                    //imgHoja.Image = null;

                    EliminarHoja(lstHojas.SelectedItems[0].Index);
                }
                // Validar que se seleccionen las hojas con las teclas de movimiento.
                else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                {
                    // seleccionar hoja.
                    seleccionarHoja();
                }
            }
            else
            {
                // Asignar texto.
                imgHoja.Text = "No hay documentos seleccionados";
            }
        }
        public void seleccionarHoja()
        {
            // Buscar y obtener la imagen seleccionada del diccionario de imagenes.
            System.Drawing.Image objImagen = (System.Drawing.Image)lstDiccionarioHojas[lstHojas.SelectedItems[0].ImageKey];

            // Limpiar texto.
            imgHoja.Text = "";

            // Asignar la imagen al image viewer.
            imgHoja.Image = objImagen;
        }
        public void EliminarHoja(int intHojaAEliminar)
        {
            try
            {
                // Eliminar hoja del pdf
                int intHojaEliminar = -1;
                string[] array = lstHojas.SelectedItems[0].ImageKey.Split('/');
                string strImageKey = array[1];

                // Buscar y remover la imagen seleccionada del diccionario de imagenes.
                lstDiccionarioHojas.Remove(lstHojas.SelectedItems[0].ImageKey);
                lstHojas.SelectedItems[0].Remove();

                // Limpiar la el control para la hoja.
                imgHoja.Image = null;

                // Crear PDF
                PdfDocument PDF = new PdfDocument(strNombreArchivo);

                // Quitar hoja y actualizar documento.
                PDF.RemovePage(intHojaAEliminar);
                PDF.SaveAs(strNombreArchivo);

                // Leer archivo.
                LeerPDF();
            }
            catch (Exception ex)
            {
                // Desplegar mensaje.
                MessageBox.Show("No se puede grabar el archivo PDF con 0 hojas.\n" + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LeerPDF()
        {
            // Variables.
            ImageList imageList = new ImageList();
            Bitmap[] pageImages;
            lstDiccionarioHojas.Clear();
            lstHojas.Clear();

            // Validar si esta vacio el URL.
            if (strNombreArchivo != "")
            {
                // Abrir el documento pdf.
                var pdf = IronPdf.PdfDocument.FromFile(strNombreArchivo);

                // Extraer todas las paginas y comvertirlas a imagen en un arreglo de bitmaps.
                pageImages = pdf.ToBitmap();

                // Recorrer el arreglo de imagenes.
                for (int intRegistro = 0; intRegistro <= pageImages.Count<Bitmap>() - 1; intRegistro++)
                {
                    // Crear el elemento de del listview.
                    ListViewItem listViewItem = lstHojas.Items.Add(intRegistro.ToString());

                    // Decirle que image usara com thumbnail.
                    listViewItem.ImageKey = "imagen/" + intRegistro;

                    // Obtener el objeto imagen seleccionada.
                    System.Drawing.Image objImagen = (System.Drawing.Image)pageImages[intRegistro];

                    // Crear la lista d imagenes y llenar el listview.
                    imageList.Images.Add("imagen/" + intRegistro, objImagen);

                    // Indicarle al control que imageList usará.
                    imageList.ImageSize = new Size(256, 256);

                    lstHojas.LargeImageList = imageList;
                    // Agregar las imagenes al diccionario de imagenes.
                    lstDiccionarioHojas.Add("imagen/" + intRegistro, objImagen);
                }
            }
        }
    }
}
