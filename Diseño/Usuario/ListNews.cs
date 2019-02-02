using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiseñoControles.Usuario
{
    public partial class ListNews : UserControl
    {
        #region Delegados
        public delegate void ClickNewDelegate(string link);
        #endregion
        #region Eventos
        public event ClickNewDelegate ClickNew;
        #endregion
        DataTable dtnews = new DataTable();
        List<Controles.News> Noticias = new List<Controles.News>();

        DataTable dtNews
        {
            get
            {
                return dtnews;
            }
            set
            {
                dtnews = value;
                Limpiar();
                Actualizar();
            }
        }
        void Limpiar()
        {
            foreach(Control c in Controls)
            {
                Controls.Remove(c);
            }
            Noticias.Clear();
        }
        void Actualizar()
        {
            foreach(DataRow dr in dtNews.Rows)
            {
                Controles.News NewTemp = new Controles.News();
            }
        }
        public ListNews()
        {
            InitializeComponent();
        }
        private void New_Click(object sender, EventArgs e)
        {
            ClickNew(((Controles.News)sender).URL);
        }
    }
}
