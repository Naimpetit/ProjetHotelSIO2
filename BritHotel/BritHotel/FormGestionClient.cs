using Isopoh.Cryptography.Argon2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BritHotel
{
    public partial class FormGestionClient : Form
    {

        Bdd maBdd;
        client MonClient;
        public FormGestionClient()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            MonClient = maBdd.client.Where(param => param.id == id).FirstOrDefault();

            if (MonClient != null)
            {
                txtboxNom.Text = MonClient.nom;
                txtboxMail.Text = MonClient.mail;
            }
            else
            {
                MessageBox.Show("Aucun client trouvé avec cet ID.");
            }
        }

        private void FormGestionClient_Load(object sender, EventArgs e)
        {
            maBdd = new Bdd();
            Varglob.monHotel = maBdd.hotel.Where(param => param.id == Varglob.monHotel.id).FirstOrDefault();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (txtboxMDP.Text.Length < 8 || txtboxMDP.Text == "")
            {
                MessageBox.Show("Le mot de passe doit contenir au moins 8 caractères ou vide.");
                return;
            }
            MonClient.motpasse = Argon2.Hash(txtboxMDP.Text);
            MonClient.nom = txtboxNom.Text;
            MonClient.mail = txtboxMail.Text;

            maBdd.SaveChanges();
        }
    }
}
