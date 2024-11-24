namespace Ingles
{
    partial class Lista
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.txtTraduccion = new System.Windows.Forms.TextBox();
            this.lbConteo = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lbPalabra = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbModo = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCorrecto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(194, 496);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(94, 29);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(138, 461);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(94, 29);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtPalabra
            // 
            this.txtPalabra.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPalabra.Location = new System.Drawing.Point(106, 109);
            this.txtPalabra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(269, 61);
            this.txtPalabra.TabIndex = 2;
            // 
            // txtTraduccion
            // 
            this.txtTraduccion.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTraduccion.Location = new System.Drawing.Point(106, 208);
            this.txtTraduccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTraduccion.Name = "txtTraduccion";
            this.txtTraduccion.Size = new System.Drawing.Size(269, 61);
            this.txtTraduccion.TabIndex = 3;
            // 
            // lbConteo
            // 
            this.lbConteo.AutoSize = true;
            this.lbConteo.Location = new System.Drawing.Point(383, 109);
            this.lbConteo.Name = "lbConteo";
            this.lbConteo.Size = new System.Drawing.Size(50, 20);
            this.lbConteo.TabIndex = 4;
            this.lbConteo.Text = "label1";
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(239, 461);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(94, 29);
            this.btnValidar.TabIndex = 5;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // lbPalabra
            // 
            this.lbPalabra.AutoSize = true;
            this.lbPalabra.Location = new System.Drawing.Point(56, 109);
            this.lbPalabra.Name = "lbPalabra";
            this.lbPalabra.Size = new System.Drawing.Size(50, 20);
            this.lbPalabra.TabIndex = 6;
            this.lbPalabra.Text = "label1";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbResultado.Location = new System.Drawing.Point(171, 279);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(149, 41);
            this.lbResultado.TabIndex = 7;
            this.lbResultado.Text = "Resultado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 50);
            this.label1.TabIndex = 8;
            this.label1.Text = "ingles espaniol";
            // 
            // cbModo
            // 
            this.cbModo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModo.FormattingEnabled = true;
            this.cbModo.Items.AddRange(new object[] {
            "Ingles - Español",
            "Español - Ingles"});
            this.cbModo.Location = new System.Drawing.Point(171, 407);
            this.cbModo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbModo.Name = "cbModo";
            this.cbModo.Size = new System.Drawing.Size(138, 28);
            this.cbModo.TabIndex = 9;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(251, 356);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(54, 27);
            this.txtCantidad.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            // 
            // lbCorrecto
            // 
            this.lbCorrecto.AutoSize = true;
            this.lbCorrecto.Location = new System.Drawing.Point(383, 367);
            this.lbCorrecto.Name = "lbCorrecto";
            this.lbCorrecto.Size = new System.Drawing.Size(50, 20);
            this.lbCorrecto.TabIndex = 13;
            this.lbCorrecto.Text = "label4";
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 552);
            this.Controls.Add(this.lbCorrecto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cbModo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbPalabra);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.lbConteo);
            this.Controls.Add(this.txtTraduccion);
            this.Controls.Add(this.txtPalabra);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnVolver);
            this.KeyPreview = true;
            this.Name = "Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.Lista_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Lista_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnVolver;
        private Button btnIniciar;
        private TextBox txtPalabra;
        private TextBox txtTraduccion;
        private Label lbConteo;
        private Button btnValidar;
        private Label lbPalabra;
        private Label lbResultado;
        private Label label1;
        private ComboBox cbModo;
        private TextBox txtCantidad;
        private Label label2;
        private Label label3;
        private Label lbCorrecto;
    }
}