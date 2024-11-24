namespace Ingles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modo modo = new Modo(this);

            modo.Show();
            this.Hide();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agregar add = new Agregar(this);
            this.Hide();
            add.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Estadisticas Estadisticas = new Estadisticas(this);
            Estadisticas.Show();
            this.Hide();
        }
    }
}