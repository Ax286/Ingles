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
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtDefinition = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ingles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espaniol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ingles,
            this.espaniol});
            this.dgvData.Location = new System.Drawing.Point(101, 170);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 25;
            this.dgvData.Size = new System.Drawing.Size(558, 175);
            this.dgvData.TabIndex = 0;
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(101, 127);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(108, 23);
            this.txtWord.TabIndex = 2;
            // 
            // txtDefinition
            // 
            this.txtDefinition.Location = new System.Drawing.Point(227, 127);
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.Size = new System.Drawing.Size(100, 23);
            this.txtDefinition.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(343, 127);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ingles
            // 
            this.ingles.HeaderText = "Ingles";
            this.ingles.Name = "ingles";
            // 
            // espaniol
            // 
            this.espaniol.HeaderText = "Español";
            this.espaniol.Name = "espaniol";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(445, 127);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 23);
            this.cbCategory.TabIndex = 5;
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDefinition);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.dgvData);
            this.Name = "Agregar";
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.Agregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvData;
        private TextBox txtWord;
        private TextBox txtDefinition;
        private Button btnAdd;
        private DataGridViewTextBoxColumn ingles;
        private DataGridViewTextBoxColumn espaniol;
        private ComboBox cbCategory;
    }
}