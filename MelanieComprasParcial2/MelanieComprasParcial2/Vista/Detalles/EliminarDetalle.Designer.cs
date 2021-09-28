
namespace MelanieComprasParcial2.Vista.Detalles
{
    partial class EliminarDetalle
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
            this.DGVDetalles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEliminarEncabezado = new System.Windows.Forms.TextBox();
            this.txtEliminarProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminarDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVDetalles
            // 
            this.DGVDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDetalles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DGVDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDetalles.Location = new System.Drawing.Point(12, 53);
            this.DGVDetalles.Name = "DGVDetalles";
            this.DGVDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDetalles.Size = new System.Drawing.Size(434, 250);
            this.DGVDetalles.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eliminar Detalle";
            // 
            // txtEliminarEncabezado
            // 
            this.txtEliminarEncabezado.Location = new System.Drawing.Point(478, 124);
            this.txtEliminarEncabezado.Name = "txtEliminarEncabezado";
            this.txtEliminarEncabezado.Size = new System.Drawing.Size(100, 20);
            this.txtEliminarEncabezado.TabIndex = 3;
            // 
            // txtEliminarProducto
            // 
            this.txtEliminarProducto.Location = new System.Drawing.Point(478, 182);
            this.txtEliminarProducto.Name = "txtEliminarProducto";
            this.txtEliminarProducto.Size = new System.Drawing.Size(100, 20);
            this.txtEliminarProducto.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Código de Encabezado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Código de Producto";
            // 
            // btnEliminarDetalle
            // 
            this.btnEliminarDetalle.Location = new System.Drawing.Point(478, 225);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarDetalle.TabIndex = 7;
            this.btnEliminarDetalle.Text = "Eliminar";
            this.btnEliminarDetalle.UseVisualStyleBackColor = true;
            // 
            // EliminarDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 315);
            this.Controls.Add(this.btnEliminarDetalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEliminarProducto);
            this.Controls.Add(this.txtEliminarEncabezado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVDetalles);
            this.Name = "EliminarDetalle";
            this.Text = "EliminarDetalle";
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DGVDetalles;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtEliminarEncabezado;
        public System.Windows.Forms.TextBox txtEliminarProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnEliminarDetalle;
    }
}