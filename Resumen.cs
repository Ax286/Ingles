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
    public partial class Resumen : Form
    {
        int correctos, incorrectos;
        DataTable resumen=new DataTable();
 
        public Resumen(int _correctos, int _incorrectos, DataTable _resumen)
        {
            InitializeComponent();
            
            correctos = _correctos;
            incorrectos = _incorrectos;
            resumen= _resumen;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Resumen_Load(object sender, EventArgs e)
        {
            lbCorrecto.Text = correctos.ToString();
            lbIncorrecto.Text = incorrectos.ToString();
            dgvResumen.DataSource = resumen;

            dgvResumen.CurrentCell = null;

            int cantida=dgvResumen.Rows.Count;

            for(int i=0;i<cantida;i++) 
            {
                if(dgvResumen.Rows[i].Cells[3].Value != null && dgvResumen.Rows[i].Cells[3].Value.ToString() == "Correcto")
                {
                    dgvResumen.Rows[i].Cells[3].Style.BackColor= Color.Green;
                }
                else if (dgvResumen.Rows[i].Cells[3].Value != null && dgvResumen.Rows[i].Cells[3].Value.ToString() == "Incorrecto")
                {
                    dgvResumen.Rows[i].Cells[3].Style.BackColor=Color.Red;
                }
            }
        }
    }
}
