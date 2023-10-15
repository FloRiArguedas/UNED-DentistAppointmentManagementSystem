namespace Presentacion
{
    partial class FormTipoConsulta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_description = new Label();
            txtb_description = new TextBox();
            label1 = new Label();
            cmbbx_status = new ComboBox();
            DGV_TC = new DataGridView();
            bttn_ad = new Button();
            bttn_modify = new Button();
            lbl_IDModify = new Label();
            txtbx_IDModify = new TextBox();
            lbl_IDTC = new Label();
            txtbx_IDTC = new TextBox();
            lbl_ChangeStatus = new Label();
            cmbbx_changeStatus = new ComboBox();
            lbl_addSection = new Label();
            lbl_SectionModify = new Label();
            ((System.ComponentModel.ISupportInitialize)DGV_TC).BeginInit();
            SuspendLayout();
            // 
            // lbl_description
            // 
            lbl_description.AutoSize = true;
            lbl_description.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_description.Location = new Point(24, 112);
            lbl_description.Name = "lbl_description";
            lbl_description.Size = new Size(100, 21);
            lbl_description.TabIndex = 0;
            lbl_description.Text = "Descripción:";
            // 
            // txtb_description
            // 
            txtb_description.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_description.Location = new Point(130, 110);
            txtb_description.Name = "txtb_description";
            txtb_description.Size = new Size(234, 25);
            txtb_description.TabIndex = 1;
            txtb_description.TextChanged += txtb_description_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 148);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 2;
            label1.Text = "Estado:";
            // 
            // cmbbx_status
            // 
            cmbbx_status.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbbx_status.FormattingEnabled = true;
            cmbbx_status.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbbx_status.Location = new Point(130, 145);
            cmbbx_status.Name = "cmbbx_status";
            cmbbx_status.Size = new Size(121, 25);
            cmbbx_status.TabIndex = 3;
            cmbbx_status.SelectedIndexChanged += cmbbx_status_SelectedIndexChanged;
            // 
            // DGV_TC
            // 
            DGV_TC.BackgroundColor = Color.FromArgb(192, 192, 255);
            DGV_TC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_TC.Location = new Point(392, 35);
            DGV_TC.Name = "DGV_TC";
            DGV_TC.RowTemplate.Height = 25;
            DGV_TC.Size = new Size(353, 327);
            DGV_TC.TabIndex = 4;
            // 
            // bttn_ad
            // 
            bttn_ad.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bttn_ad.Location = new Point(289, 149);
            bttn_ad.Name = "bttn_ad";
            bttn_ad.Size = new Size(75, 23);
            bttn_ad.TabIndex = 5;
            bttn_ad.Text = "Añadir";
            bttn_ad.UseVisualStyleBackColor = true;
            bttn_ad.Click += bttn_ad_Click;
            // 
            // bttn_modify
            // 
            bttn_modify.BackColor = Color.FromArgb(128, 128, 255);
            bttn_modify.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bttn_modify.Location = new Point(289, 269);
            bttn_modify.Name = "bttn_modify";
            bttn_modify.Size = new Size(87, 23);
            bttn_modify.TabIndex = 6;
            bttn_modify.Text = "Modificar";
            bttn_modify.UseVisualStyleBackColor = false;
            bttn_modify.Click += bttn_modify_Click;
            // 
            // lbl_IDModify
            // 
            lbl_IDModify.AutoSize = true;
            lbl_IDModify.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_IDModify.Location = new Point(24, 273);
            lbl_IDModify.Name = "lbl_IDModify";
            lbl_IDModify.Size = new Size(109, 21);
            lbl_IDModify.TabIndex = 7;
            lbl_IDModify.Text = "Indique el ID:";
            // 
            // txtbx_IDModify
            // 
            txtbx_IDModify.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtbx_IDModify.Location = new Point(169, 269);
            txtbx_IDModify.Name = "txtbx_IDModify";
            txtbx_IDModify.Size = new Size(109, 25);
            txtbx_IDModify.TabIndex = 8;
            // 
            // lbl_IDTC
            // 
            lbl_IDTC.AutoSize = true;
            lbl_IDTC.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_IDTC.Location = new Point(24, 77);
            lbl_IDTC.Name = "lbl_IDTC";
            lbl_IDTC.Size = new Size(29, 21);
            lbl_IDTC.TabIndex = 9;
            lbl_IDTC.Text = "ID:";
            // 
            // txtbx_IDTC
            // 
            txtbx_IDTC.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtbx_IDTC.Location = new Point(131, 78);
            txtbx_IDTC.Name = "txtbx_IDTC";
            txtbx_IDTC.Size = new Size(100, 25);
            txtbx_IDTC.TabIndex = 10;
            txtbx_IDTC.TextChanged += txtbx_IDTC_TextChanged;
            txtbx_IDTC.KeyPress += txtbx_IDTC_KeyPress;
            // 
            // lbl_ChangeStatus
            // 
            lbl_ChangeStatus.AutoSize = true;
            lbl_ChangeStatus.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ChangeStatus.Location = new Point(24, 319);
            lbl_ChangeStatus.Name = "lbl_ChangeStatus";
            lbl_ChangeStatus.Size = new Size(143, 21);
            lbl_ChangeStatus.TabIndex = 11;
            lbl_ChangeStatus.Text = "Cambie el Estado:";
            // 
            // cmbbx_changeStatus
            // 
            cmbbx_changeStatus.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbbx_changeStatus.FormattingEnabled = true;
            cmbbx_changeStatus.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbbx_changeStatus.Location = new Point(169, 319);
            cmbbx_changeStatus.Name = "cmbbx_changeStatus";
            cmbbx_changeStatus.Size = new Size(121, 25);
            cmbbx_changeStatus.TabIndex = 12;
            // 
            // lbl_addSection
            // 
            lbl_addSection.AutoSize = true;
            lbl_addSection.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_addSection.Location = new Point(21, 35);
            lbl_addSection.Name = "lbl_addSection";
            lbl_addSection.Size = new Size(339, 13);
            lbl_addSection.TabIndex = 13;
            lbl_addSection.Text = "Llene los campos a continuación para añadir un Tipo Consulta";
            // 
            // lbl_SectionModify
            // 
            lbl_SectionModify.AutoSize = true;
            lbl_SectionModify.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_SectionModify.Location = new Point(21, 223);
            lbl_SectionModify.Name = "lbl_SectionModify";
            lbl_SectionModify.Size = new Size(355, 13);
            lbl_SectionModify.TabIndex = 14;
            lbl_SectionModify.Text = "Llene los campos a continuación para modificar un Tipo Consulta";
            // 
            // FormTipoConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 374);
            Controls.Add(lbl_SectionModify);
            Controls.Add(lbl_addSection);
            Controls.Add(cmbbx_changeStatus);
            Controls.Add(lbl_ChangeStatus);
            Controls.Add(txtbx_IDTC);
            Controls.Add(lbl_IDTC);
            Controls.Add(txtbx_IDModify);
            Controls.Add(lbl_IDModify);
            Controls.Add(bttn_modify);
            Controls.Add(bttn_ad);
            Controls.Add(DGV_TC);
            Controls.Add(cmbbx_status);
            Controls.Add(label1);
            Controls.Add(txtb_description);
            Controls.Add(lbl_description);
            Name = "FormTipoConsulta";
            Text = "Registro de Tipos de Consulta";
            ((System.ComponentModel.ISupportInitialize)DGV_TC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_description;
        private TextBox txtb_description;
        private Label label1;
        private ComboBox cmbbx_status;
        private DataGridView DGV_TC;
        private Button bttn_ad;
        private Button bttn_modify;
        private Label lbl_IDModify;
        private TextBox txtbx_IDModify;
        private Label lbl_IDTC;
        private TextBox txtbx_IDTC;
        private Label lbl_ChangeStatus;
        private ComboBox cmbbx_changeStatus;
        private Label lbl_addSection;
        private Label lbl_SectionModify;
    }
}