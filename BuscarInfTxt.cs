/*
 * Programador: Diego García.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Collections;
using BuscarInfTxt.Properties;
using System.Threading;
using Microsoft.Win32;

namespace BuscarInfTxt
{
    public partial class BuscarLog : Form
    {
        #region variables
        bool bTermino = false;
        bool bAbortarThread = false;

        int iTotalDirectorios = 0;
        int iCuentaCarpetas = 0;
        int icontaNombre = 0;
        int iIndiceBuffer;
        int itiempo = 0;
        int itiempoReal = 0;
        int nValor = 0;
        string sRutaIni = "";
        string sRutaScaner = "";

        ArrayList RutaIndices = new ArrayList();
        ArrayList AgregarArreglo = new ArrayList();
        ArrayList Extenciones = new ArrayList();
        string[] BufferTemp;
        string sExtencionesLimitados = "";
        Thread obtenercaller;
        Thread InstanceCaller;
        RegistryKey RegistroWindows;
        
        #endregion

        #region constructor
        public BuscarLog()
        {
            InitializeComponent();
            RegistroWindows = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\LinksSoft\Config\SearchExt");
            InstanceCaller = null;
            obtenerExtenciones();
            InstanceCaller = new Thread(new ThreadStart(busquedaHilo));
            obtenercaller = new Thread(new ThreadStart(obtenerDirectorios_hilo));	
        }

        private void inicializarProceso()
        {
            itiempo = 0;
            lblArchivosRevisados.Text = "0";
            iTotalDirectorios = 0;
            pgrBarraBusqueda.Value = 0;
            iCuentaCarpetas = 0;
            icontaNombre = 0;
			txtpalabra.Enabled = true;
	        bttBuscar.Enabled = true;
	        bttExaminar.Enabled = true;
	        txtRutaPrincipal.ReadOnly = false;
        }

        #endregion
                
        #region metodos personalizados
		
        private void obtenerDirectorios_hilo()
        {
        	obtenerTotalDirectorios(txtRutaPrincipal.Text.Replace('/', '\\'));
        }
               
        private void busquedaHilo()
        {
        	Buscar(txtRutaPrincipal.Text);
            bTermino = true; 
        }

        private void obtenerTotalDirectorios(string sRuta)
        {     
            if (!bAbortarThread)
            {
                if (!sRuta.ToString().ToUpper().Contains(".SVN"))
                {
                    if (Directory.Exists(sRuta))
                    {
                        try 
                        {
                            foreach (string sdirectorios in Directory.GetDirectories(sRuta))
                            {
                                if (!sdirectorios.ToString().ToUpper().Contains(".SVN"))
                                {
                                    iTotalDirectorios++;
                                    obtenerTotalDirectorios(sdirectorios);
                                }
                            }
                        }
                        catch{}
                    }
                }
            }
        }
        
        private void Buscar(string sDir)
		{
       
            if (!bAbortarThread)
            {
                if (!sDir.ToString().ToUpper().Contains(".SVN"))
                {
                    iCuentaCarpetas++;
                    try
                    {
                        if (Directory.Exists(sDir))
                        {
                            BuscarPalabra(Directory.GetFiles(sDir), txtpalabra.Text.ToUpper());

                            foreach (string sdirectorios in Directory.GetDirectories(sDir))
                            {
                                if (!sdirectorios.ToUpper().Contains(".SVN"))
                                {
                                    Buscar(sdirectorios);
                                }
                            }
                        }

                    }
                    catch{}
                }			
            }
        }
        
        public void BuscarPalabra(string[] sArchivo, string sTextoBusqueda)
        {
            string sMensaje = string.Empty;
            string[] Ruta;
            string sprograma = string.Empty;
            char[] cSeparador = {'\\'};
   
           
            for (int i = 0; i <= sArchivo.Length - 1; i++ )
            {
                GC.Collect();
                try
                {
                    if (esArchivoValido(sArchivo[i]))	
                	{
                        sRutaScaner = sArchivo[i].ToString();
                		StreamReader Sr = new StreamReader(sArchivo[i].ToString());
                       Ruta = sArchivo[i].ToString().Split('\\', '\\');
                       
                        if (Ruta.Length > 0 ) sprograma = Ruta[Ruta.Length - 1].ToString();
                       else sprograma = "";
                      
                       sMensaje = Sr.ReadToEnd();
                        Sr.Close();
                        if (sMensaje.ToUpper().Contains(sTextoBusqueda.ToUpper()) ||
                            sprograma.ToUpper().Contains(sTextoBusqueda.ToUpper()))
                        {
                            AgregarArreglo.Add(sprograma);
                            RutaIndices.Add(sArchivo[i].ToString());
                            icontaNombre++;
                        }			
                	}
					else
					{	
						sMensaje = string.Empty;
					}
                }
                catch//(Exception ex)
                {
                    //MessageBox.Show("sArchivo: -" + sArchivo[i] + " - " + ex.Message);
                }
            }
        }

        private string[] RutaArchivos
        {
            get { return BufferTemp; }
            set 
            {
                BufferTemp = value;
            }
        }

        private int IndiceBuffer 
        {
            get { return iIndiceBuffer; }
            set 
            { 
                if(value >= 0)
                {
                    iIndiceBuffer = value;
                }
            }
        }

        string msFromTicks(int iTicks)
        {
        	TimeSpan ts = new TimeSpan((long)iTicks);
        	return ts.TotalSeconds.ToString() +":"+ts.TotalMilliseconds.ToString();
        }

        private void examinarCarpetas()
        {
            FolderBrowserDialog BuscarRuta = new FolderBrowserDialog();
            if (txtRutaPrincipal.Text.Length > 0)
            {
                BuscarRuta.SelectedPath = txtRutaPrincipal.Text;
            }
            if (BuscarRuta.ShowDialog() == DialogResult.OK)
            {
                txtRutaPrincipal.Text = BuscarRuta.SelectedPath;
            } 
        }

        private bool esArchivoValido(string sArchivo)
        {
            bool bArchivoValido = false;
            string sExtencionArchivo = "";

            if(sArchivo.Contains("."))
            {
                sExtencionArchivo = sArchivo.Substring(sArchivo.LastIndexOf(".") + 1, sArchivo.Length - (sArchivo.LastIndexOf(".") + 1));
                if (sExtencionesLimitados.Contains(sExtencionArchivo) )
                {
                    bArchivoValido = true;
                }
            }
            else if( sArchivo.ToUpper().Contains("MAKEFILE") ) 
            {
            	bArchivoValido = true;
            }

            return bArchivoValido;
        }

        private void obtenerExtenciones()
        {
            Extenciones.Clear();
            sExtencionesLimitados = "";
            foreach (string sExtenciones in RegistroWindows.GetValueNames())
            {                
                if (sExtenciones.Contains("*."))
                {
                    if (Convert.ToInt16(RegistroWindows.GetValue(sExtenciones)) == 1)
                    {
                        Extenciones.Add(sExtenciones.Replace("*.", ""));
                        sExtencionesLimitados += sExtenciones.Replace("*.", "")+"|";
                    }
                }              
            }
            
            sExtencionesLimitados+="makefile|";
        }

        private void guardarBusqueda()
        {
            int ilinea = 0;
            string smensaje = string.Empty;
            StreamReader Sr;
            StreamWriter Sw;
            StringBuilder StrBuild = new StringBuilder();

            if (RutaIndices.Count > 0)
            {
                 StrBuild.AppendFormat("RESULTADO DE LA BUSQUEDA DE: [\"{0}\"]\n\n", txtpalabra.Text);
                
                for (int i = 0; i < RutaIndices.Count; i++)
                {
                    ilinea = 0;
                    Sr = new StreamReader(RutaIndices[i].ToString());
                    if (File.Exists(RutaIndices[i].ToString()))
                    {
                        StrBuild.AppendFormat("-\n".PadLeft(100, '-'));
                        StrBuild.AppendFormat("*{0}\n\n",RutaIndices[i].ToString());
                        while (!Sr.EndOfStream)
                        {
                            ilinea++;
                            smensaje = Sr.ReadLine();
                            if (smensaje.ToUpper().Contains(txtpalabra.Text.ToUpper()))
                            {
                                StrBuild.Append("    (" + ilinea + ").-   " + smensaje + "\n\n");                                
                            }
                        }
                    }
                    Sr.Close();
                }

                SaveFileDialog GuardarArchivo = new SaveFileDialog();
                GuardarArchivo.Title = "Guardar Resultado de la Busqueda Recursiva.";
                GuardarArchivo.Filter = "Documento de Texto|*.txt";
                DialogResult dlg = GuardarArchivo.ShowDialog();                
                
                if (dlg == DialogResult.OK)
                {
                    Sw = new StreamWriter(GuardarArchivo.FileName);
                    Sw.Write(StrBuild.ToString());
                    Sw.Close();
                }
            }
        }

        private void PresionoTeclado(Keys key)
        {
            if (key == Keys.F5)
            {
            	if(bttBuscar.Enabled && txtRutaPrincipal.Text.Trim() != "")
            	{
            		bttBuscar_Click(null, null);
            	}
                
            }
            else if (key == Keys.F3)
            {
            	if(bttCancelar.Enabled)
            	{
	                BttCancelarClick(null, null);
            	}
            }
        }

        #endregion
        
        #region eventos de la aplicación
                
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbouSearchInfTxt dlgAbout = new AbouSearchInfTxt();
            dlgAbout.ShowDialog();
        }

        private void lbxResultado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iCont = 0;
            string smensaje = string.Empty;
            int ilinea = 0;

            if (lbxResultado.SelectedItem != null)
            {
                if (RutaIndices != null && lbxResultado.SelectedItem.ToString() != "")
                {
                    if (File.Exists(RutaIndices[lbxResultado.SelectedIndex].ToString()))
                    {
                        IndiceBuffer = iCont;
                        txtLiga.Text = RutaIndices[lbxResultado.SelectedIndex].ToString();
                    }

                    iCont++;
                }

                rtbTextLog.Clear();

                StreamReader Sr = new StreamReader(RutaIndices[lbxResultado.SelectedIndex].ToString());
                while (!Sr.EndOfStream)
                {
                    ilinea++;
                    smensaje = Sr.ReadLine();
                    if (smensaje.ToUpper().Contains(txtpalabra.Text.ToUpper()))
                    {
                        rtbTextLog.AppendText("(" + ilinea + ").-   " + smensaje + "\n");
                        rtbTextLog.AppendText("\n");
                    }
                }
                Sr.Close();

                rtbTextLog.AppendText("\n\nTotal de Filas: " + ilinea);
            }
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Close();
        }

        private void BuscarLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            BttCancelarClick(null, null);
        }
        
        private void BuscarLog_KeyUp(object sender, KeyEventArgs e)
        	
        {
            PresionoTeclado(e.KeyCode);
        }
       
        private void bttBuscar_Click(object sender, EventArgs e)
        {
            string sRuta = "";
            inicializarProceso();
            bTermino = false;
            bAbortarThread = false;
            txtLiga.Text = "";
            txtpalabra.Enabled = false;
            bttBuscar.Enabled = false;
            bttExaminar.Enabled = false;
            txtRutaPrincipal.ReadOnly = true;
            
            sRuta = txtRutaPrincipal.Text.Replace('/', '\\');
            sRutaIni = sRuta;

            if (Directory.Exists(sRuta))
            {
                AgregarArreglo = new ArrayList();
                RutaIndices = new ArrayList();
                timer1.Start();
                rtbTextLog.Clear();
                
                obtenercaller = new Thread(new ThreadStart(obtenerDirectorios_hilo));
                InstanceCaller = new Thread(new ThreadStart(busquedaHilo));
                
                InstanceCaller.Priority = ThreadPriority.Highest;
                obtenercaller.Priority = ThreadPriority.Highest;

                obtenercaller.SetApartmentState(ApartmentState.STA);
                InstanceCaller.SetApartmentState(ApartmentState.STA);                

                lbxResultado.Items.Clear();
                obtenercaller.Start();
            	InstanceCaller.Start(); 
            }
        }
        
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
           int iCont = 0;
           string smensaje = string.Empty;
           int ilinea = 0;
        
           if(lbxResultado.SelectedItem != null)
           {
	           	if (RutaIndices != null && lbxResultado.SelectedItem.ToString() != "")
	            {
                	if (File.Exists(RutaIndices[lbxResultado.SelectedIndex].ToString()))
                    {
                        IndiceBuffer = iCont;
                        txtLiga.Text = RutaIndices[lbxResultado.SelectedIndex].ToString();
                    }

                    iCont++;
	            }
	
	           rtbTextLog.Clear();
	
	           StreamReader Sr = new StreamReader(RutaIndices[lbxResultado.SelectedIndex].ToString());
	          while (!Sr.EndOfStream)
	           {
	               ilinea++;
	               smensaje = Sr.ReadLine();
	               if (smensaje.ToUpper().Contains(txtpalabra.Text.ToUpper()))
	               {
	                   rtbTextLog.AppendText("(" + ilinea + ").-   " + smensaje + "\n");
	                   rtbTextLog.AppendText("\n");
	               }
	           }
              Sr.Close();
	           rtbTextLog.AppendText("\n\nTotal de Filas: " + ilinea);
           }
        }

        private void txtRutaPrincipal_DoubleClick(object sender, EventArgs e)
        {
            examinarCarpetas();
        }

        private void lblRutaTexto_DoubleClick(object sender, EventArgs e)
        {
            if (lbxResultado.SelectedIndex > 0)
            {
                Process.Start(RutaIndices[IndiceBuffer].ToString());
            }
        }

        private void lblRutaTexto_MouseHover(object sender, EventArgs e)
        {
           // lblRutaTexto.ForeColor = Color.SteelBlue;
        }

        private void lblRutaTexto_MouseLeave(object sender, EventArgs e)
        {
           // lblRutaTexto.ForeColor = Color.Red;
        }

		void Timer1Tick(object sender, EventArgs e)
        {
            itiempo += 10;
            itiempo++;

            itiempoReal++;
            if(itiempoReal > 99)
            {
                itiempoReal = 0;
            }

            label3.Text = "(" + TimeSpan.FromMilliseconds(itiempo).Hours.ToString().PadLeft(2, '0') + ":" + 
                TimeSpan.FromMilliseconds(itiempo).Minutes.ToString().PadLeft(2, '0') + ":" 
                + TimeSpan.FromMilliseconds(itiempo).Seconds.ToString().PadLeft(2, '0') + ":" 
                + itiempoReal.ToString().PadLeft(2, '0') + "" + ")";

        	//if(bObtenerCarpetas)
        	{
                lblArchivosRevisados.Text =  iTotalDirectorios.ToString();
                 lblArchivoScaner.Text = sRutaScaner;
        	}
        	
        	if(iCuentaCarpetas > 0)
        	{
                try 
                {
                    nValor = (iCuentaCarpetas * 100) / (iTotalDirectorios + 1);
                    if (nValor <= 100)
                    {
                        pgrBarraBusqueda.Value = nValor;
                    }
                    else 
                    {
                        nValor = pgrBarraBusqueda.Value;
                    }
                    
                }
        		catch//(Exception ex)
                {
                   // MessageBox.Show(ex.Message);
                }
        	}
        	
    		if(bTermino)
        	{
                GC.Collect();
                inicializarProceso();
                
        		if(AgregarArreglo.Count > 0)
        		{
        			foreach(string stexto in AgregarArreglo)
        			{
        				lbxResultado.Items.Add(stexto);
        				
        			}
        		}
        		timer1.Stop();
        	}    	
        }
        
		void BttCancelarClick(object sender, EventArgs e)
        {
            bTermino = true;
            bAbortarThread = true;
        }

        private void BuscarLog_Load(object sender, EventArgs e)
        {
          
        }

        private void extencionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!InstanceCaller.IsAlive)
            {
                DlgModificaExt dlgExtenciones = new DlgModificaExt();
                dlgExtenciones.ShowDialog();
                obtenerExtenciones();
            }
            else
            {
                MessageBox.Show("No es posible modificar las extenciones, mientras se realice una consulta.");
            }
        }

        private void bttExaminar_Click(object sender, EventArgs e)
        {
            examinarCarpetas();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!InstanceCaller.IsAlive)
            {
                guardarBusqueda();
            }
            else 
            {
                MessageBox.Show("Aun se está realizando la consulta, favor de esperar a que termine.");
            }
        }
        #endregion
        
	}
}