namespace Ingles
{
    partial class Agregar
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
            dgvData = new DataGridView();
            txtIngles = new TextBox();
            txtEspaniol = new TextBox();
            btnAdd = new Button();
            cbCategory = new ComboBox();
            btnVolver = new Button();
            lbPrueba = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.AllowUserToResizeColumns = false;
            dgvData.AllowUserToResizeRows = false;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(101, 170);
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(558, 175);
            dgvData.TabIndex = 0;
            // 
            // txtIngles
            // 
            txtIngles.Location = new Point(101, 127);
            txtIngles.Name = "txtIngles";
            txtIngles.Size = new Size(108, 23);
            txtIngles.TabIndex = 2;
            // 
            // txtEspaniol
            // 
            txtEspaniol.Location = new Point(227, 127);
            txtEspaniol.Name = "txtEspaniol";
            txtEspaniol.Size = new Size(100, 23);
            txtEspaniol.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(457, 126);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Confirmar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "Agregar", "Eliminar" });
            cbCategory.Location = new Point(538, 127);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(121, 23);
            cbCategory.TabIndex = 5;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(584, 351);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lbPrueba
            // 
            lbPrueba.AutoSize = true;
            lbPrueba.Location = new Point(101, 359);
            lbPrueba.Name = "lbPrueba";
            lbPrueba.Size = new Size(38, 15);
            lbPrueba.TabIndex = 7;
            lbPrueba.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 109);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 8;
            label1.Text = "Espaniol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 109);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 9;
            label2.Text = "Ingles";
            // 
            // Agregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbPrueba);
            Controls.Add(btnVolver);
            Controls.Add(cbCategory);
            Controls.Add(btnAdd);
            Controls.Add(txtEspaniol);
            Controls.Add(txtIngles);
            Controls.Add(dgvData);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Agregar";
            Text = "Agregar";
            Load += Agregar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvData;
        private TextBox txtIngles;
        private TextBox txtEspaniol;
        private Button btnAdd;
        private ComboBox cbCategory;
        private Button btnVolver;
        private Label lbPrueba;
        private Label label1;
        private Label label2;
    }
}