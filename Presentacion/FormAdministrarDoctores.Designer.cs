namespace Presentacion
{
    partial class FormAdministrarDoctores
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
            DGV_Doctores = new DataGridView();
            ldl_IDDoctor = new Label();
            txtbx_IDDoctor = new TextBox();
            Txtbx_NameDoctor = new TextBox();
            Txtbx_PriApDoctor = new TextBox();
            Txtbx_SegApDoctor = new TextBox();
            cmbbx_StatusDoctor = new ComboBox();
            bttn_addDoc = new Button();
            bttn_ModifyDoc = new Button();
            lbl_NameDoctor = new Label();
            lbl_PrApDoctor = new Label();
            lbl_SegApDoctor = new Label();
            lbl_Estado = new Label();
            lbl_IDMD = new Label();
            lbl_StatusMD = new Label();
            lblTittleAdd = new Label();
            lblTittleModifyDoctor = new Label();
            cmbbx_StatusModifyDoctor = new ComboBox();
            Txtbx_IDModifyDoctor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGV_Doctores).BeginInit();
            SuspendLayout();
            // 
            // DGV_Doctores
            // 
            DGV_Doctores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Doctores.Location = new Point(25, 142);
            DGV_Doctores.Name = "DGV_Doctores";
            DGV_Doctores.RowTemplate.Height = 25;
            DGV_Doctores.Size = new Size(750, 219);
            DGV_Doctores.TabIndex = 0;
            // 
            // ldl_IDDoctor
            // 
            ldl_IDDoctor.AutoSize = true;
            ldl_IDDoctor.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ldl_IDDoctor.Location = new Point(29, 41);
            ldl_IDDoctor.Name = "ldl_IDDoctor";
            ldl_IDDoctor.Size = new Size(90, 17);
            ldl_IDDoctor.TabIndex = 1;
            ldl_IDDoctor.Text = "Identificacion:";
            // 
            // txtbx_IDDoctor
            // 
            txtbx_IDDoctor.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtbx_IDDoctor.Location = new Point(116, 37);
            txtbx_IDDoctor.Name = "txtbx_IDDoctor";
            txtbx_IDDoctor.Size = new Size(100, 25);
            txtbx_IDDoctor.TabIndex = 2;
            txtbx_IDDoctor.TextChanged += txtbx_IDDoctor_TextChanged;
            txtbx_IDDoctor.KeyPress += txtbx_IDDoctor_KeyPress;
            // 
            // Txtbx_NameDoctor
            // 
            Txtbx_NameDoctor.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Txtbx_NameDoctor.Location = new Point(116, 101);
            Txtbx_NameDoctor.Name = "Txtbx_NameDoctor";
            Txtbx_NameDoctor.Size = new Size(100, 25);
            Txtbx_NameDoctor.TabIndex = 3;
            Txtbx_NameDoctor.TextChanged += Txtbx_NameDoctor_TextChanged;
            // 
            // Txtbx_PriApDoctor
            // 
            Txtbx_PriApDoctor.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Txtbx_PriApDoctor.Location = new Point(417, 36);
            Txtbx_PriApDoctor.Name = "Txtbx_PriApDoctor";
            Txtbx_PriApDoctor.Size = new Size(100, 25);
            Txtbx_PriApDoctor.TabIndex = 4;
            Txtbx_PriApDoctor.TextChanged += Txtbx_PriApDoctor_TextChanged;
            // 
            // Txtbx_SegApDoctor
            // 
            Txtbx_SegApDoctor.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Txtbx_SegApDoctor.Location = new Point(417, 101);
            Txtbx_SegApDoctor.Name = "Txtbx_SegApDoctor";
            Txtbx_SegApDoctor.Size = new Size(100, 25);
            Txtbx_SegApDoctor.TabIndex = 5;
            Txtbx_SegApDoctor.TextChanged += Txtbx_SegApDoctor_TextChanged;
            // 
            // cmbbx_StatusDoctor
            // 
            cmbbx_StatusDoctor.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbbx_StatusDoctor.FormattingEnabled = true;
            cmbbx_StatusDoctor.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbbx_StatusDoctor.Location = new Point(637, 35);
            cmbbx_StatusDoctor.Name = "cmbbx_StatusDoctor";
            cmbbx_StatusDoctor.Size = new Size(121, 25);
            cmbbx_StatusDoctor.TabIndex = 6;
            cmbbx_StatusDoctor.SelectedIndexChanged += cmbbx_StatusDoctor_SelectedIndexChanged;
            // 
            // bttn_addDoc
            // 
            bttn_addDoc.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bttn_addDoc.Location = new Point(660, 107);
            bttn_addDoc.Name = "bttn_addDoc";
            bttn_addDoc.Size = new Size(75, 23);
            bttn_addDoc.TabIndex = 7;
            bttn_addDoc.Text = "AÑADIR";
            bttn_addDoc.UseVisualStyleBackColor = true;
            bttn_addDoc.Click += bttn_addDoc_Click;
            // 
            // bttn_ModifyDoc
            // 
            bttn_ModifyDoc.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bttn_ModifyDoc.ForeColor = SystemColors.Highlight;
            bttn_ModifyDoc.Location = new Point(653, 405);
            bttn_ModifyDoc.Name = "bttn_ModifyDoc";
            bttn_ModifyDoc.Size = new Size(93, 23);
            bttn_ModifyDoc.TabIndex = 8;
            bttn_ModifyDoc.Text = "MODIFICAR";
            bttn_ModifyDoc.UseVisualStyleBackColor = true;
            bttn_ModifyDoc.Click += bttn_ModifyDoc_Click;
            // 
            // lbl_NameDoctor
            // 
            lbl_NameDoctor.AutoSize = true;
            lbl_NameDoctor.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_NameDoctor.Location = new Point(29, 106);
            lbl_NameDoctor.Name = "lbl_NameDoctor";
            lbl_NameDoctor.Size = new Size(60, 17);
            lbl_NameDoctor.TabIndex = 9;
            lbl_NameDoctor.Text = "Nombre:";
            // 
            // lbl_PrApDoctor
            // 
            lbl_PrApDoctor.AutoSize = true;
            lbl_PrApDoctor.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_PrApDoctor.Location = new Point(299, 39);
            lbl_PrApDoctor.Name = "lbl_PrApDoctor";
            lbl_PrApDoctor.Size = new Size(103, 17);
            lbl_PrApDoctor.TabIndex = 10;
            lbl_PrApDoctor.Text = "Primer Apellido:";
            // 
            // lbl_SegApDoctor
            // 
            lbl_SegApDoctor.AutoSize = true;
            lbl_SegApDoctor.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_SegApDoctor.Location = new Point(299, 108);
            lbl_SegApDoctor.Name = "lbl_SegApDoctor";
            lbl_SegApDoctor.Size = new Size(119, 17);
            lbl_SegApDoctor.TabIndex = 11;
            lbl_SegApDoctor.Text = "Segundo Apellido:";
            // 
            // lbl_Estado
            // 
            lbl_Estado.AutoSize = true;
            lbl_Estado.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Estado.Location = new Point(580, 39);
            lbl_Estado.Name = "lbl_Estado";
            lbl_Estado.Size = new Size(51, 17);
            lbl_Estado.TabIndex = 12;
            lbl_Estado.Text = "Estado:";
            // 
            // lbl_IDMD
            // 
            lbl_IDMD.AutoSize = true;
            lbl_IDMD.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_IDMD.Location = new Point(29, 408);
            lbl_IDMD.Name = "lbl_IDMD";
            lbl_IDMD.Size = new Size(90, 17);
            lbl_IDMD.TabIndex = 13;
            lbl_IDMD.Text = "Identificación:";
            // 
            // lbl_StatusMD
            // 
            lbl_StatusMD.AutoSize = true;
            lbl_StatusMD.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_StatusMD.Location = new Point(304, 407);
            lbl_StatusMD.Name = "lbl_StatusMD";
            lbl_StatusMD.Size = new Size(51, 17);
            lbl_StatusMD.TabIndex = 14;
            lbl_StatusMD.Text = "Estado:";
            // 
            // lblTittleAdd
            // 
            lblTittleAdd.AutoSize = true;
            lblTittleAdd.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTittleAdd.Location = new Point(258, 6);
            lblTittleAdd.Name = "lblTittleAdd";
            lblTittleAdd.Size = new Size(297, 15);
            lblTittleAdd.TabIndex = 15;
            lblTittleAdd.Text = "Llene las siguientes casillas para añadir un doctor";
            // 
            // lblTittleModifyDoctor
            // 
            lblTittleModifyDoctor.AutoSize = true;
            lblTittleModifyDoctor.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTittleModifyDoctor.Location = new Point(209, 370);
            lblTittleModifyDoctor.Name = "lblTittleModifyDoctor";
            lblTittleModifyDoctor.Size = new Size(391, 15);
            lblTittleModifyDoctor.TabIndex = 16;
            lblTittleModifyDoctor.Text = "Llene las siguientes casillas para modificar el estado de un doctor";
            // 
            // cmbbx_StatusModifyDoctor
            // 
            cmbbx_StatusModifyDoctor.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbbx_StatusModifyDoctor.FormattingEnabled = true;
            cmbbx_StatusModifyDoctor.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbbx_StatusModifyDoctor.Location = new Point(381, 404);
            cmbbx_StatusModifyDoctor.Name = "cmbbx_StatusModifyDoctor";
            cmbbx_StatusModifyDoctor.Size = new Size(121, 25);
            cmbbx_StatusModifyDoctor.TabIndex = 17;
            cmbbx_StatusModifyDoctor.SelectedIndexChanged += cmbbx_StatusModifyDoctor_SelectedIndexChanged;
            // 
            // Txtbx_IDModifyDoctor
            // 
            Txtbx_IDModifyDoctor.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Txtbx_IDModifyDoctor.Location = new Point(123, 403);
            Txtbx_IDModifyDoctor.Name = "Txtbx_IDModifyDoctor";
            Txtbx_IDModifyDoctor.Size = new Size(100, 25);
            Txtbx_IDModifyDoctor.TabIndex = 18;
            Txtbx_IDModifyDoctor.TextChanged += Txtbx_IDModifyDoctor_TextChanged;
            // 
            // FormAdministrarDoctores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Txtbx_IDModifyDoctor);
            Controls.Add(cmbbx_StatusModifyDoctor);
            Controls.Add(lblTittleModifyDoctor);
            Controls.Add(lblTittleAdd);
            Controls.Add(lbl_StatusMD);
            Controls.Add(lbl_IDMD);
            Controls.Add(lbl_Estado);
            Controls.Add(lbl_SegApDoctor);
            Controls.Add(lbl_PrApDoctor);
            Controls.Add(lbl_NameDoctor);
            Controls.Add(bttn_ModifyDoc);
            Controls.Add(bttn_addDoc);
            Controls.Add(cmbbx_StatusDoctor);
            Controls.Add(Txtbx_SegApDoctor);
            Controls.Add(Txtbx_PriApDoctor);
            Controls.Add(Txtbx_NameDoctor);
            Controls.Add(txtbx_IDDoctor);
            Controls.Add(ldl_IDDoctor);
            Controls.Add(DGV_Doctores);
            Name = "FormAdministrarDoctores";
            Text = "FormAdministrarDoctores";
            ((System.ComponentModel.ISupportInitialize)DGV_Doctores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV_Doctores;
        private Label ldl_IDDoctor;
        private TextBox txtbx_IDDoctor;
        private TextBox Txtbx_NameDoctor;
        private TextBox Txtbx_PriApDoctor;
        private TextBox Txtbx_SegApDoctor;
        private ComboBox cmbbx_StatusDoctor;
        private Button bttn_addDoc;
        private Button bttn_ModifyDoc;
        private Label lbl_NameDoctor;
        private Label lbl_PrApDoctor;
        private Label lbl_SegApDoctor;
        private Label lbl_Estado;
        private Label lbl_IDMD;
        private Label lbl_StatusMD;
        private Label lblTittleAdd;
        private Label lblTittleModifyDoctor;
        private ComboBox cmbbx_StatusModifyDoctor;
        private TextBox Txtbx_IDModifyDoctor;
    }
}