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
    public partial class FormReservation : Form
    {
        Bdd maBdd;
        public FormReservation()
        {
            InitializeComponent();
        }

        private void FormReservation_Load(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
            dateTimePicker1.Value = DateTime.Now.AddYears(-1);
            dateTimePicker2.Value = DateTime.Now.AddYears(1);
            maBdd = new Bdd();
            Varglob.monHotel = maBdd.hotel.Where(param => param.id == Varglob.monHotel.id).FirstOrDefault();

            string Chambre = "";

            foreach (var item in maBdd.reservation)
            {
                if (item.datedebut >= dateTimePicker1.Value && item.datefin <= dateTimePicker2.Value)
                {
                    foreach (chambre uneChambre in item.chambres)
                    { Chambre = Chambre + uneChambre.numero.ToString() + " / "; }
                        
                    dataGridView1.Rows.Add(item.id, item.datedebut, item.datefin, item.client.nom, Chambre);
                }
            }
        }

        private void BtnRecharger_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string Chambre = "";

            foreach (var item in maBdd.reservation)
            {
                if (item.datedebut >= dateTimePicker1.Value && item.datefin <= dateTimePicker2.Value)
                {
                    foreach (chambre uneChambre in item.chambres)
                    { Chambre = Chambre + uneChambre.numero.ToString() + " / "; }

                    dataGridView1.Rows.Add(item.id, item.datedebut, item.datefin, item.client.nom, Chambre);
                }
            }
        }
    }
}
