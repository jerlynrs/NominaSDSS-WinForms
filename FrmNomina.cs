using System.Data;
using Microsoft.Data.SqlClient;
using System.IO;

namespace NominaSDSS
{
    public partial class FrmNomina : Form
    {
        string connectionString =
@"Server=DOL8YNH9Y3;
Database=NominaSDSS;
Trusted_Connection=True;
TrustServerCertificate=True;";


        public FrmNomina()
        {
            InitializeComponent();
        }

        private void FrmNomina_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerarTxt_Click(object sender, EventArgs e)
        {
            string ruta = @"C:\temp\NominaSDSS.txt";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT Cedula, Nombre, Cargo, Salario FROM Empleados";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    while (dr.Read())
                    {
                        string linea =
                            dr["Cedula"] + "," +
                            dr["Nombre"] + "," +
                            dr["Cargo"] + "," +
                            dr["Salario"];

                        sw.WriteLine(linea);
                    }
                }
                dr.Close();
            }

            MessageBox.Show("Archivo TXT generado correctamente");
        }

        private void btnLeerTxt_Click(object sender, EventArgs e)
        {
            string ruta = @"C:\temp\NominaSDSS.txt";
            DataTable dt = new DataTable();

            dt.Columns.Add("Cedula");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Cargo");
            dt.Columns.Add("Salario");

            using (StreamReader sr = new StreamReader(ruta))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] datos = linea.Split(',');

                    DataRow fila = dt.NewRow();
                    fila["Cedula"] = datos[0];
                    fila["Nombre"] = datos[1];
                    fila["Cargo"] = datos[2];
                    fila["Salario"] = datos[3];

                    dt.Rows.Add(fila);
                }
            }

            dataGridNomina.DataSource = dt;
        }

        private void btnLeerTxt_Click_1(object sender, EventArgs e)
        {
            string ruta = @"C:\temp\NominaSDSS.txt";
            DataTable dt = new DataTable();

            dt.Columns.Add("Cedula");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Cargo");
            dt.Columns.Add("Salario");

            using (StreamReader sr = new StreamReader(ruta))
            {
                string? linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] datos = linea.Split(',');

                    DataRow fila = dt.NewRow();
                    fila["Cedula"] = datos[0];
                    fila["Nombre"] = datos[1];
                    fila["Cargo"] = datos[2];
                    fila["Salario"] = datos[3];

                    dt.Rows.Add(fila);
                }

            }
            dataGridNomina.DataSource = dt;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }
    }
}
