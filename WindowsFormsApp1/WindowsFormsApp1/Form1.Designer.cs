
namespace WindowsFormsApp1
{
    partial class frmLeerPDF
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerarPDF = new System.Windows.Forms.Button();
            this.grpBuscarArchivo = new System.Windows.Forms.GroupBox();
            this.btnLeerPDF = new System.Windows.Forms.Button();
            this.tbxURL = new System.Windows.Forms.TextBox();
            this.lblBuscarArchivo = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpBuscarArchivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarPDF.Location = new System.Drawing.Point(12, 12);
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.Size = new System.Drawing.Size(406, 115);
            this.btnGenerarPDF.TabIndex = 2;
            this.btnGenerarPDF.Text = "Generar PDF";
            this.btnGenerarPDF.UseVisualStyleBackColor = true;
            this.btnGenerarPDF.Click += new System.EventHandler(this.btnGenerarPDF_Click);
            // 
            // grpBuscarArchivo
            // 
            this.grpBuscarArchivo.Controls.Add(this.btnLeerPDF);
            this.grpBuscarArchivo.Controls.Add(this.tbxURL);
            this.grpBuscarArchivo.Controls.Add(this.lblBuscarArchivo);
            this.grpBuscarArchivo.Location = new System.Drawing.Point(13, 133);
            this.grpBuscarArchivo.Name = "grpBuscarArchivo";
            this.grpBuscarArchivo.Size = new System.Drawing.Size(405, 119);
            this.grpBuscarArchivo.TabIndex = 0;
            this.grpBuscarArchivo.TabStop = false;
            this.grpBuscarArchivo.Text = "Consultar archivo";
            // 
            // btnLeerPDF
            // 
            this.btnLeerPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeerPDF.Location = new System.Drawing.Point(256, 53);
            this.btnLeerPDF.Name = "btnLeerPDF";
            this.btnLeerPDF.Size = new System.Drawing.Size(136, 60);
            this.btnLeerPDF.TabIndex = 3;
            this.btnLeerPDF.Text = "Leer PDF";
            this.btnLeerPDF.UseVisualStyleBackColor = true;
            this.btnLeerPDF.Click += new System.EventHandler(this.BtnLeerPDF_Click);
            // 
            // tbxURL
            // 
            this.tbxURL.Location = new System.Drawing.Point(87, 27);
            this.tbxURL.Name = "tbxURL";
            this.tbxURL.ReadOnly = true;
            this.tbxURL.Size = new System.Drawing.Size(305, 20);
            this.tbxURL.TabIndex = 0;
            this.tbxURL.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxURL_KeyUp);
            // 
            // lblBuscarArchivo
            // 
            this.lblBuscarArchivo.AutoSize = true;
            this.lblBuscarArchivo.Location = new System.Drawing.Point(6, 30);
            this.lblBuscarArchivo.Name = "lblBuscarArchivo";
            this.lblBuscarArchivo.Size = new System.Drawing.Size(78, 13);
            this.lblBuscarArchivo.TabIndex = 0;
            this.lblBuscarArchivo.Text = "Buscar archivo";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmLeerPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 262);
            this.Controls.Add(this.grpBuscarArchivo);
            this.Controls.Add(this.btnGenerarPDF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmLeerPDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laser fiche 2.0";
            this.grpBuscarArchivo.ResumeLayout(false);
            this.grpBuscarArchivo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGenerarPDF;
        private System.Windows.Forms.GroupBox grpBuscarArchivo;
        private System.Windows.Forms.Button btnLeerPDF;
        private System.Windows.Forms.TextBox tbxURL;
        private System.Windows.Forms.Label lblBuscarArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

