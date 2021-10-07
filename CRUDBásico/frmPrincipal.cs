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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instaciamos al formulario
            frmTest frm = new frmTest();
            frm.MdiParent = this; //definir formulario padre
            frm.Show();//mostrar formulario
        }

        private void perroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Perro perro = new Perro();
            perro.MdiParent = this; //definir formulario padre
            perro.Show();//mostrar formulario

        }
    }
}
