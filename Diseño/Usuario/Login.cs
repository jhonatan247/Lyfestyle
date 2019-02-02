#region Lifestyle Coyright 2017
#region Librerías
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using DiseñoControles.Properties;
using BunifuAnimatorNS;
using Bunifu.Framework.UI;
using Negocio.Manejo_de_datos;
using Negocio.Lógica;
using DiseñoControles.Controles;
#endregion

#region DiseñoControles
namespace DiseñoControles.Usuario
{
    #region Login
    public partial class Login : UserControl
    {
        #region Atributos
        DataRow Drow;
        AccionesSistema As = new AccionesSistema();
        #endregion

        #region Delegados
        public delegate void SignUpClickDelegate();
        public delegate void GoToHomeClickDelegate();
        public delegate void ForgotUserClickDelegate();
        #endregion

        #region Eventos
        public event SignUpClickDelegate SignUpClick;
        public event GoToHomeClickDelegate GoToHomeClick;
        public event ForgotUserClickDelegate ForgotUserClick;
        #endregion

        #region Propiedades
        #endregion

        #region Constructores
        public Login()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos
        #endregion

        #region ControlEventos
        private void UserControl1_Load(object sender, EventArgs e)
        {
        }

        private void bnContinue_Click(object sender, EventArgs e)
        {
            if (txUsuario.IsCorrect())
            {
                try
                {
                    Drow = new CRUD_Usuario(txUsuario.Text).autentificar_nombre_usuario().Rows[0];
                    if (Convert.ToBoolean(Drow[0]))
                    {
                        if(Drow[1].ToString() != "")
                            As.CropImage(As.ObtenerImagen(Drow[1]), pbPicture);
                        Animator.HideSync(pnlUser);
                        Animator.ShowSync(pnlPassword);
                        return;
                    }
                }
                catch{ }
                txUsuario.mostrarMensaje("Username is incorrect");
            }
        }
        #endregion

        private void bnBack_Click(object sender, EventArgs e)
        {
            Animator.HideSync(pnlPassword);
            txContraseña.Limpiar();
            Animator.ShowSync(pnlUser);
        }

        private void bnSignIn_Click(object sender, EventArgs e)
        {
            if (txContraseña.IsCorrect())
            {
                try
                {
                    Drow = new CRUD_Usuario().Autentificar(txUsuario.Text, txContraseña.Text).Rows[0];
                    if (Drow[4].ToString() == txUsuario.Text && Drow[5].ToString() == txContraseña.Text)
                    {
                        FormsEnglish.HomeUser fHom = new FormsEnglish.HomeUser(Drow);
                        As.GetFormParent(this).Hide();
                        fHom.ShowDialog();
                        As.GetFormParent(this).Show();
                        return;
                    }
                }
                catch{ }
                txContraseña.mostrarMensaje("Password is incorrect");
            }
        }

        private void Login_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
            {
                pnlPassword.Hide();
                txContraseña.Limpiar();
                txUsuario.Limpiar();
                pnlUser.Show();
            }
        }

        private void toolStripMenuItemPro1_Click(object sender, EventArgs e)
        {
           if( new InputPro("Document number", ValidatingType.NumeroEnteroPositivo, 5, 20).ShowInput() != "")
           {

           }
        }

        private void toolStripMenuItemPro3_Click(object sender, EventArgs e)
        {
            SignUpClick();
        }

        private void toolStripMenuItemPro4_Click(object sender, EventArgs e)
        {
            GoToHomeClick();
        }
    }
    #endregion
}
#endregion
#endregion
