namespace Ingles
{
    partial class Modo
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
            this.cbPorcentaje = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbPorcentaje
            // 
            this.cbPorcentaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPorcentaje.FormattingEnabled = true;
            this.cbPorcentaje.Items.AddRange(new object[] {
            "100",
            "80",
            "50",
            "20"});
            this.cbPorcentaje.Location = new System.Drawing.Point(125, 99);
            this.cbPorcentaje.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPorcentaje.Name = "cbPorcentaje";
            this.cbPorcentaje.Size = new System.Drawing.Size(138, 28);
            this.cbPorcentaje.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elija el porcentaje de aprendizaje";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(149, 239);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(86, 31);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Elija el tipo de las palabras";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Todos"});
            this.cbTipo.Location = new System.Drawing.Point(125, 188);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(138, 28);
            this.cbTipo.TabIndex = 3;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(14, 309);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(86, 31);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Modo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 356);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPorcentaje);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Modo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modo";
            this.Load += new System.EventHandler(this.Modo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbPorcentaje;
        private Label label1;
        private Button btnAceptar;
        private Label label2;
        private ComboBox cbTipo;
        private Button btnVolver;
    }
}