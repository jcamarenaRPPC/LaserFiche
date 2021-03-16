
namespace WindowsFormsApp1
{
    partial class imgPartidas
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
            this.components = new System.ComponentModel.Container();
            this.imgHoja = new Cyotek.Windows.Forms.ImageBox();
            this.lstHojas = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // imgHoja
            // 
            this.imgHoja.AllowClickZoom = true;
            this.imgHoja.AllowUnfocusedMouseWheel = true;
            this.imgHoja.AlwaysShowHScroll = true;
            this.imgHoja.AlwaysShowVScroll = true;
            this.imgHoja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgHoja.ForeColor = System.Drawing.Color.Maroon;
            this.imgHoja.GridDisplayMode = Cyotek.Windows.Forms.ImageBoxGridDisplayMode.Image;
            this.imgHoja.GridScale = Cyotek.Windows.Forms.ImageBoxGridScale.None;
            this.imgHoja.ImageBorderStyle = Cyotek.Windows.Forms.ImageBoxBorderStyle.FixedSingle;
            this.imgHoja.Location = new System.Drawing.Point(731, 9);
            this.imgHoja.Name = "imgHoja";
            this.imgHoja.Size = new System.Drawing.Size(797, 813);
            this.imgHoja.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Fit;
            this.imgHoja.TabIndex = 9;
            this.imgHoja.Text = "No hay documentos seleccionados";
            this.imgHoja.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.imgHoja.Zoom = 1;
            // 
            // lstHojas
            // 
            this.lstHojas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstHojas.HideSelection = false;
            this.lstHojas.LabelWrap = false;
            this.lstHojas.Location = new System.Drawing.Point(2, 12);
            this.lstHojas.MultiSelect = false;
            this.lstHojas.Name = "lstHojas";
            this.lstHojas.Size = new System.Drawing.Size(723, 813);
            this.lstHojas.TabIndex = 8;
            this.lstHojas.UseCompatibleStateImageBehavior = false;
            this.lstHojas.Click += new System.EventHandler(this.lstHojas_Click);
            this.lstHojas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstHojas_KeyUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // imgPartidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 837);
            this.Controls.Add(this.imgHoja);
            this.Controls.Add(this.lstHojas);
            this.Name = "imgPartidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[NombreDelArchivo]";
            this.Load += new System.EventHandler(this.imgPartidas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Cyotek.Windows.Forms.ImageBox imgHoja;
        private System.Windows.Forms.ListView lstHojas;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}