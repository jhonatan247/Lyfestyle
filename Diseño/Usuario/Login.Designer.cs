namespace DiseñoControles.Usuario
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbLogin = new DiseñoControles.Controles.LabelPro();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lbCreateOne = new DiseñoControles.Controles.LabelPro();
            this.lbMoreOpt = new DiseñoControles.Controles.LabelPro();
            this.chRecordar = new Bunifu.Framework.UI.BunifuCheckbox();
            this.ctxMoreOptions = new DiseñoControles.Controles.ContextMenuPro();
            this.tsmForgetUsername = new DiseñoControles.Controles.ToolStripMenuItemPro();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemPro2 = new DiseñoControles.Controles.ToolStripMenuItemPro();
            this.DropDownOn2 = new DiseñoControles.Controles.ContextMenuPro();
            this.toolStripMenuItemPro3 = new DiseñoControles.Controles.ToolStripMenuItemPro();
            this.toolStripMenuItemPro4 = new DiseñoControles.Controles.ToolStripMenuItemPro();
            this.bnContinue = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txUsuario = new DiseñoControles.Controles.TextBoxValide();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.lbForgot = new DiseñoControles.Controles.LabelPro();
            this.bnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnSignIn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txContraseña = new DiseñoControles.Controles.TextBoxValide();
            this.lbRecordar = new DiseñoControles.Controles.LabelPro();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.Animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.ctxMoreOptions.SuspendLayout();
            this.DropDownOn2.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
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
            this.lbLogin.Size = new System.Drawing.Size(114, 54);
            this.lbLogin.SizeTag = new System.Drawing.Size(0, 0);
            this.lbLogin.Style = DiseñoControles.Controles.LabelStyle.Over;
            this.lbLogin.TabIndex = 5;
            this.lbLogin.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlPassword);
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
            this.pnlUser.Controls.Add(this.lbLogin);
            this.pnlUser.Controls.Add(this.lbCreateOne);
            this.pnlUser.Controls.Add(this.lbMoreOpt);
            this.pnlUser.Controls.Add(this.bnContinue);
            this.pnlUser.Controls.Add(this.txUsuario);
            this.Animator.SetDecoration(this.pnlUser, BunifuAnimatorNS.DecorationType.None);
            this.pnlUser.Location = new System.Drawing.Point(38, 19);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(325, 354);
            this.pnlUser.TabIndex = 14;
            // 
            // lbCreateOne
            // 
            this.lbCreateOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCreateOne.CheckReference = null;
            this.lbCreateOne.CustomLabelType = DiseñoControles.Controles.LabelType.Custom;
            this.Animator.SetDecoration(this.lbCreateOne, BunifuAnimatorNS.DecorationType.None);
            this.lbCreateOne.EnabledTransitions = true;
            this.lbCreateOne.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreateOne.ForColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.lbCreateOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.lbCreateOne.Link = "";
            this.lbCreateOne.Location = new System.Drawing.Point(20, 59);
            this.lbCreateOne.Name = "lbCreateOne";
            this.lbCreateOne.Size = new System.Drawing.Size(285, 52);
            this.lbCreateOne.SizeTag = new System.Drawing.Size(0, 0);
            this.lbCreateOne.Style = DiseñoControles.Controles.LabelStyle.Opaque;
            this.lbCreateOne.TabIndex = 17;
            this.lbCreateOne.Text = "Enter and discover everything that Lifestyle has for you\r\n";
            // 
            // lbMoreOpt
            // 
            this.lbMoreOpt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbMoreOpt.AutoSize = true;
            this.lbMoreOpt.CheckReference = this.chRecordar;
            this.lbMoreOpt.ContextMenuStrip = this.ctxMoreOptions;
            this.lbMoreOpt.CustomLabelType = DiseñoControles.Controles.LabelType.ContextMenu;
            this.Animator.SetDecoration(this.lbMoreOpt, BunifuAnimatorNS.DecorationType.None);
            this.lbMoreOpt.EnabledTransitions = false;
            this.lbMoreOpt.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.lbMoreOpt.ForColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.lbMoreOpt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.lbMoreOpt.Link = "";
            this.lbMoreOpt.Location = new System.Drawing.Point(35, 297);
            this.lbMoreOpt.Name = "lbMoreOpt";
            this.lbMoreOpt.Size = new System.Drawing.Size(91, 20);
            this.lbMoreOpt.SizeTag = new System.Drawing.Size(0, 0);
            this.lbMoreOpt.Style = DiseñoControles.Controles.LabelStyle.Link;
            this.lbMoreOpt.TabIndex = 16;
            this.lbMoreOpt.Text = "More options";
            // 
            // chRecordar
            // 
            this.chRecordar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chRecordar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chRecordar.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chRecordar.Checked = false;
            this.chRecordar.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.Animator.SetDecoration(this.chRecordar, BunifuAnimatorNS.DecorationType.None);
            this.chRecordar.ForeColor = System.Drawing.Color.White;
            this.chRecordar.Location = new System.Drawing.Point(15, 242);
            this.chRecordar.Name = "chRecordar";
            this.chRecordar.Size = new System.Drawing.Size(20, 20);
            this.chRecordar.TabIndex = 13;
            // 
            // ctxMoreOptions
            // 
            this.ctxMoreOptions.AutoSize = false;
            this.ctxMoreOptions.BackColor = System.Drawing.Color.White;
            this.Animator.SetDecoration(this.ctxMoreOptions, BunifuAnimatorNS.DecorationType.None);
            this.ctxMoreOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmForgetUsername,
            this.toolStripSeparator1,
            this.toolStripMenuItemPro2});
            this.ctxMoreOptions.Name = "contextMenuPro1";
            this.ctxMoreOptions.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ctxMoreOptions.ShowItemToolTips = false;
            this.ctxMoreOptions.Size = new System.Drawing.Size(260, 90);
            this.ctxMoreOptions.Text = "¿Olvidaste tu contraseña?";
            // 
            // tsmForgetUsername
            // 
            this.tsmForgetUsername.AutoSize = false;
            this.tsmForgetUsername.BackColor = System.Drawing.Color.White;
            this.tsmForgetUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmForgetUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.tsmForgetUsername.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
            this.tsmForgetUsername.Name = "tsmForgetUsername";
            this.tsmForgetUsername.ShortcutKeyDisplayString = "";
            this.tsmForgetUsername.Size = new System.Drawing.Size(260, 40);
            this.tsmForgetUsername.Text = "Did you forget your username?";
            this.tsmForgetUsername.Click += new System.EventHandler(this.toolStripMenuItemPro1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(256, 6);
            // 
            // toolStripMenuItemPro2
            // 
            this.toolStripMenuItemPro2.AutoSize = false;
            this.toolStripMenuItemPro2.BackColor = System.Drawing.Color.White;
            this.toolStripMenuItemPro2.DropDown = this.DropDownOn2;
            this.toolStripMenuItemPro2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemPro2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.toolStripMenuItemPro2.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItemPro2.Name = "toolStripMenuItemPro2";
            this.toolStripMenuItemPro2.ShortcutKeyDisplayString = "";
            this.toolStripMenuItemPro2.Size = new System.Drawing.Size(260, 40);
            this.toolStripMenuItemPro2.Text = "You do not have an account?";
            // 
            // DropDownOn2
            // 
            this.DropDownOn2.AutoSize = false;
            this.DropDownOn2.BackColor = System.Drawing.Color.White;
            this.Animator.SetDecoration(this.DropDownOn2, BunifuAnimatorNS.DecorationType.None);
            this.DropDownOn2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemPro3,
            this.toolStripMenuItemPro4});
            this.DropDownOn2.Name = "DropDownOn2";
            this.DropDownOn2.OwnerItem = this.toolStripMenuItemPro2;
            this.DropDownOn2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.DropDownOn2.ShowItemToolTips = false;
            this.DropDownOn2.Size = new System.Drawing.Size(200, 65);
            // 
            // toolStripMenuItemPro3
            // 
            this.toolStripMenuItemPro3.AutoSize = false;
            this.toolStripMenuItemPro3.BackColor = System.Drawing.Color.White;
            this.toolStripMenuItemPro3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemPro3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.toolStripMenuItemPro3.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItemPro3.Name = "toolStripMenuItemPro3";
            this.toolStripMenuItemPro3.ShortcutKeyDisplayString = "";
            this.toolStripMenuItemPro3.Size = new System.Drawing.Size(200, 30);
            this.toolStripMenuItemPro3.Text = "Sign up now";
            this.toolStripMenuItemPro3.Click += new System.EventHandler(this.toolStripMenuItemPro3_Click);
            // 
            // toolStripMenuItemPro4
            // 
            this.toolStripMenuItemPro4.AutoSize = false;
            this.toolStripMenuItemPro4.BackColor = System.Drawing.Color.White;
            this.toolStripMenuItemPro4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemPro4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.toolStripMenuItemPro4.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItemPro4.Name = "toolStripMenuItemPro4";
            this.toolStripMenuItemPro4.ShortcutKeyDisplayString = "";
            this.toolStripMenuItemPro4.Size = new System.Drawing.Size(200, 30);
            this.toolStripMenuItemPro4.Text = "Go to home page";
            this.toolStripMenuItemPro4.Click += new System.EventHandler(this.toolStripMenuItemPro4_Click);
            // 
            // bnContinue
            // 
            this.bnContinue.ActiveBorderThickness = 1;
            this.bnContinue.ActiveCornerRadius = 40;
            this.bnContinue.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bnContinue.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bnContinue.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bnContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.bnContinue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnContinue.BackgroundImage")));
            this.bnContinue.ButtonText = "Continue";
            this.bnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animator.SetDecoration(this.bnContinue, BunifuAnimatorNS.DecorationType.None);
            this.bnContinue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnContinue.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnContinue.IdleBorderThickness = 1;
            this.bnContinue.IdleCornerRadius = 20;
            this.bnContinue.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.bnContinue.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.bnContinue.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bnContinue.Location = new System.Drawing.Point(189, 282);
            this.bnContinue.Margin = new System.Windows.Forms.Padding(5);
            this.bnContinue.Name = "bnContinue";
            this.bnContinue.Size = new System.Drawing.Size(116, 49);
            this.bnContinue.TabIndex = 7;
            this.bnContinue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnContinue.Click += new System.EventHandler(this.bnContinue_Click);
            // 
            // txUsuario
            // 
            this.txUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.txUsuario.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txUsuario.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.txUsuario.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txUsuario.BorderThickness = 3;
            this.txUsuario.CampoObligatorio = true;
            this.txUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Animator.SetDecoration(this.txUsuario, BunifuAnimatorNS.DecorationType.None);
            this.txUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txUsuario.isPassword = false;
            this.txUsuario.Location = new System.Drawing.Point(24, 166);
            this.txUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txUsuario.MaxLength = ((uint)(2000u));
            this.txUsuario.MinimLengtth = ((uint)(0u));
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.OverText = "User or Email";
            this.txUsuario.PermEspacios = true;
            this.txUsuario.Size = new System.Drawing.Size(281, 44);
            this.txUsuario.TabIndex = 15;
            this.txUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txUsuario.TextBoxCompare = null;
            this.txUsuario.TextCompare = "";
            this.txUsuario.Underline = true;
            this.txUsuario.Validacion = DiseñoControles.Controles.ValidatingType.Ninguna;
            this.txUsuario.UserGo += new DiseñoControles.Controles.TextBoxValide.UserGoDelegate(this.bnContinue_Click);
            // 
            // pnlPassword
            // 
            this.pnlPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPassword.Controls.Add(this.lbForgot);
            this.pnlPassword.Controls.Add(this.bnBack);
            this.pnlPassword.Controls.Add(this.bnSignIn);
            this.pnlPassword.Controls.Add(this.txContraseña);
            this.pnlPassword.Controls.Add(this.lbRecordar);
            this.pnlPassword.Controls.Add(this.chRecordar);
            this.pnlPassword.Controls.Add(this.pbPicture);
            this.Animator.SetDecoration(this.pnlPassword, BunifuAnimatorNS.DecorationType.None);
            this.pnlPassword.Location = new System.Drawing.Point(38, 19);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(325, 354);
            this.pnlPassword.TabIndex = 13;
            this.pnlPassword.Visible = false;
            // 
            // lbForgot
            // 
            this.lbForgot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbForgot.AutoSize = true;
            this.lbForgot.CheckReference = null;
            this.lbForgot.CustomLabelType = DiseñoControles.Controles.LabelType.TextOnly;
            this.Animator.SetDecoration(this.lbForgot, BunifuAnimatorNS.DecorationType.None);
            this.lbForgot.EnabledTransitions = true;
            this.lbForgot.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForgot.ForColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.lbForgot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.lbForgot.Link = "";
            this.lbForgot.Location = new System.Drawing.Point(12, 314);
            this.lbForgot.Name = "lbForgot";
            this.lbForgot.Size = new System.Drawing.Size(137, 17);
            this.lbForgot.SizeTag = new System.Drawing.Size(0, 0);
            this.lbForgot.Style = DiseñoControles.Controles.LabelStyle.Link;
            this.lbForgot.TabIndex = 18;
            this.lbForgot.Text = "¿Forgot your password?";
            // 
            // bnBack
            // 
            this.bnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnBack.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.bnBack, BunifuAnimatorNS.DecorationType.None);
            this.bnBack.Image = global::DiseñoControles.Properties.Resources.Back_50px;
            this.bnBack.ImageActive = null;
            this.bnBack.Location = new System.Drawing.Point(15, 14);
            this.bnBack.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bnBack.Name = "bnBack";
            this.bnBack.Size = new System.Drawing.Size(50, 50);
            this.bnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnBack.TabIndex = 17;
            this.bnBack.TabStop = false;
            this.toolTip1.SetToolTip(this.bnBack, "To return");
            this.bnBack.Zoom = 20;
            this.bnBack.Click += new System.EventHandler(this.bnBack_Click);
            // 
            // bnSignIn
            // 
            this.bnSignIn.ActiveBorderThickness = 1;
            this.bnSignIn.ActiveCornerRadius = 40;
            this.bnSignIn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bnSignIn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bnSignIn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bnSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.bnSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnSignIn.BackgroundImage")));
            this.bnSignIn.ButtonText = "Sign in";
            this.bnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animator.SetDecoration(this.bnSignIn, BunifuAnimatorNS.DecorationType.None);
            this.bnSignIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnSignIn.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnSignIn.IdleBorderThickness = 1;
            this.bnSignIn.IdleCornerRadius = 20;
            this.bnSignIn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.bnSignIn.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.bnSignIn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bnSignIn.Location = new System.Drawing.Point(189, 297);
            this.bnSignIn.Margin = new System.Windows.Forms.Padding(5);
            this.bnSignIn.Name = "bnSignIn";
            this.bnSignIn.Size = new System.Drawing.Size(122, 49);
            this.bnSignIn.TabIndex = 16;
            this.bnSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnSignIn.Click += new System.EventHandler(this.bnSignIn_Click);
            // 
            // txContraseña
            // 
            this.txContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.txContraseña.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txContraseña.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.txContraseña.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txContraseña.BorderThickness = 3;
            this.txContraseña.CampoObligatorio = true;
            this.txContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Animator.SetDecoration(this.txContraseña, BunifuAnimatorNS.DecorationType.None);
            this.txContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txContraseña.isPassword = true;
            this.txContraseña.Location = new System.Drawing.Point(15, 188);
            this.txContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txContraseña.MaxLength = ((uint)(20u));
            this.txContraseña.MinimLengtth = ((uint)(4u));
            this.txContraseña.Name = "txContraseña";
            this.txContraseña.OverText = "Password";
            this.txContraseña.PermEspacios = true;
            this.txContraseña.Size = new System.Drawing.Size(295, 44);
            this.txContraseña.TabIndex = 15;
            this.txContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txContraseña.TextBoxCompare = null;
            this.txContraseña.TextCompare = "";
            this.txContraseña.Underline = true;
            this.txContraseña.Validacion = DiseñoControles.Controles.ValidatingType.Ninguna;
            this.txContraseña.UserGo += new DiseñoControles.Controles.TextBoxValide.UserGoDelegate(this.bnSignIn_Click);
            // 
            // lbRecordar
            // 
            this.lbRecordar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRecordar.AutoSize = true;
            this.lbRecordar.BackColor = System.Drawing.Color.Transparent;
            this.lbRecordar.CheckReference = this.chRecordar;
            this.lbRecordar.CustomLabelType = DiseñoControles.Controles.LabelType.CheckBx;
            this.Animator.SetDecoration(this.lbRecordar, BunifuAnimatorNS.DecorationType.None);
            this.lbRecordar.EnabledTransitions = true;
            this.lbRecordar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordar.ForColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.lbRecordar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.lbRecordar.Link = "";
            this.lbRecordar.Location = new System.Drawing.Point(36, 242);
            this.lbRecordar.Name = "lbRecordar";
            this.lbRecordar.Size = new System.Drawing.Size(104, 17);
            this.lbRecordar.SizeTag = new System.Drawing.Size(0, 0);
            this.lbRecordar.Style = DiseñoControles.Controles.LabelStyle.Opaque;
            this.lbRecordar.TabIndex = 14;
            this.lbRecordar.Text = "Remember me";
            // 
            // pbPicture
            // 
            this.pbPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Animator.SetDecoration(this.pbPicture, BunifuAnimatorNS.DecorationType.None);
            this.pbPicture.Image = global::DiseñoControles.Properties.Resources.user;
            this.pbPicture.Location = new System.Drawing.Point(109, 71);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(106, 104);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPicture.TabIndex = 11;
            this.pbPicture.TabStop = false;
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
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.panel1);
            this.Animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(400, 400);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.VisibleChanged += new System.EventHandler(this.Login_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.ctxMoreOptions.ResumeLayout(false);
            this.DropDownOn2.ResumeLayout(false);
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Controles.LabelPro lbLogin;
        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuThinButton2 bnContinue;
        private System.Windows.Forms.Panel pnlUser;
        public Controles.TextBoxValide txUsuario;
        private System.Windows.Forms.Panel pnlPassword;
        public Controles.TextBoxValide txContraseña;
        public Controles.LabelPro lbRecordar;
        public Bunifu.Framework.UI.BunifuCheckbox chRecordar;
        public System.Windows.Forms.PictureBox pbPicture;
        public Bunifu.Framework.UI.BunifuThinButton2 bnSignIn;
        private Controles.LabelPro lbMoreOpt;
        private Controles.LabelPro lbForgot;
        private Bunifu.Framework.UI.BunifuImageButton bnBack;
        private Controles.LabelPro lbCreateOne;
        private BunifuAnimatorNS.BunifuTransition Animator;
        private System.Windows.Forms.ToolTip toolTip1;
        private Controles.ContextMenuPro ctxMoreOptions;
        private Controles.ToolStripMenuItemPro tsmForgetUsername;
        private Controles.ToolStripMenuItemPro toolStripMenuItemPro2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Controles.ContextMenuPro DropDownOn2;
        private Controles.ToolStripMenuItemPro toolStripMenuItemPro3;
        private Controles.ToolStripMenuItemPro toolStripMenuItemPro4;
    }
}
