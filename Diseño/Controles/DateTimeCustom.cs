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
    public partial class DateTimeCustom : UserControl
    {
        Color idle = Color.FromArgb(84, 103, 130), Colorfocused = Color.FromArgb(0, 102, 204), Colorhove = Color.FromArgb(114, 133, 160), fore, Colornormal;
        bool focused = false;
        public Color LineColorIdle
        {
            get
            {
                return idle;
            }
            set
            {
                idle = value;
            }
        }
        public Color LineColorHove
        {
            get
            {
                return Colorhove;
            }
            set
            {
                Colorhove = value;
            }
        }
        public Color LineColorFocused
        {
            get
            {
                return Colorfocused;
            }
            set
            {
                Colorfocused = value;
            }
        }
        public string OverText
        {
            get
            {
                return lbOver.Text;
            }
            set
            {
                lbOver.Text = value;
                toolTip1.SetToolTip(dateTimeInput1, value);
            }
        }
        public DateTimeCustom()
        {
            InitializeComponent();
            fore = ForeColor;
            Colornormal = idle;
        }
        public void Invalide()
        {
            pnlUnderline1.BackColor = Colornormal = ForeColor = Color.Tomato;
        }

        private void dateTimeInput1_MouseHover(object sender, EventArgs e)
        {
            if (!focused)
                pnlUnderline1.BackColor = Colorhove;
        }

        private void lbOver_MouseMove(object sender, MouseEventArgs e)
        {
            if (!focused)
                pnlUnderline1.BackColor = Colorhove;
        }

        private void dateTimeInput1_Enter(object sender, EventArgs e)
        {
            pnlUnderline1.BackColor = Colorfocused;
            focused = true;
        }

        private void pnlUnderline3_MouseLeave(object sender, EventArgs e)
        {
            if (!focused)
                pnlUnderline1.BackColor = Colornormal;
        }

        private void DateTimePro_Load(object sender, EventArgs e)
        {

        }

        private void pnlUnderline1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimeInput1_Leave(object sender, EventArgs e)
        {
            focused = false;
            pnlUnderline1.BackColor = Colornormal;
            if (dateTimeInput1.Value == null)
            {
                lbOver.Show();
            }
        }
        private void nOnValueChanged(object sender, EventArgs e)
        {
            pnlUnderline1.BackColor = Colorfocused;
            focused = true;
            if (dateTimeInput1.Value == null)
            {
                lbOver.Mostrar();
            }
            else
                lbOver.Ocultar();

            if (Colornormal == Color.Tomato || ForeColor == Color.Tomato)
            {
                pnlUnderline1.BackColor = Colornormal = idle;
                ForeColor = fore;
            }
        }
        private void dateTimeInput1_ButtonDropDownClick(object sender, CancelEventArgs e)
        {
            lbOver.Hide();
        }

        private void dateTimeInput1_Click(object sender, EventArgs e)
        {
            lbOver.Hide();
        }
    }
}
