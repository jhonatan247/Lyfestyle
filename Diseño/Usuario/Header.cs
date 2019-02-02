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
using BunifuAnimatorNS;
using Bunifu.Framework.UI;
using DiseñoControles.FormsEnglish;
#endregion

#region DiseñoControles
namespace DiseñoControles.Usuario
{
    #region Header
    /// <summary>
    /// Barra superior del formulario
    /// </summary>
    public partial class Header : UserControl
    {
        #region Atributos
        private string companyName = "Company";
        private string formTitle = "Title";
        private bool enabledTransitions = true;
        private Image headerIcon = Properties.Resources.Play_24px;
        private string hora = "";
        #endregion


        #region Propiedades
        public Icon TrayIcon
        {
            get
            {
                return trayBar.Icon;
            }
            set
            {
                trayBar.Icon = value;
            }
        }
        public bool HeaderButtonExit
        {
            get
            {
                return bnExit.Visible;
            }
            set
            {
                bnExit.Visible = value;
                UpdateButtons();
            }
        }
        public bool HeaderButtonMaxim
        {
            get
            {
                return bnMaxim.Visible;
            }
            set
            {
                bnMaxim.Visible = value;
                UpdateButtons();
            }
        }
        public bool HeaderButtonMinim
        {
            get
            {
                return bnMinim.Visible;
            }
            set
            {
                bnMinim.Visible = value;
                UpdateButtons();
            }
        }
        public bool HeaderButtonHide
        {
            get
            {
                return bnHide.Visible;
            }
            set
            {
                bnHide.Visible = value;
                UpdateButtons();
            }
        }
        public bool HeaderButtonHome
        {
            get
            {
                return bnHome.Visible;
            }
            set
            {
                bnHome.Visible = value;
                UpdateButtons();
            }
        }
        public bool HeaderButtonBack
        {
            get
            {
                return bnBack.Visible;
            }
            set
            {
                bnBack.Visible = value;
                UpdateButtons();
            }
        }
        public bool HeaderButtonAbout
        {
            get
            {
                return bnAbout.Visible;
            }
            set
            {
                bnAbout.Visible = value;
                UpdateButtons();
            }
        }
        public bool EnabledHour
        {
            get
            {
                return tHora.Enabled;
            }
            set
            {
                tHora.Enabled = value;
                if (!value)
                {
                    hora = "";
                    UpdateTitle();
                }
            }
        }
        /// <summary>
        /// Imagen
        /// </summary>
        public Image HeaderIcon
        {
            get
            {
                return headerIcon;
            }
            set
            {
                headerIcon = value;
                pbHeaderIcon.Image = headerIcon;
            }
        }
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
                Animar();
            }
        }

        /// <summary>
        /// Típo de animación
        /// </summary>
        public AnimationType TypeLabelAnimation
        {
            get
            {
                return Animator.AnimationType;
            }
            set
            {
                Animator.AnimationType = value;
                Animar();
            }
        }

        /// <summary>
        /// True para activar transiciones
        /// </summary>
        public bool EnabledTransitions
        {
            get
            {
                return enabledTransitions;
            }
            set
            {
                enabledTransitions = value;
            }
        }

        /// <summary>
        /// Titulo del formulario
        /// </summary>
        public string FormTitle
        {
            get
                {
                    return formTitle;
                }
            set
            {
                formTitle = value;
                UpdateTitle();
            }
        }

        /// <summary>
        /// Nombre del programa
        /// </summary>
        public string CompanyTitle
        {
            get
            {
                return companyName;
            }
            set
            {
                companyName = value;
                UpdateTitle();
            }
        }
        
        #endregion


        #region Constructores
        public Header()
        {
            InitializeComponent();
            UpdateTitle();
            UpdateButtons();
        }
        #endregion


        #region Métodos
        public void GoToHome()
        {
            frmHomePage Home = new frmHomePage();
            Parent.Hide();
            Home.ShowDialog();
            Parent.Show();
        }
        private void UpdateTitle()
        {
            SuspendLayout();
            lbHeader.Text = formTitle + " - " + companyName+"   "+hora;
            trayBar.Text = formTitle + " - " + companyName;
            ResumeLayout();
        }
        private void UpdateButtons()
        {
            SuspendLayout();
            int x = pnlContenedor.Width - bnExit.Width;
            foreach (BunifuImageButton bn in pnlContenedor.Controls.OfType<BunifuImageButton>())
            {
                if (bn.Visible)
                {
                    bn.Location = new Point(x, 0);
                    x -= bn.Width;
                }
            }
            ResumeLayout();
        }
        private void Animar()
        {
            if (EnabledTransitions)
            {
                foreach (BunifuCustomLabel lb in pnlContenedor.Controls.OfType<BunifuCustomLabel>())
                {
                    lb.Hide();
                    Animator.ShowSync(lb);
                }
            }
        }
        #endregion


        #region Eventos
        private void bnSalir_Click(object sender, EventArgs e)
        {
            
            Animator.AnimationType = AnimationType.ScaleAndHorizSlide;
            Animator.HideSync(Parent);
            try
            {
                ((Form)Parent).Close();
            }
            catch
            {
            }
        }

        private void lbHeader_Click(object sender, EventArgs e)
        {
            Animar();
        }

        private void bnMaxim_Click(object sender, EventArgs e)
        {
            try {
                if (((Form)Parent).WindowState == FormWindowState.Normal)
                {
                    ((Form)Parent).WindowState = FormWindowState.Maximized;
                    toolMensaje.SetToolTip(bnMaxim, "Minimize");
                }
                else
                {
                    ((Form)Parent).WindowState = FormWindowState.Normal;
                    toolMensaje.SetToolTip(bnMaxim, "Maximize");
                }
            }
            catch { }
        }

        private void Header_FontChanged(object sender, EventArgs e)
        {
            int w = pnlContenedor.Width,
                h= pnlContenedor.Height,
                x = pnlContenedor.Location.X,
                y = pnlContenedor.Location.Y;
            Width = w + 2 * x;
            Height = h+ 2 * y;
            pnlContenedor.Height = h;
            pnlContenedor.Width = w;
            pnlContenedor.Location = new Point(x,y);
        }
        #endregion

        private void tHora_Tick(object sender, EventArgs e)
        {
            hora = (DateTime.Now.Hour > 9 ? "" + DateTime.Now.Hour : "0" + DateTime.Now.Hour) + ":" + (DateTime.Now.Minute > 9 ? "" + DateTime.Now.Minute : "0" + DateTime.Now.Minute);
            UpdateTitle();
        }

        private void bnHide_Click(object sender, EventArgs e)
        {
            trayBar.Visible = true;
            tTransparencia.Start();
        }

        private void tTransparencia_Tick(object sender, EventArgs e)
        {
            if (trayBar.Visible)
            {
                ((Form)Parent).Opacity -= 0.01;
                if (((Form)Parent).Opacity <= 0)
                {
                    ((Form)Parent).ShowInTaskbar = false;
                    tTransparencia.Stop();
                }
            }
            else
            {
                if (((Form)Parent).Opacity == 0)
                {
                    ((Form)Parent).ShowInTaskbar = true;
                }
                ((Form)Parent).Opacity += 0.01;
                if (((Form)Parent).Opacity >= 1)
                {
                    tTransparencia.Stop();
                }
            }
        }

        private void trayBar_DoubleClick(object sender, EventArgs e)
        {
            trayBar.Visible = false;
            tTransparencia.Start();
        }

        private void bnMinim_Click(object sender, EventArgs e)
        {
            ((Form)Parent).WindowState = FormWindowState.Minimized;
        }

        private void bnHome_Click(object sender, EventArgs e)
        {
            GoToHome();
        }

        private void bnBack_Click(object sender, EventArgs e)
        {
            Parent.Hide();
        }

        private void bnAbout_Click(object sender, EventArgs e)
        {
            frmAbout About = new frmAbout();
            About.ShowDialog();
        }
    }
    #endregion
}
#endregion
#endregion
