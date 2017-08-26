namespace BuscarInfTxt
{
    partial class BuscarLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarLog));
            this.bttBuscar = new System.Windows.Forms.Button();
            this.lbxResultado = new System.Windows.Forms.ListBox();
            this.txtRutaPrincipal = new System.Windows.Forms.TextBox();
            this.txtpalabra = new System.Windows.Forms.TextBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.gbxParametros = new System.Windows.Forms.GroupBox();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.bttExaminar = new System.Windows.Forms.Button();
            this.lblPalabra = new System.Windows.Forms.Label();
            this.gbxResultado = new System.Windows.Forms.GroupBox();
            this.gbxLogTexto = new System.Windows.Forms.GroupBox();
            this.txtLiga = new System.Windows.Forms.TextBox();
            this.rtbTextLog = new System.Windows.Forms.RichTextBox();
            this.pgrBarraBusqueda = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblArchivosRevisados = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.mnuRevisarLog = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extencionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblArchivoScaner = new System.Windows.Forms.Label();
            this.gbxParametros.SuspendLayout();
            this.gbxResultado.SuspendLayout();
            this.gbxLogTexto.SuspendLayout();
            this.mnuRevisarLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttBuscar
            // 
            this.bttBuscar.Location = new System.Drawing.Point(165, 207);
            this.bttBuscar.Name = "bttBuscar";
            this.bttBuscar.Size = new System.Drawing.Size(153, 33);
            this.bttBuscar.TabIndex = 3;
            this.bttBuscar.Text = "[F5] &Buscar";
            this.bttBuscar.UseVisualStyleBackColor = true;
            this.bttBuscar.Click += new System.EventHandler(this.bttBuscar_Click);
            this.bttBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BuscarLog_KeyUp);
            // 
            // lbxResultado
            // 
            this.lbxResultado.FormattingEnabled = true;
            this.lbxResultado.Location = new System.Drawing.Point(6, 28);
            this.lbxResultado.Name = "lbxResultado";
            this.lbxResultado.Size = new System.Drawing.Size(328, 212);
            this.lbxResultado.TabIndex = 2;
            this.lbxResultado.SelectedIndexChanged += new System.EventHandler(this.lbxResultado_SelectedIndexChanged);
            this.lbxResultado.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            this.lbxResultado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BuscarLog_KeyUp);
            // 
            // txtRutaPrincipal
            // 
            this.txtRutaPrincipal.Location = new System.Drawing.Point(9, 42);
            this.txtRutaPrincipal.Name = "txtRutaPrincipal";
            this.txtRutaPrincipal.Size = new System.Drawing.Size(277, 20);
            this.txtRutaPrincipal.TabIndex = 0;
            this.txtRutaPrincipal.DoubleClick += new System.EventHandler(this.txtRutaPrincipal_DoubleClick);
            this.txtRutaPrincipal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BuscarLog_KeyUp);
            // 
            // txtpalabra
            // 
            this.txtpalabra.Location = new System.Drawing.Point(7, 93);
            this.txtpalabra.Multiline = true;
            this.txtpalabra.Name = "txtpalabra";
            this.txtpalabra.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtpalabra.Size = new System.Drawing.Size(315, 108);
            this.txtpalabra.TabIndex = 1;
            this.txtpalabra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BuscarLog_KeyUp);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(9, 21);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(33, 13);
            this.lblRuta.TabIndex = 4;
            this.lblRuta.Text = "Ruta:";
            // 
            // gbxParametros
            // 
            this.gbxParametros.Controls.Add(this.bttCancelar);
            this.gbxParametros.Controls.Add(this.bttExaminar);
            this.gbxParametros.Controls.Add(this.lblPalabra);
            this.gbxParametros.Controls.Add(this.bttBuscar);
            this.gbxParametros.Controls.Add(this.txtRutaPrincipal);
            this.gbxParametros.Controls.Add(this.lblRuta);
            this.gbxParametros.Controls.Add(this.txtpalabra);
            this.gbxParametros.Location = new System.Drawing.Point(12, 36);
            this.gbxParametros.Name = "gbxParametros";
            this.gbxParametros.Size = new System.Drawing.Size(330, 256);
            this.gbxParametros.TabIndex = 5;
            this.gbxParametros.TabStop = false;
            this.gbxParametros.Text = "Parametros de Busqueda";
            // 
            // bttCancelar
            // 
            this.bttCancelar.Location = new System.Drawing.Point(6, 207);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(153, 33);
            this.bttCancelar.TabIndex = 4;
            this.bttCancelar.Text = "[F3] &Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = true;
            this.bttCancelar.Click += new System.EventHandler(this.BttCancelarClick);
            this.bttCancelar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BuscarLog_KeyUp);
            // 
            // bttExaminar
            // 
            this.bttExaminar.Location = new System.Drawing.Point(289, 40);
            this.bttExaminar.Name = "bttExaminar";
            this.bttExaminar.Size = new System.Drawing.Size(33, 23);
            this.bttExaminar.TabIndex = 6;
            this.bttExaminar.Text = "...";
            this.bttExaminar.UseVisualStyleBackColor = true;
            this.bttExaminar.Click += new System.EventHandler(this.bttExaminar_Click);
            this.bttExaminar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BuscarLog_KeyUp);
            // 
            // lblPalabra
            // 
            this.lblPalabra.AutoSize = true;
            this.lblPalabra.Location = new System.Drawing.Point(9, 70);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(116, 13);
            this.lblPalabra.TabIndex = 5;
            this.lblPalabra.Text = "Buscar palabra o frase:";
            // 
            // gbxResultado
            // 
            this.gbxResultado.Controls.Add(this.lbxResultado);
            this.gbxResultado.Location = new System.Drawing.Point(348, 36);
            this.gbxResultado.Name = "gbxResultado";
            this.gbxResultado.Size = new System.Drawing.Size(340, 256);
            this.gbxResultado.TabIndex = 6;
            this.gbxResultado.TabStop = false;
            this.gbxResultado.Text = "Resultado de la busqueda";
            // 
            // gbxLogTexto
            // 
            this.gbxLogTexto.Controls.Add(this.txtLiga);
            this.gbxLogTexto.Controls.Add(this.rtbTextLog);
            this.gbxLogTexto.Location = new System.Drawing.Point(15, 410);
            this.gbxLogTexto.Name = "gbxLogTexto";
            this.gbxLogTexto.Size = new System.Drawing.Size(676, 256);
            this.gbxLogTexto.TabIndex = 7;
            this.gbxLogTexto.TabStop = false;
            this.gbxLogTexto.Text = "Leer Texto: ";
            // 
            // txtLiga
            // 
            this.txtLiga.Location = new System.Drawing.Point(9, 224);
            this.txtLiga.Name = "txtLiga";
            this.txtLiga.ReadOnly = true;
            this.txtLiga.Size = new System.Drawing.Size(661, 20);
            this.txtLiga.TabIndex = 11;
            this.txtLiga.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BuscarLog_KeyUp);
            // 
            // rtbTextLog
            // 
            this.rtbTextLog.ForeColor = System.Drawing.Color.Black;
            this.rtbTextLog.Location = new System.Drawing.Point(9, 21);
            this.rtbTextLog.Name = "rtbTextLog";
            this.rtbTextLog.ReadOnly = true;
            this.rtbTextLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtbTextLog.ShowSelectionMargin = true;
            this.rtbTextLog.Size = new System.Drawing.Size(661, 197);
            this.rtbTextLog.TabIndex = 0;
            this.rtbTextLog.Text = "";
            this.rtbTextLog.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BuscarLog_KeyUp);
            // 
            // pgrBarraBusqueda
            // 
            this.pgrBarraBusqueda.Location = new System.Drawing.Point(15, 331);
            this.pgrBarraBusqueda.Name = "pgrBarraBusqueda";
            this.pgrBarraBusqueda.Size = new System.Drawing.Size(571, 21);
            this.pgrBarraBusqueda.Step = 1;
            this.pgrBarraBusqueda.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Carpetas Encontradas: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArchivosRevisados
            // 
            this.lblArchivosRevisados.Location = new System.Drawing.Point(156, 305);
            this.lblArchivosRevisados.Name = "lblArchivosRevisados";
            this.lblArchivosRevisados.Size = new System.Drawing.Size(100, 21);
            this.lblArchivosRevisados.TabIndex = 10;
            this.lblArchivosRevisados.Text = "0";
            this.lblArchivosRevisados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(589, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 12;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnuRevisarLog
            // 
            this.mnuRevisarLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.mnuRevisarLog.Location = new System.Drawing.Point(0, 0);
            this.mnuRevisarLog.Name = "mnuRevisarLog";
            this.mnuRevisarLog.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuRevisarLog.Size = new System.Drawing.Size(697, 24);
            this.mnuRevisarLog.TabIndex = 13;
            this.mnuRevisarLog.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.salirToolStripMenuItem.Text = "Guardar Resultado";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extencionesToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // extencionesToolStripMenuItem
            // 
            this.extencionesToolStripMenuItem.Name = "extencionesToolStripMenuItem";
            this.extencionesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.extencionesToolStripMenuItem.Text = "Extenciones";
            this.extencionesToolStripMenuItem.Click += new System.EventHandler(this.extencionesToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblArchivoScaner
            // 
            this.lblArchivoScaner.ForeColor = System.Drawing.Color.Blue;
            this.lblArchivoScaner.Location = new System.Drawing.Point(21, 355);
            this.lblArchivoScaner.Name = "lblArchivoScaner";
            this.lblArchivoScaner.Size = new System.Drawing.Size(664, 52);
            this.lblArchivoScaner.TabIndex = 14;
            // 
            // BuscarLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(697, 682);
            this.Controls.Add(this.lblArchivoScaner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblArchivosRevisados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgrBarraBusqueda);
            this.Controls.Add(this.gbxLogTexto);
            this.Controls.Add(this.gbxResultado);
            this.Controls.Add(this.gbxParametros);
            this.Controls.Add(this.mnuRevisarLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuRevisarLog;
            this.MaximizeBox = false;
            this.Name = "BuscarLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Información dentro de Texto Plano";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BuscarLog_FormClosing);
            this.Load += new System.EventHandler(this.BuscarLog_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BuscarLog_KeyUp);
            this.gbxParametros.ResumeLayout(false);
            this.gbxParametros.PerformLayout();
            this.gbxResultado.ResumeLayout(false);
            this.gbxLogTexto.ResumeLayout(false);
            this.gbxLogTexto.PerformLayout();
            this.mnuRevisarLog.ResumeLayout(false);
            this.mnuRevisarLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button bttCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLiga;
        private System.Windows.Forms.Label lblArchivosRevisados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pgrBarraBusqueda;

        #endregion

        private System.Windows.Forms.Button bttBuscar;
        private System.Windows.Forms.ListBox lbxResultado;
        private System.Windows.Forms.TextBox txtRutaPrincipal;
        private System.Windows.Forms.TextBox txtpalabra;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.GroupBox gbxParametros;
        private System.Windows.Forms.Label lblPalabra;
        private System.Windows.Forms.GroupBox gbxResultado;
        private System.Windows.Forms.GroupBox gbxLogTexto;
        private System.Windows.Forms.RichTextBox rtbTextLog;
        private System.Windows.Forms.Button bttExaminar;
        private System.Windows.Forms.MenuStrip mnuRevisarLog;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extencionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.Label lblArchivoScaner;
        private System.Windows.Forms.Timer timer1;
    }
}

