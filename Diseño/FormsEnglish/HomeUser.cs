using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Manejo_de_datos;
using Negocio.Lógica;
using System.Diagnostics;

namespace DiseñoControles.FormsEnglish
{
    public partial class HomeUser : Form
    {
        AccionesSistema As = new AccionesSistema();
        DataRow Drow;
        public HomeUser(DataRow pdRow)
        {
            InitializeComponent();
            Drow = pdRow;
            dataGridViewX1.DataSource = new CRUD_Usuario().Search();
            lbUser.Text = Drow[4].ToString();
            if (Drow[10].ToString() != "")
                As.CropImage(As.ObtenerImagen(Drow[10]), pbPicture);
        }

        private void labelPro1_Click(object sender, EventArgs e)
        {
            dataGridViewX1.DataSource = new CRUD_Usuario().Search();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Process.Start("Server.exe");
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Process.Start("Client.exe");
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
