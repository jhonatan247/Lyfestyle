using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiseñoControles.Controles
{
    public partial class News : UserControl
    {
        string url = "";
       
        public string URL
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
            }
        }
        public string Titulo
        {
            get
            {
                return lbTitulo.Text;
            }
            set
            {
                lbTitulo.Text = value;
            }
        }
        public string Descripcion
        {
            get
            {
                return lbDescription.Text;
            }
            set
            {
                lbDescription.Text = value;
            }
        }
        public Image Imagen
        {
            get
            {
                return pictureBox1.Image;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }
        public News()
        {
            InitializeComponent();
            
        }
        public News(string pTitulo, string pTexto, string pURL, Image pImagen )
        {
            InitializeComponent();
            Titulo = pTexto;
            Descripcion = pTexto;
            URL = pURL;
            Imagen = pImagen;
        }
    }
}
