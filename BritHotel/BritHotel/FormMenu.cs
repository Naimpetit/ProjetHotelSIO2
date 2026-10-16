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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void clientsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form formHotel = new FormHotel();
            formHotel.Show();
        }

        private void chambreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formChambre = new FormChambre();
            formChambre.Show();
        }

        private void gestionClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formGestionClient = new FormGestionClient();
            formGestionClient.Show();
        }

        private void infosClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formInfosClient = new FormInfosClient();
            formInfosClient.Show();
        }

        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formReservation = new FormReservation();
            formReservation.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }


    }
}
