namespace Presentacion
{
    partial class FormReporteFecha
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
            lblTittle = new Label();
            lbl_FechaReporte = new Label();
            DaTiPic_DateSelected = new DateTimePicker();
            bttn_VerCitasFecha = new Button();
            DGV_ReporteFecha = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGV_ReporteFecha).BeginInit();
            SuspendLayout();
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.Font = new Font("Malgun Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTittle.Location = new Point(294, 20);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(237, 20);
            lblTittle.TabIndex = 0;
            lblTittle.Text = "REPORTE DE CITAS POR FECHA";
            // 
            // lbl_FechaReporte
            // 
            lbl_FechaReporte.AutoSize = true;
            lbl_FechaReporte.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_FechaReporte.Location = new Point(63, 86);
            lbl_FechaReporte.Name = "lbl_FechaReporte";
            lbl_FechaReporte.Size = new Size(125, 17);
            lbl_FechaReporte.TabIndex = 1;
            lbl_FechaReporte.Text = "Seleccione la fecha:";
            // 
            // DaTiPic_DateSelected
            // 
            DaTiPic_DateSelected.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DaTiPic_DateSelected.Location = new Point(201, 81);
            DaTiPic_DateSelected.Name = "DaTiPic_DateSelected";
            DaTiPic_DateSelected.Size = new Size(263, 25);
            DaTiPic_DateSelected.TabIndex = 2;
            DaTiPic_DateSelected.ValueChanged += DaTiPic_DateSelected_ValueChanged;
            // 
            // bttn_VerCitasFecha
            // 
            bttn_VerCitasFecha.BackColor = Color.Yellow;
            bttn_VerCitasFecha.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bttn_VerCitasFecha.ForeColor = SystemColors.ActiveCaptionText;
            bttn_VerCitasFecha.Location = new Point(606, 82);
            bttn_VerCitasFecha.Name = "bttn_VerCitasFecha";
            bttn_VerCitasFecha.Size = new Size(144, 23);
            bttn_VerCitasFecha.TabIndex = 3;
            bttn_VerCitasFecha.Text = "MOSTRAR REPORTE";
            bttn_VerCitasFecha.UseVisualStyleBackColor = false;
            bttn_VerCitasFecha.Click += bttn_VerCitasFecha_Click;
            // 
            // DGV_ReporteFecha
            // 
            DGV_ReporteFecha.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_ReporteFecha.Location = new Point(63, 152);
            DGV_ReporteFecha.Name = "DGV_ReporteFecha";
            DGV_ReporteFecha.RowTemplate.Height = 25;
            DGV_ReporteFecha.Size = new Size(687, 259);
            DGV_ReporteFecha.TabIndex = 4;
            // 
            // FormReporteFecha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DGV_ReporteFecha);
            Controls.Add(bttn_VerCitasFecha);
            Controls.Add(DaTiPic_DateSelected);
            Controls.Add(lbl_FechaReporte);
            Controls.Add(lblTittle);
            Name = "FormReporteFecha";
            Text = "Reportes por Fecha";
            ((System.ComponentModel.ISupportInitialize)DGV_ReporteFecha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTittle;
        private Label lbl_FechaReporte;
        private DateTimePicker DaTiPic_DateSelected;
        private Button bttn_VerCitasFecha;
        private DataGridView DGV_ReporteFecha;
    }
}