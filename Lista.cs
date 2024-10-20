using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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

        string sql = "server=LAPTOP-JSH17H4D; database=ingles; integrated security=true";
        DataTable dt = new DataTable();
        DataTable copia = new DataTable();

        private void Lista_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            txtPalabra.Enabled = false;
            txtTraduccion.Enabled = false;
            lbPalabra.Hide();
            cbModo.SelectedIndex = 0;
            label1.Text = cbModo.Items[0].ToString();

            SqlConnection cn = new SqlConnection(sql);
            cn.Open();
            string query = "select espaniol,ingles from Palabra";
            SqlCommand command = new SqlCommand(query, cn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            cn.Close();
            adapter.Fill(dt);
            copia = dt.Copy();
            txtCantidad.Text = dt.Rows.Count.ToString();
        }


        public int n = 0;

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            dt = copia.Copy();
            label3.Text = conteo.ToString();

            int cantidad = dt.Rows.Count;
            Random azar = new Random();
            n = azar.Next(0, cantidad);
            lbConteo.Text = cantidad.ToString();

            btnIniciar.Enabled = false;
            btnValidar.Enabled = true;
            txtTraduccion.Enabled = true;
            txtTraduccion.Focus();
            txtCantidad.Enabled = false;
            cbModo.Enabled = false;

            if (cantidad > 0)
            {

                lbPalabra.Text = dt.Rows[n]["espaniol"].ToString();

                if (cbModo.SelectedIndex == 0)
                {
                    label1.Text = cbModo.Items[0].ToString();
                    txtPalabra.Text = dt.Rows[n]["ingles"].ToString();
                }
                else if (cbModo.SelectedIndex == 1)
                {
                    label1.Text = cbModo.Items[1].ToString();
                    txtPalabra.Text = dt.Rows[n]["espaniol"].ToString();
                }
                else
                {
                    MessageBox.Show("No hay palabras");
                }
            }
        }
        int c = 0, i = 0,conteo=0;
        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtCantidad.Text)!=conteo)
            {
                conteo += 1;
                label3.Text = conteo.ToString();

                if (cbModo.SelectedIndex == 0)
                {
                    Modo("espaniol", "ingles");
                }
                else if (cbModo.SelectedIndex == 1)
                {
                    Modo("ingles", "espaniol");
                }
                if(conteo==int.Parse(txtCantidad.Text))
                {
                    MessageBox.Show("Correctas: " + c.ToString() + " Incorrectas: " + i.ToString());
                    Limpiar();
                }
            }
        }

        void Modo(string palabra, string traduccion)
        {
            int cantidad = dt.Rows.Count;
            Random azar = new Random();

            if (txtTraduccion.Text == dt.Rows[n][palabra].ToString())
            {
                lbResultado.Text = "Correcto";
                c += 1;
            }
            else
            {
                lbResultado.Text = "Incorrecto";
                i += 1;
            }

            txtTraduccion.Text = "";
            txtTraduccion.Focus();

            foreach (DataRow dr in dt.Rows)
            {
                if (dr[traduccion].ToString() == txtPalabra.Text)
                {
                    dr.Delete();
                }
            }
            dt.AcceptChanges();

            txtTraduccion.Enabled = true;
            txtTraduccion.Focus();

            cantidad = dt.Rows.Count;

            if (cantidad > 0)
            {
                n = azar.Next(0, cantidad);
                txtPalabra.Text = dt.Rows[n][traduccion].ToString();
                lbPalabra.Text = dt.Rows[n][palabra].ToString();
                lbConteo.Text = cantidad.ToString();
            }
            else
            {
                Limpiar();
            }
        }

        void Limpiar()
        {
            btnIniciar.Enabled = true;
            btnValidar.Enabled = false;
            txtTraduccion.Text = "";
            txtPalabra.Text = "";
            lbResultado.Text = "Resultado";
            txtTraduccion.Enabled = false;
            txtCantidad.Enabled = true;
            cbModo.Enabled = true;
            c = 0;
            i = 0;
            conteo = 0;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
