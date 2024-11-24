using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingles
{
    public partial class Estadisticas : Form
    {
        Form1 main;
        public Estadisticas(Form1 _main)
        {
            InitializeComponent();
            main = _main;
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {      
            SqlConnection cn = new SqlConnection(Configuracion.sql);
            cn.Open();
            string query = "select espaniol, ingles, Correcto,Incorrecto,Total,Porcentaje from Palabra";
            SqlCommand comando = new SqlCommand(query,cn);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable datos = new DataTable();
            adapter.Fill(datos);
            dgvDatos.DataSource=datos;
            cn.Close();           

            dgvDatos.Columns[0].HeaderText = "Español";
            dgvDatos.Columns[1].HeaderText = "Ingles";
            dgvDatos.Columns[2].HeaderText = "Correcto";
            dgvDatos.Columns[3].HeaderText = "Incorrecto";
            dgvDatos.Columns[4].HeaderText = "Total";
            dgvDatos.Columns[5].HeaderText = "Dominio";

            lbTotal.Text=dgvDatos.Rows.Count.ToString();
            dgvDatos.CurrentCell = null;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }
    }
}
