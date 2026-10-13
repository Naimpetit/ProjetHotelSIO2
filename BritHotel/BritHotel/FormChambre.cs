using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BritHotel
{
    public partial class FormChambre : Form
    {
        Bdd maBdd;
        public FormChambre()
        {
            InitializeComponent();
        }

        private void FormChambre_Load(object sender, EventArgs e)
        {
            maBdd = new Bdd();
            dgvChambre.RowHeadersVisible = false;
            dgvChambre.Rows.Clear();
            dgvChambre.ColumnCount=2;
            dgvChambre.Columns[0].HeaderText = "ID";
            dgvChambre.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvChambre.Columns[1].HeaderText = "numéro";
            dgvChambre.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Varglob.monHotel = maBdd.hotel.Where(param => param.id == Varglob.monHotel.id).FirstOrDefault();
            foreach (chambre ch in Varglob.monHotel.chambres)
            {
                dgvChambre.Rows.Add(ch.id, ch.numero);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Varglob.monHotel = maBdd.hotel.Where(param => param.id == Varglob.monHotel.id).FirstOrDefault();
            Boolean existe = Varglob.monHotel.chambres.Any(param => param.numero == textBox1.Text);
            if (existe)
            {
                MessageBox.Show("Cette chambre existe déjà");
            }
            else
            {
                chambre chambre = new chambre();
                chambre.numero = textBox1.Text;
                chambre.hotel_id = Varglob.monHotel.id;
                maBdd.chambre.Add(chambre);
                maBdd.SaveChanges();
                FormChambre_Load(sender, e);
            }




        }

        private void dgvChambre_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = dgvChambre.Rows[e.RowIndex].Cells[1].Value.ToString(); ;
            label5.Text = dgvChambre.Rows[e.RowIndex].Cells[0].Value.ToString(); ;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int idchambre = Convert.ToInt32(label5.Text);
            chambre unechambre = maBdd.chambre.Where(param => param.id == idchambre).FirstOrDefault();
            maBdd.chambre.Remove( unechambre);
            maBdd.SaveChanges();
            FormChambre_Load(sender, e);
        }

    }
}
