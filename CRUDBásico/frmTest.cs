﻿using System;
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
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string connectionString = "";
            MySqlConnection conn;
            try
            {
                connectionString = @"Server=localhost;Database=SMIS001721;
                Uid=root;Pwd=usbw; SSL Mode=None";
                conn = new MySqlConnection(connectionString);
                conn.Open();
                //MessageBox.Show("Se establecio a la base de datos");
                MetroFramework.MetroMessageBox.Show(this,
                    "CONEXION EXITOSA", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                conn.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                MetroFramework.MetroMessageBox.Show(this,
                    Ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }   
    }
}
