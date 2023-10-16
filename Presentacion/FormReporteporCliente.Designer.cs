namespace Presentacion
{
    partial class FormReporteporCliente
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
            lbl_tittle = new Label();
            lbl_SeleccioneClienteReporte = new Label();
            cmbbx_ClienteReporte = new ComboBox();
            DGV_ReporteCliente = new DataGridView();
            bttn_MostrarreporteCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_ReporteCliente).BeginInit();
            SuspendLayout();
            // 
            // lbl_tittle
            // 
            lbl_tittle.AutoSize = true;
            lbl_tittle.Font = new Font("Malgun Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tittle.Location = new Point(289, 22);
            lbl_tittle.Name = "lbl_tittle";
            lbl_tittle.Size = new Size(248, 20);
            lbl_tittle.TabIndex = 0;
            lbl_tittle.Text = "REPORTE DE CITAS POR CLIENTE";
            // 
            // lbl_SeleccioneClienteReporte
            // 
            lbl_SeleccioneClienteReporte.AutoSize = true;
            lbl_SeleccioneClienteReporte.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_SeleccioneClienteReporte.Location = new Point(45, 93);
            lbl_SeleccioneClienteReporte.Name = "lbl_SeleccioneClienteReporte";
            lbl_SeleccioneClienteReporte.Size = new Size(131, 17);
            lbl_SeleccioneClienteReporte.TabIndex = 1;
            lbl_SeleccioneClienteReporte.Text = "Seleccione el cliente:";
            // 
            // cmbbx_ClienteReporte
            // 
            cmbbx_ClienteReporte.FormattingEnabled = true;
            cmbbx_ClienteReporte.Location = new Point(185, 90);
            cmbbx_ClienteReporte.Name = "cmbbx_ClienteReporte";
            cmbbx_ClienteReporte.Size = new Size(185, 23);
            cmbbx_ClienteReporte.TabIndex = 2;
            cmbbx_ClienteReporte.SelectedIndexChanged += cmbbx_ClienteReporte_SelectedIndexChanged;
            cmbbx_ClienteReporte.Click += cmbbx_ClienteReporte_Click;
            // 
            // DGV_ReporteCliente
            // 
            DGV_ReporteCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_ReporteCliente.Location = new Point(48, 175);
            DGV_ReporteCliente.Name = "DGV_ReporteCliente";
            DGV_ReporteCliente.RowTemplate.Height = 25;
            DGV_ReporteCliente.Size = new Size(703, 238);
            DGV_ReporteCliente.TabIndex = 3;
            // 
            // bttn_MostrarreporteCliente
            // 
            bttn_MostrarreporteCliente.BackColor = SystemColors.ActiveCaption;
            bttn_MostrarreporteCliente.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bttn_MostrarreporteCliente.Location = new Point(592, 93);
            bttn_MostrarreporteCliente.Name = "bttn_MostrarreporteCliente";
            bttn_MostrarreporteCliente.Size = new Size(159, 23);
            bttn_MostrarreporteCliente.TabIndex = 4;
            bttn_MostrarreporteCliente.Text = "MOSTRAR REPORTE";
            bttn_MostrarreporteCliente.UseVisualStyleBackColor = false;
            bttn_MostrarreporteCliente.Click += bttn_MostrarreporteCliente_Click;
            // 
            // FormReporteporCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bttn_MostrarreporteCliente);
            Controls.Add(DGV_ReporteCliente);
            Controls.Add(cmbbx_ClienteReporte);
            Controls.Add(lbl_SeleccioneClienteReporte);
            Controls.Add(lbl_tittle);
            Name = "FormReporteporCliente";
            Text = "Reportes por Cliente";
            ((System.ComponentModel.ISupportInitialize)DGV_ReporteCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_tittle;
        private Label lbl_SeleccioneClienteReporte;
        private ComboBox cmbbx_ClienteReporte;
        private DataGridView DGV_ReporteCliente;
        private Button bttn_MostrarreporteCliente;
    }
}