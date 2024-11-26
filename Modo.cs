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
    public partial class Modo : Form
    {
        Form1 main;
        public Modo(Form1 _main)
        {
            InitializeComponent();
            main = _main;

        }
        public DataTable datos = new DataTable();

        private void btnVolver_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }

        string porcentaje= "100";

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Valida la opcion seleccionada 
            if (cbPorcentaje.SelectedIndex==1)
            {
                porcentaje=cbPorcentaje.Items[1].ToString();
            }
            else if (cbPorcentaje.SelectedIndex == 2)
            {
                porcentaje=cbPorcentaje.Items[2].ToString();
            }
            else if (cbPorcentaje.SelectedIndex==3)
            {
                porcentaje = cbPorcentaje.Items[3].ToString();
            }

            //Consulta de palabras de acuerdo al porcentaje elegido
            string query = $"select * from Palabra where Porcentaje<={porcentaje}";

            //Conexion a la bd
            SqlConnection cn = new SqlConnection(Configuracion.sql);
            cn.Open();
            SqlCommand comando = new SqlCommand(query, cn);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            
            //Llena el DataTable con los datos almacenados en el adapter
            adapter.Fill(datos);
            cn.Close();
            Lista lista = new Lista(this, datos);
            lista.Show();
            this.Hide();

        }

        private void Modo_Load(object sender, EventArgs e)
        {
            //Pone por defecto el textbox del Porcentaje en la opcion 1 (100%), Tipo en Todos y elimina los datos almacenados en el DataTable 'datos'
            cbPorcentaje.SelectedIndex = 0;
            cbTipo.SelectedIndex = 0;
            datos.Clear();
        }

        private void Modo_Load_1(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {

        }
    }
}
