using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BritHotel
{
    public partial class FormInfosClient : Form
    {
        Bdd maBdd;
        client MonClient;
        public FormInfosClient()
        {
            InitializeComponent();
        }
        private void FormInfosClient_Load(object sender, EventArgs e)
        {
            maBdd = new Bdd();
            Varglob.monHotel = maBdd.hotel.Where(param => param.id == Varglob.monHotel.id).FirstOrDefault();
            dataGridView1.RowHeadersVisible = false;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            MonClient = maBdd.client.Where(param => param.id == id).FirstOrDefault();
            txtboxMail.Text = "";
            txtboxNom.Text = "";

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

        private void btnRech_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            foreach (reservation resa in maBdd.reservation)
            {
                string Chambre = "";
                if (resa.client_id== Convert.ToInt32(textBox1.Text))
                {
                    foreach (chambre uneChambre in resa.chambres)
                    { Chambre = Chambre + uneChambre.numero.ToString() + " / "; }

                    dataGridView1.Rows.Add(resa.id, resa.datedebut, resa.datefin, resa.client.nom, Chambre);
                }
            }

        }
    }
}
