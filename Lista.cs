using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Ingles
{
    public partial class Lista : Form
    {
        Modo modo;
        DataTable dt = new DataTable();
        DataTable copia = new DataTable();
        DataTable resumen= new DataTable();
       

        public Lista(Modo _modo,DataTable _dt)
        {
            InitializeComponent();
            modo = _modo;
            dt = _dt;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            modo.datos.Clear();
            modo.Show();
            this.Close();
        }



        SoundPlayer sonidoOK = new SoundPlayer(Path.Combine(Application.StartupPath,"vida.wav"));

        private void Lista_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            txtPalabra.Enabled = false;
            txtTraduccion.Enabled = false;
            lbPalabra.Hide();
            cbModo.SelectedIndex = 0;
            label1.Text = cbModo.Items[0].ToString();
            btnValidar.Enabled = false;

            copia = dt.Copy();
            txtCantidad.Text = dt.Rows.Count.ToString();

            resumen.Columns.Add("Ingles",typeof(string));
            resumen.Columns.Add("Español", typeof(string));
            resumen.Columns.Add("Respuesta", typeof(string));
            resumen.Columns.Add("Estado", typeof(string));
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
            correcto = 0;
            incorrecto = 0;

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
                    Resumen res =new Resumen(c,i,resumen);
                    res.ShowDialog();
                    resumen.Clear();
                    //MessageBox.Show("Correctas: " + c.ToString() + " Incorrectas: " + i.ToString());
                    Limpiar();
                }
            }
        }

        int correcto = 0;
        int incorrecto = 0;

        void Modo(string palabra, string traduccion)
        {

            int cantidad = dt.Rows.Count;
            Random azar = new Random();
            SqlConnection cn = new SqlConnection(Configuracion.sql);
            SqlCommand command = new SqlCommand();
            DataTable valor = new DataTable();
            SqlDataAdapter adapter;

            if (txtTraduccion.Text == dt.Rows[n][palabra].ToString())
            {
                cn.Open();
                string word = dt.Rows[n][traduccion].ToString();
                string query = $"select correcto from Palabra where {traduccion}=@palabra";
                command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@palabra", word);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(valor);
                int correcto = int.Parse(valor.Rows[0]["Correcto"].ToString());
                lbResultado.Text = "Correcto";
                c += 1;
                correcto += 1;
                lbConteo.Text = word;
                query = $"update Palabra set correcto=@valor where {traduccion}=@palabra";
                command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@valor", correcto);
                command.Parameters.AddWithValue("@palabra", word);
                command.ExecuteNonQuery();
                cn.Close();
                lbCorrecto.Text = correcto.ToString();

                resumen.Rows.Add(txtPalabra.Text, dt.Rows[n][palabra].ToString(), txtTraduccion.Text , lbResultado.Text);
                sonidoOK.Play();
            }
            else
            {
                string respuesta = dt.Rows[n][palabra].ToString();
                MessageBox.Show(respuesta);
                cn.Open();
                string word = dt.Rows[n][traduccion].ToString();
                string query = $"select Incorrecto from Palabra where {traduccion}=@palabra";
                command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@palabra", word);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(valor);
                int incorrecto = int.Parse(valor.Rows[0]["Incorrecto"].ToString());
                lbResultado.Text = "Incorrecto";
                i += 1;
                incorrecto += 1;
                lbConteo.Text = word;
                query = $"update Palabra set Incorrecto=@valor where {traduccion}=@palabra";
                command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@valor", incorrecto);
                command.Parameters.AddWithValue("@palabra", word);
                command.ExecuteNonQuery();
                cn.Close();

                resumen.Rows.Add(txtPalabra.Text, dt.Rows[n][palabra].ToString(), txtTraduccion.Text, lbResultado.Text);
                lbCorrecto.Text = incorrecto.ToString();
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
                //lbConteo.Text = cantidad.ToString();
            }
            else
            {
                MessageBox.Show("Correctas: " + c.ToString() + " Incorrectas: " + i.ToString());
                Limpiar();
            }
        }

        private void Lista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Llama al método que quieras, por ejemplo, hacer clic en el botón
                btnValidar.PerformClick();
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
