﻿namespace Presentacion
{
    partial class FormRegistroCitas
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
            lbl_ID = new Label();
            DGV_Citas = new DataGridView();
            lbl_Cliente = new Label();
            lbl_Doctor = new Label();
            lbl_TipoConsulta = new Label();
            lbl_FechaCita = new Label();
            lblbTittleCita = new Label();
            bttn_AddCita = new Button();
            txtbx_IDCita = new TextBox();
            cmbbx_PacienteCita = new ComboBox();
            cmbbx_DoctorCita = new ComboBox();
            cmbbx_TipoConsultaCita = new ComboBox();
            DateTP_FechaCita = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)DGV_Citas).BeginInit();
            SuspendLayout();
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ID.Location = new Point(17, 58);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(24, 17);
            lbl_ID.TabIndex = 0;
            lbl_ID.Text = "ID:";
            // 
            // DGV_Citas
            // 
            DGV_Citas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Citas.Location = new Point(18, 187);
            DGV_Citas.Name = "DGV_Citas";
            DGV_Citas.RowTemplate.Height = 25;
            DGV_Citas.Size = new Size(683, 256);
            DGV_Citas.TabIndex = 1;
            // 
            // lbl_Cliente
            // 
            lbl_Cliente.AutoSize = true;
            lbl_Cliente.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Cliente.Location = new Point(169, 59);
            lbl_Cliente.Name = "lbl_Cliente";
            lbl_Cliente.Size = new Size(60, 17);
            lbl_Cliente.TabIndex = 2;
            lbl_Cliente.Text = "Paciente:";
            // 
            // lbl_Doctor
            // 
            lbl_Doctor.AutoSize = true;
            lbl_Doctor.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Doctor.Location = new Point(483, 59);
            lbl_Doctor.Name = "lbl_Doctor";
            lbl_Doctor.Size = new Size(51, 17);
            lbl_Doctor.TabIndex = 3;
            lbl_Doctor.Text = "Doctor:";
            // 
            // lbl_TipoConsulta
            // 
            lbl_TipoConsulta.AutoSize = true;
            lbl_TipoConsulta.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TipoConsulta.Location = new Point(21, 119);
            lbl_TipoConsulta.Name = "lbl_TipoConsulta";
            lbl_TipoConsulta.Size = new Size(114, 17);
            lbl_TipoConsulta.TabIndex = 4;
            lbl_TipoConsulta.Text = "Tipo de Consulta:";
            // 
            // lbl_FechaCita
            // 
            lbl_FechaCita.AutoSize = true;
            lbl_FechaCita.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_FechaCita.Location = new Point(318, 118);
            lbl_FechaCita.Name = "lbl_FechaCita";
            lbl_FechaCita.Size = new Size(105, 17);
            lbl_FechaCita.TabIndex = 5;
            lbl_FechaCita.Text = "Fecha de la cita:";
            // 
            // lblbTittleCita
            // 
            lblbTittleCita.AutoSize = true;
            lblbTittleCita.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblbTittleCita.Location = new Point(166, 13);
            lblbTittleCita.Name = "lblbTittleCita";
            lblbTittleCita.Size = new Size(402, 17);
            lblbTittleCita.TabIndex = 6;
            lblbTittleCita.Text = "Rellene todos los campos a continuación para asignar una cita";
            // 
            // bttn_AddCita
            // 
            bttn_AddCita.BackColor = Color.FromArgb(255, 192, 128);
            bttn_AddCita.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bttn_AddCita.Location = new Point(551, 156);
            bttn_AddCita.Name = "bttn_AddCita";
            bttn_AddCita.Size = new Size(148, 23);
            bttn_AddCita.TabIndex = 7;
            bttn_AddCita.Text = "AGREGAR CITA";
            bttn_AddCita.UseVisualStyleBackColor = false;
            // 
            // txtbx_IDCita
            // 
            txtbx_IDCita.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbx_IDCita.Location = new Point(44, 56);
            txtbx_IDCita.Name = "txtbx_IDCita";
            txtbx_IDCita.Size = new Size(84, 22);
            txtbx_IDCita.TabIndex = 8;
            // 
            // cmbbx_PacienteCita
            // 
            cmbbx_PacienteCita.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbbx_PacienteCita.FormattingEnabled = true;
            cmbbx_PacienteCita.Location = new Point(233, 57);
            cmbbx_PacienteCita.Name = "cmbbx_PacienteCita";
            cmbbx_PacienteCita.Size = new Size(233, 21);
            cmbbx_PacienteCita.TabIndex = 9;
            cmbbx_PacienteCita.Click += cmbbx_PacienteCita_Click;
            // 
            // cmbbx_DoctorCita
            // 
            cmbbx_DoctorCita.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbbx_DoctorCita.FormattingEnabled = true;
            cmbbx_DoctorCita.Location = new Point(537, 57);
            cmbbx_DoctorCita.Name = "cmbbx_DoctorCita";
            cmbbx_DoctorCita.Size = new Size(163, 21);
            cmbbx_DoctorCita.TabIndex = 10;
            cmbbx_DoctorCita.Click += cmbbx_DoctorCita_Click;
            // 
            // cmbbx_TipoConsultaCita
            // 
            cmbbx_TipoConsultaCita.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbbx_TipoConsultaCita.FormattingEnabled = true;
            cmbbx_TipoConsultaCita.Location = new Point(137, 117);
            cmbbx_TipoConsultaCita.Name = "cmbbx_TipoConsultaCita";
            cmbbx_TipoConsultaCita.Size = new Size(160, 21);
            cmbbx_TipoConsultaCita.TabIndex = 11;
            cmbbx_TipoConsultaCita.Click += cmbbx_TipoConsultaCita_Click;
            // 
            // DateTP_FechaCita
            // 
            DateTP_FechaCita.Location = new Point(424, 115);
            DateTP_FechaCita.Name = "DateTP_FechaCita";
            DateTP_FechaCita.Size = new Size(200, 23);
            DateTP_FechaCita.TabIndex = 12;
            // 
            // FormRegistroCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 450);
            Controls.Add(DateTP_FechaCita);
            Controls.Add(cmbbx_TipoConsultaCita);
            Controls.Add(cmbbx_DoctorCita);
            Controls.Add(cmbbx_PacienteCita);
            Controls.Add(txtbx_IDCita);
            Controls.Add(bttn_AddCita);
            Controls.Add(lblbTittleCita);
            Controls.Add(lbl_FechaCita);
            Controls.Add(lbl_TipoConsulta);
            Controls.Add(lbl_Doctor);
            Controls.Add(lbl_Cliente);
            Controls.Add(DGV_Citas);
            Controls.Add(lbl_ID);
            Name = "FormRegistroCitas";
            Text = "FormRegistroCitas";
            ((System.ComponentModel.ISupportInitialize)DGV_Citas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_ID;
        private DataGridView DGV_Citas;
        private Label lbl_Cliente;
        private Label lbl_Doctor;
        private Label lbl_TipoConsulta;
        private Label lbl_FechaCita;
        private Label lblbTittleCita;
        private Button bttn_AddCita;
        private TextBox txtbx_IDCita;
        private ComboBox cmbbx_PacienteCita;
        private ComboBox cmbbx_DoctorCita;
        private ComboBox cmbbx_TipoConsultaCita;
        private DateTimePicker DateTP_FechaCita;
    }
}