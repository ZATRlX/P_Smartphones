// ETML
// Auteur : Loïc Rosset
// Modifications par : Pierric Ripoll, Loïc Rosset, Ricardo Olivera, Grégory Briand
// Date : 05.12.2017
// Description :   Programme permettant de sélectionner des Smartphones dans une liste de Smartphones (géré en externe dans une base de données). Dans le cadre du Projet GestProj2
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

namespace P_GestProj2_Interface
{
    // ETML
    // Auteur : Loïc Rosset
    // Modifications par : Pierric Ripoll, Loïc Rosset, Ricardo Olivera, Grégory Briand
    // Date : 05.12.2017
    // Description :   Form principale avec le datagridview où tous les smartphones sont affichés, et les contrôles de tri et de filtres
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

        //constantes des liens Github des membres de l'équipe utilisés dans la fonction Contact
        const string PIERRIC = "https://github.com/Nyawww";
        const string RICARDO = "https://github.com/ZATRlX";
        const string LOIC = "https://github.com/loicrx9";
        const string GREGORY = "https://github.com/Imacutekayx";
        
        DataView dv = new DataView();
        Panel p = new Panel();
        
        /// <summary>
        /// Execution lors du lancement de la Form1
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            //crée la base de donnée accessible par l'utilisateur
            Process EasyPHP = Process.Start(@"EasyPHP-DevServer-14.1VC11-Portable\EasyPHP-DevServer-14.1VC11.exe");
            //TODO(Résoudre le problème d'insertion par .sql)
            MySqlDataReader rdr2 = ExecuteQuery(@"DROP DATABASE IF EXISTS db_Smartphones;
                                                CREATE DATABASE db_Smartphones CHARACTER SET utf8 COLLATE utf8_general_ci;
                                                USE db_Smartphones;
                                                //TODO importer le fichier .sql dans la base de donnée
                                                db_smartphones < CSV\CreateDatabase.sql");

            //rajoute les composants de la fonction Contact au panel de cette même fonction
            pnlContact.Controls.Add(btnStopContact);
            pnlContact.Controls.Add(lblPierric);
            pnlContact.Controls.Add(llblPierric);
            pnlContact.Controls.Add(lblRicardo);
            pnlContact.Controls.Add(llblRicardo);
            pnlContact.Controls.Add(lblLoic);
            pnlContact.Controls.Add(llblLoic);
            pnlContact.Controls.Add(lblGregory);
            pnlContact.Controls.Add(llblGregory);

            //écrit au point des liens des contacts
            llblPierric.Text = PIERRIC;
            llblRicardo.Text = RICARDO;
            llblLoic.Text = LOIC;
            llblGregory.Text = GREGORY;

            //charger dans rdr3 La Requête sql qui est dans le string.
            MySqlDataReader rdr3 = ExecuteQuery(@"SELECT smaMarque, smaModele, smaDate, smaOS, smaConstructeurs, smaTailleEcran, smaAutonomie, smaRAM, proNom FROM t_smartphone INNER JOIN t_processeur ON t_smartphone.Idproc = t_processeur.idProcesseur;");
            
            //créé les colonnes dans le DataGridView, avec leur noms
            dgvResultatSmartphones.Columns.Add("colMarque", "Marque");
            dgvResultatSmartphones.Columns.Add("colModele", "Modele");
            dgvResultatSmartphones.Columns.Add("colDate", "DateSortie");
            dgvResultatSmartphones.Columns.Add("colOS", "OS");
            dgvResultatSmartphones.Columns.Add("colConstructeurs", "Constructeurs");
            dgvResultatSmartphones.Columns.Add("colTailleEcran", "TailleEcran");
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

            //Filtre des OS
            MySqlDataReader rdrOS = ExecuteQuery(@"SELECT DISTINCT smaOS FROM t_smartphone ORDER BY smaOS;");

            while (rdrOS.Read())
            {
                cbOS.Items.Add(rdrOS.GetString("smaOS"));
            }

            //Filtre des marques
            MySqlDataReader rdrMarque = ExecuteQuery(@"SELECT DISTINCT smaMarque FROM t_smartphone ORDER BY smaMarque;;");

            while (rdrMarque.Read())
            {
                cbMarque.Items.Add(rdrMarque.GetString("smaMarque"));
            }

            //Filtres de la taille de l'écran
            MySqlDataReader rdrTaille = ExecuteQuery(@"SELECT DISTINCT smaTailleEcran FROM t_smartphone ORDER BY smaTailleEcran;;");

            while (rdrTaille.Read())
            {
                cbTailleEcran.Items.Add(rdrTaille.GetString("smaTailleEcran") + " pouces");
            }

            //Filtre de la RAM
            MySqlDataReader rdrRAM = ExecuteQuery(@"SELECT DISTINCT smaRAM FROM t_smartphone ORDER BY smaRAM;");

            while (rdrRAM.Read())
            {
                cbRAM.Items.Add(rdrRAM.GetString("smaRAM"));
            }

            //Filtre du processeur
            MySqlDataReader rdrCPU = ExecuteQuery(@"SELECT DISTINCT proNom FROM t_processeur ORDER BY proPerformances;");

            while (rdrCPU.Read())
            {
                cbCPU.Items.Add(rdrCPU.GetString("proNom"));
            }

            //Ajout des dates manuellement
            cbDate.Items.Add("2015");
            cbDate.Items.Add("2016");
            cbDate.Items.Add("2017");
            
            //Ajout des comboboxes dans la panel et modification de celui-ci
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

        /// <summary>
        /// Execute les commandes SQL dans la base de donnée
        /// </summary>
        /// <param name="query">commande à executer</param>
        /// <returns>MySqlDataReader rdr</returns>
        private MySqlDataReader ExecuteQuery(string query)
        {
            MySqlCommand acmd = new MySqlCommand(query, connection);

            //Se connecte à la base de donnée
            if (connection != null && connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            if (rdr != null)
            {
                rdr.Close();
            }

            //Execute la commande
            rdr = acmd.ExecuteReader();

            return rdr;
        }

        /// <summary>
        /// Change les filtres
        /// </summary>
        /// <param name="sender">Objet envoyant la requête</param>
        /// <param name="e">Evenement déclanchant cette méthode</param>
        public void ChangeFilters(object sender, EventArgs e)
        {
            if (canChange)
            {
                //change la taille du Datagridview pour qu'il se redimensionne automatiquement
                dgvResultatSmartphones.Height = 0;
                if(dgvResultatSmartphones.AutoSize == false) { dgvResultatSmartphones.AutoSize = true; }
                
                ComboBox cb = sender as ComboBox;
                
                foreach (ComboBox cbs in p.Controls)
                {
                    canChange = false;

                    if (cb != cbs)
                        cbs.SelectedIndex = -1;
                    
                }
                
                DataSet ds = new DataSet();
                //Réécrit le Datagridview avec les informations filtrées
                MySqlDataAdapter daa = new MySqlDataAdapter(@"SELECT smaMarque AS Marque, smaModele AS Modele, smaDate AS DateSortie, smaOS AS OS, smaConstructeurs AS Constructeur, smaTailleEcran AS TailleEcran, smaAutonomie AS Autonomie, smaRAM AS RAM, proNom AS Processeur FROM t_smartphone INNER JOIN t_processeur ON t_smartphone.Idproc = t_processeur.idProcesseur;", connection);
                connection.Close();
                connection.Open();
                daa.Fill(ds, "t_smartphone, t_Processeur");

                DataView dv;
                
                //remodèle certaines informations
                if (cb.Name == "cbCPU")
                {
                    dv = new DataView(ds.Tables[0], "Processeur  = '" + cb.Text + "'", "Processeur Desc", DataViewRowState.CurrentRows);
                }
                else if(cb.Name == "cbDate")
                {
                    dv = new DataView(ds.Tables[0], "DateSortie LIKE '%" + cb.Text + "%'", "DateSortie Desc", DataViewRowState.CurrentRows);
                }
                else if(cb.Name == "cbTailleEcran")
                {
                    dv = new DataView(ds.Tables[0], "TailleEcran = " + Convert.ToSingle(cb.Text.Replace(" pouces", "")), "TailleEcran Desc", DataViewRowState.CurrentRows);
                }
                else
                {
                    dv = new DataView(ds.Tables[0], cb.Name.Substring(2) + " = '" + cb.Text + "'", cb.Name.Substring(2) + " Desc", DataViewRowState.CurrentRows);
                }
                
                dgvResultatSmartphones.DataSource = null;
                dgvResultatSmartphones.Rows.Clear();
                dgvResultatSmartphones.Columns.Clear();
                dgvResultatSmartphones.DataSource = dv;
                
                connection.Close();
            }

            canChange = true;
        }

        /// <summary>
        /// Lorsque le Form1 charge, ajoute les informations des colonnes
        /// </summary>
        /// <param name="sender">Objet envoyant la requête</param>
        /// <param name="e">Evenement déclanchant cette méthode</param>
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

        /// <summary>
        /// Affiche les informations des téléphones lotsque l'utilisateur clique sur une cellule
        /// </summary>
        /// <param name="sender">Objet envoyant la requête</param>
        /// <param name="e">Evenement déclanchant cette méthode</param>
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

        /// <summary>
        /// Affiche un pop-up avec le texte voulu
        /// </summary>
        /// <param name="show">Texte à afficher</param>
        public void PopUp(string show)
        {
            MessageBox.Show(show, "", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Affiche le panel de contact lorsque le bouton contact est cliqué
        /// </summary>
        /// <param name="sender">Objet envoyant la requête</param>
        /// <param name="e">Evenement déclanchant cette méthode</param>
        private void BtnContact_Click(object sender, EventArgs e)
        {
            pnlContact.Enabled = true;
            pnlContact.Visible = true;
        }

        /// <summary>
        /// Ouvre une page internet vers le compte GitHub de Pierric Ripoll lorsque que l'utilisateur clic sur le lien
        /// </summary>
        /// <param name="sender">Objet envoyant la requête</param>
        /// <param name="e">Evenement déclanchant cette méthode</param>
        private void Pierric_Click(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(PIERRIC);
        }

        /// <summary>
        /// Ouvre une page internet vers le compte GitHub de Ricardo Cardoso Oliveira lorsque que l'utilisateur clic sur le lien
        /// </summary>
        /// <param name="sender">Objet envoyant la requête</param>
        /// <param name="e">Evenement déclanchant cette méthode</param>
        private void Ricardo_Click(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(RICARDO);
        }

        /// <summary>
        /// Ouvre une page internet vers le compte GitHub de Loïc Rosset lorsque que l'utilisateur clic sur le lien
        /// </summary>
        /// <param name="sender">Objet envoyant la requête</param>
        /// <param name="e">Evenement déclanchant cette méthode</param>
        private void Loic_Click(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(LOIC);
        }

        /// <summary>
        /// Ouvre une page internet vers le compte GitHub de Grégory Briand lorsque que l'utilisateur clic sur le lien
        /// </summary>
        /// <param name="sender">Objet envoyant la requête</param>
        /// <param name="e">Evenement déclanchant cette méthode</param>
        private void Gregory_Click(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(GREGORY);
        }

        /// <summary>
        /// Ferme le panel de contact lorsque l'utilisateur clique sur le bouton de fermeture du panel
        /// </summary>
        /// <param name="sender">Objet envoyant la requête</param>
        /// <param name="e">Evenement déclanchant cette méthode</param>
        private void BtnStopContact_Click(object sender, EventArgs e)
        {
            pnlContact.Enabled = false;
            pnlContact.Visible = false;
        }
    }
}