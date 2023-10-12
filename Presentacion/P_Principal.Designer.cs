﻿namespace Presentacion
{
    partial class P_Principal
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            registroClienteToolStripMenuItem = new ToolStripMenuItem();
            registrarCitasToolStripMenuItem = new ToolStripMenuItem();
            administrarClientesToolStripMenuItem = new ToolStripMenuItem();
            administrarDoctoresToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            reportesPorFechaToolStripMenuItem = new ToolStripMenuItem();
            reportesPorDoctorToolStripMenuItem = new ToolStripMenuItem();
            reportesPorClienteToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, reportesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registroClienteToolStripMenuItem, registrarCitasToolStripMenuItem, administrarClientesToolStripMenuItem, administrarDoctoresToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // registroClienteToolStripMenuItem
            // 
            registroClienteToolStripMenuItem.Name = "registroClienteToolStripMenuItem";
            registroClienteToolStripMenuItem.Size = new Size(201, 22);
            registroClienteToolStripMenuItem.Text = "Registrar Tipos Consulta";
            registroClienteToolStripMenuItem.Click += registroClienteToolStripMenuItem_Click;
            // 
            // registrarCitasToolStripMenuItem
            // 
            registrarCitasToolStripMenuItem.Name = "registrarCitasToolStripMenuItem";
            registrarCitasToolStripMenuItem.Size = new Size(201, 22);
            registrarCitasToolStripMenuItem.Text = "Registrar Citas";
            
            // 
            // administrarClientesToolStripMenuItem
            // 
            administrarClientesToolStripMenuItem.Name = "administrarClientesToolStripMenuItem";
            administrarClientesToolStripMenuItem.Size = new Size(201, 22);
            administrarClientesToolStripMenuItem.Text = "Administrar Clientes";
            // 
            // administrarDoctoresToolStripMenuItem
            // 
            administrarDoctoresToolStripMenuItem.Name = "administrarDoctoresToolStripMenuItem";
            administrarDoctoresToolStripMenuItem.Size = new Size(201, 22);
            administrarDoctoresToolStripMenuItem.Text = "Administrar Doctores";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(201, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reportesPorFechaToolStripMenuItem, reportesPorDoctorToolStripMenuItem, reportesPorClienteToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(65, 20);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reportesPorFechaToolStripMenuItem
            // 
            reportesPorFechaToolStripMenuItem.Name = "reportesPorFechaToolStripMenuItem";
            reportesPorFechaToolStripMenuItem.Size = new Size(181, 22);
            reportesPorFechaToolStripMenuItem.Text = "Reportes por Fecha";
            // 
            // reportesPorDoctorToolStripMenuItem
            // 
            reportesPorDoctorToolStripMenuItem.Name = "reportesPorDoctorToolStripMenuItem";
            reportesPorDoctorToolStripMenuItem.Size = new Size(181, 22);
            reportesPorDoctorToolStripMenuItem.Text = "Reportes por Doctor";
            // 
            // reportesPorClienteToolStripMenuItem
            // 
            reportesPorClienteToolStripMenuItem.Name = "reportesPorClienteToolStripMenuItem";
            reportesPorClienteToolStripMenuItem.Size = new Size(181, 22);
            reportesPorClienteToolStripMenuItem.Text = "Reportes por Cliente";
            // 
            // P_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "P_Principal";
            Text = "P_Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem registroClienteToolStripMenuItem;
        private ToolStripMenuItem registrarCitasToolStripMenuItem;
        private ToolStripMenuItem administrarClientesToolStripMenuItem;
        private ToolStripMenuItem administrarDoctoresToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem reportesPorFechaToolStripMenuItem;
        private ToolStripMenuItem reportesPorDoctorToolStripMenuItem;
        private ToolStripMenuItem reportesPorClienteToolStripMenuItem;
    }
}