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
using DiseñoControles.Controles;
using Bunifu.Framework.UI;
using Negocio.Manejo_de_datos;
using Negocio.Lógica;
#endregion

#region DiseñoControles
namespace DiseñoControles.Usuario
{
    #region Login
    public partial class SignUp : UserControl
    {
        #region Atributos
        AccionesSistema As = new AccionesSistema();
        #endregion

        #region Delegados
        public delegate void UserSignUpDelegate();
        #endregion

        #region Eventos
        public event UserSignUpDelegate UserSignUp;
        #endregion

        #region Propiedades
        #endregion

        #region Constructores
        public SignUp()
        {
            InitializeComponent();
            DateTime Dt = DateTime.Parse(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + (DateTime.Now.Year - 4));
            dtBirthday.ValueCompare = Dt;
            Limpiar();
        }
        #endregion

        #region Métodos
        public void ShowNormal()
        {
            foreach (Panel pnl in Controls.OfType<Panel>())
            {
                foreach (BunifuThinButton2 bn in pnl.Controls.OfType<BunifuThinButton2>())
                    bn.Show();
                foreach (TextBoxValide tx in pnl.Controls.OfType<TextBoxValide>())
                    tx.Show();
            }
        }
        public void HideNormal()
        {
            foreach (Panel pnl in Controls.OfType<Panel>())
            {
                foreach (TextBoxValide tx in pnl.Controls.OfType<TextBoxValide>())
                    tx.Hide();
                foreach (BunifuThinButton2 bn in pnl.Controls.OfType<BunifuThinButton2>())
                    bn.Hide();
            }
        }
        public void ShowAll()
        {
            ShowBug();
            ShowNormal();
        }
        public void HideAll()
        {
            HideBug();
            HideNormal();
        }
        public void ShowBug()
        {
            foreach (Panel pnl in Controls.OfType<Panel>())
            {
                foreach (DropDownPro dr in pnl.Controls.OfType<DropDownPro>())
                    dr.Show();
                foreach (DateTimePro dt in pnl.Controls.OfType<DateTimePro>())
                    dt.Show();
            }
        }
        public void HideBug()
        {
            foreach (Panel pnl in Controls.OfType<Panel>())
            {
                foreach (DropDownPro dr in pnl.Controls.OfType<DropDownPro>())
                    dr.Hide();
                foreach (DateTimePro dt in pnl.Controls.OfType<DateTimePro>())
                    dt.Hide();
            }
        }
        bool Validar(Control sender)
        {
            bool result = true;
            foreach (Control contr in ((Panel)sender).Controls)
            {
                try
                {
                    result = ((TextBoxValide)contr).IsCorrect();
                }
                catch
                {
                    try
                    {
                        result = ((DropDownPro)contr).IsCorrect();
                    }
                    catch
                    {
                        try
                        {
                            result = ((DateTimePro)contr).IsCorrect();
                        }
                        catch{}
                    }
                }
                if (!result)
                {
                    break;
                }
            }
            return result;
        }
        void Limpiar()
        {
            foreach(Panel sender in Controls.OfType<Panel>())
            {
                foreach (TextBoxValide tx in sender.Controls.OfType<TextBoxValide>())
                {
                    tx.Limpiar();
                }
                foreach (DropDownPro dr in sender.Controls.OfType<DropDownPro>())
                {
                    dr.Limpiar();
                }
                foreach (DateTimePro dt in sender.Controls.OfType<DateTimePro>())
                {
                    dt.Limpiar();
                }
                sender.Hide();
            }
            pbPicture.Image = Resources.user;

        }
        public void PanelTransition(Control p1, Control p2)
        {
            HideBug();
            Animator.HideSync(p1);
            Animator.ShowSync(p2);
            ShowBug();
        }
        #endregion

        #region ControlEventos
        private void bnNext_Click(object sender, EventArgs e)
        {
            if (Validar(pnlPersonalInformation))
                PanelTransition(pnlPersonalInformation, pnlContactInformation);
        }

        private void pnlPersonalInformation_VisibleChanged(object sender, EventArgs e)
        {
            if (((Panel)sender).Visible)
                lbDescription.Text = ((Panel)sender).Tag.ToString();
        }

        private void bnNextContact_Click(object sender, EventArgs e)
        {
            if (Validar(pnlContactInformation))
                PanelTransition(pnlContactInformation, pnlUserInformation);
        }

        private void bnBackContactInformation_Click(object sender, EventArgs e)
        {
            PanelTransition(pnlContactInformation, pnlPersonalInformation);
        }

        private void bnNextUserInformation_Click(object sender, EventArgs e)
        {
            if (Validar(pnlUserInformation))
                PanelTransition(pnlUserInformation, pnlDesignInformation);
        }

        private void bnBackUserInformation_Click(object sender, EventArgs e)
        {
            PanelTransition(pnlUserInformation, pnlContactInformation);
        }

        private void bnBackDesign_Click(object sender, EventArgs e)
        {
            PanelTransition(pnlDesignInformation, pnlUserInformation);
        }

        private void bnFinalize_Click(object sender, EventArgs e)
        {
            CRUD_Usuario newUser = new CRUD_Usuario(
                txFirstName.Text,
                txSecondName.Text,
                txSurname.Text,
                txSecondSurname.Text,
                cbGender.selectedValue[0],
                dtBirthday.Value,
                cbDocumentType.selectedValue,
                txDocumenNumber.Text,
                cbDepartament.selectedValue,
                txCity.Text,
                txComune.Text,
                txResidence.Text,
                txCellphone.Text,
                txLandline.Text,
                cbTheme.selectedValue,
                txUser.Text,
                txPassword.Text,
                txEmail.Text,
                cbSecurityQuestion.selectedValue,
                txAnswer.Text,
                txPin.Text,
                (As.TagIsNull(pbPicture.Tag) ? null : Image.FromFile(pbPicture.Tag.ToString()))
             );
            if (newUser.Insert() >= 0)
            {
                MessageUser Mes = new MessageUser("¡¡Congratulations!!", "You have registered successfully, log in to your new account.", "Sign up", MessageBtns.Ok, 30, DevComponents.DotNetBar.eAlertAnimation.TopToBottom, Resources.Approval_96px);
                UserSignUp();
            }
            else
            {

            }
        }

        private void pbPicture_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void pbPicture_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, true); // recupera los datos del archivo que arrastre
                As.CropImage(Image.FromFile(files[0]), ((PictureBox)sender));
                ((PictureBox)sender).Tag = files[0];
            }
            catch { }
        }

        private void pbPicture_Click(object sender, EventArgs e)
        {
            try
            {
                OpenMedia = new OpenFileDialog();
                OpenMedia.InitialDirectory = Environment.SpecialFolder.CommonMusic.ToString();
                OpenMedia.FileName = "";
                OpenMedia.Title = "FREGDA";
                OpenMedia.Multiselect = false;
                OpenMedia.Filter = "Archivo de Imagen (*.GIF;*.BMP;*.JPEG;*.PNG;*.TIF;*.TIFF;*.JPG;)|*.GIF;*.BMP;*.JPEG;*.PNG;*.TIF;*.TIFF;*.JPG";
                if (OpenMedia.ShowDialog() == DialogResult.OK)
                {
                    As.CropImage(Image.FromFile(OpenMedia.FileName), ((PictureBox)sender));
                    ((PictureBox)sender).Tag = OpenMedia.FileName;
                }
            }
            catch { }
        }

        private void SignUp_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                pnlPersonalInformation.Show();
                ShowNormal();
            }
            else
                Limpiar();
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
