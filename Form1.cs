using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GestionJeux
{
    public partial class Form1 : Form
    {
        private string ID;

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\tiago\\source\\repos\\jeux\\JeuxDB.mdf;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            ChargerDonnees();
            AjouterBouton();
        }

        private void ChargerDonnees()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Jeux", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void AjouterBouton()
        {
            btnConf.Visible = false;

            DataGridViewButtonColumn btnSupprimer = new DataGridViewButtonColumn();
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.HeaderText = "Supprimer";
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnSupprimer);

            DataGridViewButtonColumn btnModifier = new DataGridViewButtonColumn();
            btnModifier.Text = "Modifier";
            btnModifier.HeaderText = "Modifier";
            btnModifier.Name = "btnModifier";
            btnModifier.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnModifier);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string titre = txtTitre.Text;
            string genre = comboGenre.Text;
            int annee;
            decimal prix;
            string statut = comboStatut.Text;

            if (!int.TryParse(comboAnnee.Text, out annee) || !decimal.TryParse(txtPrix.Text, out prix))
            {
                MessageBox.Show("Année ou prix invalide.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Jeux (Titre, Genre, Annee, Prix, Statut) VALUES (@Titre, @Genre, @Annee, @Prix, @Statut)", conn);
                cmd.Parameters.AddWithValue("@Titre", titre);
                cmd.Parameters.AddWithValue("@Genre", genre);
                cmd.Parameters.AddWithValue("@Annee", annee);
                cmd.Parameters.AddWithValue("@Prix", prix);
                cmd.Parameters.AddWithValue("@Statut", statut);
                cmd.ExecuteNonQuery();
            }

            ChargerDonnees();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnSupprimer"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce jeu?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Jeux WHERE ID = @ID", conn);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                    }
                    ChargerDonnees();
                }
            }
            else if (e.ColumnIndex == dataGridView1.Columns["btnModifier"].Index && e.RowIndex >= 0)
            {
                // récupération les valeurs
                ID = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txtTitre.Text = dataGridView1.Rows[e.RowIndex].Cells["Titre"].Value.ToString();
                comboGenre.Text = dataGridView1.Rows[e.RowIndex].Cells["Genre"].Value.ToString();
                comboAnnee.Text = dataGridView1.Rows[e.RowIndex].Cells["Annee"].Value.ToString();
                txtPrix.Text = dataGridView1.Rows[e.RowIndex].Cells["Prix"].Value.ToString();
                comboStatut.Text = dataGridView1.Rows[e.RowIndex].Cells["Statut"].Value.ToString();

                btnConf.Visible = true;
                btnAjouter.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ID));

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Jeux SET Titre = @Titre, Genre = @Genre, Annee = @Annee, Prix = @Prix, Statut = @Statut WHERE ID = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@Titre", txtTitre.Text);
                cmd.Parameters.AddWithValue("@Genre", comboGenre.Text);
                cmd.Parameters.AddWithValue("@Annee", int.Parse(comboAnnee.Text));
                cmd.Parameters.AddWithValue("@Prix", decimal.Parse(txtPrix.Text));
                cmd.Parameters.AddWithValue("@Statut", comboStatut.Text);
                cmd.ExecuteNonQuery();
            }

            // Cacher le bouton confirmer et effacer les données de la cellule
            btnConf.Visible = false;
            btnAjouter.Visible = true;
            txtTitre.Clear();
            comboGenre.SelectedIndex = -1;
            comboAnnee.SelectedIndex = -1;
            txtPrix.Clear();
            comboStatut.SelectedIndex = -1;
            ChargerDonnees();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
