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
            DataSet ds = new DataSet();
            MySqlDataAdapter daa = new MySqlDataAdapter(@"SELECT smaMarque, smaModele, smaDate, smaOS, smaConstructeurs, smaTailleEcran, smaAutonomie, smaRAM, proNom FROM t_smartphone INNER JOIN t_processeur ON t_smartphone.Idproc = t_processeur.idProcesseur ORDER BY smaAutonomie DESC LIMIT 5;", connection);


            connection.Close();
            connection.Open();
            daa.Fill(ds, "t_smartphone, t_Processeur");

            DataView dv;
            dv = new DataView(ds.Tables[0], "", "proNom Desc", DataViewRowState.CurrentRows);


            f.dgvResultatSmartphones.DataSource = null;
            f.dgvResultatSmartphones.Rows.Clear();
            f.dgvResultatSmartphones.Columns.Clear();
            f.dgvResultatSmartphones.DataSource = dv;
            SortHeader(6);


        }

        public void SortHeader(int intIndex)
        {
            Form1 f = this.Owner as Form1;

            DataGridViewColumn newColumn = f.dgvResultatSmartphones.Columns[intIndex];
            DataGridViewColumn oldColumn = f.dgvResultatSmartphones.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not sorted.
            if (oldColumn != null)
            {
                // Sort the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    f.dgvResultatSmartphones.SortOrder == SortOrder.Descending)
                {
                    direction = ListSortDirection.Ascending;
                }
                else
                {
                    // Sort a new column and remove the old SortGlyph.
                    direction = ListSortDirection.Descending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Descending;
            }

            // Sort the selected column.
            f.dgvResultatSmartphones.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Descending ?
                SortOrder.Ascending : SortOrder.Ascending;
            
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

        private void btn2_Click(object sender, EventArgs e)
        {
            Form1 f = this.Owner as Form1;
            DataSet ds = new DataSet();
            MySqlDataAdapter daa = new MySqlDataAdapter(@"SELECT smaMarque, smaModele, smaDate, smaOS, smaConstructeurs, smaTailleEcran, smaAutonomie, smaRAM, proNom, proPerformances FROM t_smartphone INNER JOIN t_processeur ON t_smartphone.Idproc = t_processeur.idProcesseur ORDER BY proPerformances DESC LIMIT 10;", connection);


            connection.Close();
            connection.Open();
            daa.Fill(ds, "t_smartphone, t_Processeur");

            DataView dv;
            dv = new DataView(ds.Tables[0], "", "proNom Desc", DataViewRowState.CurrentRows);


            f.dgvResultatSmartphones.DataSource = null;
            f.dgvResultatSmartphones.Rows.Clear();
            f.dgvResultatSmartphones.Columns.Clear();
            f.dgvResultatSmartphones.DataSource = dv;
            SortHeader(9);
            f.dgvResultatSmartphones.Columns[9].Visible = false;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Form1 f = this.Owner as Form1;
            DataSet ds = new DataSet();
            MySqlDataAdapter daa = new MySqlDataAdapter(@"SELECT proNom FROM t_smartphone INNER JOIN t_processeur ON t_smartphone.Idproc = t_processeur.idProcesseur;", connection);
            MySqlDataAdapter dab = new MySqlDataAdapter(@"SELECT smaTailleEcran FROM t_smartphone INNER JOIN t_processeur ON t_smartphone.Idproc = t_processeur.idProcesseur;", connection);
            MySqlDataAdapter dac = new MySqlDataAdapter(@"SELECT smaRAM FROM t_smartphone INNER JOIN t_processeur ON t_smartphone.Idproc = t_processeur.idProcesseur;", connection);

            connection.Close();
            connection.Open();
            daa.Fill(ds, "t_smartphone, t_Processeur");

            DataView dv;
            dv = new DataView(ds.Tables[0], "", "proNom Desc", DataViewRowState.CurrentRows);


            f.dgvResultatSmartphones.DataSource = null;
            f.dgvResultatSmartphones.Rows.Clear();
            f.dgvResultatSmartphones.Columns.Clear();
            f.dgvResultatSmartphones.DataSource = dv;
            SortHeader(6);

        }
    }
}
