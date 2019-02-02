#region Código hecho por Jhonatan Torres
#region Librerías
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Lógica;
using Negocio.Manejo_de_datos;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using System.Media;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using Negocio.Properties;
using DevComponents.DotNetBar;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
#endregion

#region Lógica
namespace Negocio.Lógica
{
    #region Class
    public class AccionesSistema
    {
        #region Atributos

        #endregion

        #region Propiedades

        #endregion

        #region Acciones
        public bool TagIsNull(object tag)
        {
            try
            {
                string tg = tag.ToString();
                return false;
            }
            catch
            {
                return true;
            }
        }
        public Byte[] ConvertirImagen(Image value)
        {
            MemoryStream MemS = new MemoryStream();
            value.Save(MemS, ImageFormat.Png);
            return MemS.GetBuffer();
        }
        public Image ObtenerImagen(object value)
        {
            Byte[] DatosImg = (Byte[])value;
            MemoryStream MemS = new MemoryStream(DatosImg);
            return Image.FromStream(MemS);
        }
        public static Image CropToCircle(Image srcImage, Color backGround)
        {
            Image dstImage = new Bitmap(srcImage.Width, srcImage.Height, srcImage.PixelFormat);
            Graphics g = Graphics.FromImage(dstImage);
            using (Brush br = new SolidBrush(backGround))
            {
                g.FillRectangle(br, 0, 0, dstImage.Width, dstImage.Height);
            }
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, dstImage.Width, dstImage.Height);
            g.SetClip(path);
            g.DrawImage(srcImage, 0, 0);

            return dstImage;
        }
        public void CropImage(Image pic, PictureBox pbImage)
        {
            int s = (pic.Height < pic.Width ? pic.Height : pic.Width);
            int x = (pic.Width == s ? 0 : (pic.Width - s) / 2);
            int y = (pic.Height == s ? 0 : (pic.Height - s) / 2);
            Rectangle section = new Rectangle(new Point(x, y), new Size(s, s));
            Image bmp = new Bitmap(section.Width, section.Height);

            Graphics g = Graphics.FromImage(bmp);

            // Draw the given area (section) of the source image
            // at location 0,0 on the empty bitmap (bmp)
            g.DrawImage(pic, 0, 0, section, GraphicsUnit.Pixel);
            pbImage.Image = CropToCircle(bmp, Color.Transparent);

        }
        public void ShowToolTimInvaide(string text, Control sender)
        {
            Balloon b = new Balloon();
            b.Style = eBallonStyle.Balloon;
            b.CaptionText = "Validation error";
            b.Text = "\t" + text;
            b.AlertAnimation = eAlertAnimation.TopToBottom;
            b.Font = new Font("Segoe UI Light", 8F);
            b.CaptionFont = new Font("Segoe UI Light", 10F);
            b.AutoResize();
            b.AutoClose = true;
            b.AutoCloseTimeOut = 4;
            b.BackColor = Color.FromArgb(0, 102, 204);
            b.ForeColor = Color.White;
            b.CaptionColor = Color.WhiteSmoke;
            b.BorderColor = Color.White;
            b.CaptionImage = Resources.Error_20px;

            b.Owner = GetFormParent(sender);
            b.Show(sender, false);
        }
        public Form GetFormParent(Control sender)
        {
            Control retorno = sender;
            while (true)
            {
                try
                {
                    retorno = retorno.Parent;
                }
                catch
                {
                    break;
                }
                try
                {
                    Form temp = (Form)retorno;
                    break;
                }
                catch { }
            }
            return (Form)retorno;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
