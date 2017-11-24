using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace P_GestProj2_Interface
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        static string connectionString = @"server=localhost;userid=root;password=;database=db_smartphones";
        MySqlConnection connection = new MySqlConnection(connectionString);
        MySqlDataReader rdr;
        public void btn1_Click(object sender, EventArgs e)
        {
            Form1 f = this.Owner as Form1;
            MySqlDataReader rdr1 = ExecuteQuery(@"SELECT DISTINCT t_smartphone.* FROM t_smartphone ORDER BY smaAutonomie;");
            f.dgvResultatSmartphones.DataSource = null;
            f.dgvResultatSmartphones.Rows.Clear();
            f.dgvResultatSmartphones.Columns.Clear();
            f.dgvResultatSmartphones.DataSource = rdr1;
            int i = 0;

            while (rdr1.Read())
            {
                f.dgvResultatSmartphones.Rows.Add();
                f.dgvResultatSmartphones[0, i].Value = rdr1.GetString("smaMarque");
                f.dgvResultatSmartphones[1, i].Value = rdr1.GetString("smaModele");
                f.dgvResultatSmartphones[2, i].Value = rdr1.GetString("smaDate").Substring(6, 4);
                f.dgvResultatSmartphones[3, i].Value = rdr1.GetString("smaOS");
                f.dgvResultatSmartphones[4, i].Value = rdr1.GetString("smaConstructeurs");
                f.dgvResultatSmartphones[5, i].Value = rdr1.GetString("smaTailleEcran");
                f.dgvResultatSmartphones[6, i].Value = rdr1.GetString("smaAutonomie");
                f.dgvResultatSmartphones[7, i].Value = rdr1.GetString("smaRAM");
                f.dgvResultatSmartphones[8, i].Value = rdr1.GetString("proNom");
                i++;

            }
            connection.Close();

        }

        private MySqlDataReader ExecuteQuery(string query)
        {
            MySqlCommand acmd = new MySqlCommand(query, connection);

            if (connection != null && connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            if (rdr != null)
            {
                rdr.Close();
            }

            rdr = acmd.ExecuteReader();

            return rdr;


        }
    }
}
