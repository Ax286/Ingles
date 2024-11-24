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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.txtIngles = new System.Windows.Forms.TextBox();
            this.txtEspaniol = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lbPrueba = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(115, 227);
            this.dgvData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 25;
            this.dgvData.Size = new System.Drawing.Size(638, 233);
            this.dgvData.TabIndex = 0;
            // 
            // txtIngles
            // 
            this.txtIngles.Location = new System.Drawing.Point(115, 169);
            this.txtIngles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIngles.Name = "txtIngles";
            this.txtIngles.Size = new System.Drawing.Size(123, 27);
            this.txtIngles.TabIndex = 2;
            // 
            // txtEspaniol
            // 
            this.txtEspaniol.Location = new System.Drawing.Point(259, 169);
            this.txtEspaniol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEspaniol.Name = "txtEspaniol";
            this.txtEspaniol.Size = new System.Drawing.Size(114, 27);
            this.txtEspaniol.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(522, 168);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 31);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Confirmar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Agregar",
            "Eliminar"});
            this.cbCategory.Location = new System.Drawing.Point(615, 169);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(138, 28);
            this.cbCategory.TabIndex = 5;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(667, 468);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(86, 31);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lbPrueba
            // 
            this.lbPrueba.AutoSize = true;
            this.lbPrueba.Location = new System.Drawing.Point(115, 479);
            this.lbPrueba.Name = "lbPrueba";
            this.lbPrueba.Size = new System.Drawing.Size(50, 20);
            this.lbPrueba.TabIndex = 7;
            this.lbPrueba.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Espaniol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ingles";
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPrueba);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtEspaniol);
            this.Controls.Add(this.txtIngles);
            this.Controls.Add(this.dgvData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Agregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.Agregar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Agregar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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