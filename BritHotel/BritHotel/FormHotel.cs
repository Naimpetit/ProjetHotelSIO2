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
    public partial class FormHotel : Form
    {
        Bdd maBdd;
        List<equipement> lesEquipements = new List<equipement>();
        int i = 0;
        public FormHotel()
        {
            InitializeComponent();
        }

        private void FormHotel_Load(object sender, EventArgs e) // Initialisation
        {
            maBdd = new Bdd();
            Varglob.monHotel = maBdd.hotel.Where(param => param.id == Varglob.monHotel.id).FirstOrDefault();
            txtboxNom.Text = Varglob.monHotel.nom;
            txtboxEmplacement.Text = Varglob.monHotel.rue1;
            txtboxCodeP.Text = Varglob.monHotel.cp;
            txtboxVille.Text = Varglob.monHotel.ville;
            txtboxTel.Text = Varglob.monHotel.telephone.ToString();
            txtboxDesc.Text = Varglob.monHotel.descourt;
            txtboxPrix.Text = Varglob.monHotel.prix.ToString() + "€";

            listBox1.SelectionMode = SelectionMode.MultiSimple;       
            listBox1.Items.Clear();
            i = 0;
            foreach (var item in maBdd.equipement)
            {
                listBox1.Items.Add(item.libelle + " " + item.id.ToString());
                lesEquipements.Add(item);
                Boolean coche = Varglob.monHotel.equipements.Any(param => param.id == lesEquipements[i].id);
                listBox1.SetSelected(i, coche);
                i += 1;
            }
        }

        private void Btnvalider_Click(object sender, EventArgs e)
        {
            Varglob.monHotel.nom = txtboxNom.Text;
            Varglob.monHotel.rue1 = txtboxEmplacement.Text;
            Varglob.monHotel.cp = txtboxCodeP.Text;
            Varglob.monHotel.ville = txtboxVille.Text;
            Varglob.monHotel.telephone = txtboxTel.Text;
            Varglob.monHotel.descourt = txtboxDesc.Text;
            Varglob.monHotel.prix = Convert.ToSingle(txtboxPrix.Text.Replace("€", ""));
            Varglob.monHotel.equipements.Clear();

            i = 0;
            foreach (var item in maBdd.equipement) // boucle qui m'a pris 1h50 </3
            {
                if (listBox1.GetSelected(i))
                {
                    var equipementSelectionne = lesEquipements[i];
                    Varglob.monHotel.equipements.Add(equipementSelectionne);
                    MessageBox.Show("Equipement ajouté : " + equipementSelectionne.id);
                }
                i += 1;
            }
            maBdd.SaveChanges();
            FormHotel_Load(sender, e);
        }
    }
}
