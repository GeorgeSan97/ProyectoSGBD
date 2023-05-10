using Npgsql;

namespace ProyectoSGBD
{
    public partial class Form1 : Form
    {
        private string conexiónString = String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};",
                    "localhost", 5434, "postgres",
                    "17052016", "dbDemo");

        private NpgsqlConnection conexión;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexión = new NpgsqlConnection(conexiónString);
        }
    }
}