﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DiseñoControles.Properties;
using Negocio.Lógica;

namespace DiseñoControles.Controles
{
    public partial class DropDownPro : Bunifu.Framework.UI.BunifuDropdown
    {
        Color idle, fore, colornormal;
        bool campoObligatorio = true;
        AccionesSistema As = new AccionesSistema();
        public bool CampoObligatorio
        {
            get
            {
                return campoObligatorio;
            }
            set
            {
                campoObligatorio = value;
                UpdateText();
            }
        }
        
        public DropDownPro()
        {
            InitializeComponent();
            UpdateText();
            idle = colornormal = Style.Normalcolor;
            fore = Style.Textcolor;
        }
        public void Normalize()
        {
            Style.Normalcolor = colornormal = idle;
            Style.Textcolor = fore;
        }
        public void Limpiar()
        {
            Normalize();
            selectedIndex = 0;
        }
        void UpdateText()
        {
            try
            {
                if (campoObligatorio)
                {
                    if (Items[0].Substring(Items[0].Length - 2, 1) != "*")
                        Items[0] += "*";
                }
                else if (Items[0].Substring(Items[0].Length - 2, 1) == "*")
                    Items[0] = Items[0].Substring(0, Items[0].Length - 1);
            }
            catch { }
        }
        public void Invalide()
        {

            Style.Normalcolor = colornormal = Color.Tomato;
            Style.Textcolor = Color.White; 
        }
        public void mostrarMensaje(string text)
        {
            Invalide();
            As.ShowToolTimInvaide(text, this);
        }
        public bool IsCorrect()
        {
            bool retorno = true;
            if (!campoObligatorio && selectedIndex <= 0)
                return true;
            if (campoObligatorio && selectedIndex <= 0)
            {
                mostrarMensaje("This field is required");
                return false;
            }
            return retorno;
        }
        private void nOnValueChanged(object sender, EventArgs e)
        {
            if (Style.Normalcolor == Color.Tomato || ForeColor == Color.White)
            {
                Normalize();
            }
        }
    }
}
