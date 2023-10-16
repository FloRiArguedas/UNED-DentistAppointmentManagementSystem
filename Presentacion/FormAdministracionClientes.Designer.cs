namespace Presentacion
{
    partial class FormAdministracionClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_AC = new DataGridView();
            lblID = new Label();
            lblname = new Label();
            lblApellido1 = new Label();
            lblApellido2 = new Label();
            lblBDate = new Label();
            lblGen = new Label();
            bttnAdd = new Button();
            bttnModify = new Button();
            bttnCharge = new Button();
            lblBDModify = new Label();
            lblGenModify = new Label();
            cmbbxGenAdd = new ComboBox();
            cmbbxGenModify = new ComboBox();
            txtboxID = new TextBox();
            txtboxName = new TextBox();
            txtbox1A = new TextBox();
            txtbox2A = new TextBox();
            dateToAdd = new DateTimePicker();
            dateToModify = new DateTimePicker();
            lblTittleAdd = new Label();
            label1 = new Label();
            lbl_IDtoModify = new Label();
            txtBox_IDtoModify = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_AC).BeginInit();
            SuspendLayout();
            // 
            // dgv_AC
            // 
            dgv_AC.AllowUserToAddRows = false;
            dgv_AC.AllowUserToDeleteRows = false;
            dgv_AC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_AC.Location = new Point(12, 179);
            dgv_AC.Name = "dgv_AC";
            dgv_AC.ReadOnly = true;
            dgv_AC.RowTemplate.Height = 25;
            dgv_AC.Size = new Size(776, 239);
            dgv_AC.TabIndex = 0;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblID.Location = new Point(12, 33);
            lblID.Name = "lblID";
            lblID.Size = new Size(90, 17);
            lblID.TabIndex = 1;
            lblID.Text = "Identificación:";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblname.Location = new Point(205, 35);
            lblname.Name = "lblname";
            lblname.Size = new Size(60, 17);
            lblname.TabIndex = 2;
            lblname.Text = "Nombre:";
            // 
            // lblApellido1
            // 
            lblApellido1.AutoSize = true;
            lblApellido1.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido1.Location = new Point(386, 34);
            lblApellido1.Name = "lblApellido1";
            lblApellido1.Size = new Size(84, 17);
            lblApellido1.TabIndex = 3;
            lblApellido1.Text = "1er Apellido:";
            // 
            // lblApellido2
            // 
            lblApellido2.AutoSize = true;
            lblApellido2.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido2.Location = new Point(582, 34);
            lblApellido2.Name = "lblApellido2";
            lblApellido2.Size = new Size(88, 17);
            lblApellido2.TabIndex = 4;
            lblApellido2.Text = "2do Apellido:";
            // 
            // lblBDate
            // 
            lblBDate.AutoSize = true;
            lblBDate.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBDate.Location = new Point(12, 84);
            lblBDate.Name = "lblBDate";
            lblBDate.Size = new Size(137, 17);
            lblBDate.TabIndex = 5;
            lblBDate.Text = "Fecha de Nacimiento:";
            // 
            // lblGen
            // 
            lblGen.AutoSize = true;
            lblGen.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblGen.Location = new Point(386, 82);
            lblGen.Name = "lblGen";
            lblGen.Size = new Size(55, 17);
            lblGen.TabIndex = 6;
            lblGen.Text = "Género:";
            // 
            // bttnAdd
            // 
            bttnAdd.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bttnAdd.Location = new Point(679, 76);
            bttnAdd.Name = "bttnAdd";
            bttnAdd.Size = new Size(75, 23);
            bttnAdd.TabIndex = 7;
            bttnAdd.Text = "AGREGAR";
            bttnAdd.UseVisualStyleBackColor = true;
            bttnAdd.Click += bttnAdd_Click;
            // 
            // bttnModify
            // 
            bttnModify.BackColor = Color.DarkSeaGreen;
            bttnModify.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bttnModify.ForeColor = SystemColors.ButtonHighlight;
            bttnModify.Location = new Point(679, 147);
            bttnModify.Name = "bttnModify";
            bttnModify.Size = new Size(84, 23);
            bttnModify.TabIndex = 8;
            bttnModify.Text = "MODIFICAR";
            bttnModify.UseVisualStyleBackColor = false;
            bttnModify.Click += bttnModify_Click;
            // 
            // bttnCharge
            // 
            bttnCharge.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bttnCharge.Location = new Point(696, 421);
            bttnCharge.Name = "bttnCharge";
            bttnCharge.Size = new Size(92, 23);
            bttnCharge.TabIndex = 9;
            bttnCharge.Text = "CONSULTAR";
            bttnCharge.UseVisualStyleBackColor = true;
            bttnCharge.Click += bttnCharge_Click;
            // 
            // lblBDModify
            // 
            lblBDModify.AutoSize = true;
            lblBDModify.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBDModify.Location = new Point(160, 151);
            lblBDModify.Name = "lblBDModify";
            lblBDModify.Size = new Size(137, 17);
            lblBDModify.TabIndex = 10;
            lblBDModify.Text = "Fecha de Nacimiento:";
            // 
            // lblGenModify
            // 
            lblGenModify.AutoSize = true;
            lblGenModify.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblGenModify.Location = new Point(481, 151);
            lblGenModify.Name = "lblGenModify";
            lblGenModify.Size = new Size(55, 17);
            lblGenModify.TabIndex = 11;
            lblGenModify.Text = "Género:";
            // 
            // cmbbxGenAdd
            // 
            cmbbxGenAdd.Font = new Font("Malgun Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbbxGenAdd.FormattingEnabled = true;
            cmbbxGenAdd.Items.AddRange(new object[] { "Femenino", "Masculino", "No deseo especificar" });
            cmbbxGenAdd.Location = new Point(476, 76);
            cmbbxGenAdd.Name = "cmbbxGenAdd";
            cmbbxGenAdd.Size = new Size(121, 23);
            cmbbxGenAdd.TabIndex = 14;
            cmbbxGenAdd.SelectedIndexChanged += cmbbxGenAdd_SelectedIndexChanged;
            // 
            // cmbbxGenModify
            // 
            cmbbxGenModify.Font = new Font("Malgun Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbbxGenModify.FormattingEnabled = true;
            cmbbxGenModify.Items.AddRange(new object[] { "Femenino", "Masculino", "No deseo especificar" });
            cmbbxGenModify.Location = new Point(541, 148);
            cmbbxGenModify.Name = "cmbbxGenModify";
            cmbbxGenModify.Size = new Size(121, 23);
            cmbbxGenModify.TabIndex = 15;
            cmbbxGenModify.SelectedIndexChanged += cmbbxGenModify_SelectedIndexChanged;
            // 
            // txtboxID
            // 
            txtboxID.Font = new Font("Malgun Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtboxID.Location = new Point(108, 31);
            txtboxID.Name = "txtboxID";
            txtboxID.Size = new Size(91, 23);
            txtboxID.TabIndex = 16;
            txtboxID.TextChanged += txtboxID_TextChanged;
            txtboxID.KeyPress += txtboxID_KeyPress;
            // 
            // txtboxName
            // 
            txtboxName.Font = new Font("Malgun Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtboxName.Location = new Point(271, 31);
            txtboxName.Name = "txtboxName";
            txtboxName.Size = new Size(100, 23);
            txtboxName.TabIndex = 17;
            txtboxName.TextChanged += txtboxName_TextChanged;
            // 
            // txtbox1A
            // 
            txtbox1A.Font = new Font("Malgun Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox1A.Location = new Point(476, 31);
            txtbox1A.Name = "txtbox1A";
            txtbox1A.Size = new Size(100, 23);
            txtbox1A.TabIndex = 18;
            txtbox1A.TextChanged += txtbox1A_TextChanged;
            // 
            // txtbox2A
            // 
            txtbox2A.Font = new Font("Malgun Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox2A.Location = new Point(679, 31);
            txtbox2A.Name = "txtbox2A";
            txtbox2A.Size = new Size(100, 23);
            txtbox2A.TabIndex = 19;
            txtbox2A.TextChanged += txtbox2A_TextChanged;
            // 
            // dateToAdd
            // 
            dateToAdd.Font = new Font("Malgun Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateToAdd.Location = new Point(155, 78);
            dateToAdd.Name = "dateToAdd";
            dateToAdd.Size = new Size(167, 23);
            dateToAdd.TabIndex = 20;
            dateToAdd.ValueChanged += dateToAdd_ValueChanged;
            // 
            // dateToModify
            // 
            dateToModify.Font = new Font("Malgun Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateToModify.Location = new Point(303, 148);
            dateToModify.Name = "dateToModify";
            dateToModify.Size = new Size(162, 23);
            dateToModify.TabIndex = 21;
            dateToModify.ValueChanged += dateToModify_ValueChanged;
            // 
            // lblTittleAdd
            // 
            lblTittleAdd.AutoSize = true;
            lblTittleAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTittleAdd.Location = new Point(264, 9);
            lblTittleAdd.Name = "lblTittleAdd";
            lblTittleAdd.Size = new Size(280, 15);
            lblTittleAdd.TabIndex = 22;
            lblTittleAdd.Text = "Llene las siguientes casillas para agregar un cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(229, 115);
            label1.Name = "label1";
            label1.Size = new Size(369, 15);
            label1.TabIndex = 23;
            label1.Text = "Cambie los datos de las siguientes casillas para modificar un cliente";
            // 
            // lbl_IDtoModify
            // 
            lbl_IDtoModify.AutoSize = true;
            lbl_IDtoModify.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_IDtoModify.Location = new Point(18, 151);
            lbl_IDtoModify.Name = "lbl_IDtoModify";
            lbl_IDtoModify.Size = new Size(24, 17);
            lbl_IDtoModify.TabIndex = 24;
            lbl_IDtoModify.Text = "ID:";
            // 
            // txtBox_IDtoModify
            // 
            txtBox_IDtoModify.Location = new Point(48, 148);
            txtBox_IDtoModify.Name = "txtBox_IDtoModify";
            txtBox_IDtoModify.Size = new Size(100, 23);
            txtBox_IDtoModify.TabIndex = 25;
            txtBox_IDtoModify.TextChanged += txtBox_IDtoModify_TextChanged;
            // 
            // FormAdministracionClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBox_IDtoModify);
            Controls.Add(lbl_IDtoModify);
            Controls.Add(label1);
            Controls.Add(lblTittleAdd);
            Controls.Add(dateToModify);
            Controls.Add(dateToAdd);
            Controls.Add(txtbox2A);
            Controls.Add(txtbox1A);
            Controls.Add(txtboxName);
            Controls.Add(txtboxID);
            Controls.Add(cmbbxGenModify);
            Controls.Add(cmbbxGenAdd);
            Controls.Add(lblGenModify);
            Controls.Add(lblBDModify);
            Controls.Add(bttnCharge);
            Controls.Add(bttnModify);
            Controls.Add(bttnAdd);
            Controls.Add(lblGen);
            Controls.Add(lblBDate);
            Controls.Add(lblApellido2);
            Controls.Add(lblApellido1);
            Controls.Add(lblname);
            Controls.Add(lblID);
            Controls.Add(dgv_AC);
            Name = "FormAdministracionClientes";
            Text = "Administracion de Clientes";
            ((System.ComponentModel.ISupportInitialize)dgv_AC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_AC;
        private Label lblID;
        private Label lblname;
        private Label lblApellido1;
        private Label lblApellido2;
        private Label lblBDate;
        private Label lblGen;
        private Button bttnAdd;
        private Button bttnModify;
        private Button bttnCharge;
        private Label lblBDModify;
        private Label lblGenModify;
        private ComboBox cmbbxGenAdd;
        private ComboBox cmbbxGenModify;
        private TextBox txtboxID;
        private TextBox txtboxName;
        private TextBox txtbox1A;
        private TextBox txtbox2A;
        private DateTimePicker dateToAdd;
        private DateTimePicker dateToModify;
        private Label lblTittleAdd;
        private Label label1;
        private Label lbl_IDtoModify;
        private TextBox txtBox_IDtoModify;
    }
}