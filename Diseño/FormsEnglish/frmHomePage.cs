using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiseñoControles.Properties;

namespace DiseñoControles.FormsEnglish
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void bnGoFrowad_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void bnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.ligataekwondobogota.org/");
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
            webBrowser1.Update();
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            lbPage.Text = webBrowser1.DocumentTitle;
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
        }

        private void bnCancel_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void tabFormItem3_Click(object sender, EventArgs e)
        {

        }
    }
}
