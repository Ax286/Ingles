using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
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

        string sql = "server=LAPTOP-9LMT76US\\SQLEXPRESS; database=ingles; integrated security=true";

        private void Agregar_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(sql);
            Actualizar(cn);

            cbCategory.SelectedIndex = 0;
            if (cbCategory.SelectedIndex == 0)
            {
                txtEspaniol.Enabled = true;
            }
            else
            {
                txtEspaniol.Enabled = false;
            }
            

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(sql);

            if (cbCategory.SelectedIndex == 0)
            {
                string ingles = txtIngles.Text;
                string espaniol = txtEspaniol.Text;

                AgregarDatos(connection, espaniol, ingles);
            }
            else if (cbCategory.SelectedIndex == 1)
            {
                string eliminar = txtIngles.Text;
                Eliminar(connection, eliminar);
            }
            txtIngles.Text = "";
            txtEspaniol.Text = "";
            txtIngles.Focus();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            this.Close();
            main.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        void AgregarDatos(SqlConnection cn, string esp, string eng)
        {

            try
            {
                string query = "insert into Palabra (ct, espaniol,ingles) values (1,@espaniol,@ingles)";
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@espaniol", esp);
                command.Parameters.AddWithValue("@ingles", eng);
                cn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Agregado correctamente");
                cn.Close();
                Actualizar(cn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cn.Close();
        }
        void Actualizar(SqlConnection cn)
        {
            cn.Open();
            string query = "select espaniol,ingles from Palabra";
            SqlCommand command = new SqlCommand(query, cn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvData.DataSource = dt;    
            cn.Close();
        }

        void Practica(SqlConnection cn)
        {
            cn.Open();
            string query = "select espaniol,ingles from Palabra";
            SqlCommand command = new SqlCommand(query, cn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvData.DataSource = dt;
            cn.Close();

            int c = dt.Rows.Count;
            Random r = new Random();
            int n = r.Next(0, c);
            lbPrueba.Text = dt.Rows[n]["espaniol"].ToString();
        }
        void Eliminar(SqlConnection cn, string delete)
        {
            cn.Open();
            string query = "delete from Palabra where ingles=@delete";
            SqlCommand command = new SqlCommand(query, cn);
            command.Parameters.AddWithValue("@delete", delete);
            int resultado = command.ExecuteNonQuery();
            if (resultado > 0)
            {
                MessageBox.Show("Elemento eliminado");
            }
            else
            {
                MessageBox.Show("Elemento no encontrado");
            }
            cn.Close();
            Actualizar(cn);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedIndex == 0) 
            {
                txtEspaniol.Enabled=true;
            }
            else if (cbCategory.SelectedIndex == 1)
            {
                txtEspaniol.Enabled = false;
            }
        }
    }
}
