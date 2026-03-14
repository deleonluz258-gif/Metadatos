namespace AppMetadatos
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarInicio = new System.Windows.Forms.Button();
            this.btnAgregarMedio = new System.Windows.Forms.Button();
            this.btnAgregarFinal = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.numPosicion = new System.Windows.Forms.NumericUpDown();
            this.dgvMetadatos = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFormato = new System.Windows.Forms.TextBox();
            this.txtResolucion = new System.Windows.Forms.TextBox();
            this.pbVistaPrevia = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPosicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetadatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVistaPrevia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imagenes ";
            // 
            // btnAgregarInicio
            // 
            this.btnAgregarInicio.Location = new System.Drawing.Point(12, 223);
            this.btnAgregarInicio.Name = "btnAgregarInicio";
            this.btnAgregarInicio.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarInicio.TabIndex = 2;
            this.btnAgregarInicio.Text = "Inicio";
            this.btnAgregarInicio.UseVisualStyleBackColor = true;
            this.btnAgregarInicio.Click += new System.EventHandler(this.btnAgregarInicio_Click);
            // 
            // btnAgregarMedio
            // 
            this.btnAgregarMedio.Location = new System.Drawing.Point(12, 293);
            this.btnAgregarMedio.Name = "btnAgregarMedio";
            this.btnAgregarMedio.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMedio.TabIndex = 3;
            this.btnAgregarMedio.Text = "Medio";
            this.btnAgregarMedio.UseVisualStyleBackColor = true;
            this.btnAgregarMedio.Click += new System.EventHandler(this.btnAgregarMedio_Click);
            // 
            // btnAgregarFinal
            // 
            this.btnAgregarFinal.Location = new System.Drawing.Point(15, 357);
            this.btnAgregarFinal.Name = "btnAgregarFinal";
            this.btnAgregarFinal.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarFinal.TabIndex = 4;
            this.btnAgregarFinal.Text = "Final";
            this.btnAgregarFinal.UseVisualStyleBackColor = true;
            this.btnAgregarFinal.Click += new System.EventHandler(this.btnAgregarFinal_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(143, 223);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(143, 293);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // numPosicion
            // 
            this.numPosicion.Location = new System.Drawing.Point(143, 358);
            this.numPosicion.Name = "numPosicion";
            this.numPosicion.Size = new System.Drawing.Size(120, 22);
            this.numPosicion.TabIndex = 7;
            // 
            // dgvMetadatos
            // 
            this.dgvMetadatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMetadatos.Location = new System.Drawing.Point(323, 199);
            this.dgvMetadatos.Name = "dgvMetadatos";
            this.dgvMetadatos.RowHeadersWidth = 51;
            this.dgvMetadatos.RowTemplate.Height = 24;
            this.dgvMetadatos.Size = new System.Drawing.Size(446, 199);
            this.dgvMetadatos.TabIndex = 8;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(15, 53);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(178, 23);
            this.btnSeleccionar.TabIndex = 9;
            this.btnSeleccionar.Text = "Seleccionar Imagen";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 97);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 10;
            // 
            // txtFormato
            // 
            this.txtFormato.Location = new System.Drawing.Point(12, 142);
            this.txtFormato.Name = "txtFormato";
            this.txtFormato.Size = new System.Drawing.Size(100, 22);
            this.txtFormato.TabIndex = 11;
            // 
            // txtResolucion
            // 
            this.txtResolucion.Location = new System.Drawing.Point(15, 185);
            this.txtResolucion.Name = "txtResolucion";
            this.txtResolucion.Size = new System.Drawing.Size(100, 22);
            this.txtResolucion.TabIndex = 12;
            // 
            // pbVistaPrevia
            // 
            this.pbVistaPrevia.Location = new System.Drawing.Point(529, 21);
            this.pbVistaPrevia.Name = "pbVistaPrevia";
            this.pbVistaPrevia.Size = new System.Drawing.Size(240, 124);
            this.pbVistaPrevia.TabIndex = 13;
            this.pbVistaPrevia.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbVistaPrevia);
            this.Controls.Add(this.txtResolucion);
            this.Controls.Add(this.txtFormato);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvMetadatos);
            this.Controls.Add(this.numPosicion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregarFinal);
            this.Controls.Add(this.btnAgregarMedio);
            this.Controls.Add(this.btnAgregarInicio);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPosicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetadatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVistaPrevia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarInicio;
        private System.Windows.Forms.Button btnAgregarMedio;
        private System.Windows.Forms.Button btnAgregarFinal;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.NumericUpDown numPosicion;
        private System.Windows.Forms.DataGridView dgvMetadatos;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtFormato;
        private System.Windows.Forms.TextBox txtResolucion;
        private System.Windows.Forms.PictureBox pbVistaPrevia;
    }
}

