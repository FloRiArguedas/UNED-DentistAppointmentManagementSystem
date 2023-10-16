namespace Presentacion
{
    partial class FormReporteDoctor
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
            bttn_VerCitasDoctor = new Button();
            lbl_Tittle = new Label();
            lbl_SelectDoctor = new Label();
            cmbbox_DoctoresReporte = new ComboBox();
            DGV_ReporteDoctor = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGV_ReporteDoctor).BeginInit();
            SuspendLayout();
            // 
            // bttn_VerCitasDoctor
            // 
            bttn_VerCitasDoctor.BackColor = Color.FromArgb(128, 255, 255);
            bttn_VerCitasDoctor.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bttn_VerCitasDoctor.Location = new Point(576, 96);
            bttn_VerCitasDoctor.Name = "bttn_VerCitasDoctor";
            bttn_VerCitasDoctor.Size = new Size(149, 23);
            bttn_VerCitasDoctor.TabIndex = 0;
            bttn_VerCitasDoctor.Text = "MOSTRAR REPORTE";
            bttn_VerCitasDoctor.UseVisualStyleBackColor = false;
            bttn_VerCitasDoctor.Click += bttn_VerCitasDoctor_Click;
            // 
            // lbl_Tittle
            // 
            lbl_Tittle.AutoSize = true;
            lbl_Tittle.Font = new Font("Malgun Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Tittle.Location = new Point(276, 31);
            lbl_Tittle.Name = "lbl_Tittle";
            lbl_Tittle.Size = new Size(252, 20);
            lbl_Tittle.TabIndex = 1;
            lbl_Tittle.Text = "REPORTE DE CITAS POR DOCTOR";
            // 
            // lbl_SelectDoctor
            // 
            lbl_SelectDoctor.AutoSize = true;
            lbl_SelectDoctor.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_SelectDoctor.Location = new Point(83, 97);
            lbl_SelectDoctor.Name = "lbl_SelectDoctor";
            lbl_SelectDoctor.Size = new Size(132, 17);
            lbl_SelectDoctor.TabIndex = 2;
            lbl_SelectDoctor.Text = "Seleccione el doctor:";
            // 
            // cmbbox_DoctoresReporte
            // 
            cmbbox_DoctoresReporte.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbbox_DoctoresReporte.FormattingEnabled = true;
            cmbbox_DoctoresReporte.Location = new Point(222, 94);
            cmbbox_DoctoresReporte.Name = "cmbbox_DoctoresReporte";
            cmbbox_DoctoresReporte.Size = new Size(188, 25);
            cmbbox_DoctoresReporte.TabIndex = 3;
            cmbbox_DoctoresReporte.SelectedIndexChanged += cmbbox_DoctoresReporte_SelectedIndexChanged;
            cmbbox_DoctoresReporte.Click += cmbbox_DoctoresReporte_Click;
            // 
            // DGV_ReporteDoctor
            // 
            DGV_ReporteDoctor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_ReporteDoctor.Location = new Point(83, 176);
            DGV_ReporteDoctor.Name = "DGV_ReporteDoctor";
            DGV_ReporteDoctor.RowTemplate.Height = 25;
            DGV_ReporteDoctor.Size = new Size(642, 221);
            DGV_ReporteDoctor.TabIndex = 4;
            // 
            // FormReporteDoctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DGV_ReporteDoctor);
            Controls.Add(cmbbox_DoctoresReporte);
            Controls.Add(lbl_SelectDoctor);
            Controls.Add(lbl_Tittle);
            Controls.Add(bttn_VerCitasDoctor);
            Name = "FormReporteDoctor";
            Text = "Reportes por Doctor";
            ((System.ComponentModel.ISupportInitialize)DGV_ReporteDoctor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttn_VerCitasDoctor;
        private Label lbl_Tittle;
        private Label lbl_SelectDoctor;
        private ComboBox cmbbox_DoctoresReporte;
        private DataGridView DGV_ReporteDoctor;
    }
}