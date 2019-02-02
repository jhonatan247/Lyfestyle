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
#endregion

#region DiseñoControles
namespace DiseñoControles.Usuario
{
    #region PanelMain
    public partial class PanelMain : UserControl
    {
        #region Atributos
        bool VisibleMenu = false;
        private bool first = true, second = false, spleet = false;
        #endregion

        #region Delegados
        public delegate void LoginClickDelegate();
        public delegate void SignUpClickDelegate();
        public delegate void ToolsClickDelegate();
        public delegate void SettingsClickDelegate();
        public delegate void MoreOptionsClickDelegate();
        #endregion

        #region Eventos
        public event LoginClickDelegate LoginClick;
        public event SignUpClickDelegate SignUpClick;
        public event ToolsClickDelegate ToolsClick;
        public event SettingsClickDelegate SettingsClick;
        public event MoreOptionsClickDelegate MoreOptionsClick;
        #endregion

        #region Propiedades
        public Form FormParent { get; set; }
        /// <summary>
        /// Valor entre 0 y 1
        /// </summary>
        public float TimeStepAnimation
        {
            get
            {
                return Animator.TimeStep;
            }
            set
            {
                Animator.TimeStep = value;
            }
        }
        #endregion

        #region Constructores
        public PanelMain()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos
        public void ChangeBnVisible(bool value)
        {
            bnOpciones.Visible = value;
        }
        public void SeleccionarBtn(int index)
        {
            int i = 4;
            foreach(BunifuFlatButton bn in panelMainMenu1.Controls.OfType<BunifuFlatButton>())
            {
                if (i == index)
                {
                    bn.selected = true;
                }
                else
                    bn.selected = false;
                i--;
            }
        }
        public void OcultarBtn()
        {
            foreach (BunifuFlatButton sender in panelMainMenu1.Controls.OfType<BunifuFlatButton>())
            {
                sender.Hide();
            }
        }
        public void MostrarBtn()
        {
            foreach (BunifuFlatButton sender in panelMainMenu1.Controls.OfType<BunifuFlatButton>())
            {
                sender.Show();
            }

            if (!second)
                bnLogin.selected = second = true;
        }
        private void AnimLogo()
        {
            Animator.TimeStep -= 0.01f;
            lbLogo.Hide();
            Animator.AnimationType = AnimationType.Particles;
            Animator.ShowSync(lbLogo);
            Animator.TimeStep += 0.01f;
        }
        public void Animar()
        {
            bnOpciones.Enabled = false;
            pnFondo.Show();
            if (first)
            {
                AnimLogo();
                Animator.AnimationType = AnimationType.Leaf;
                Animator.ShowSync(lbMensaje1);
                Animator.ShowSync(lbSocialMedia);
                Animator.ShowSync(bnFacebook);
                Animator.ShowSync(bnTwitter);
                first = false;
            }
            else
            {
                lbLogo.Hide();
                Animator.AnimationType = AnimationType.HorizSlide;
                Animator.HideSync(this);
                if (VisibleMenu)
                {
                    panelMainMenu1.Hide();
                    panelMainContenido1.Show();
                    toolMensaje.SetToolTip(bnOpciones, "Options");
                    bnOpciones.Image = Resources.Menu_24px;
                }
                else
                {
                    panelMainContenido1.Hide();
                    panelMainMenu1.Show();
                    toolMensaje.SetToolTip(bnOpciones, "To return");
                    bnOpciones.Image = Resources.Return_24px;
                }

                Animator.ShowSync(this);
                VisibleMenu = !VisibleMenu;
                lbLogo.Show();
                if (!second)
                    bnLogin.selected = second= true;
            }
            bnOpciones.Enabled = true;
        }
        #endregion
        #region ControlEventos
        private void bnFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("www.facebook.com");
        }

        private void bnTwiter_Click(object sender, EventArgs e)
        {
            Process.Start("www.twitter.com");
        }

        private void bnLogin_Click(object sender, EventArgs e)
        {
            LoginClick();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            SignUpClick();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ToolsClick();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            SettingsClick();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            //MoreOptionsClick();
        }

        private void bnOpciones_Click(object sender, EventArgs e)
        {
            Animar();
        }
        #endregion

        private void bnSplit_Click(object sender, EventArgs e)
        {

            Animator.AnimationType = AnimationType.HorizSlide;
            OcultarBtn();
            if (!spleet)
            {
                toolMensaje.SetToolTip(bnSplit, "Show more");
                bnOpciones.Hide();
                bunifuSeparator1.Hide();
                panelMainContenido1.Hide();
                panelMainMenu1.Show();
                VisibleMenu = true;
                
                lbLogo.Hide();
                Animator.HideSync(this);
                Width = 50;
                Animator.ShowSync(this);
                bnSplit.Image = Resources.Forward_64px;
                spleet = true;
                bnSplit.Location = new Point(bnSplit.Location.X - 15, bnSplit.Location.Y);

            }
            else
            {

                toolMensaje.SetToolTip(bnSplit, "Show less");
                Animator.HideSync(this);
                bnOpciones.Show();
                bunifuSeparator1.Show();
                lbLogo.Show();
                Width = 270;
                bnSplit.Image = Resources.Back_96px;
                Animator.ShowSync(this);
                spleet = false;
                bnSplit.Location = new Point(bnSplit.Location.X + 15, bnSplit.Location.Y);
            }
            MostrarBtn();
        }
    }
    #endregion
}
#endregion
#endregion