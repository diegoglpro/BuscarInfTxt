using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace BuscarInfTxt
{
    public partial class DlgModificaExt : Form
    {
        RegistryKey RegistroWindows;

        public DlgModificaExt()
        {
            InitializeComponent();
            RegistroWindows = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\LinksSoft\Config\SearchExt");
            obtenerTipoArchiosBusqueda();
        }

        private void bttGuardarExt_Click(object sender, EventArgs e)
        {
            guardarArchivosBusqueda();
            this.Close();
        }

        private void obtenerTipoArchiosBusqueda()
        {
            int iContador = 0;
            bool bChecked = false;

            foreach (string sExtencion in RegistroWindows.GetValueNames())
            {
                bChecked = false;
                if (sExtencion.IndexOf("*.") >= 0)
                {
                    lstExtenciones.Items.Add(sExtencion);
                    if (int.Parse(RegistroWindows.GetValue(sExtencion).ToString()) > 0)
                    {
                        bChecked = true;
                    }
                   lstExtenciones.SetItemChecked(iContador, bChecked);
                    iContador++;
                 }
            }
        }

        /// <summary>
        /// Guarda los cambios de formato en el registro
        /// </summary>
        private void guardarArchivosBusqueda()
        {
            int iChecked = 0, iContador = 0;
            foreach(string sItem in lstExtenciones.Items )
            {
                iChecked = 0;
                if (lstExtenciones.GetItemChecked(iContador))
                {
                    iChecked = 1;
                }

                RegistroWindows.SetValue(sItem, iChecked);
                iContador++;
            }

            MessageBox.Show("La lista de busqueda ha sido actualizada satisfactorimanete.","Lista de Formatos",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }

        private void bttAgregar_Click(object sender, EventArgs e)
        {
            string sExt = "";
            
            sExt = txtAddExtenciones.Text;
            sExt = sExt.Replace(".","");
            sExt = sExt.Replace("*","");
            
            if (soloAlfaNumericos(sExt))
            {
               // sExt = txtAddExtenciones.Text;
                if (agregarExtencion(ref sExt))
                {
                    lstExtenciones.Items.Add(sExt,true);
                    txtAddExtenciones.Text = "";
                    bttGuardarExt.Focus();

                }
                else 
                {
                    MessageBox.Show("La extención que se quiere agregar ya existe.");
                }
            }
            else 
            {
                MessageBox.Show("no es una extención valida.");
            }
        }

        private bool agregarExtencion(ref string sExtencion)
        {
            bool bRegresa = false, bencontro = false;
            
            if (!sExtencion.StartsWith("*."))
            {
                sExtencion = string.Format("*.{0}",sExtencion);
            }
            
            foreach(string sExt in lstExtenciones.Items)
            {
                if (sExtencion.Trim().ToUpper() == sExt.ToUpper().Trim())
                {
                    bencontro = true;
                    break;
                }
            }

            if(!bencontro)
            {
                bRegresa = true;
            }

            return bRegresa;

        }

        private bool soloAlfaNumericos(string sExtencion)
        {
            bool bAlfanumerico = false;
            char[] trim = {'*','.'};

            char[] VALIDOS = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
                                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
                                'K','L','M','N','Ñ','O','P','Q','R','S','T','U','V',
                                'W','X','Y','Z'};

            /*if (sExtencion.StartsWith("*."))
            {
                sExtencion = sExtencion.Remove(0, 2);
            }*/
            
            sExtencion = sExtencion.Trim().ToUpper();

            for (int i = 0; i < sExtencion.Length; i++ )
            {
                bAlfanumerico = false;
                foreach (char cLetra in VALIDOS)
                {
                    if (sExtencion[i] == cLetra)
                    {
                        bAlfanumerico = true;
                    }
                }

                if(!bAlfanumerico)
                {
                    break;
                }
            }

            return bAlfanumerico;            
        }

        private void bttEliminar_Click(object sender, EventArgs e)
        {
            if (lstExtenciones.SelectedIndex >= 0)
            {
                foreach(string sExt in RegistroWindows.GetValueNames())
                {
                    if (sExt.Trim() == lstExtenciones.SelectedItem.ToString().Trim())
                    {
                        RegistroWindows.DeleteValue(lstExtenciones.SelectedItem.ToString());
                        break;
                    }
                }
                
                lstExtenciones.Items.RemoveAt(lstExtenciones.SelectedIndex);
            }            
        }
    }
}

