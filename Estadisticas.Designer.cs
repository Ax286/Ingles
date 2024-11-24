namespace Ingles
{
    partial class Estadisticas
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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(61, 105);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 25;
            this.dgvDatos.Size = new System.Drawing.Size(802, 282);
            this.dgvDatos.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(777, 403);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(86, 31);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(61, 408);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(49, 20);
            this.lbTotal.TabIndex = 2;
            this.lbTotal.Text = "Total: ";
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 474);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvDatos);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvDatos;
        private Button btnVolver;
        private Label lbTotal;
    }
}