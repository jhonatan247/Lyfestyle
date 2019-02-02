namespace DiseñoControles.Usuario
{
    partial class UserSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSettings));
            this.lbLogin = new DiseñoControles.Controles.LabelPro();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.Animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuSlider1 = new Bunifu.Framework.UI.BunifuSlider();
            this.labelPro2 = new DiseñoControles.Controles.LabelPro();
            this.cbTheme = new DiseñoControles.Controles.DropDownPro();
            this.labelPro1 = new DiseñoControles.Controles.LabelPro();
            this.labelPro3 = new DiseñoControles.Controles.LabelPro();
            this.bunifuiOSSwitch1 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.labelPro4 = new DiseñoControles.Controles.LabelPro();
            this.labelPro5 = new DiseñoControles.Controles.LabelPro();
            this.bunifuiOSSwitch2 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bunifuSlider2 = new Bunifu.Framework.UI.BunifuSlider();
            this.labelPro6 = new DiseñoControles.Controles.LabelPro();
            this.bunifuiOSSwitch3 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bnFinalize = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.CheckReference = null;
            this.lbLogin.CustomLabelType = DiseñoControles.Controles.LabelType.Custom;
            this.Animator.SetDecoration(this.lbLogin, BunifuAnimatorNS.DecorationType.None);
            this.lbLogin.EnabledTransitions = true;
            this.lbLogin.Font = new System.Drawing.Font("Segoe UI Light", 30F);
            this.lbLogin.ForColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.lbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.lbLogin.Link = "";
            this.lbLogin.Location = new System.Drawing.Point(6, 1);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(154, 54);
            this.lbLogin.SizeTag = new System.Drawing.Size(0, 0);
            this.lbLogin.Style = DiseñoControles.Controles.LabelStyle.Over;
            this.lbLogin.TabIndex = 5;
            this.lbLogin.Text = "Settings";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlUser);
            this.Animator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 12;
            // 
            // pnlUser
            // 
            this.pnlUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlUser.Controls.Add(this.bnFinalize);
            this.pnlUser.Controls.Add(this.labelPro6);
            this.pnlUser.Controls.Add(this.bunifuiOSSwitch3);
            this.pnlUser.Controls.Add(this.labelPro4);
            this.pnlUser.Controls.Add(this.labelPro5);
            this.pnlUser.Controls.Add(this.bunifuiOSSwitch2);
            this.pnlUser.Controls.Add(this.bunifuSlider2);
            this.pnlUser.Controls.Add(this.labelPro3);
            this.pnlUser.Controls.Add(this.labelPro1);
            this.pnlUser.Controls.Add(this.labelPro2);
            this.pnlUser.Controls.Add(this.cbTheme);
            this.pnlUser.Controls.Add(this.bunifuiOSSwitch1);
            this.pnlUser.Controls.Add(this.bunifuSlider1);
            this.pnlUser.Controls.Add(this.lbLogin);
            this.Animator.SetDecoration(this.pnlUser, BunifuAnimatorNS.DecorationType.None);
            this.pnlUser.Location = new System.Drawing.Point(38, 19);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(325, 354);
            this.pnlUser.TabIndex = 14;
            // 
            // Animator
            // 
            this.Animator.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
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
            animation1.TransparencyCoeff = 1F;
            this.Animator.DefaultAnimation = animation1;
            this.Animator.TimeStep = 0.01F;
            // 
            // bunifuSlider1
            // 
            this.bunifuSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSlider1.BorderRadius = 10;
            this.Animator.SetDecoration(this.bunifuSlider1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSlider1.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuSlider1.Location = new System.Drawing.Point(208, 83);
            this.bunifuSlider1.MaximumValue = 100;
            this.bunifuSlider1.Name = "bunifuSlider1";
            this.bunifuSlider1.Size = new System.Drawing.Size(92, 30);
            this.bunifuSlider1.TabIndex = 6;
            this.bunifuSlider1.Value = 0;
            // 
            // labelPro2
            // 
            this.labelPro2.AutoSize = true;
            this.labelPro2.CheckReference = null;
            this.labelPro2.CustomLabelType = DiseñoControles.Controles.LabelType.Custom;
            this.Animator.SetDecoration(this.labelPro2, BunifuAnimatorNS.DecorationType.None);
            this.labelPro2.EnabledTransitions = true;
            this.labelPro2.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.labelPro2.ForColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.labelPro2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.labelPro2.Link = "";
            this.labelPro2.Location = new System.Drawing.Point(24, 254);
            this.labelPro2.Name = "labelPro2";
            this.labelPro2.Size = new System.Drawing.Size(108, 20);
            this.labelPro2.SizeTag = new System.Drawing.Size(0, 0);
            this.labelPro2.Style = DiseñoControles.Controles.LabelStyle.Opaque;
            this.labelPro2.TabIndex = 41;
            this.labelPro2.Text = "Window theme";
            // 
            // cbTheme
            // 
            this.cbTheme.BackColor = System.Drawing.Color.Transparent;
            this.cbTheme.BorderRadius = 3;
            this.cbTheme.CampoObligatorio = false;
            this.Animator.SetDecoration(this.cbTheme, BunifuAnimatorNS.DecorationType.None);
            this.cbTheme.ForeColor = System.Drawing.Color.White;
            this.cbTheme.Items = new string[] {
        "Dark",
        "White",
        "Lifestyle theme"};
            this.cbTheme.Location = new System.Drawing.Point(138, 246);
            this.cbTheme.Name = "cbTheme";
            this.cbTheme.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.cbTheme.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.cbTheme.selectedIndex = 0;
            this.cbTheme.Size = new System.Drawing.Size(162, 35);
            this.cbTheme.TabIndex = 40;
            // 
            // labelPro1
            // 
            this.labelPro1.AutoSize = true;
            this.labelPro1.CheckReference = null;
            this.labelPro1.CustomLabelType = DiseñoControles.Controles.LabelType.Custom;
            this.Animator.SetDecoration(this.labelPro1, BunifuAnimatorNS.DecorationType.None);
            this.labelPro1.EnabledTransitions = true;
            this.labelPro1.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.labelPro1.ForColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.labelPro1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.labelPro1.Link = "";
            this.labelPro1.Location = new System.Drawing.Point(144, 83);
            this.labelPro1.Name = "labelPro1";
            this.labelPro1.Size = new System.Drawing.Size(58, 20);
            this.labelPro1.SizeTag = new System.Drawing.Size(0, 0);
            this.labelPro1.Style = DiseñoControles.Controles.LabelStyle.Opaque;
            this.labelPro1.TabIndex = 42;
            this.labelPro1.Text = "Volume";
            // 
            // labelPro3
            // 
            this.labelPro3.AutoSize = true;
            this.labelPro3.CheckReference = null;
            this.labelPro3.CustomLabelType = DiseñoControles.Controles.LabelType.Custom;
            this.Animator.SetDecoration(this.labelPro3, BunifuAnimatorNS.DecorationType.None);
            this.labelPro3.EnabledTransitions = true;
            this.labelPro3.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.labelPro3.ForColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.labelPro3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.labelPro3.Link = "";
            this.labelPro3.Location = new System.Drawing.Point(24, 83);
            this.labelPro3.Name = "labelPro3";
            this.labelPro3.Size = new System.Drawing.Size(51, 20);
            this.labelPro3.SizeTag = new System.Drawing.Size(0, 0);
            this.labelPro3.Style = DiseñoControles.Controles.LabelStyle.Opaque;
            this.labelPro3.TabIndex = 43;
            this.labelPro3.Text = "Sound";
            // 
            // bunifuiOSSwitch1
            // 
            this.bunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch1.BackgroundImage")));
            this.bunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animator.SetDecoration(this.bunifuiOSSwitch1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuiOSSwitch1.Location = new System.Drawing.Point(81, 83);
            this.bunifuiOSSwitch1.Name = "bunifuiOSSwitch1";
            this.bunifuiOSSwitch1.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuiOSSwitch1.Size = new System.Drawing.Size(43, 25);
            this.bunifuiOSSwitch1.TabIndex = 7;
            this.bunifuiOSSwitch1.Value = false;
            // 
            // labelPro4
            // 
            this.labelPro4.AutoSize = true;
            this.labelPro4.CheckReference = null;
            this.labelPro4.CustomLabelType = DiseñoControles.Controles.LabelType.Custom;
            this.Animator.SetDecoration(this.labelPro4, BunifuAnimatorNS.DecorationType.None);
            this.labelPro4.EnabledTransitions = true;
            this.labelPro4.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.labelPro4.ForColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.labelPro4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.labelPro4.Link = "";
            this.labelPro4.Location = new System.Drawing.Point(24, 142);
            this.labelPro4.Name = "labelPro4";
            this.labelPro4.Size = new System.Drawing.Size(77, 20);
            this.labelPro4.SizeTag = new System.Drawing.Size(0, 0);
            this.labelPro4.Style = DiseñoControles.Controles.LabelStyle.Opaque;
            this.labelPro4.TabIndex = 47;
            this.labelPro4.Text = "Transitions";
            // 
            // labelPro5
            // 
            this.labelPro5.AutoSize = true;
            this.labelPro5.CheckReference = null;
            this.labelPro5.CustomLabelType = DiseñoControles.Controles.LabelType.Custom;
            this.Animator.SetDecoration(this.labelPro5, BunifuAnimatorNS.DecorationType.None);
            this.labelPro5.EnabledTransitions = true;
            this.labelPro5.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.labelPro5.ForColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.labelPro5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.labelPro5.Link = "";
            this.labelPro5.Location = new System.Drawing.Point(169, 142);
            this.labelPro5.Name = "labelPro5";
            this.labelPro5.Size = new System.Drawing.Size(51, 20);
            this.labelPro5.SizeTag = new System.Drawing.Size(0, 0);
            this.labelPro5.Style = DiseñoControles.Controles.LabelStyle.Opaque;
            this.labelPro5.TabIndex = 46;
            this.labelPro5.Text = "Speed";
            // 
            // bunifuiOSSwitch2
            // 
            this.bunifuiOSSwitch2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch2.BackgroundImage")));
            this.bunifuiOSSwitch2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animator.SetDecoration(this.bunifuiOSSwitch2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuiOSSwitch2.Location = new System.Drawing.Point(107, 142);
            this.bunifuiOSSwitch2.Name = "bunifuiOSSwitch2";
            this.bunifuiOSSwitch2.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch2.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuiOSSwitch2.Size = new System.Drawing.Size(43, 25);
            this.bunifuiOSSwitch2.TabIndex = 45;
            this.bunifuiOSSwitch2.Value = true;
            // 
            // bunifuSlider2
            // 
            this.bunifuSlider2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider2.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSlider2.BorderRadius = 10;
            this.Animator.SetDecoration(this.bunifuSlider2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSlider2.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuSlider2.Location = new System.Drawing.Point(226, 142);
            this.bunifuSlider2.MaximumValue = 100;
            this.bunifuSlider2.Name = "bunifuSlider2";
            this.bunifuSlider2.Size = new System.Drawing.Size(74, 30);
            this.bunifuSlider2.TabIndex = 44;
            this.bunifuSlider2.Value = 50;
            // 
            // labelPro6
            // 
            this.labelPro6.AutoSize = true;
            this.labelPro6.CheckReference = null;
            this.labelPro6.CustomLabelType = DiseñoControles.Controles.LabelType.Custom;
            this.Animator.SetDecoration(this.labelPro6, BunifuAnimatorNS.DecorationType.None);
            this.labelPro6.EnabledTransitions = true;
            this.labelPro6.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.labelPro6.ForColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.labelPro6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.labelPro6.Link = "";
            this.labelPro6.Location = new System.Drawing.Point(24, 198);
            this.labelPro6.Name = "labelPro6";
            this.labelPro6.Size = new System.Drawing.Size(93, 20);
            this.labelPro6.SizeTag = new System.Drawing.Size(0, 0);
            this.labelPro6.Style = DiseñoControles.Controles.LabelStyle.Opaque;
            this.labelPro6.TabIndex = 49;
            this.labelPro6.Text = "Offline mode";
            // 
            // bunifuiOSSwitch3
            // 
            this.bunifuiOSSwitch3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch3.BackgroundImage")));
            this.bunifuiOSSwitch3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animator.SetDecoration(this.bunifuiOSSwitch3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuiOSSwitch3.Location = new System.Drawing.Point(123, 198);
            this.bunifuiOSSwitch3.Name = "bunifuiOSSwitch3";
            this.bunifuiOSSwitch3.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch3.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuiOSSwitch3.Size = new System.Drawing.Size(43, 25);
            this.bunifuiOSSwitch3.TabIndex = 48;
            this.bunifuiOSSwitch3.Value = true;
            // 
            // bnFinalize
            // 
            this.bnFinalize.ActiveBorderThickness = 1;
            this.bnFinalize.ActiveCornerRadius = 20;
            this.bnFinalize.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bnFinalize.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bnFinalize.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bnFinalize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnFinalize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.bnFinalize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnFinalize.BackgroundImage")));
            this.bnFinalize.ButtonText = "Restore settings";
            this.bnFinalize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animator.SetDecoration(this.bnFinalize, BunifuAnimatorNS.DecorationType.None);
            this.bnFinalize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnFinalize.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnFinalize.IdleBorderThickness = 1;
            this.bnFinalize.IdleCornerRadius = 20;
            this.bnFinalize.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.bnFinalize.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.bnFinalize.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bnFinalize.Location = new System.Drawing.Point(90, 306);
            this.bnFinalize.Margin = new System.Windows.Forms.Padding(5);
            this.bnFinalize.Name = "bnFinalize";
            this.bnFinalize.Size = new System.Drawing.Size(145, 43);
            this.bnFinalize.TabIndex = 50;
            this.bnFinalize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.panel1);
            this.Animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "UserSettings";
            this.Size = new System.Drawing.Size(400, 400);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.VisibleChanged += new System.EventHandler(this.Login_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Controles.LabelPro lbLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlUser;
        private BunifuAnimatorNS.BunifuTransition Animator;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuSlider bunifuSlider1;
        private Controles.LabelPro labelPro6;
        private Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch3;
        private Controles.LabelPro labelPro4;
        private Controles.LabelPro labelPro5;
        private Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch2;
        private Bunifu.Framework.UI.BunifuSlider bunifuSlider2;
        private Controles.LabelPro labelPro3;
        private Controles.LabelPro labelPro1;
        private Controles.LabelPro labelPro2;
        private Controles.DropDownPro cbTheme;
        private Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch1;
        public Bunifu.Framework.UI.BunifuThinButton2 bnFinalize;
    }
}
