using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

            //deja un tab 
            tabs.TabPages.Remove(tabForm);

            //carga los datos en el datagridView
            //deshabilita controles
            fillDataGridView();
            controlsDisable();

        }

        //utilizado para mostrar los registros en el datagridview
        public void fillDataGridView()
        {
            //instancia de la clase libro| Book
            clasePerro clasePerro = new clasePerro();

            clearDataGridView();

            dtgDog.Columns.Add("perroId", "PERRO ID");
            dtgDog.Columns.Add("nombre", "NOMBRE");
            dtgDog.Columns.Add("raza", "RAZA");
            dtgDog.Columns.Add("edad", "EDAD");
            dtgDog.Columns.Add("vaccine", "VACUNAS");
            dtgDog.Columns.Add("ownerName", "NOMBRE DUEÑO");
            dtgDog.Columns.Add("telephone", "TELEFONO");


            //llamado al medoto getBooks() de la clase Book
            MySqlDataReader dataReader = clasePerro.getAllPerro();

            //leer el resultado y mostrarlo en el datagridview
            while (dataReader.Read())
            {
                dtgDog.Rows.Add(
                        dataReader.GetValue(0),
                        dataReader.GetValue(1),
                        dataReader.GetValue(2),
                        dataReader.GetValue(3),
                        dataReader.GetValue(4),
                        dataReader.GetValue(5),
                        dataReader.GetValue(6)
                       );
            }
        }

        public void clearDataGridView()
        {
            dtgDog.Columns.Clear();
            dtgDog.Rows.Clear();
        }

        //deshabilita los controles de formulario
        public void controlsDisable()
        {
            txtId.Enabled = false;
            txtName.Enabled = false;
            txtRace.Enabled = false;
            txtAge.Enabled = false;
            txtVaccines.Enabled = false;
            txtOwnerName.Enabled = false;
            txtTelephone.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        //habilitar los controles de formulario
        public void controlsEnable()
        {
            txtId.Enabled = false;
            txtName.Enabled = true;
            txtRace.Enabled = true;
            txtAge.Enabled = true;
            txtVaccines.Enabled = true;
            txtOwnerName.Enabled = true;
            txtTelephone.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        //limpiar el contenido de los controles
        public void clearControls()
        {

            txtId.Text = "";
            txtName.Text = "";
            txtRace.Text = "";
            txtAge.Text = "";
            txtVaccines.Text = "";
            txtOwnerName.Text = "";
            txtTelephone.Text = "";
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
            //controlsEnable();
            //clearControls();
        }

        private void dtgDog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tabs.TabPages.Remove(tabData);//ocultar el tab de el datagridview
            tabs.TabPages.Add(tabForm); //mostrar el formulario para los datos
            tabs.TabPages[0].Text = "EDITAR";

            action = "edit";
            controlsEnable();

            txtId.Visible = true;
            txtId.ReadOnly = true;
            lbId.Visible = true;

            //cargar datos en controles
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            //mediante este boton se programara para guardar y editar
        }

     
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            //codigo del boton salir
            string mensaje = "¿Está seguró que desea salir?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lNew_Click(object sender, EventArgs e)
        {
            tabs.TabPages.Add(tabForm);//mostrar el formulario
            tabs.TabPages.Remove(tabData); //ocultar el  tab del dataagridview
            tabs.TabPages[0].Text = "Nuevo"; //agregar texto al tab

            txtId.Visible = false;
            lbId.Visible = false;
            txtName.Focus(); //enviar enfoque al titulo
            action = "new";
            controlsEnable();
            clearControls();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sResultado = ValidacionTxtBox();

            if (sResultado == "")
            {
                clasePerro clasePerro = new clasePerro(); //instancia de la clase perro

                if (action == "edit")
                {
                    clasePerro._perroId = Convert.ToInt32(txtId.Text);
                }

                clasePerro._nombre = txtName.Text;
                clasePerro._raza = txtRace.Text;
                clasePerro._edad = txtAge.Text;
                clasePerro._vaccine = txtVaccines.Text;
                clasePerro._ownerName = txtOwnerName.Text;
                clasePerro._telephone = txtTelephone.Text;

                string mensaje = "Estas seguro que desea guardar el registro";
                if (MetroFramework.MetroMessageBox.Show(this, mensaje, "CONFIRMACION",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Llamar al metodo par guardar
                    if (clasePerro.newEditclasePerro(action))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Los datos no se han guardado!",
                        "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Los datos se han guardado exitosamentente!",
                       "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    clearControls();
                    controlsDisable();
                    fillDataGridView();
                    tabs.TabPages.Remove(tabForm);
                    tabs.TabPages.Add(tabData);
                    tabs.TabPages[0].Text = "LISTA PERRO";
                }

            }
            else 
            {
                MetroFramework.MetroMessageBox.Show(this, "FALTAN DATOS", "CONFIRMACION",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguró que desea cancelar?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clearControls();
                controlsDisable();


                tabs.TabPages.Remove(tabForm);
                tabs.TabPages.Add(tabData);
                tabs.TabPages[0].Text = "PERRO LIST";
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabs.TabPages.Remove(tabData);
            tabs.TabPages.Add(tabForm);
            tabs.TabPages[0].Text = "EDIT REGISTRO";
            controlsEnable();

            txtId.Visible = true;
            txtId.ReadOnly = true;
            lbId.Visible = true;

            //pasar los de la datagridview hacia los texbox
            txtId.Text = dtgDog.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dtgDog.CurrentRow.Cells[1].Value.ToString();
            txtRace.Text = dtgDog.CurrentRow.Cells[2].Value.ToString();
            txtAge.Text = dtgDog.CurrentRow.Cells[3].Value.ToString();
            txtVaccines.Text = dtgDog.CurrentRow.Cells[4].Value.ToString();
            txtOwnerName.Text = dtgDog.CurrentRow.Cells[5].Value.ToString();
            txtTelephone.Text = dtgDog.CurrentRow.Cells[6].Value.ToString();

            //enviar accion
            action = "edit";

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensaje = "Esta seguro que desea eliminar el registro?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "CONFIRMACION",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                clasePerro clasePerro = new clasePerro();
                clasePerro._perroId = Convert.ToInt32(dtgDog.CurrentRow.Cells[0].Value);

                //llamado al metodo
                if(clasePerro.deletePerro())
                {
                    MetroFramework.MetroMessageBox.Show(this, "Los datos se han eliminado exitosamente",
                    "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //actualizar datagridview
                    fillDataGridView();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Los datos no se han eliminado",
                   "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public string ValidacionTxtBox()
        {
            string Resultado = "";
            if (txtName.Text == "")
            {
                Resultado = Resultado + "caja\n";
            }
            if (txtRace.Text =="")
            {
                Resultado = Resultado + "caja\n";
            }
            if (txtAge.Text == "")
            {
                Resultado = Resultado + "caja\n";
            }
            if (txtVaccines.Text == "")
            {
                Resultado = Resultado + "caja\n";
            }
            if (txtOwnerName.Text == "")
            {
                Resultado = Resultado + "caja\n";
            }
            if (txtTelephone.Text == "")
            {
                Resultado = Resultado + "caja\n";
            }

            return Resultado;
        }
    }
}
