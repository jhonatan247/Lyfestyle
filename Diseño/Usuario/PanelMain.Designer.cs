namespace DiseñoControles.Usuario
{
    partial class PanelMain
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelMain));
            this.toolMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.Animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnFondo = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bnSplit = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbLogo = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMainMenu1 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelMainContenido1 = new System.Windows.Forms.Panel();
            this.lbMensaje1 = new DiseñoControles.Controles.LabelPro();
            this.lbSocialMedia = new DiseñoControles.Controles.LabelPro();
            this.bnFacebook = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnTwitter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnOpciones = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pnFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnSplit)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelMainMenu1.SuspendLayout();
            this.panelMainContenido1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnOpciones)).BeginInit();
            this.SuspendLayout();
            // 
            // Animator
            // 
            this.Animator.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.Animator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Animator.DefaultAnimation = animation1;
            // 
            // pnFondo
            // 
            this.pnFondo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnFondo.BackgroundImage")));
            this.pnFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnFondo.Controls.Add(this.bnSplit);
            this.pnFondo.Controls.Add(this.lbLogo);
            this.pnFondo.Controls.Add(this.panel1);
            this.pnFondo.Controls.Add(this.bnOpciones);
            this.pnFondo.Controls.Add(this.bunifuSeparator1);
            this.Animator.SetDecoration(this.pnFondo, BunifuAnimatorNS.DecorationType.None);
            this.pnFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFondo.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnFondo.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(213)))));
            this.pnFondo.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.pnFondo.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnFondo.Location = new System.Drawing.Point(0, 0);
            this.pnFondo.Name = "pnFondo";
            this.pnFondo.Quality = 10;
            this.pnFondo.Size = new System.Drawing.Size(270, 400);
            this.pnFondo.TabIndex = 3;
            this.pnFondo.Visible = false;
            // 
            // bnSplit
            // 
            this.bnSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnSplit.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.bnSplit, BunifuAnimatorNS.DecorationType.None);
            this.bnSplit.Image = global::DiseñoControles.Properties.Resources.Back_96px;
            this.bnSplit.ImageActive = null;
            this.bnSplit.Location = new System.Drawing.Point(240, 35);
            this.bnSplit.Name = "bnSplit";
            this.bnSplit.Size = new System.Drawing.Size(30, 30);
            this.bnSplit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnSplit.TabIndex = 17;
            this.bnSplit.TabStop = false;
            this.toolMensaje.SetToolTip(this.bnSplit, "Show less");
            this.bnSplit.Zoom = 20;
            this.bnSplit.Click += new System.EventHandler(this.bnSplit_Click);
            // 
            // lbLogo
            // 
            this.lbLogo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbLogo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Animator.SetDecoration(this.lbLogo, BunifuAnimatorNS.DecorationType.None);
            this.lbLogo.Font = new System.Drawing.Font("Segoe UI Light", 34F);
            this.lbLogo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbLogo.Location = new System.Drawing.Point(31, 14);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.ReflectionEnabled = false;
            this.lbLogo.Size = new System.Drawing.Size(157, 90);
            this.lbLogo.TabIndex = 16;
            this.lbLogo.Text = "<font size=\"+0\"><i>Life</i><font color=\"#0063D5\">Style</font></font>\r\n<p>\r\n<font " +
    "size=\"15\"><font color=\"#1477E9\"><b> Taekwondo</b></font></font>\r\n</p>";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panelMainMenu1);
            this.panel1.Controls.Add(this.panelMainContenido1);
            this.Animator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 290);
            this.panel1.TabIndex = 14;
            // 
            // panelMainMenu1
            // 
            this.panelMainMenu1.AutoScroll = true;
            this.panelMainMenu1.Controls.Add(this.bunifuFlatButton3);
            this.panelMainMenu1.Controls.Add(this.bunifuFlatButton2);
            this.panelMainMenu1.Controls.Add(this.bunifuFlatButton1);
            this.panelMainMenu1.Controls.Add(this.bunifuFlatButton4);
            this.panelMainMenu1.Controls.Add(this.bnLogin);
            this.Animator.SetDecoration(this.panelMainMenu1, BunifuAnimatorNS.DecorationType.None);
            this.panelMainMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainMenu1.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu1.Name = "panelMainMenu1";
            this.panelMainMenu1.Size = new System.Drawing.Size(270, 290);
            this.panelMainMenu1.TabIndex = 0;
            this.panelMainMenu1.Visible = false;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "More options";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animator.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 40D;
            this.bunifuFlatButton3.IsTab = true;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 192);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(213)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(270, 48);
            this.bunifuFlatButton3.TabIndex = 21;
            this.bunifuFlatButton3.Tag = "1";
            this.bunifuFlatButton3.Text = "More options";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolMensaje.SetToolTip(this.bunifuFlatButton3, "More options");
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Settings";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animator.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::DiseñoControles.Properties.Resources.Settings_24px;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 40D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 144);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(213)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(270, 48);
            this.bunifuFlatButton2.TabIndex = 20;
            this.bunifuFlatButton2.Tag = "1";
            this.bunifuFlatButton2.Text = "Settings";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolMensaje.SetToolTip(this.bunifuFlatButton2, "Settings");
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Tools";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animator.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::DiseñoControles.Properties.Resources.Toolbox_24px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 40D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 96);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(213)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(270, 48);
            this.bunifuFlatButton1.TabIndex = 19;
            this.bunifuFlatButton1.Tag = "1";
            this.bunifuFlatButton1.Text = "Tools";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolMensaje.SetToolTip(this.bunifuFlatButton1, "Tools");
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Sign up";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animator.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = global::DiseñoControles.Properties.Resources.Add_User_Male_96px;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 40D;
            this.bunifuFlatButton4.IsTab = true;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(0, 48);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(213)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(270, 48);
            this.bunifuFlatButton4.TabIndex = 22;
            this.bunifuFlatButton4.Tag = "1";
            this.bunifuFlatButton4.Text = "Sign up";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolMensaje.SetToolTip(this.bunifuFlatButton4, "Sign up");
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bnLogin
            // 
            this.bnLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bnLogin.BackColor = System.Drawing.Color.Transparent;
            this.bnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnLogin.BorderRadius = 0;
            this.bnLogin.ButtonText = "Login";
            this.bnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animator.SetDecoration(this.bnLogin, BunifuAnimatorNS.DecorationType.None);
            this.bnLogin.DisabledColor = System.Drawing.Color.Gray;
            this.bnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.bnLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.bnLogin.Iconimage = global::DiseñoControles.Properties.Resources.User_Credentials_24px;
            this.bnLogin.Iconimage_right = null;
            this.bnLogin.Iconimage_right_Selected = null;
            this.bnLogin.Iconimage_Selected = null;
            this.bnLogin.IconMarginLeft = 0;
            this.bnLogin.IconMarginRight = 0;
            this.bnLogin.IconRightVisible = true;
            this.bnLogin.IconRightZoom = 0D;
            this.bnLogin.IconVisible = true;
            this.bnLogin.IconZoom = 40D;
            this.bnLogin.IsTab = true;
            this.bnLogin.Location = new System.Drawing.Point(0, 0);
            this.bnLogin.Name = "bnLogin";
            this.bnLogin.Normalcolor = System.Drawing.Color.Transparent;
            this.bnLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(213)))));
            this.bnLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.bnLogin.selected = true;
            this.bnLogin.Size = new System.Drawing.Size(270, 48);
            this.bnLogin.TabIndex = 18;
            this.bnLogin.Tag = "1";
            this.bnLogin.Text = "Login";
            this.bnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnLogin.Textcolor = System.Drawing.Color.White;
            this.bnLogin.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolMensaje.SetToolTip(this.bnLogin, "Login");
            this.bnLogin.Click += new System.EventHandler(this.bnLogin_Click);
            // 
            // panelMainContenido1
            // 
            this.panelMainContenido1.Controls.Add(this.lbMensaje1);
            this.panelMainContenido1.Controls.Add(this.lbSocialMedia);
            this.panelMainContenido1.Controls.Add(this.bnFacebook);
            this.panelMainContenido1.Controls.Add(this.bnTwitter);
            this.Animator.SetDecoration(this.panelMainContenido1, BunifuAnimatorNS.DecorationType.None);
            this.panelMainContenido1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContenido1.Location = new System.Drawing.Point(0, 0);
            this.panelMainContenido1.Name = "panelMainContenido1";
            this.panelMainContenido1.Size = new System.Drawing.Size(270, 290);
            this.panelMainContenido1.TabIndex = 1;
            // 
            // lbMensaje1
            // 
            this.lbMensaje1.AutoSize = true;
            this.lbMensaje1.BackColor = System.Drawing.Color.Transparent;
            this.lbMensaje1.CheckReference = null;
            this.lbMensaje1.CustomLabelType = DiseñoControles.Controles.LabelType.Custom;
            this.Animator.SetDecoration(this.lbMensaje1, BunifuAnimatorNS.DecorationType.None);
            this.lbMensaje1.EnabledTransitions = true;
            this.lbMensaje1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbMensaje1.ForColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.lbMensaje1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.lbMensaje1.Link = "";
            this.lbMensaje1.Location = new System.Drawing.Point(31, 15);
            this.lbMensaje1.Name = "lbMensaje1";
            this.lbMensaje1.Size = new System.Drawing.Size(186, 42);
            this.lbMensaje1.SizeTag = new System.Drawing.Size(0, 0);
            this.lbMensaje1.Style = DiseñoControles.Controles.LabelStyle.Custom;
            this.lbMensaje1.TabIndex = 14;
            this.lbMensaje1.Text = "The best app to \r\nmanage your sports life.";
            this.lbMensaje1.Visible = false;
            // 
            // lbSocialMedia
            // 
            this.lbSocialMedia.AutoSize = true;
            this.lbSocialMedia.BackColor = System.Drawing.Color.Transparent;
            this.lbSocialMedia.CheckReference = null;
            this.lbSocialMedia.CustomLabelType = DiseñoControles.Controles.LabelType.Custom;
            this.Animator.SetDecoration(this.lbSocialMedia, BunifuAnimatorNS.DecorationType.None);
            this.lbSocialMedia.EnabledTransitions = true;
            this.lbSocialMedia.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lbSocialMedia.ForColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.lbSocialMedia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.lbSocialMedia.Link = "";
            this.lbSocialMedia.Location = new System.Drawing.Point(31, 134);
            this.lbSocialMedia.Name = "lbSocialMedia";
            this.lbSocialMedia.Size = new System.Drawing.Size(180, 21);
            this.lbSocialMedia.SizeTag = new System.Drawing.Size(0, 0);
            this.lbSocialMedia.Style = DiseñoControles.Controles.LabelStyle.Custom;
            this.lbSocialMedia.TabIndex = 15;
            this.lbSocialMedia.Text = "Sign in using social media";
            this.lbSocialMedia.Visible = false;
            // 
            // bnFacebook
            // 
            this.bnFacebook.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(104)))), ((int)(((byte)(184)))));
            this.bnFacebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(104)))), ((int)(((byte)(184)))));
            this.bnFacebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnFacebook.BorderRadius = 7;
            this.bnFacebook.ButtonText = "Facebook";
            this.bnFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animator.SetDecoration(this.bnFacebook, BunifuAnimatorNS.DecorationType.None);
            this.bnFacebook.DisabledColor = System.Drawing.Color.Gray;
            this.bnFacebook.Iconcolor = System.Drawing.Color.Transparent;
            this.bnFacebook.Iconimage = global::DiseñoControles.Properties.Resources.FacebookFocused_96px;
            this.bnFacebook.Iconimage_right = null;
            this.bnFacebook.Iconimage_right_Selected = null;
            this.bnFacebook.Iconimage_Selected = null;
            this.bnFacebook.IconMarginLeft = 0;
            this.bnFacebook.IconMarginRight = 0;
            this.bnFacebook.IconRightVisible = true;
            this.bnFacebook.IconRightZoom = 0D;
            this.bnFacebook.IconVisible = true;
            this.bnFacebook.IconZoom = 90D;
            this.bnFacebook.IsTab = false;
            this.bnFacebook.Location = new System.Drawing.Point(35, 175);
            this.bnFacebook.Name = "bnFacebook";
            this.bnFacebook.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(104)))), ((int)(((byte)(184)))));
            this.bnFacebook.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(114)))), ((int)(((byte)(194)))));
            this.bnFacebook.OnHoverTextColor = System.Drawing.Color.White;
            this.bnFacebook.selected = false;
            this.bnFacebook.Size = new System.Drawing.Size(204, 38);
            this.bnFacebook.TabIndex = 16;
            this.bnFacebook.Text = "Facebook";
            this.bnFacebook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnFacebook.Textcolor = System.Drawing.Color.White;
            this.bnFacebook.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnFacebook.Visible = false;
            this.bnFacebook.Click += new System.EventHandler(this.bnFacebook_Click);
            // 
            // bnTwitter
            // 
            this.bnTwitter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.bnTwitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.bnTwitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnTwitter.BorderRadius = 7;
            this.bnTwitter.ButtonText = "Twitter";
            this.bnTwitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animator.SetDecoration(this.bnTwitter, BunifuAnimatorNS.DecorationType.None);
            this.bnTwitter.DisabledColor = System.Drawing.Color.Gray;
            this.bnTwitter.Iconcolor = System.Drawing.Color.Transparent;
            this.bnTwitter.Iconimage = global::DiseñoControles.Properties.Resources.Twitter_96px;
            this.bnTwitter.Iconimage_right = null;
            this.bnTwitter.Iconimage_right_Selected = null;
            this.bnTwitter.Iconimage_Selected = null;
            this.bnTwitter.IconMarginLeft = 0;
            this.bnTwitter.IconMarginRight = 0;
            this.bnTwitter.IconRightVisible = true;
            this.bnTwitter.IconRightZoom = 0D;
            this.bnTwitter.IconVisible = true;
            this.bnTwitter.IconZoom = 90D;
            this.bnTwitter.IsTab = false;
            this.bnTwitter.Location = new System.Drawing.Point(35, 219);
            this.bnTwitter.Name = "bnTwitter";
            this.bnTwitter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.bnTwitter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(204)))), ((int)(((byte)(243)))));
            this.bnTwitter.OnHoverTextColor = System.Drawing.Color.White;
            this.bnTwitter.selected = false;
            this.bnTwitter.Size = new System.Drawing.Size(204, 38);
            this.bnTwitter.TabIndex = 17;
            this.bnTwitter.Text = "Twitter";
            this.bnTwitter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnTwitter.Textcolor = System.Drawing.Color.White;
            this.bnTwitter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnTwitter.Visible = false;
            this.bnTwitter.Click += new System.EventHandler(this.bnTwiter_Click);
            // 
            // bnOpciones
            // 
            this.bnOpciones.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.bnOpciones, BunifuAnimatorNS.DecorationType.None);
            this.bnOpciones.Image = global::DiseñoControles.Properties.Resources.Menu_24px;
            this.bnOpciones.ImageActive = null;
            this.bnOpciones.Location = new System.Drawing.Point(194, 35);
            this.bnOpciones.Name = "bnOpciones";
            this.bnOpciones.Size = new System.Drawing.Size(30, 30);
            this.bnOpciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnOpciones.TabIndex = 10;
            this.bnOpciones.TabStop = false;
            this.toolMensaje.SetToolTip(this.bnOpciones, "Options");
            this.bnOpciones.Zoom = 20;
            this.bnOpciones.Click += new System.EventHandler(this.bnOpciones_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(213)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 87);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(270, 35);
            this.bunifuSeparator1.TabIndex = 15;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // PanelMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(52)))), ((int)(((byte)(91)))));
            this.Controls.Add(this.pnFondo);
            this.Animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "PanelMain";
            this.Size = new System.Drawing.Size(270, 400);
            this.pnFondo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnSplit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelMainMenu1.ResumeLayout(false);
            this.panelMainContenido1.ResumeLayout(false);
            this.panelMainContenido1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnOpciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnFondo;
        private Bunifu.Framework.UI.BunifuImageButton bnOpciones;
        private System.Windows.Forms.ToolTip toolMensaje;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel lbLogo;
        private BunifuAnimatorNS.BunifuTransition Animator;
        private Bunifu.Framework.UI.BunifuImageButton bnSplit;
        private System.Windows.Forms.Panel panelMainMenu1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bnLogin;
        private System.Windows.Forms.Panel panelMainContenido1;
        private Controles.LabelPro lbMensaje1;
        private Controles.LabelPro lbSocialMedia;
        private Bunifu.Framework.UI.BunifuFlatButton bnFacebook;
        private Bunifu.Framework.UI.BunifuFlatButton bnTwitter;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
    }
}
