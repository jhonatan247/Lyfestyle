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
using LifeStyle.Properties;
using BunifuAnimatorNS;
using Bunifu.Framework.UI;
using DiseñoControles.Controles;
using DevComponents.DotNetBar;
using DiseñoControles.Usuario;
#endregion

#region DiseñoControles
namespace LifeStyle
{
    #region Main
    public partial class frmMain : Form
    {
        #region Atributos
        private bool enabledTransitions;
        private Accion accionActual = Accion.Login;
        #endregion

        #region Propiedades
        public bool EnabledTransitions
        {
            get
            {
                return enabledTransitions;
            }
            set
            {
                enabledTransitions =
                header.EnabledTransitions = value;
            }
        }

        public Accion AccionActual
        {
            get
            {
                return accionActual;
            }
            set
            {
                accionActual = value;
                ActualizarTitulo();
            }
        }
        #endregion

        #region Constructores
        public frmMain()
        {
            InitializeComponent();
            EnabledTransitions = Settings.Default.enabledTransitions;
            ActualizarTitulo();
            Opacity = 0.7;
            Carga.Show();
            Carga.BringToFront();
            header.Show();
            tLoader.Start();
        }
        #endregion

        #region Métodos
        void OcultaTodos()
        {
            if (signUp1.Visible)
                signUp1.HideAll();
            foreach (Control c in pnlContMenu.Controls)
            {
                c.Hide();
            }
        }
        void ActualizarTitulo()
        {
            header.FormTitle = accionActual.ToString();
        }
        private void Animar()
        {
        }
        #endregion

        #region Eventos
        private void signUp1_Validated(object sender, EventArgs e)
        {
            
        }

        private void login1_AutoValidateChanged(object sender, EventArgs e)
        {
            
        }
        private void tLoader_Tick(object sender, EventArgs e)
        {
            tLoader.Stop();
            Animator.HideSync(Carga);
            Opacity = 1;
            panelMain1.Animar();
            Animator.ShowSync(pnlContMenu);
            MessageUser m_AlertOnLoad = new MessageUser("¡Welcome to Lifestyle!",
@"Sign in to continue.You do not have an account? Signing up will take less than a minute. 
Are you new to this? Visit our home page and get information.",
                "User Login", MessageLocation.BottomRight, MessageBtns.Ok);
            Focus();
        }
        #endregion

        private void panelMain1_SizeChanged(object sender, EventArgs e)
        {
            panel1.Width = panelMain1.Width;
        }

        private void panelMain1_LoginClick()
        {
            if (!login1.Visible)
            {
                panelMain1.SeleccionarBtn(0);
                OcultaTodos();
                Animator.ShowSync(login1);
                AccionActual = Accion.Login;
            }

            
        }

        private void panelMain1_SignUpClick()
        {
            if (!signUp1.Visible)
            {
                panelMain1.SeleccionarBtn(1);
                OcultaTodos();
                Animator.ShowSync(signUp1);
                signUp1.ShowBug();
                AccionActual = Accion.SignUp;
            }
        }

        private void login1_VisibleChanged(object sender, EventArgs e)
        {
            if (login1.Visible)
            {
                
            }
        }
        private void panelMain1_ToolsClick()
        {
            if (!tools1.Visible)
            {
                panelMain1.SeleccionarBtn(2);
                OcultaTodos();
                Animator.ShowSync(tools1);
                AccionActual = Accion.Tools;
            }
        }

        private void panelMain1_SettingsClick()
        {
            if (!userSettings1.Visible)
            {
                panelMain1.SeleccionarBtn(2);
                OcultaTodos();
                Animator.ShowSync(userSettings1);
                AccionActual = Accion.Tools;
            }
        }

        private void login1_GoToHomeClick()
        {
            header.GoToHome();
            
        }
    }
    #endregion

    #region Típos

    public enum Accion
    {
        
        Login,
        SignUp,
        Tools

    }
    #endregion
}
#endregion
#endregion