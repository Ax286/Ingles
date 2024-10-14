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
    public partial class Lista : Form
    {
        public Lista()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();

            main.Show();
            this.Close(); 
        }

        private void Lista_Load(object sender, EventArgs e)
        {
            this.StartPosition= FormStartPosition.CenterScreen;
        }
    }
}
