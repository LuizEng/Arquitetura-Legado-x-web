﻿namespace ManagerService.View
{
    partial class Home_Form
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.grdDadosHoje = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.grdDadosSemana = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mnuHome = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarPagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAgendar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agendarServiçoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAgenda = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.realizarPagamentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosHoje)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosSemana)).BeginInit();
            this.panel6.SuspendLayout();
            this.mnuHome.SuspendLayout();
            this.mnuAgendar.SuspendLayout();
            this.mnuAgenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.mnuHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 673);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1108, 581);
            this.panel4.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.grdClientes);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(542, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(566, 581);
            this.panel10.TabIndex = 1;
            // 
            // grdClientes
            // 
            this.grdClientes.AllowUserToAddRows = false;
            this.grdClientes.AllowUserToDeleteRows = false;
            this.grdClientes.AllowUserToOrderColumns = true;
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdClientes.Location = new System.Drawing.Point(0, 14);
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.ReadOnly = true;
            this.grdClientes.Size = new System.Drawing.Size(566, 567);
            this.grdClientes.TabIndex = 2;
            this.grdClientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grdClientes_MouseClick);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label3);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(566, 14);
            this.panel11.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lista de Clientes";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(542, 581);
            this.panel5.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.grdDadosHoje);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 14);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(542, 283);
            this.panel9.TabIndex = 3;
            // 
            // grdDadosHoje
            // 
            this.grdDadosHoje.AllowUserToAddRows = false;
            this.grdDadosHoje.AllowUserToDeleteRows = false;
            this.grdDadosHoje.AllowUserToOrderColumns = true;
            this.grdDadosHoje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDadosHoje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDadosHoje.Location = new System.Drawing.Point(0, 0);
            this.grdDadosHoje.Name = "grdDadosHoje";
            this.grdDadosHoje.ReadOnly = true;
            this.grdDadosHoje.Size = new System.Drawing.Size(542, 283);
            this.grdDadosHoje.TabIndex = 0;
            this.grdDadosHoje.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grdDadosHoje_MouseClick);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 297);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(542, 14);
            this.panel8.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Serviços marcados para esta semana:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.grdDadosSemana);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 311);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(542, 270);
            this.panel7.TabIndex = 1;
            // 
            // grdDadosSemana
            // 
            this.grdDadosSemana.AllowUserToAddRows = false;
            this.grdDadosSemana.AllowUserToDeleteRows = false;
            this.grdDadosSemana.AllowUserToOrderColumns = true;
            this.grdDadosSemana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDadosSemana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDadosSemana.Location = new System.Drawing.Point(0, 0);
            this.grdDadosSemana.Name = "grdDadosSemana";
            this.grdDadosSemana.ReadOnly = true;
            this.grdDadosSemana.Size = new System.Drawing.Size(542, 270);
            this.grdDadosSemana.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(542, 14);
            this.panel6.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serviços marcados para hoje:";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 647);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1108, 26);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 42);
            this.panel2.TabIndex = 1;
            // 
            // mnuHome
            // 
            this.mnuHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.agendaToolStripMenuItem});
            this.mnuHome.Location = new System.Drawing.Point(0, 0);
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.Size = new System.Drawing.Size(1108, 24);
            this.mnuHome.TabIndex = 0;
            this.mnuHome.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.serviçosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            this.serviçosToolStripMenuItem.Click += new System.EventHandler(this.serviçosToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarServiçoToolStripMenuItem,
            this.realizarPagamentoToolStripMenuItem});
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.agendaToolStripMenuItem.Text = "Agenda";
            // 
            // agendarServiçoToolStripMenuItem
            // 
            this.agendarServiçoToolStripMenuItem.Name = "agendarServiçoToolStripMenuItem";
            this.agendarServiçoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agendarServiçoToolStripMenuItem.Text = "Agendar Serviço";
            this.agendarServiçoToolStripMenuItem.Click += new System.EventHandler(this.agendarServiçoToolStripMenuItem_Click);
            // 
            // realizarPagamentoToolStripMenuItem
            // 
            this.realizarPagamentoToolStripMenuItem.Name = "realizarPagamentoToolStripMenuItem";
            this.realizarPagamentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.realizarPagamentoToolStripMenuItem.Text = "Realizar Pagamento";
            // 
            // mnuAgendar
            // 
            this.mnuAgendar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarServiçoToolStripMenuItem1});
            this.mnuAgendar.Name = "mnuAgendar";
            this.mnuAgendar.Size = new System.Drawing.Size(161, 26);
            // 
            // agendarServiçoToolStripMenuItem1
            // 
            this.agendarServiçoToolStripMenuItem1.Name = "agendarServiçoToolStripMenuItem1";
            this.agendarServiçoToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.agendarServiçoToolStripMenuItem1.Text = "Agendar Serviço";
            this.agendarServiçoToolStripMenuItem1.Click += new System.EventHandler(this.agendarServiçoToolStripMenuItem1_Click);
            // 
            // mnuAgenda
            // 
            this.mnuAgenda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarPagamentoToolStripMenuItem1});
            this.mnuAgenda.Name = "mnuAgenda";
            this.mnuAgenda.Size = new System.Drawing.Size(181, 48);
            // 
            // realizarPagamentoToolStripMenuItem1
            // 
            this.realizarPagamentoToolStripMenuItem1.Name = "realizarPagamentoToolStripMenuItem1";
            this.realizarPagamentoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.realizarPagamentoToolStripMenuItem1.Text = "Realizar Pagamento";
            this.realizarPagamentoToolStripMenuItem1.Click += new System.EventHandler(this.realizarPagamentoToolStripMenuItem1_Click);
            // 
            // Home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 673);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.mnuHome;
            this.Name = "Home_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home - Bem vindo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_Form_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosHoje)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosSemana)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.mnuHome.ResumeLayout(false);
            this.mnuHome.PerformLayout();
            this.mnuAgendar.ResumeLayout(false);
            this.mnuAgenda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip mnuHome;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarPagamentoToolStripMenuItem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView grdDadosHoje;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView grdDadosSemana;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.ContextMenuStrip mnuAgendar;
        private System.Windows.Forms.ToolStripMenuItem agendarServiçoToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip mnuAgenda;
        private System.Windows.Forms.ToolStripMenuItem realizarPagamentoToolStripMenuItem1;
    }
}