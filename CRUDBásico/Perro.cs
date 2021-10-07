using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDBásico
{
    public partial class Perro : Form
    {
        public Perro()
        {
            InitializeComponent();
        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void Perro_Load(object sender, EventArgs e)
        {
            controlsDisable();

        }

        public void controlsDisable()
        {
            txbIdPerro.Enabled = false;
            txbName.Enabled = false;
            txbRaza.Enabled = false;
            txbAge.Enabled = false;
            txbVaccine.Enabled = false;
            txbOwerName.Enabled = false;
            txbOwerName.Enabled = false;
            txbtelephone.Enabled = false;
            lbPerro.Enabled = false;
            lbName.Enabled = false;
            lbRaza.Enabled = false;
            lbEdad.Enabled = false;
            lbVacuna.Enabled = false;
            lbdueno.Enabled = false;
            lbTelefono.Enabled = false;  
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            

        }
    }
}
