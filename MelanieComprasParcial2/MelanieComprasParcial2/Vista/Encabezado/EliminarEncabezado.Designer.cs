
namespace MelanieComprasParcial2.Vista.Encabezado
{
    partial class EliminarEncabezado
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
            this.btnEliminarDetalle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEliminarEncabezado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVDetalles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarDetalle
            // 
            this.btnEliminarDetalle.Location = new System.Drawing.Point(514, 198);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarDetalle.TabIndex = 14;
            this.btnEliminarDetalle.Text = "Eliminar";
            this.btnEliminarDetalle.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Código de Encabezado";
            // 
            // txtEliminarEncabezado
            // 
            this.txtEliminarEncabezado.Location = new System.Drawing.Point(501, 145);
            this.txtEliminarEncabezado.Name = "txtEliminarEncabezado";
            this.txtEliminarEncabezado.Size = new System.Drawing.Size(100, 20);
            this.txtEliminarEncabezado.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Eliminar Encabezado";
            // 
            // DGVDetalles
            // 
            this.DGVDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDetalles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DGVDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDetalles.Location = new System.Drawing.Point(35, 74);
            this.DGVDetalles.Name = "DGVDetalles";
            this.DGVDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDetalles.Size = new System.Drawing.Size(434, 250);
            this.DGVDetalles.TabIndex = 8;
            // 
            // EliminarEncabezado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 354);
            this.Controls.Add(this.btnEliminarDetalle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEliminarEncabezado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVDetalles);
            this.Name = "EliminarEncabezado";
            this.Text = "EliminarEncabezado";
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnEliminarDetalle;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtEliminarEncabezado;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView DGVDetalles;
    }
}