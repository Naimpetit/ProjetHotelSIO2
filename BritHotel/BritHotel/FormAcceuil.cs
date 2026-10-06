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

namespace BritHotel
{
    public partial class FormAcceuil : Form
    {
        Bdd maBdd;
        public FormAcceuil()
        {
            InitializeComponent();
        }

        private void FormAcceuil_Load(object sender, EventArgs e)
        {
            maBdd = new Bdd();
        }

        private void btnconnexion_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtboxidentifiant.Text, out int result) == false)
            {
                MessageBox.Show("L'identifiant doit être un nombre entier");
                return;
            }
            else
            {
                int monid = Convert.ToInt32(txtboxidentifiant.Text);
                Varglob.monHotel = maBdd.hotel.Where(hotel => hotel.id == monid).FirstOrDefault();

                bool valide = Argon2.Verify(Varglob.monHotel.motpasse, txtboxmdp.Text);

                if (valide)
                {
                    FormMenu formMenu = new FormMenu();
                    formMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Identifiant ou mot de passe incorrect");
                }
            }
        }
    }
}
