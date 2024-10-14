using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingles
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            dgvData.Rows.Add("Bureau","Oficina");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string word=txtWord.Text;
            string df=txtDefinition.Text;

            dgvData.Rows.Add(word, df);
        }
    }
}
