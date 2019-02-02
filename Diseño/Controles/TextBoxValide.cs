using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Net.Mail;
using DiseñoControles.Properties;
using Negocio.Lógica;

namespace DiseñoControles.Controles
{
    public partial class TextBoxValide : Bunifu.Framework.UI.BunifuMetroTextbox
    {

        Color idle, fore, Colornormal, Colorfocused, Colorhove;
        uint maxLength = 2000;
        uint minimLength = 0;
        ValidatingType validacion = ValidatingType.Ninguna;
        bool permEspacios = true, campoObligatorio = true, underline = true, focused=false;
        TextBoxValide textBoxCompare = null;
        string textCompare = "";
        string obligatory = "*", overText = "OverText";
        AccionesSistema As = new AccionesSistema();

        #region Delegados
        public delegate void UserGoDelegate(object sender, EventArgs e);
        #endregion
        #region Eventos
        public event UserGoDelegate UserGo;
        #endregion
        public string TextCompare
        {
            get
            {
                return textCompare;
            }
            set
            {
                textCompare = value;
            }
        }
        public bool Underline
        {
            get
            {
                return underline;
            }
            set
            {
                underline = value;
                if (!underline)
                {
                    pnlUnderline1.Visible = pnlUnderline2.Visible = pnlUnderline3.Visible = false;
                }
                else
                    pnlUnderline1.Visible = pnlUnderline2.Visible = pnlUnderline3.Visible = true;
            }
        }
        public TextBoxValide TextBoxCompare
        {
            get
            {
                return textBoxCompare;
            }
            set
            {
                textBoxCompare = value;
            }
        }
        public bool CampoObligatorio
        {
            get
            {
                return campoObligatorio;
            }
            set
            {
                campoObligatorio = value;
                if (campoObligatorio)
                {
                    obligatory = "*";
                }
                else
                    obligatory = "";
                UpdateOver();
            }       
        }
        public bool PermEspacios
        {
            get
            {
                return permEspacios;
            }
            set
            {
                permEspacios = value;
            }
        }
        public ValidatingType Validacion
        {
            get
            {
                return validacion;
            }
            set
            {
                if(value == ValidatingType.CompararConTextBox && textBoxCompare == null)
                {
                    MessageBox.Show("Ingrese un TextBox para comparar");
                }
                validacion = value;
            }
        }
        public string OverText
        {
            get
            {
                return overText;
            }
            set
            {
                overText = value;
                
                if (value == "")
                {
                    lbOver.Hide();
                }
                else
                    lbOver.Show();
                UpdateOver();
            }
        }
        public uint MaxLength
        {
            get
            {
                return maxLength;
            }
            set
            {
                maxLength = value;
            }
        }
        public uint MinimLengtth
        {
            get
            {
                return minimLength;
            }
            set
            {
                minimLength = value;
            }
        }
        public TextBoxValide()
        {
            InitializeComponent();
            idle= Colornormal = BorderColorIdle;
            Colorhove = BorderColorMouseHover;
            Colorfocused = BorderColorFocused;
            fore = ForeColor;
        }
        public void Limpiar()
        {
            Text = "";
            Normalize();
        }
        void UpdateOver()
        {
            lbOver.Text = OverText + obligatory;
        }
        public void Normalize()
        {
            BorderColorIdle = Colornormal = idle;
            lbOver.ForeColor = ForeColor = fore;
        }
        public void Invalide()
        {
            BorderColorIdle = Colornormal =
            lbOver.ForeColor = ForeColor = Color.Tomato;
        }

        private void pnlUnderline3_MouseHover(object sender, EventArgs e)
        {
            if(!focused)
                BorderColorFocused = BorderColorIdle = BorderColorMouseHover = Colorhove;
        }

        private void lbOver_MouseMove(object sender, MouseEventArgs e)
        {
            if (!focused)
                BorderColorFocused = BorderColorIdle = BorderColorMouseHover = Colorhove;
        }

        private void TextBoxValide_Enter(object sender, EventArgs e)
        {
            BorderColorFocused = BorderColorIdle = BorderColorMouseHover = Colorfocused;
            focused = true;
        }

        private void pnlUnderline3_MouseLeave(object sender, EventArgs e)
        {
            if (!focused)
                BorderColorFocused = BorderColorIdle = BorderColorMouseHover = Colornormal;
        }

        private void TextBoxValide_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                UserGo(this, new EventArgs());
        }

