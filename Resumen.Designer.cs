namespace Ingles
{
    partial class Resumen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCorrecto = new System.Windows.Forms.Label();
            this.lbIncorrecto = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvResumen = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(175, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correctos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(342, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Incorrectos";
            // 
            // lbCorrecto
            // 
            this.lbCorrecto.AutoSize = true;
            this.lbCorrecto.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbCorrecto.Location = new System.Drawing.Point(218, 134);
            this.lbCorrecto.Name = "lbCorrecto";
            this.lbCorrecto.Size = new System.Drawing.Size(26, 29);
            this.lbCorrecto.TabIndex = 2;
            this.lbCorrecto.Text = "0";
            // 
            // lbIncorrecto
            // 
            this.lbIncorrecto.AutoSize = true;
            this.lbIncorrecto.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbIncorrecto.Location = new System.Drawing.Point(392, 134);
            this.lbIncorrecto.Name = "lbIncorrecto";
            this.lbIncorrecto.Size = new System.Drawing.Size(26, 29);
            this.lbIncorrecto.TabIndex = 3;
            this.lbIncorrecto.Text = "0";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.Location = new System.Drawing.Point(267, 482);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(98, 37);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvResumen
            // 
            this.dgvResumen.AllowUserToAddRows = false;
            this.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumen.Location = new System.Drawing.Point(47, 186);
            this.dgvResumen.Name = "dgvResumen";
            this.dgvResumen.ReadOnly = true;
            this.dgvResumen.RowHeadersWidth = 51;
            this.dgvResumen.RowTemplate.Height = 29;
            this.dgvResumen.Size = new System.Drawing.Size(556, 278);
            this.dgvResumen.TabIndex = 5;
            // 
            // Resumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 540);
            this.Controls.Add(this.dgvResumen);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lbIncorrecto);
            this.Controls.Add(this.lbCorrecto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Resumen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resumen";
            this.Load += new System.EventHandler(this.Resumen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbCorrecto;
        private Label lbIncorrecto;
        private Button btnAceptar;
        private DataGridView dgvResumen;
    }
}