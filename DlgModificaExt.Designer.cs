namespace BuscarInfTxt
{
    partial class DlgModificaExt
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
        	this.gbxExtenciones = new System.Windows.Forms.GroupBox();
        	this.bttGuardarExt = new System.Windows.Forms.Button();
        	this.bttAgregar = new System.Windows.Forms.Button();
        	this.bttEliminar = new System.Windows.Forms.Button();
        	this.lstExtenciones = new System.Windows.Forms.CheckedListBox();
        	this.txtAddExtenciones = new System.Windows.Forms.TextBox();
        	this.gbxExtenciones.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// gbxExtenciones
        	// 
        	this.gbxExtenciones.Controls.Add(this.bttGuardarExt);
        	this.gbxExtenciones.Controls.Add(this.bttAgregar);
        	this.gbxExtenciones.Controls.Add(this.bttEliminar);
        	this.gbxExtenciones.Controls.Add(this.lstExtenciones);
        	this.gbxExtenciones.Controls.Add(this.txtAddExtenciones);
        	this.gbxExtenciones.Location = new System.Drawing.Point(12, 7);
        	this.gbxExtenciones.Name = "gbxExtenciones";
        	this.gbxExtenciones.Size = new System.Drawing.Size(257, 276);
        	this.gbxExtenciones.TabIndex = 0;
        	this.gbxExtenciones.TabStop = false;
        	this.gbxExtenciones.Text = "Agregar Extención:";
        	// 
        	// bttGuardarExt
        	// 
        	this.bttGuardarExt.Location = new System.Drawing.Point(155, 241);
        	this.bttGuardarExt.Name = "bttGuardarExt";
        	this.bttGuardarExt.Size = new System.Drawing.Size(95, 29);
        	this.bttGuardarExt.TabIndex = 4;
        	this.bttGuardarExt.Text = "&Guardar";
        	this.bttGuardarExt.UseVisualStyleBackColor = true;
        	this.bttGuardarExt.Click += new System.EventHandler(this.bttGuardarExt_Click);
        	// 
        	// bttAgregar
        	// 
        	this.bttAgregar.Location = new System.Drawing.Point(155, 42);
        	this.bttAgregar.Name = "bttAgregar";
        	this.bttAgregar.Size = new System.Drawing.Size(95, 29);
        	this.bttAgregar.TabIndex = 1;
        	this.bttAgregar.Text = "&Agregar";
        	this.bttAgregar.UseVisualStyleBackColor = true;
        	this.bttAgregar.Click += new System.EventHandler(this.bttAgregar_Click);
        	// 
        	// bttEliminar
        	// 
        	this.bttEliminar.Location = new System.Drawing.Point(54, 241);
        	this.bttEliminar.Name = "bttEliminar";
        	this.bttEliminar.Size = new System.Drawing.Size(95, 29);
        	this.bttEliminar.TabIndex = 3;
        	this.bttEliminar.Text = "&Eliminar";
        	this.bttEliminar.UseVisualStyleBackColor = true;
        	this.bttEliminar.Click += new System.EventHandler(this.bttEliminar_Click);
        	// 
        	// lstExtenciones
        	// 
        	this.lstExtenciones.FormattingEnabled = true;
        	this.lstExtenciones.Location = new System.Drawing.Point(6, 77);
        	this.lstExtenciones.Name = "lstExtenciones";
        	this.lstExtenciones.Size = new System.Drawing.Size(244, 154);
        	this.lstExtenciones.TabIndex = 2;
        	// 
        	// txtAddExtenciones
        	// 
        	this.txtAddExtenciones.Location = new System.Drawing.Point(5, 16);
        	this.txtAddExtenciones.Name = "txtAddExtenciones";
        	this.txtAddExtenciones.Size = new System.Drawing.Size(245, 20);
        	this.txtAddExtenciones.TabIndex = 0;
        	// 
        	// DlgModificaExt
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(281, 295);
        	this.Controls.Add(this.gbxExtenciones);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.MaximizeBox = false;
        	this.Name = "DlgModificaExt";
        	this.ShowIcon = false;
        	this.Text = "Mod. Extención";
        	this.gbxExtenciones.ResumeLayout(false);
        	this.gbxExtenciones.PerformLayout();
        	this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbxExtenciones;
        private System.Windows.Forms.TextBox txtAddExtenciones;
        private System.Windows.Forms.Button bttGuardarExt;
        private System.Windows.Forms.CheckedListBox lstExtenciones;
        private System.Windows.Forms.Button bttAgregar;
        private System.Windows.Forms.Button bttEliminar;
    }
}