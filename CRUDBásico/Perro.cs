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
        private string action = "";

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
             
        }

        public void controlsEnable()
        {
            txbIdPerro.Enabled = true;
            txbName.Enabled = true;
            txbRaza.Enabled = true;
            txbAge.Enabled = true;
            txbVaccine.Enabled = true;
            txbOwerName.Enabled = true;
            txbtelephone.Enabled = true;
        }





        public void clearControls()
        {
            txbIdPerro.Text = "";
            txbName.Text = "";
            txbRaza.Text = "";
            txbAge.Text = "";
            txbVaccine.Text = "";
            txbOwerName.Text = "";
            txbtelephone.Text = "";
        }



        private void metroButton1_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Seguro desea cancelar ";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

            }

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            controlsEnable();
            clearControls();
        }
    }
}
