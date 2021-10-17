
namespace CRUDBásico
{
    partial class Perro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabs = new MetroFramework.Controls.MetroTabControl();
            this.tabForm = new MetroFramework.Controls.MetroTabPage();
            this.lbOwnerName = new MetroFramework.Controls.MetroLabel();
            this.lbTelephone = new MetroFramework.Controls.MetroLabel();
            this.txtOwnerName = new MetroFramework.Controls.MetroTextBox();
            this.txtVaccines = new MetroFramework.Controls.MetroTextBox();
            this.txtAge = new MetroFramework.Controls.MetroTextBox();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.lbAge = new MetroFramework.Controls.MetroLabel();
            this.lbId = new MetroFramework.Controls.MetroLabel();
            this.txtRace = new MetroFramework.Controls.MetroTextBox();
            this.lbName = new MetroFramework.Controls.MetroLabel();
            this.lbVaccines = new MetroFramework.Controls.MetroLabel();
            this.lbRace = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.tabData = new MetroFramework.Controls.MetroTabPage();
            this.dtgDog = new System.Windows.Forms.DataGridView();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lNew = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.txtTelephone = new System.Windows.Forms.MaskedTextBox();
            this.tabs.SuspendLayout();
            this.tabForm.SuspendLayout();
            this.tabData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDog)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabForm);
            this.tabs.Controls.Add(this.tabData);
            this.tabs.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.tabs.Location = new System.Drawing.Point(24, 88);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(823, 374);
            this.tabs.TabIndex = 34;
            this.tabs.UseSelectable = true;
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.txtTelephone);
            this.tabForm.Controls.Add(this.lbOwnerName);
            this.tabForm.Controls.Add(this.lbTelephone);
            this.tabForm.Controls.Add(this.txtOwnerName);
            this.tabForm.Controls.Add(this.txtVaccines);
            this.tabForm.Controls.Add(this.txtAge);
            this.tabForm.Controls.Add(this.btnCancel);
            this.tabForm.Controls.Add(this.btnSave);
            this.tabForm.Controls.Add(this.lbAge);
            this.tabForm.Controls.Add(this.lbId);
            this.tabForm.Controls.Add(this.txtRace);
            this.tabForm.Controls.Add(this.lbName);
            this.tabForm.Controls.Add(this.lbVaccines);
            this.tabForm.Controls.Add(this.lbRace);
            this.tabForm.Controls.Add(this.txtId);
            this.tabForm.Controls.Add(this.txtName);
            this.tabForm.HorizontalScrollbarBarColor = true;
            this.tabForm.HorizontalScrollbarHighlightOnWheel = false;
            this.tabForm.HorizontalScrollbarSize = 10;
            this.tabForm.Location = new System.Drawing.Point(4, 34);
            this.tabForm.Name = "tabForm";
            this.tabForm.Size = new System.Drawing.Size(815, 336);
            this.tabForm.TabIndex = 0;
            this.tabForm.Text = "NUEVO REGISTRO";
            this.tabForm.VerticalScrollbarBarColor = true;
            this.tabForm.VerticalScrollbarHighlightOnWheel = false;
            this.tabForm.VerticalScrollbarSize = 10;
            // 
            // lbOwnerName
            // 
            this.lbOwnerName.AutoSize = true;
            this.lbOwnerName.Location = new System.Drawing.Point(428, 65);
            this.lbOwnerName.Name = "lbOwnerName";
            this.lbOwnerName.Size = new System.Drawing.Size(115, 19);
            this.lbOwnerName.TabIndex = 32;
            this.lbOwnerName.Text = "NOMBRE DUEÑO";
            // 
            // lbTelephone
            // 
            this.lbTelephone.AutoSize = true;
            this.lbTelephone.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbTelephone.Location = new System.Drawing.Point(428, 111);
            this.lbTelephone.Name = "lbTelephone";
            this.lbTelephone.Size = new System.Drawing.Size(76, 19);
            this.lbTelephone.TabIndex = 34;
            this.lbTelephone.Text = "TELEFONO";
            // 
            // txtOwnerName
            // 
            // 
            // 
            // 
            this.txtOwnerName.CustomButton.Image = null;
            this.txtOwnerName.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.txtOwnerName.CustomButton.Name = "";
            this.txtOwnerName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOwnerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOwnerName.CustomButton.TabIndex = 1;
            this.txtOwnerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOwnerName.CustomButton.UseSelectable = true;
            this.txtOwnerName.CustomButton.Visible = false;
            this.txtOwnerName.Lines = new string[0];
            this.txtOwnerName.Location = new System.Drawing.Point(555, 65);
            this.txtOwnerName.MaxLength = 32767;
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.PasswordChar = '\0';
            this.txtOwnerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOwnerName.SelectedText = "";
            this.txtOwnerName.SelectionLength = 0;
            this.txtOwnerName.SelectionStart = 0;
            this.txtOwnerName.ShortcutsEnabled = true;
            this.txtOwnerName.Size = new System.Drawing.Size(241, 23);
            this.txtOwnerName.TabIndex = 33;
            this.txtOwnerName.UseSelectable = true;
            this.txtOwnerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOwnerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtVaccines
            // 
            // 
            // 
            // 
            this.txtVaccines.CustomButton.Image = null;
            this.txtVaccines.CustomButton.Location = new System.Drawing.Point(18, 1);
            this.txtVaccines.CustomButton.Name = "";
            this.txtVaccines.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtVaccines.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVaccines.CustomButton.TabIndex = 1;
            this.txtVaccines.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVaccines.CustomButton.UseSelectable = true;
            this.txtVaccines.CustomButton.Visible = false;
            this.txtVaccines.Lines = new string[0];
            this.txtVaccines.Location = new System.Drawing.Point(155, 211);
            this.txtVaccines.MaxLength = 32767;
            this.txtVaccines.Name = "txtVaccines";
            this.txtVaccines.PasswordChar = '\0';
            this.txtVaccines.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVaccines.SelectedText = "";
            this.txtVaccines.SelectionLength = 0;
            this.txtVaccines.SelectionStart = 0;
            this.txtVaccines.ShortcutsEnabled = true;
            this.txtVaccines.Size = new System.Drawing.Size(51, 23);
            this.txtVaccines.TabIndex = 31;
            this.txtVaccines.UseSelectable = true;
            this.txtVaccines.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVaccines.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAge
            // 
            // 
            // 
            // 
            this.txtAge.CustomButton.Image = null;
            this.txtAge.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.txtAge.CustomButton.Name = "";
            this.txtAge.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAge.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAge.CustomButton.TabIndex = 1;
            this.txtAge.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAge.CustomButton.UseSelectable = true;
            this.txtAge.CustomButton.Visible = false;
            this.txtAge.Lines = new string[0];
            this.txtAge.Location = new System.Drawing.Point(155, 161);
            this.txtAge.MaxLength = 32767;
            this.txtAge.Name = "txtAge";
            this.txtAge.PasswordChar = '\0';
            this.txtAge.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAge.SelectedText = "";
            this.txtAge.SelectionLength = 0;
            this.txtAge.SelectionStart = 0;
            this.txtAge.ShortcutsEnabled = true;
            this.txtAge.Size = new System.Drawing.Size(241, 23);
            this.txtAge.TabIndex = 30;
            this.txtAge.UseSelectable = true;
            this.txtAge.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAge.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DimGray;
            this.btnCancel.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(438, 288);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 33);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.White;
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseCustomBackColor = true;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseStyleColors = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(343, 288);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(53, 33);
            this.btnSave.Style = MetroFramework.MetroColorStyle.White;
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(28, 165);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(43, 19);
            this.lbAge.TabIndex = 20;
            this.lbAge.Text = "EDAD";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(28, 25);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(67, 19);
            this.lbId.TabIndex = 14;
            this.lbId.Text = "ID PERRO";
            // 
            // txtRace
            // 
            // 
            // 
            // 
            this.txtRace.CustomButton.Image = null;
            this.txtRace.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.txtRace.CustomButton.Name = "";
            this.txtRace.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRace.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRace.CustomButton.TabIndex = 1;
            this.txtRace.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRace.CustomButton.UseSelectable = true;
            this.txtRace.CustomButton.Visible = false;
            this.txtRace.Lines = new string[0];
            this.txtRace.Location = new System.Drawing.Point(155, 115);
            this.txtRace.MaxLength = 32767;
            this.txtRace.Name = "txtRace";
            this.txtRace.PasswordChar = '\0';
            this.txtRace.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRace.SelectedText = "";
            this.txtRace.SelectionLength = 0;
            this.txtRace.SelectionStart = 0;
            this.txtRace.ShortcutsEnabled = true;
            this.txtRace.Size = new System.Drawing.Size(241, 23);
            this.txtRace.TabIndex = 19;
            this.txtRace.UseSelectable = true;
            this.txtRace.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRace.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(28, 69);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(65, 19);
            this.lbName.TabIndex = 15;
            this.lbName.Text = "NOMBRE";
            // 
            // lbVaccines
            // 
            this.lbVaccines.AutoSize = true;
            this.lbVaccines.Location = new System.Drawing.Point(28, 215);
            this.lbVaccines.Name = "lbVaccines";
            this.lbVaccines.Size = new System.Drawing.Size(69, 19);
            this.lbVaccines.TabIndex = 22;
            this.lbVaccines.Text = "VACUNAS";
            // 
            // lbRace
            // 
            this.lbRace.AutoSize = true;
            this.lbRace.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbRace.Location = new System.Drawing.Point(28, 115);
            this.lbRace.Name = "lbRace";
            this.lbRace.Size = new System.Drawing.Size(43, 19);
            this.lbRace.TabIndex = 18;
            this.lbRace.Text = "RAZA";
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(79, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(155, 25);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ReadOnly = true;
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(101, 23);
            this.txtId.TabIndex = 16;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(155, 69);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(241, 23);
            this.txtName.TabIndex = 17;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.dtgDog);
            this.tabData.HorizontalScrollbarBarColor = true;
            this.tabData.HorizontalScrollbarHighlightOnWheel = false;
            this.tabData.HorizontalScrollbarSize = 10;
            this.tabData.Location = new System.Drawing.Point(4, 34);
            this.tabData.Name = "tabData";
            this.tabData.Size = new System.Drawing.Size(815, 336);
            this.tabData.TabIndex = 1;
            this.tabData.Text = "LISTA PERROS";
            this.tabData.VerticalScrollbarBarColor = true;
            this.tabData.VerticalScrollbarHighlightOnWheel = false;
            this.tabData.VerticalScrollbarSize = 10;
            // 
            // dtgDog
            // 
            this.dtgDog.AllowUserToAddRows = false;
            this.dtgDog.AllowUserToDeleteRows = false;
            this.dtgDog.AllowUserToResizeColumns = false;
            this.dtgDog.AllowUserToResizeRows = false;
            this.dtgDog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDog.BackgroundColor = System.Drawing.Color.White;
            this.dtgDog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgDog.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgDog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDog.ContextMenuStrip = this.metroContextMenu1;
            this.dtgDog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgDog.Location = new System.Drawing.Point(13, 17);
            this.dtgDog.MultiSelect = false;
            this.dtgDog.Name = "dtgDog";
            this.dtgDog.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgDog.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgDog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDog.Size = new System.Drawing.Size(772, 263);
            this.dtgDog.TabIndex = 32;
            this.dtgDog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDog_CellContentClick);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // lNew
            // 
            this.lNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lNew.Location = new System.Drawing.Point(118, 36);
            this.lNew.Name = "lNew";
            this.lNew.Size = new System.Drawing.Size(105, 41);
            this.lNew.TabIndex = 35;
            this.lNew.Text = "| Nuevo Registro";
            this.lNew.UseSelectable = true;
            this.lNew.Click += new System.EventHandler(this.lNew_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(37, 36);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel1.TabIndex = 36;
            this.metroLabel1.Text = "PERRO";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(781, 490);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 28);
            this.btnExit.Style = MetroFramework.MetroColorStyle.White;
            this.btnExit.TabIndex = 37;
            this.btnExit.Text = "Exit";
            this.btnExit.UseCustomBackColor = true;
            this.btnExit.UseSelectable = true;
            this.btnExit.UseStyleColors = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(555, 118);
            this.txtTelephone.Mask = "0000-0000";
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(67, 20);
            this.txtTelephone.TabIndex = 36;
            // 
            // Perro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(881, 530);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lNew);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Perro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Perro_Load);
            this.tabs.ResumeLayout(false);
            this.tabForm.ResumeLayout(false);
            this.tabForm.PerformLayout();
            this.tabData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDog)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl tabs;
        private MetroFramework.Controls.MetroTabPage tabForm;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLabel lbAge;
        private MetroFramework.Controls.MetroLabel lbId;
        private MetroFramework.Controls.MetroTextBox txtRace;
        private MetroFramework.Controls.MetroLabel lbName;
        private MetroFramework.Controls.MetroLabel lbVaccines;
        private MetroFramework.Controls.MetroLabel lbRace;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTabPage tabData;
        private System.Windows.Forms.DataGridView dtgDog;
        private MetroFramework.Controls.MetroLabel lbOwnerName;
        private MetroFramework.Controls.MetroLabel lbTelephone;
        private MetroFramework.Controls.MetroTextBox txtOwnerName;
        private MetroFramework.Controls.MetroTextBox txtVaccines;
        private MetroFramework.Controls.MetroTextBox txtAge;
        private MetroFramework.Controls.MetroLink lNew;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox txtTelephone;
    }
}

