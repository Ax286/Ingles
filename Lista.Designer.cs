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
            btnVolver = new Button();
            btnIniciar = new Button();
            txtPalabra = new TextBox();
            txtTraduccion = new TextBox();
            lbConteo = new Label();
            btnValidar = new Button();
            lbPalabra = new Label();
            lbResultado = new Label();
            label1 = new Label();
            cbModo = new ComboBox();
            txtCantidad = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(170, 372);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(82, 22);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(121, 346);
            btnIniciar.Margin = new Padding(3, 2, 3, 2);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(82, 22);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // txtPalabra
            // 
            txtPalabra.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txtPalabra.Location = new Point(93, 82);
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(236, 50);
            txtPalabra.TabIndex = 2;
            // 
            // txtTraduccion
            // 
            txtTraduccion.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txtTraduccion.Location = new Point(93, 156);
            txtTraduccion.Name = "txtTraduccion";
            txtTraduccion.Size = new Size(236, 50);
            txtTraduccion.TabIndex = 3;
            // 
            // lbConteo
            // 
            lbConteo.AutoSize = true;
            lbConteo.Location = new Point(335, 82);
            lbConteo.Name = "lbConteo";
            lbConteo.Size = new Size(38, 15);
            lbConteo.TabIndex = 4;
            lbConteo.Text = "label1";
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(209, 346);
            btnValidar.Margin = new Padding(3, 2, 3, 2);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(82, 22);
            btnValidar.TabIndex = 5;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // lbPalabra
            // 
            lbPalabra.AutoSize = true;
            lbPalabra.Location = new Point(49, 82);
            lbPalabra.Name = "lbPalabra";
            lbPalabra.Size = new Size(38, 15);
            lbPalabra.TabIndex = 6;
            lbPalabra.Text = "label1";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbResultado.Location = new Point(150, 209);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(118, 32);
            lbResultado.TabIndex = 7;
            lbResultado.Text = "Resultado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(93, 18);
            label1.Name = "label1";
            label1.Size = new Size(233, 40);
            label1.TabIndex = 8;
            label1.Text = "Español - Ingles";
            // 
            // cbModo
            // 
            cbModo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbModo.FormattingEnabled = true;
            cbModo.Items.AddRange(new object[] { "Ingles - Español", "Español - Ingles" });
            cbModo.Location = new Point(150, 305);
            cbModo.Name = "cbModo";
            cbModo.Size = new Size(121, 23);
            cbModo.TabIndex = 9;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(220, 267);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(48, 23);
            txtCantidad.TabIndex = 10;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 270);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 11;
            label2.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(335, 168);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 12;
            label3.Text = "label3";
            // 
            // Lista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 414);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCantidad);
            Controls.Add(cbModo);
            Controls.Add(label1);
            Controls.Add(lbResultado);
            Controls.Add(lbPalabra);
            Controls.Add(btnValidar);
            Controls.Add(lbConteo);
            Controls.Add(txtTraduccion);
            Controls.Add(txtPalabra);
            Controls.Add(btnIniciar);
            Controls.Add(btnVolver);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Lista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista";
            Load += Lista_Load;
            ResumeLayout(false);
            PerformLayout();
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
    }
}