        public void mostrarMensaje( string text){
            Invalide();
            As.ShowToolTimInvaide(text, this);
        }
        bool ValidarCorreo()
        {
            try
            {
                MailAddress MS = new MailAddress(Text);
                return true;
            }
            catch
            {
                return false;
            }
        }
        bool ValidarLetras()
        {
            foreach (char c in Text)
            {
                if (!char.IsLetter(c) && !char.IsControl(c) && c != ' ')
                {
                    return false; 
                }
            }
            return true;
        }
        public bool IsCorrect()
        {
            if (!campoObligatorio && Text.Trim() == "")
                return true;
            if (campoObligatorio && Text.Trim() == "")
            {
                mostrarMensaje("This field is required");
                return false;
            }

            if (Text.Length >= minimLength && Text.Length <= maxLength 
                || validacion == ValidatingType.CompararConTextBox 
                || validacion == ValidatingType.CompararTexto)
            {
                bool retorno = true;
                switch (validacion)
                {
                    case ValidatingType.CompararConTextBox:
                        if (textBoxCompare.Text != Text)
                        {
                            mostrarMensaje("The values ​​do not match");
                            retorno= false;
                        }
                        break;
                    case ValidatingType.CompararTexto:
                        if (textCompare != Text)
                        {
                            mostrarMensaje("The value entered is not correct, please check and try again");
                            retorno = false;
                        }
                        break;
                    case ValidatingType.Correo:
                        retorno = ValidarCorreo();
                        if (!retorno)
                            mostrarMensaje("The value you entered is not a valid email");
                        break;
                    case ValidatingType.Letras:
                        retorno = ValidarLetras();
                        if (!retorno)
                            mostrarMensaje("This field accepts only letters");
                        break;
                    case ValidatingType.User:
                        retorno = ValidarLetras() && !ValidarCorreo();
                        if (!retorno)
                            mostrarMensaje("The value entered is incorrect");
                        break;
                    case ValidatingType.NumeroDecimal:
                        try
                        {
                            Convert.ToDouble(Text);
                        }
                        catch
                        {
                            mostrarMensaje("The value entered is incorrect");
                            retorno = false;
                        }
                        break;
                    case ValidatingType.NumeroDecimalPositivo:
                    case ValidatingType.Moneda:
                        try
                        {
                            Text = (Convert.ToDouble(Text)<0? -Convert.ToDouble(Text): Convert.ToDouble(Text)).ToString();
                        }
                        catch
                        {
                            mostrarMensaje("The value entered is incorrect");
                            retorno = false;
                        }
                        break;
                    case ValidatingType.NumeroEntero:
                        try
                        {
                            Convert.ToInt64(Text);
                        }
                        catch
                        {
                            mostrarMensaje("The value entered is incorrect");
                            retorno = false;
                        }
                        break;
                    case ValidatingType.NumeroEnteroPositivo:
                        try
                        {
                            Text = Convert.ToUInt64(Text).ToString();
                        }
                        catch
                        {
                            mostrarMensaje("The value entered is incorrect");
                            retorno = false;
                        }
                        break;
                    case ValidatingType.TelefonoFijo:
                        if (Text.Length == 7)
                        {
                            try
                            {
                                Convert.ToInt64(Text);
                            }
                            catch
                            {
                                retorno = false;
                            }
                        }
                        else retorno = false;
                        if(!retorno)
                                mostrarMensaje("The value entered is incorrect");
                        break;
                    case ValidatingType.TelefonoMovil:
                        if (Text.Length == 10)
                        {
                            try
                            {
                                Convert.ToInt64(Text);
                            }
                            catch
                            {
                                retorno = false;
                            }
                        }
                        else retorno = false;
                        if (!retorno)
                            mostrarMensaje("The value entered is incorrect");
                        break;
                    case ValidatingType.Hora:
                        if (Text.Length == 5)
                        {
                            try
                            {
                                short h = Convert.ToInt16(Text.Substring(0, 2));
                                short m = Convert.ToInt16(Text.Substring(3, 2));
                                if (h <= 23 && h >= 0 && m <= 59 && m >= 0)
                                {
                                    TimeSpan Dt = new TimeSpan(h, m, 00);
                                }
                                else
                                    retorno = false;
                            }
                            catch
                            {
                                retorno = false;
                            }
                        }
                        else
                        {
                            retorno = false;
                        }
                        if(!retorno)
                            mostrarMensaje("The value entered is not an hour in hh: mm format");
                        break;
                }
                return retorno;
            }
            mostrarMensaje("Field must be between " + minimLength + " and " + maxLength + " characters");
            return false;
        }
        string QuitarEspacios(string text)
        {
            string retorno = "";
            foreach(char c in text)
            {
                if(c!=' ')
                {
                    retorno += c;
                }
            }
            return retorno;
        }
        private void nClick(object sender, EventArgs e)
        {
            lbOver.Hide();
            Focus();
        }

        private void TextBoxXD_Leave(object sender, EventArgs e)
        {
            focused = false;
            BorderColorFocused = BorderColorIdle = BorderColorMouseHover = Colornormal;
            if (Text == "")
            {
                lbOver.Show();
            }
        }

        private void nOnValueChanged(object sender, EventArgs e)
        {
            BorderColorFocused = BorderColorIdle = BorderColorMouseHover = Colorfocused;
            focused = true;
            if (!permEspacios)
            {
                string sinSp = QuitarEspacios(Text);
                if (sinSp != Text)
                {
                    Text = sinSp;
                    Focus();
                }
            }
            if (Text == "")
            {
                lbOver.Mostrar();
            }
            else
                lbOver.Ocultar();
            
            if ( BorderColorIdle == Color.Tomato || ForeColor == Color.Tomato )
            {
                Normalize();
            }
        }
    }
    public enum ValidatingType
    {
        Ninguna,
        NumeroDecimal,
        NumeroEntero,
        NumeroDecimalPositivo,
        NumeroEnteroPositivo,
        Letras,
        User,
        Correo,
        TelefonoMovil,
        TelefonoFijo,
        Moneda,
        Hora,
        CompararConTextBox,
        CompararTexto
    };
}
