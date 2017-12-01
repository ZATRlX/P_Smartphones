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

        //string de connexion à la base de données
        static string connectionString = @"server=localhost;userid=root;password=;database=db_smartphones";
        MySqlConnection connection = new MySqlConnection(connectionString);
        MySqlDataReader rdr;

        //Requète n°1
        //5 meilleurs smartphones en autonomie
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

        //Requète n°2
        //10 meilleurs smartphones CPU
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

        //Requète n°3
        //5 meilleurs smartphones par CPU * TailleEcran * RAM
        private void btn3_Click(object sender, EventArgs e)
        {
            Form1 f = this.Owner as Form1;
            DataSet ds = new DataSet();
            MySqlDataAdapter daa = new MySqlDataAdapter(@"SELECT smaMarque, smaModele, smaDate, smaOS, smaConstructeurs, smaTailleEcran, smaAutonomie, smaRAM, proNom, proPerformances, (proPerformances * smaTailleEcran * smaRAM) as total FROM t_smartphone INNER JOIN t_processeur ON t_smartphone.Idproc = t_processeur.idProcesseur ORDER BY total DESC LIMIT 5;", connection);

            connection.Close();
            connection.Open();
            daa.Fill(ds, "t_smartphone, t_Processeur");

            DataView dv;
            dv = new DataView(ds.Tables[0], "", "proNom Desc", DataViewRowState.CurrentRows);


            f.dgvResultatSmartphones.DataSource = null;
            f.dgvResultatSmartphones.Rows.Clear();
            f.dgvResultatSmartphones.Columns.Clear();
            f.dgvResultatSmartphones.DataSource = dv;
            SortHeader(10);
            f.dgvResultatSmartphones.Columns[9].Visible = false;
            f.dgvResultatSmartphones.Columns[10].Visible = false;

        }

        //Requète n°4
        //3 Smartphones les plus chers
        private void btn4_Click(object sender, EventArgs e)
        {
            Form1 f = this.Owner as Form1;
            DataSet ds = new DataSet();
            MySqlDataAdapter daa = new MySqlDataAdapter(@"SELECT smaMarque, smaModele, smaDate, smaOS, smaConstructeurs, smaTailleEcran, smaAutonomie, smaRAM, proNom, valPrix FROM t_smartphone INNER JOIN t_processeur ON t_smartphone.Idproc = t_processeur.idProcesseur INNER JOIN t_valeur ON t_valeur.Idsmartphone = t_smartphone.idSmartphone WHERE t_valeur.valDate LIKE '2017-09-15' ORDER BY valPrix DESC LIMIT 3;", connection);

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


        private void btn5_Click(object sender, EventArgs e)
        {
            Form1 f = this.Owner as Form1;
            DataSet ds = new DataSet();
            MySqlDataAdapter daa = new MySqlDataAdapter(@"SELECT smaMarque, smaModele, smaDate, smaOS, smaConstructeurs, smaTailleEcran, smaAutonomie, smaRAM, proNom, valPrix FROM t_smartphone INNER JOIN t_processeur ON t_smartphone.Idproc = t_processeur.idProcesseur INNER JOIN t_valeur ON t_valeur.Idsmartphone = t_smartphone.idSmartphone WHERE t_valeur.valDate LIKE '2017-09-15' ORDER BY valPrix DESC LIMIT 1;", connection);

            connection.Close();
            connection.Open();
            daa.Fill(ds, "t_smartphone, t_Processeur");

            DataView dv;
            dv = new DataView(ds.Tables[0], "", "proNom Desc", DataViewRowState.CurrentRows);


            f.dgvResultatSmartphones.DataSource = null;
            f.dgvResultatSmartphones.Rows.Clear();
            f.dgvResultatSmartphones.Columns.Clear();
            f.dgvResultatSmartphones.DataSource = dv;
            SortHeaderReverse(9);
        }

        //Méthode
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

        //SortHeader permet de trier la datagridview par rapport à la colonne donnée par ordre croissant
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

        //SortHeader permet de trier la datagridview par rapport à la colonne donnée par ordre décroissant
        public void SortHeaderReverse(int intIndex)
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
                    f.dgvResultatSmartphones.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    // Sort a new column and remove the old SortGlyph.
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            // Sort the selected column.
            f.dgvResultatSmartphones.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;

        }

    }
}
