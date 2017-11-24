/*
Auteur : Loïc Rosset
Modifications par : Pierric Ripoll, Loïc Rosset, Ricardo Olivera, Grégory Briand
Description :   Programme permettant de sélectionner des Smarthpones dans une liste de Smartphones (géré en externe dans une base de données)
                Dans le cadre du Projet GestProj2
*/
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Data;

namespace P_GestProj2_Interface
{
    /// <summary>
    /// Form principale avec le datagridview où tous les smartphones sont affichés,
    /// et les contrôles de tri et de filtres
    /// </summary>
    public partial class Form1 : Form
    {
        //string servant de connection à la base de donnée. Utilisé dans l'objet MySqlConnection.
        static string connectionString = @"server=localhost;userid=root;password=;database=db_smartphones";

        //Objet qui sera utilisé dans les méthodes qui récupèrent des données
        MySqlConnection connection = new MySqlConnection(connectionString);

        //Objet "lecteur" de données 
        MySqlDataReader rdr;

        //Utilisé dans la méthode ChangeFilters
        bool canChange = true;

        //constantes pour les informations personnelles des devs :)
        const string PIERRIC = "Pierric Ripoll : https://github.com/Nyawww";
        const string RICARDO = "Ricardo Cardoso Oliveira : https://github.com/ZATRlX";
        const string LOIC = "Loïc Rosset : https://github.com/loicrx9";
        const string GREGORY = "Grégory Briand : https://github.com/Imacutekayx";


        //DataView dv = new DataView();


        Panel p = new Panel();


        public Form1()
        {
            InitializeComponent();

            //charger dans rdr3 La Requête sql qui est dans le string.
            MySqlDataReader rdr3 = ExecuteQuery(@"SELECT smaMarque, smaModele, smaDate, smaOS, smaConstructeurs, smaTailleEcran, smaAutonomie, smaRAM, proNom FROM t_smartphone INNER JOIN t_processeur ON t_smartphone.Idproc = t_processeur.idProcesseur;");


            //créé les colonnes dans le DataGridView, avec leur noms
            dgvResultatSmartphones.Columns.Add("colMarque", "Marque");
            dgvResultatSmartphones.Columns.Add("colModele", "Modele");
            dgvResultatSmartphones.Columns.Add("colDate", "Date de sortie");
            dgvResultatSmartphones.Columns.Add("colOS", "OS");
            dgvResultatSmartphones.Columns.Add("colConstructeurs", "Constructeurs");
            dgvResultatSmartphones.Columns.Add("colTailleEcran", "Taille Ecran");
            dgvResultatSmartphones.Columns.Add("colAutomomie", "Autonomie");
            dgvResultatSmartphones.Columns.Add("colRAM", "RAM");
            dgvResultatSmartphones.Columns.Add("colProcesseur", "Processeur");

            int i = 0;

            //remplis les colonnes avec les valeurs de la base de données
            while (rdr3.Read())
            {
                dgvResultatSmartphones.Rows.Add();
                dgvResultatSmartphones[0, i].Value = rdr3.GetString("smaMarque");
                dgvResultatSmartphones[1, i].Value = rdr3.GetString("smaModele");
                //fait en sorte de prendre juste le "2016" de "07-05-2016" 
                dgvResultatSmartphones[2, i].Value = rdr3.GetString("smaDate").Substring(6, 4);
                dgvResultatSmartphones[3, i].Value = rdr3.GetString("smaOS");
                dgvResultatSmartphones[4, i].Value = rdr3.GetString("smaConstructeurs");
                dgvResultatSmartphones[5, i].Value = rdr3.GetString("smaTailleEcran");
                dgvResultatSmartphones[6, i].Value = rdr3.GetString("smaAutonomie");
                dgvResultatSmartphones[7, i].Value = rdr3.GetString("smaRAM");
                dgvResultatSmartphones[8, i].Value = rdr3.GetString("proNom");
                i++;

            }


            connection.Close();

            MySqlDataReader rdrOS = ExecuteQuery(@"SELECT DISTINCT smaOS FROM t_smartphone ORDER BY smaOS;");

            while (rdrOS.Read())
            {

                cbOS.Items.Add(rdrOS.GetString("smaOS"));

            }

            MySqlDataReader rdrMarque = ExecuteQuery(@"SELECT DISTINCT smaMarque FROM t_smartphone ORDER BY smaMarque;;");

            while (rdrMarque.Read())
            {

                cbMarque.Items.Add(rdrMarque.GetString("smaMarque"));

            }

            MySqlDataReader rdrTaille = ExecuteQuery(@"SELECT DISTINCT smaTailleEcran FROM t_smartphone ORDER BY smaTailleEcran;;");

            while (rdrTaille.Read())
            {

                cbTailleEcran.Items.Add(rdrTaille.GetString("smaTailleEcran") + " pouces");

            }

            MySqlDataReader rdrRAM = ExecuteQuery(@"SELECT DISTINCT smaRAM FROM t_smartphone ORDER BY smaRAM;");

            while (rdrRAM.Read())
            {

                cbRAM.Items.Add(rdrRAM.GetString("smaRAM"));

            }

            MySqlDataReader rdrCPU = ExecuteQuery(@"SELECT DISTINCT proNom FROM t_processeur ORDER BY proPerformances;");

            while (rdrCPU.Read())
            {

                cbCPU.Items.Add(rdrCPU.GetString("proNom"));

            }



            cbDate.Items.Add("2015");
            cbDate.Items.Add("2016");
            cbDate.Items.Add("2017");


            

            p.Controls.Add(cbCPU);
            p.Controls.Add(cbTailleEcran);
            p.Controls.Add(cbRAM);
            p.Controls.Add(cbOS);
            p.Controls.Add(cbMarque);
            p.Controls.Add(cbDate);

            grpFiltres.Controls.Add(p);

            p.Width = 660;
            p.Height = 125;

            p.Location = new System.Drawing.Point(10, 14);
        }

