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
    }
}
