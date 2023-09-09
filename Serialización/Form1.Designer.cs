namespace Serialización
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.txtBxCodigo = new System.Windows.Forms.TextBox();
            this.txtBxDescripcion = new System.Windows.Forms.TextBox();
            this.txtBxPrecio = new System.Windows.Forms.TextBox();
            this.txtBxExistencia = new System.Windows.Forms.TextBox();
            this.btnCargarProducto = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(10, 57);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 15);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(12, 86);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio";
            // 
            // lblExistencia
            // 
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Location = new System.Drawing.Point(12, 119);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(59, 15);
            this.lblExistencia.TabIndex = 3;
            this.lblExistencia.Text = "Existencia";
            // 
            // txtBxCodigo
            // 
            this.txtBxCodigo.Location = new System.Drawing.Point(85, 20);
            this.txtBxCodigo.Name = "txtBxCodigo";
            this.txtBxCodigo.Size = new System.Drawing.Size(138, 23);
            this.txtBxCodigo.TabIndex = 4;
            // 
            // txtBxDescripcion
            // 
            this.txtBxDescripcion.Location = new System.Drawing.Point(85, 49);
            this.txtBxDescripcion.Name = "txtBxDescripcion";
            this.txtBxDescripcion.Size = new System.Drawing.Size(138, 23);
            this.txtBxDescripcion.TabIndex = 5;
            // 
            // txtBxPrecio
            // 
            this.txtBxPrecio.Location = new System.Drawing.Point(85, 78);
            this.txtBxPrecio.Name = "txtBxPrecio";
            this.txtBxPrecio.Size = new System.Drawing.Size(138, 23);
            this.txtBxPrecio.TabIndex = 6;
            // 
            // txtBxExistencia
            // 
            this.txtBxExistencia.Location = new System.Drawing.Point(85, 111);
            this.txtBxExistencia.Name = "txtBxExistencia";
            this.txtBxExistencia.Size = new System.Drawing.Size(138, 23);
            this.txtBxExistencia.TabIndex = 7;
            // 
            // btnCargarProducto
            // 
            this.btnCargarProducto.Location = new System.Drawing.Point(85, 166);
            this.btnCargarProducto.Name = "btnCargarProducto";
            this.btnCargarProducto.Size = new System.Drawing.Size(124, 35);
            this.btnCargarProducto.TabIndex = 8;
            this.btnCargarProducto.Text = "Cargar Producto";
            this.btnCargarProducto.UseVisualStyleBackColor = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 23);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 15);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Código";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 312);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnCargarProducto);
            this.Controls.Add(this.txtBxExistencia);
            this.Controls.Add(this.txtBxPrecio);
            this.Controls.Add(this.txtBxDescripcion);
            this.Controls.Add(this.txtBxCodigo);
            this.Controls.Add(this.lblExistencia);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblDescripcion;
        private Label lblPrecio;
        private Label lblExistencia;
        private TextBox txtBxCodigo;
        private TextBox txtBxDescripcion;
        private TextBox txtBxPrecio;
        private TextBox txtBxExistencia;
        private Button btnCargarProducto;
        private Label lblCodigo;
    }
}