        private void Button1_Click(object sender, EventArgs e)
        {





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

        public void ChangeFilters(object sender, EventArgs e)
        {
            if (canChange)
            {

                ComboBox cb = sender as ComboBox;


            
                foreach (ComboBox cbs in p.Controls)
                {
                    canChange = false;

                    if (cb != cbs)
                        cbs.SelectedIndex = -1;
                    
                }


                DataSet ds = new DataSet();
                MySqlDataAdapter daa = new MySqlDataAdapter(@"SELECT smaMarque, smaModele, smaDate, smaOS, smaConstructeurs, smaTailleEcran, smaAutonomie, smaRAM, proNom FROM t_smartphone INNER JOIN t_processeur ON t_smartphone.Idproc = t_processeur.idProcesseur;", connection);
                connection.Close();
                connection.Open();
                daa.Fill(ds, "t_smartphone, t_Processeur");

                DataView dv;


                if (cb.Name == "cbCPU")
                {
                    dv = new DataView(ds.Tables[0], "proNom  = '" + cb.Text + "'", "proNom Desc", DataViewRowState.CurrentRows);
                }
                else if(cb.Name == "cbDate")
                {
                    dv = new DataView(ds.Tables[0], "smaDate LIKE '%" + cb.Text + "%'", "smaDate Desc", DataViewRowState.CurrentRows);
                }
                else if(cb.Name == "cbTailleEcran")
                {
                    dv = new DataView(ds.Tables[0], "smaTailleEcran = " + Convert.ToSingle(cb.Text.Replace(" pouces", "")), "smaTailleEcran Desc", DataViewRowState.CurrentRows);
                }
                else
                {
                    dv = new DataView(ds.Tables[0], "sma" + cb.Name.Substring(2) + " = '" + cb.Text + "'", "sma" + cb.Name.Substring(2) + " Desc", DataViewRowState.CurrentRows);
                }


                dgvResultatSmartphones.DataSource = null;
                dgvResultatSmartphones.Rows.Clear();
                dgvResultatSmartphones.Columns.Clear();
                dgvResultatSmartphones.DataSource = dv;

                connection.Close();
            }

            canChange = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlDataReader rdr2 = ExecuteQuery(@"SELECT smaDate, smaMarque, smaModele, smaOS, smaConstructeurs, smaTailleEcran, smaAutonomie, smaRAM FROM t_smartphone;");

            while (rdr2.Read())
            {

                string strOS = rdr.GetString("smaOS");
                string strMarque = rdr.GetString("smaMarque");
                string strTailleEcran = rdr.GetString("");

                if (strOS != "")
                {
                    cbOS.Items.Add(strOS);
                }
            }

            connection.Close();
        }

        private void DgvResultatSmartphones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlDataReader rdr4 = ExecuteQuery(@"SELECT smaMarque, smaModele, smaDate, smaOS, smaConstructeurs, smaTailleEcran, smaAutonomie, smaRAM, proNom FROM t_smartphone INNER JOIN t_processeur ON t_smartphone.Idproc = t_processeur.idProcesseur;");

            int j = dgvResultatSmartphones.CurrentRow.Index;
            
            while (rdr4.Read()) ;
            string show = String.Format("***{0} {1}***\n\nDate de sortie : {2}\nOS : {3}\nConstructeur : {4}\nTaille d'écran : {5} pouces\nAutonomie : {6} heures\nRAM : {7} Go\nProcesseur : {8}",
                dgvResultatSmartphones[0, j].Value, dgvResultatSmartphones[1, j].Value, dgvResultatSmartphones[2, j].Value, dgvResultatSmartphones[3, j].Value, dgvResultatSmartphones[4, j].Value,
                dgvResultatSmartphones[5, j].Value, dgvResultatSmartphones[6, j].Value, dgvResultatSmartphones[7, j].Value, dgvResultatSmartphones[8, j].Value);

            PopUp(show);

            connection.Close();
        }

        public void PopUp(string show)
        {
            MessageBox.Show(show, "", MessageBoxButtons.OK);
        }

        private void BtnContact_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PIERRIC + "\n" + RICARDO + "\n" + LOIC + "\n" + GREGORY, "", MessageBoxButtons.OK);
        }
    }
}
