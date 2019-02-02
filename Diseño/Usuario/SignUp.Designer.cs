namespace DiseñoControles.Usuario
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.lbLogin = new DiseñoControles.Controles.LabelPro();
            this.pnlPersonalInformation = new System.Windows.Forms.Panel();
            this.txFirstName = new DiseñoControles.Controles.TextBoxValide();
            this.txSecondName = new DiseñoControles.Controles.TextBoxValide();
            this.txSurname = new DiseñoControles.Controles.TextBoxValide();
            this.txSecondSurname = new DiseñoControles.Controles.TextBoxValide();
            this.cbGender = new DiseñoControles.Controles.DropDownPro();
            this.cbDocumentType = new DiseñoControles.Controles.DropDownPro();
            this.txDocumenNumber = new DiseñoControles.Controles.TextBoxValide();
            this.dtBirthday = new DiseñoControles.Controles.DateTimePro();
            this.bnNextPersonalInfo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbDescription = new DiseñoControles.Controles.LabelPro();
            this.Animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlContactInformation = new System.Windows.Forms.Panel();
            this.cbDepartament = new DiseñoControles.Controles.DropDownPro();
            this.txCity = new DiseñoControles.Controles.TextBoxValide();
            this.txComune = new DiseñoControles.Controles.TextBoxValide();
            this.txResidence = new DiseñoControles.Controles.TextBoxValide();
            this.txCellphone = new DiseñoControles.Controles.TextBoxValide();
            this.txLandline = new DiseñoControles.Controles.TextBoxValide();
            this.bnNextContactInformation = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bnBackContactInformation = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlUserInformation = new System.Windows.Forms.Panel();
            this.txUser = new DiseñoControles.Controles.TextBoxValide();
            this.txEmail = new DiseñoControles.Controles.TextBoxValide();
            this.cbSecurityQuestion = new DiseñoControles.Controles.DropDownPro();
            this.txAnswer = new DiseñoControles.Controles.TextBoxValide();
            this.txPin = new DiseñoControles.Controles.TextBoxValide();
            this.txPassword = new DiseñoControles.Controles.TextBoxValide();
            this.bnNextUserInformation = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bnBackUserInformation = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlDesignInformation = new System.Windows.Forms.Panel();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.labelPro3 = new DiseñoControles.Controles.LabelPro();
            this.labelPro2 = new DiseñoControles.Controles.LabelPro();
            this.cbTheme = new DiseñoControles.Controles.DropDownPro();
            this.bnFinalize = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bnBackDesign = new Bunifu.Framework.UI.BunifuThinButton2();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.OpenMedia = new System.Windows.Forms.OpenFileDialog();
            this.pnlPersonalInformation.SuspendLayout();
            this.pnlContactInformation.SuspendLayout();
            this.pnlUserInformation.SuspendLayout();
            this.pnlDesignInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.CheckReference = null;
            this.lbLogin.CustomLabelType = DiseñoControles.Controles.LabelType.Custom;
            this.Animator.SetDecoration(this.lbLogin, BunifuAnimatorNS.DecorationType.None);
            this.lbLogin.EnabledTransitions = true;
            this.lbLogin.Font = new System.Drawing.Font("Segoe UI Light", 26F);
            this.lbLogin.ForColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.lbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.lbLogin.Link = "";
            this.lbLogin.Location = new System.Drawing.Point(17, 18);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(132, 47);
            this.lbLogin.SizeTag = new System.Drawing.Size(0, 0);
            this.lbLogin.Style = DiseñoControles.Controles.LabelStyle.Over;
            this.lbLogin.TabIndex = 5;
            this.lbLogin.Text = "Sign up";
            // 
            // pnlPersonalInformation
            // 
            this.pnlPersonalInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlPersonalInformation.AutoScroll = true;
            this.pnlPersonalInformation.Controls.Add(this.txFirstName);
            this.pnlPersonalInformation.Controls.Add(this.txSecondName);
            this.pnlPersonalInformation.Controls.Add(this.txSurname);
            this.pnlPersonalInformation.Controls.Add(this.txSecondSurname);
            this.pnlPersonalInformation.Controls.Add(this.cbGender);
            this.pnlPersonalInformation.Controls.Add(this.cbDocumentType);
            this.pnlPersonalInformation.Controls.Add(this.txDocumenNumber);
            this.pnlPersonalInformation.Controls.Add(this.dtBirthday);
            this.pnlPersonalInformation.Controls.Add(this.bnNextPersonalInfo);
            this.Animator.SetDecoration(this.pnlPersonalInformation, BunifuAnimatorNS.DecorationType.None);
            this.pnlPersonalInformation.Location = new System.Drawing.Point(0, 92);
            this.pnlPersonalInformation.Name = "pnlPersonalInformation";
            this.pnlPersonalInformation.Size = new System.Drawing.Size(400, 308);
            this.pnlPersonalInformation.TabIndex = 14;
            this.pnlPersonalInformation.Tag = "Personal Information";
            this.pnlPersonalInformation.VisibleChanged += new System.EventHandler(this.pnlPersonalInformation_VisibleChanged);
            // 
            // txFirstName
            // 
            this.txFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.txFirstName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txFirstName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.txFirstName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txFirstName.BorderThickness = 3;
            this.txFirstName.CampoObligatorio = true;
            this.txFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Animator.SetDecoration(this.txFirstName, BunifuAnimatorNS.DecorationType.None);
            this.txFirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txFirstName.isPassword = false;
            this.txFirstName.Location = new System.Drawing.Point(37, 13);
            this.txFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txFirstName.MaxLength = ((uint)(40u));
            this.txFirstName.MinimLengtth = ((uint)(3u));
            this.txFirstName.Name = "txFirstName";
            this.txFirstName.OverText = "First name";
            this.txFirstName.PermEspacios = false;
            this.txFirstName.Size = new System.Drawing.Size(155, 29);
            this.txFirstName.TabIndex = 20;
            this.txFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txFirstName.TextBoxCompare = null;
            this.txFirstName.TextCompare = "";
            this.txFirstName.Underline = true;
            this.txFirstName.Validacion = DiseñoControles.Controles.ValidatingType.Letras;
            this.txFirstName.UserGo += new DiseñoControles.Controles.TextBoxValide.UserGoDelegate(this.bnNext_Click);
            // 
            // txSecondName
            // 
            this.txSecondName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.txSecondName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txSecondName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.txSecondName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txSecondName.BorderThickness = 3;
            this.txSecondName.CampoObligatorio = false;
            this.txSecondName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Animator.SetDecoration(this.txSecondName, BunifuAnimatorNS.DecorationType.None);
            this.txSecondName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txSecondName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txSecondName.isPassword = false;
            this.txSecondName.Location = new System.Drawing.Point(198, 13);
            this.txSecondName.Margin = new System.Windows.Forms.Padding(4);
            this.txSecondName.MaxLength = ((uint)(40u));
            this.txSecondName.MinimLengtth = ((uint)(3u));
            this.txSecondName.Name = "txSecondName";
            this.txSecondName.OverText = "Second name";
            this.txSecondName.PermEspacios = false;
            this.txSecondName.Size = new System.Drawing.Size(155, 29);
            this.txSecondName.TabIndex = 23;
            this.txSecondName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txSecondName.TextBoxCompare = null;
            this.txSecondName.TextCompare = "";
            this.txSecondName.Underline = true;
            this.txSecondName.Validacion = DiseñoControles.Controles.ValidatingType.Letras;
            this.txSecondName.UserGo += new DiseñoControles.Controles.TextBoxValide.UserGoDelegate(this.bnNext_Click);
            // 
            // txSurname
            // 
            this.txSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.txSurname.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txSurname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.txSurname.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txSurname.BorderThickness = 3;
            this.txSurname.CampoObligatorio = true;
            this.txSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Animator.SetDecoration(this.txSurname, BunifuAnimatorNS.DecorationType.None);
            this.txSurname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txSurname.isPassword = false;
            this.txSurname.Location = new System.Drawing.Point(37, 60);
            this.txSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txSurname.MaxLength = ((uint)(40u));
            this.txSurname.MinimLengtth = ((uint)(3u));
            this.txSurname.Name = "txSurname";
            this.txSurname.OverText = "Surname";
            this.txSurname.PermEspacios = false;
            this.txSurname.Size = new System.Drawing.Size(155, 29);
            this.txSurname.TabIndex = 24;
            this.txSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txSurname.TextBoxCompare = null;
            this.txSurname.TextCompare = "";
            this.txSurname.Underline = true;
            this.txSurname.Validacion = DiseñoControles.Controles.ValidatingType.Letras;
            this.txSurname.UserGo += new DiseñoControles.Controles.TextBoxValide.UserGoDelegate(this.bnNext_Click);
            // 
            // txSecondSurname
            // 
            this.txSecondSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.txSecondSurname.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txSecondSurname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.txSecondSurname.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txSecondSurname.BorderThickness = 3;
            this.txSecondSurname.CampoObligatorio = false;
            this.txSecondSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Animator.SetDecoration(this.txSecondSurname, BunifuAnimatorNS.DecorationType.None);
            this.txSecondSurname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txSecondSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txSecondSurname.isPassword = false;
            this.txSecondSurname.Location = new System.Drawing.Point(198, 60);
            this.txSecondSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txSecondSurname.MaxLength = ((uint)(40u));
            this.txSecondSurname.MinimLengtth = ((uint)(3u));
            this.txSecondSurname.Name = "txSecondSurname";
            this.txSecondSurname.OverText = "Second surname";
            this.txSecondSurname.PermEspacios = false;
            this.txSecondSurname.Size = new System.Drawing.Size(155, 29);
            this.txSecondSurname.TabIndex = 25;
            this.txSecondSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txSecondSurname.TextBoxCompare = null;
            this.txSecondSurname.TextCompare = "";
            this.txSecondSurname.Underline = true;
            this.txSecondSurname.Validacion = DiseñoControles.Controles.ValidatingType.Letras;
            this.txSecondSurname.UserGo += new DiseñoControles.Controles.TextBoxValide.UserGoDelegate(this.bnNext_Click);
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.Color.Transparent;
            this.cbGender.BorderRadius = 3;
            this.cbGender.CampoObligatorio = true;
            this.Animator.SetDecoration(this.cbGender, BunifuAnimatorNS.DecorationType.None);
            this.cbGender.ForeColor = System.Drawing.Color.White;
            this.cbGender.Items = new string[] {
        "Gender*",
        "Male",
        "Female",
        "Other"};
            this.cbGender.Location = new System.Drawing.Point(37, 107);
            this.cbGender.Name = "cbGender";
            this.cbGender.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.cbGender.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.cbGender.selectedIndex = 0;
            this.cbGender.Size = new System.Drawing.Size(155, 29);
            this.cbGender.TabIndex = 38;
            this.cbGender.Visible = false;
            // 
            // cbDocumentType
            // 
            this.cbDocumentType.BackColor = System.Drawing.Color.Transparent;
            this.cbDocumentType.BorderRadius = 3;
            this.cbDocumentType.CampoObligatorio = true;
            this.Animator.SetDecoration(this.cbDocumentType, BunifuAnimatorNS.DecorationType.None);
            this.cbDocumentType.ForeColor = System.Drawing.Color.White;
            this.cbDocumentType.Items = new string[] {
        "Document type*",
        "C.C",
        "T.I"};
            this.cbDocumentType.Location = new System.Drawing.Point(198, 107);
            this.cbDocumentType.Name = "cbDocumentType";
            this.cbDocumentType.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.cbDocumentType.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.cbDocumentType.selectedIndex = 0;
            this.cbDocumentType.Size = new System.Drawing.Size(155, 29);
            this.cbDocumentType.TabIndex = 39;
            this.cbDocumentType.Visible = false;
            // 
            // txDocumenNumber
            // 
            this.txDocumenNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.txDocumenNumber.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txDocumenNumber.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.txDocumenNumber.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txDocumenNumber.BorderThickness = 3;
            this.txDocumenNumber.CampoObligatorio = true;
            this.txDocumenNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Animator.SetDecoration(this.txDocumenNumber, BunifuAnimatorNS.DecorationType.None);
            this.txDocumenNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txDocumenNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txDocumenNumber.isPassword = false;
            this.txDocumenNumber.Location = new System.Drawing.Point(37, 143);
            this.txDocumenNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txDocumenNumber.MaxLength = ((uint)(20u));
            this.txDocumenNumber.MinimLengtth = ((uint)(5u));
            this.txDocumenNumber.Name = "txDocumenNumber";
            this.txDocumenNumber.OverText = "Document number";
            this.txDocumenNumber.PermEspacios = true;
            this.txDocumenNumber.Size = new System.Drawing.Size(316, 29);
            this.txDocumenNumber.TabIndex = 33;
            this.txDocumenNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txDocumenNumber.TextBoxCompare = null;
            this.txDocumenNumber.TextCompare = "";
            this.txDocumenNumber.Underline = true;
            this.txDocumenNumber.Validacion = DiseñoControles.Controles.ValidatingType.NumeroEntero;
            this.txDocumenNumber.UserGo += new DiseñoControles.Controles.TextBoxValide.UserGoDelegate(this.bnNext_Click);
            // 
            // dtBirthday
            // 
            this.dtBirthday.BackColor = System.Drawing.Color.SeaGreen;
            this.dtBirthday.BorderRadius = 0;
            this.dtBirthday.CampoObligatorio = true;
            this.Animator.SetDecoration(this.dtBirthday, BunifuAnimatorNS.DecorationType.None);
            this.dtBirthday.ForeColor = System.Drawing.Color.White;
            this.dtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtBirthday.FormatCustom = null;
            this.dtBirthday.Location = new System.Drawing.Point(37, 192);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.OverText = "Birthdate";
            this.dtBirthday.Size = new System.Drawing.Size(316, 36);
            this.dtBirthday.TabIndex = 37;
            this.toolTip1.SetToolTip(this.dtBirthday, "Birthdate");
            this.dtBirthday.Validacion = DiseñoControles.Controles.ValidatingDateType.FechaMenorQue;
            this.dtBirthday.Value = new System.DateTime(1999, 1, 1, 19, 53, 0, 0);
            this.dtBirthday.ValueCompare = new System.DateTime(1002, 1, 1, 0, 0, 0, 0);
            this.dtBirthday.Visible = false;
            // 
            // bnNextPersonalInfo
            // 
            this.bnNextPersonalInfo.ActiveBorderThickness = 1;
            this.bnNextPersonalInfo.ActiveCornerRadius = 20;
            this.bnNextPersonalInfo.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bnNextPersonalInfo.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bnNextPersonalInfo.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bnNextPersonalInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnNextPersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.bnNextPersonalInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnNextPersonalInfo.BackgroundImage")));
            this.bnNextPersonalInfo.ButtonText = "Next";
            this.bnNextPersonalInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animator.SetDecoration(this.bnNextPersonalInfo, BunifuAnimatorNS.DecorationType.None);
            this.bnNextPersonalInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnNextPersonalInfo.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnNextPersonalInfo.IdleBorderThickness = 1;
            this.bnNextPersonalInfo.IdleCornerRadius = 20;
            this.bnNextPersonalInfo.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.bnNextPersonalInfo.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.bnNextPersonalInfo.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bnNextPersonalInfo.Location = new System.Drawing.Point(258, 246);
            this.bnNextPersonalInfo.Margin = new System.Windows.Forms.Padding(5);
            this.bnNextPersonalInfo.Name = "bnNextPersonalInfo";
            this.bnNextPersonalInfo.Size = new System.Drawing.Size(101, 43);
            this.bnNextPersonalInfo.TabIndex = 35;
            this.bnNextPersonalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnNextPersonalInfo.Click += new System.EventHandler(this.bnNext_Click);
            // 
            // lbDescription
            // 
            this.lbDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDescription.AutoSize = true;
            this.lbDescription.CheckReference = null;
            this.lbDescription.CustomLabelType = DiseñoControles.Controles.LabelType.Custom;
            this.Animator.SetDecoration(this.lbDescription, BunifuAnimatorNS.DecorationType.None);
            this.lbDescription.EnabledTransitions = true;
            this.lbDescription.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lbDescription.ForColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.lbDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.lbDescription.Link = "";
            this.lbDescription.Location = new System.Drawing.Point(36, 65);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(148, 21);
            this.lbDescription.SizeTag = new System.Drawing.Size(0, 0);
            this.lbDescription.Style = DiseñoControles.Controles.LabelStyle.Opaque;
            this.lbDescription.TabIndex = 17;
            this.lbDescription.Text = "Personal Information";
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
            // pnlContactInformation
            // 
            this.pnlContactInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlContactInformation.AutoScroll = true;
            this.pnlContactInformation.Controls.Add(this.cbDepartament);
            this.pnlContactInformation.Controls.Add(this.txCity);
            this.pnlContactInformation.Controls.Add(this.txComune);
            this.pnlContactInformation.Controls.Add(this.txResidence);
            this.pnlContactInformation.Controls.Add(this.txCellphone);
            this.pnlContactInformation.Controls.Add(this.txLandline);
            this.pnlContactInformation.Controls.Add(this.bnNextContactInformation);
            this.pnlContactInformation.Controls.Add(this.bnBackContactInformation);
            this.Animator.SetDecoration(this.pnlContactInformation, BunifuAnimatorNS.DecorationType.None);
            this.pnlContactInformation.Location = new System.Drawing.Point(0, 92);
            this.pnlContactInformation.Name = "pnlContactInformation";
            this.pnlContactInformation.Size = new System.Drawing.Size(400, 308);
            this.pnlContactInformation.TabIndex = 18;
            this.pnlContactInformation.Tag = "Contact information";
            this.pnlContactInformation.Visible = false;
            this.pnlContactInformation.VisibleChanged += new System.EventHandler(this.pnlPersonalInformation_VisibleChanged);
            // 
            // cbDepartament
            // 
            this.cbDepartament.BackColor = System.Drawing.Color.Transparent;
            this.cbDepartament.BorderRadius = 3;
            this.cbDepartament.CampoObligatorio = true;
            this.Animator.SetDecoration(this.cbDepartament, BunifuAnimatorNS.DecorationType.None);
            this.cbDepartament.ForeColor = System.Drawing.Color.White;
            this.cbDepartament.Items = new string[] {
        "Department*",
        "Bogotá.D.C",
        "Tolima"};
            this.cbDepartament.Location = new System.Drawing.Point(35, 13);
            this.cbDepartament.Name = "cbDepartament";
            this.cbDepartament.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.cbDepartament.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.cbDepartament.selectedIndex = 0;
            this.cbDepartament.Size = new System.Drawing.Size(318, 29);
            this.cbDepartament.TabIndex = 38;
            this.cbDepartament.Visible = false;
            // 
            // txCity
            // 
            this.txCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.txCity.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txCity.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.txCity.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txCity.BorderThickness = 3;
            this.txCity.CampoObligatorio = true;
            this.txCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Animator.SetDecoration(this.txCity, BunifuAnimatorNS.DecorationType.None);
            this.txCity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txCity.isPassword = false;
            this.txCity.Location = new System.Drawing.Point(37, 60);
            this.txCity.Margin = new System.Windows.Forms.Padding(4);
            this.txCity.MaxLength = ((uint)(40u));
            this.txCity.MinimLengtth = ((uint)(3u));
            this.txCity.Name = "txCity";
            this.txCity.OverText = "City";
            this.txCity.PermEspacios = false;
            this.txCity.Size = new System.Drawing.Size(155, 29);
            this.txCity.TabIndex = 39;
            this.txCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txCity.TextBoxCompare = null;
            this.txCity.TextCompare = "";
            this.txCity.Underline = true;
            this.txCity.Validacion = DiseñoControles.Controles.ValidatingType.Letras;
            this.txCity.UserGo += new DiseñoControles.Controles.TextBoxValide.UserGoDelegate(this.bnNextContact_Click);
            // 
            // txComune
            // 
            this.txComune.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.txComune.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txComune.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.txComune.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txComune.BorderThickness = 3;
            this.txComune.CampoObligatorio = true;
            this.txComune.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Animator.SetDecoration(this.txComune, BunifuAnimatorNS.DecorationType.None);
            this.txComune.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txComune.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txComune.isPassword = false;
            this.txComune.Location = new System.Drawing.Point(200, 60);
            this.txComune.Margin = new System.Windows.Forms.Padding(4);
            this.txComune.MaxLength = ((uint)(40u));
            this.txComune.MinimLengtth = ((uint)(3u));
            this.txComune.Name = "txComune";
            this.txComune.OverText = "Comune";
            this.txComune.PermEspacios = false;
            this.txComune.Size = new System.Drawing.Size(155, 29);
            this.txComune.TabIndex = 40;
            this.txComune.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txComune.TextBoxCompare = null;
            this.txComune.TextCompare = "";
            this.txComune.Underline = true;
            this.txComune.Validacion = DiseñoControles.Controles.ValidatingType.Ninguna;
            this.txComune.UserGo += new DiseñoControles.Controles.TextBoxValide.UserGoDelegate(this.bnNextContact_Click);
            // 
            // txResidence
            // 
            this.txResidence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.txResidence.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txResidence.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.txResidence.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txResidence.BorderThickness = 3;
            this.txResidence.CampoObligatorio = true;
            this.txResidence.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Animator.SetDecoration(this.txResidence, BunifuAnimatorNS.DecorationType.None);
            this.txResidence.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txResidence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txResidence.isPassword = false;
            this.txResidence.Location = new System.Drawing.Point(37, 116);
            this.txResidence.Margin = new System.Windows.Forms.Padding(4);
            this.txResidence.MaxLength = ((uint)(40u));
            this.txResidence.MinimLengtth = ((uint)(3u));
            this.txResidence.Name = "txResidence";
            this.txResidence.OverText = "Residence address";
            this.txResidence.PermEspacios = false;
            this.txResidence.Size = new System.Drawing.Size(316, 29);
            this.txResidence.TabIndex = 20;
            this.txResidence.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txResidence.TextBoxCompare = null;
            this.txResidence.TextCompare = "";
            this.txResidence.Underline = true;
            this.txResidence.Validacion = DiseñoControles.Controles.ValidatingType.Ninguna;
            this.txResidence.UserGo += new DiseñoControles.Controles.TextBoxValide.UserGoDelegate(this.bnNextContact_Click);
            // 
            // txCellphone
            // 
            this.txCellphone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.txCellphone.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txCellphone.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.txCellphone.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txCellphone.BorderThickness = 3;
            this.txCellphone.CampoObligatorio = true;
            this.txCellphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Animator.SetDecoration(this.txCellphone, BunifuAnimatorNS.DecorationType.None);
            this.txCellphone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txCellphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txCellphone.isPassword = false;
            this.txCellphone.Location = new System.Drawing.Point(37, 170);
            this.txCellphone.Margin = new System.Windows.Forms.Padding(4);
            this.txCellphone.MaxLength = ((uint)(10u));
            this.txCellphone.MinimLengtth = ((uint)(10u));
            this.txCellphone.Name = "txCellphone";
            this.txCellphone.OverText = "Cell phone";
            this.txCellphone.PermEspacios = false;
            this.txCellphone.Size = new System.Drawing.Size(155, 29);
            this.txCellphone.TabIndex = 24;
            this.txCellphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txCellphone.TextBoxCompare = null;
            this.txCellphone.TextCompare = "";
            this.txCellphone.Underline = true;
            this.txCellphone.Validacion = DiseñoControles.Controles.ValidatingType.TelefonoMovil;
            this.txCellphone.UserGo += new DiseñoControles.Controles.TextBoxValide.UserGoDelegate(this.bnNextContact_Click);
            // 
            // txLandline
            // 
            this.txLandline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.txLandline.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txLandline.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.txLandline.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txLandline.BorderThickness = 3;
            this.txLandline.CampoObligatorio = true;
            this.txLandline.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Animator.SetDecoration(this.txLandline, BunifuAnimatorNS.DecorationType.None);
            this.txLandline.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txLandline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txLandline.isPassword = false;
            this.txLandline.Location = new System.Drawing.Point(200, 170);
            this.txLandline.Margin = new System.Windows.Forms.Padding(4);
            this.txLandline.MaxLength = ((uint)(7u));
            this.txLandline.MinimLengtth = ((uint)(7u));
            this.txLandline.Name = "txLandline";
            this.txLandline.OverText = "Landline";
            this.txLandline.PermEspacios = true;
            this.txLandline.Size = new System.Drawing.Size(155, 29);
            this.txLandline.TabIndex = 33;
            this.txLandline.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txLandline.TextBoxCompare = null;
            this.txLandline.TextCompare = "";
            this.txLandline.Underline = true;
            this.txLandline.Validacion = DiseñoControles.Controles.ValidatingType.TelefonoFijo;
            this.txLandline.UserGo += new DiseñoControles.Controles.TextBoxValide.UserGoDelegate(this.bnNextContact_Click);
            // 
            // bnNextContactInformation
            // 
            this.bnNextContactInformation.ActiveBorderThickness = 1;
            this.bnNextContactInformation.ActiveCornerRadius = 20;
            this.bnNextContactInformation.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bnNextContactInformation.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bnNextContactInformation.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bnNextContactInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnNextContactInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.bnNextContactInformation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnNextContactInformation.BackgroundImage")));
            this.bnNextContactInformation.ButtonText = "Next";
            this.bnNextContactInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animator.SetDecoration(this.bnNextContactInformation, BunifuAnimatorNS.DecorationType.None);
            this.bnNextContactInformation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnNextContactInformation.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnNextContactInformation.IdleBorderThickness = 1;
            this.bnNextContactInformation.IdleCornerRadius = 20;
            this.bnNextContactInformation.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.bnNextContactInformation.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.bnNextContactInformation.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bnNextContactInformation.Location = new System.Drawing.Point(258, 246);
            this.bnNextContactInformation.Margin = new System.Windows.Forms.Padding(5);
            this.bnNextContactInformation.Name = "bnNextContactInformation";
            this.bnNextContactInformation.Size = new System.Drawing.Size(101, 43);
            this.bnNextContactInformation.TabIndex = 35;
            this.bnNextContactInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnNextContactInformation.Click += new System.EventHandler(this.bnNextContact_Click);
            // 
            // bnBackContactInformation
            // 
            this.bnBackContactInformation.ActiveBorderThickness = 1;
            this.bnBackContactInformation.ActiveCornerRadius = 20;
            this.bnBackContactInformation.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.bnBackContactInformation.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bnBackContactInformation.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.bnBackContactInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.bnBackContactInformation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnBackContactInformation.BackgroundImage")));
            this.bnBackContactInformation.ButtonText = "Back";
            this.bnBackContactInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animator.SetDecoration(this.bnBackContactInformation, BunifuAnimatorNS.DecorationType.None);
            this.bnBackContactInformation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnBackContactInformation.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnBackContactInformation.IdleBorderThickness = 1;
            this.bnBackContactInformation.IdleCornerRadius = 20;
            this.bnBackContactInformation.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.bnBackContactInformation.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.bnBackContactInformation.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.bnBackContactInformation.Location = new System.Drawing.Point(37, 246);
            this.bnBackContactInformation.Margin = new System.Windows.Forms.Padding(5);
            this.bnBackContactInformation.Name = "bnBackContactInformation";
            this.bnBackContactInformation.Size = new System.Drawing.Size(101, 43);
            this.bnBackContactInformation.TabIndex = 18;
            this.bnBackContactInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnBackContactInformation.Click += new System.EventHandler(this.bnBackContactInformation_Click);
            // 
            // pnlUserInformation
            // 
            this.pnlUserInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlUserInformation.AutoScroll = true;
            this.pnlUserInformation.Controls.Add(this.txUser);
            this.pnlUserInformation.Controls.Add(this.txEmail);
            this.pnlUserInformation.Controls.Add(this.cbSecurityQuestion);
            this.pnlUserInformation.Controls.Add(this.txAnswer);
            this.pnlUserInformation.Controls.Add(this.txPin);
            this.pnlUserInformation.Controls.Add(this.txPassword);
            this.pnlUserInformation.Controls.Add(this.bnNextUserInformation);
            this.pnlUserInformation.Controls.Add(this.bnBackUserInformation);
            this.Animator.SetDecoration(this.pnlUserInformation, BunifuAnimatorNS.DecorationType.None);
            this.pnlUserInformation.Location = new System.Drawing.Point(0, 92);
            this.pnlUserInformation.Name = "pnlUserInformation";
            this.pnlUserInformation.Size = new System.Drawing.Size(400, 308);
            this.pnlUserInformation.TabIndex = 19;
            this.pnlUserInformation.Tag = "User information";
            this.pnlUserInformation.Visible = false;
            this.pnlUserInformation.VisibleChanged += new System.EventHandler(this.pnlPersonalInformation_VisibleChanged);
            // 
            // txUser
            // 
            this.txUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.txUser.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txUser.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.txUser.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txUser.BorderThickness = 3;
            this.txUser.CampoObligatorio = true;
            this.txUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Animator.SetDecoration(this.txUser, BunifuAnimatorNS.DecorationType.None);
            this.txUser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txUser.isPassword = false;
            this.txUser.Location = new System.Drawing.Point(37, 13);
            this.txUser.Margin = new System.Windows.Forms.Padding(4);
            this.txUser.MaxLength = ((uint)(15u));
            this.txUser.MinimLengtth = ((uint)(4u));
            this.txUser.Name = "txUser";
            this.txUser.OverText = "User";
            this.txUser.PermEspacios = false;
            this.txUser.Size = new System.Drawing.Size(155, 29);
            this.txUser.TabIndex = 39;
            this.txUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txUser.TextBoxCompare = null;
            this.txUser.TextCompare = "";
            this.txUser.Underline = true;
            this.txUser.Validacion = DiseñoControles.Controles.ValidatingType.User;
            this.txUser.UserGo += new DiseñoControles.Controles.TextBoxValide.UserGoDelegate(this.bnNextUserInformation_Click);
            // 
            // txEmail
            // 
            this.txEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.txEmail.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.txEmail.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txEmail.BorderThickness = 3;
            this.txEmail.CampoObligatorio = true;
            this.txEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Animator.SetDecoration(this.txEmail, BunifuAnimatorNS.DecorationType.None);
            this.txEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txEmail.isPassword = false;
            this.txEmail.Location = new System.Drawing.Point(198, 13);
            this.txEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txEmail.MaxLength = ((uint)(40u));
            this.txEmail.MinimLengtth = ((uint)(3u));
            this.txEmail.Name = "txEmail";
            this.txEmail.OverText = "Email";
            this.txEmail.PermEspacios = false;
            this.txEmail.Size = new System.Drawing.Size(155, 29);
            this.txEmail.TabIndex = 40;
            this.txEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txEmail.TextBoxCompare = null;
            this.txEmail.TextCompare = "";
            this.txEmail.Underline = true;
            this.txEmail.Validacion = DiseñoControles.Controles.ValidatingType.Correo;
            this.txEmail.UserGo += new DiseñoControles.Controles.TextBoxValide.UserGoDelegate(this.bnNextUserInformation_Click);
            // 
            // cbSecurityQuestion
            // 
            this.cbSecurityQuestion.BackColor = System.Drawing.Color.Transparent;
            this.cbSecurityQuestion.BorderRadius = 3;
            this.cbSecurityQuestion.CampoObligatorio = true;
            this.Animator.SetDecoration(this.cbSecurityQuestion, BunifuAnimatorNS.DecorationType.None);
            this.cbSecurityQuestion.ForeColor = System.Drawing.Color.White;
            this.cbSecurityQuestion.Items = new string[] {
        "Security question",
        "What is your favorite color?"};
            this.cbSecurityQuestion.Location = new System.Drawing.Point(37, 66);
            this.cbSecurityQuestion.Name = "cbSecurityQuestion";
            this.cbSecurityQuestion.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.cbSecurityQuestion.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.cbSecurityQuestion.selectedIndex = 0;
            this.cbSecurityQuestion.Size = new System.Drawing.Size(318, 35);
            this.cbSecurityQuestion.TabIndex = 41;
            // 
            // txAnswer
            // 
            this.txAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.txAnswer.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txAnswer.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.txAnswer.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txAnswer.BorderThickness = 3;
            this.txAnswer.CampoObligatorio = true;
            this.txAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Animator.SetDecoration(this.txAnswer, BunifuAnimatorNS.DecorationType.None);
            this.txAnswer.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txAnswer.isPassword = false;
            this.txAnswer.Location = new System.Drawing.Point(37, 116);
            this.txAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.txAnswer.MaxLength = ((uint)(50u));
            this.txAnswer.MinimLengtth = ((uint)(1u));
            this.txAnswer.Name = "txAnswer";
            this.txAnswer.OverText = "Answer";
            this.txAnswer.PermEspacios = true;
            this.txAnswer.Size = new System.Drawing.Size(316, 29);
            this.txAnswer.TabIndex = 42;
            this.txAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txAnswer.TextBoxCompare = null;
            this.txAnswer.TextCompare = "";
            this.txAnswer.Underline = true;
            this.txAnswer.Validacion = DiseñoControles.Controles.ValidatingType.Ninguna;
            this.txAnswer.UserGo += new DiseñoControles.Controles.TextBoxValide.UserGoDelegate(this.bnNextUserInformation_Click);
            // 
            // txPin
            // 
            this.txPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.txPin.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txPin.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.txPin.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txPin.BorderThickness = 3;
            this.txPin.CampoObligatorio = true;
            this.txPin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Animator.SetDecoration(this.txPin, BunifuAnimatorNS.DecorationType.None);
            this.txPin.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txPin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txPin.isPassword = true;
            this.txPin.Location = new System.Drawing.Point(37, 170);
            this.txPin.Margin = new System.Windows.Forms.Padding(4);
            this.txPin.MaxLength = ((uint)(4u));
            this.txPin.MinimLengtth = ((uint)(4u));
            this.txPin.Name = "txPin";
            this.txPin.OverText = "PIN";
            this.txPin.PermEspacios = false;
            this.txPin.Size = new System.Drawing.Size(155, 29);
            this.txPin.TabIndex = 24;
            this.txPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txPin.TextBoxCompare = null;
            this.txPin.TextCompare = "";
            this.txPin.Underline = true;
            this.txPin.Validacion = DiseñoControles.Controles.ValidatingType.NumeroEntero;
            this.txPin.UserGo += new DiseñoControles.Controles.TextBoxValide.UserGoDelegate(this.bnNextUserInformation_Click);
            // 
            // txPassword
            // 
            this.txPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.txPassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.txPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txPassword.BorderThickness = 3;
            this.txPassword.CampoObligatorio = true;
            this.txPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Animator.SetDecoration(this.txPassword, BunifuAnimatorNS.DecorationType.None);
            this.txPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txPassword.isPassword = true;
            this.txPassword.Location = new System.Drawing.Point(200, 170);
            this.txPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txPassword.MaxLength = ((uint)(15u));
            this.txPassword.MinimLengtth = ((uint)(7u));
            this.txPassword.Name = "txPassword";
            this.txPassword.OverText = "Password";
            this.txPassword.PermEspacios = false;
            this.txPassword.Size = new System.Drawing.Size(155, 29);
            this.txPassword.TabIndex = 33;
            this.txPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txPassword.TextBoxCompare = null;
            this.txPassword.TextCompare = "";
            this.txPassword.Underline = true;
            this.txPassword.Validacion = DiseñoControles.Controles.ValidatingType.Ninguna;
            this.txPassword.UserGo += new DiseñoControles.Controles.TextBoxValide.UserGoDelegate(this.bnNextUserInformation_Click);
            // 
            // bnNextUserInformation
            // 
            this.bnNextUserInformation.ActiveBorderThickness = 1;
            this.bnNextUserInformation.ActiveCornerRadius = 20;
            this.bnNextUserInformation.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bnNextUserInformation.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bnNextUserInformation.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bnNextUserInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnNextUserInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.bnNextUserInformation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnNextUserInformation.BackgroundImage")));
            this.bnNextUserInformation.ButtonText = "Next";
            this.bnNextUserInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animator.SetDecoration(this.bnNextUserInformation, BunifuAnimatorNS.DecorationType.None);
            this.bnNextUserInformation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnNextUserInformation.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnNextUserInformation.IdleBorderThickness = 1;
            this.bnNextUserInformation.IdleCornerRadius = 20;
            this.bnNextUserInformation.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.bnNextUserInformation.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.bnNextUserInformation.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bnNextUserInformation.Location = new System.Drawing.Point(258, 246);
            this.bnNextUserInformation.Margin = new System.Windows.Forms.Padding(5);
            this.bnNextUserInformation.Name = "bnNextUserInformation";
            this.bnNextUserInformation.Size = new System.Drawing.Size(101, 43);
            this.bnNextUserInformation.TabIndex = 35;
            this.bnNextUserInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnNextUserInformation.Click += new System.EventHandler(this.bnNextUserInformation_Click);
            // 
            // bnBackUserInformation
            // 
            this.bnBackUserInformation.ActiveBorderThickness = 1;
            this.bnBackUserInformation.ActiveCornerRadius = 20;
            this.bnBackUserInformation.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.bnBackUserInformation.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bnBackUserInformation.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.bnBackUserInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.bnBackUserInformation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnBackUserInformation.BackgroundImage")));
            this.bnBackUserInformation.ButtonText = "Back";
            this.bnBackUserInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animator.SetDecoration(this.bnBackUserInformation, BunifuAnimatorNS.DecorationType.None);
            this.bnBackUserInformation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnBackUserInformation.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnBackUserInformation.IdleBorderThickness = 1;
            this.bnBackUserInformation.IdleCornerRadius = 20;
            this.bnBackUserInformation.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.bnBackUserInformation.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.bnBackUserInformation.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.bnBackUserInformation.Location = new System.Drawing.Point(37, 246);
            this.bnBackUserInformation.Margin = new System.Windows.Forms.Padding(5);
            this.bnBackUserInformation.Name = "bnBackUserInformation";
            this.bnBackUserInformation.Size = new System.Drawing.Size(101, 43);
            this.bnBackUserInformation.TabIndex = 18;
            this.bnBackUserInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnBackUserInformation.Click += new System.EventHandler(this.bnBackUserInformation_Click);
            // 
            // pnlDesignInformation
            // 
            this.pnlDesignInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlDesignInformation.AutoScroll = true;
            this.pnlDesignInformation.Controls.Add(this.pbPicture);
            this.pnlDesignInformation.Controls.Add(this.labelPro3);
            this.pnlDesignInformation.Controls.Add(this.labelPro2);
            this.pnlDesignInformation.Controls.Add(this.cbTheme);
            this.pnlDesignInformation.Controls.Add(this.bnFinalize);
            this.pnlDesignInformation.Controls.Add(this.bnBackDesign);
            this.Animator.SetDecoration(this.pnlDesignInformation, BunifuAnimatorNS.DecorationType.None);
            this.pnlDesignInformation.Location = new System.Drawing.Point(0, 92);
            this.pnlDesignInformation.Name = "pnlDesignInformation";
            this.pnlDesignInformation.Size = new System.Drawing.Size(400, 308);
            this.pnlDesignInformation.TabIndex = 20;
            this.pnlDesignInformation.Tag = "Design information";
            this.pnlDesignInformation.Visible = false;
            // 
            // pbPicture
            // 
            this.pbPicture.AllowDrop = true;
            this.pbPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Animator.SetDecoration(this.pbPicture, BunifuAnimatorNS.DecorationType.None);
            this.pbPicture.Image = global::DiseñoControles.Properties.Resources.user;
            this.pbPicture.Location = new System.Drawing.Point(145, 35);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(110, 110);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPicture.TabIndex = 41;
            this.pbPicture.TabStop = false;
            this.toolTip1.SetToolTip(this.pbPicture, "Click or drag an photo");
            this.pbPicture.Click += new System.EventHandler(this.pbPicture_Click);
            this.pbPicture.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbPicture_DragDrop);
            this.pbPicture.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbPicture_DragEnter);
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
            this.labelPro3.Location = new System.Drawing.Point(151, 12);
            this.labelPro3.Name = "labelPro3";
            this.labelPro3.Size = new System.Drawing.Size(98, 20);
            this.labelPro3.SizeTag = new System.Drawing.Size(0, 0);
            this.labelPro3.Style = DiseñoControles.Controles.LabelStyle.Opaque;
            this.labelPro3.TabIndex = 40;
            this.labelPro3.Text = "Profile picture";
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
            this.labelPro2.Location = new System.Drawing.Point(36, 161);
            this.labelPro2.Name = "labelPro2";
            this.labelPro2.Size = new System.Drawing.Size(54, 20);
            this.labelPro2.SizeTag = new System.Drawing.Size(0, 0);
            this.labelPro2.Style = DiseñoControles.Controles.LabelStyle.Opaque;
            this.labelPro2.TabIndex = 39;
            this.labelPro2.Text = "Theme";
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
            this.cbTheme.Location = new System.Drawing.Point(40, 184);
            this.cbTheme.Name = "cbTheme";
            this.cbTheme.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.cbTheme.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.cbTheme.selectedIndex = 0;
            this.cbTheme.Size = new System.Drawing.Size(315, 35);
            this.cbTheme.TabIndex = 38;
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
            this.bnFinalize.ButtonText = "Finalize";
            this.bnFinalize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animator.SetDecoration(this.bnFinalize, BunifuAnimatorNS.DecorationType.None);
            this.bnFinalize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnFinalize.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnFinalize.IdleBorderThickness = 1;
            this.bnFinalize.IdleCornerRadius = 20;
            this.bnFinalize.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.bnFinalize.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.bnFinalize.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bnFinalize.Location = new System.Drawing.Point(252, 246);
            this.bnFinalize.Margin = new System.Windows.Forms.Padding(5);
            this.bnFinalize.Name = "bnFinalize";
            this.bnFinalize.Size = new System.Drawing.Size(101, 43);
            this.bnFinalize.TabIndex = 35;
            this.bnFinalize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnFinalize.Click += new System.EventHandler(this.bnFinalize_Click);
            // 
            // bnBackDesign
            // 
            this.bnBackDesign.ActiveBorderThickness = 1;
            this.bnBackDesign.ActiveCornerRadius = 20;
            this.bnBackDesign.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.bnBackDesign.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bnBackDesign.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.bnBackDesign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.bnBackDesign.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnBackDesign.BackgroundImage")));
            this.bnBackDesign.ButtonText = "Back";
            this.bnBackDesign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animator.SetDecoration(this.bnBackDesign, BunifuAnimatorNS.DecorationType.None);
            this.bnBackDesign.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnBackDesign.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnBackDesign.IdleBorderThickness = 1;
            this.bnBackDesign.IdleCornerRadius = 20;
            this.bnBackDesign.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.bnBackDesign.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.bnBackDesign.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.bnBackDesign.Location = new System.Drawing.Point(37, 246);
            this.bnBackDesign.Margin = new System.Windows.Forms.Padding(5);
            this.bnBackDesign.Name = "bnBackDesign";
            this.bnBackDesign.Size = new System.Drawing.Size(101, 43);
            this.bnBackDesign.TabIndex = 18;
            this.bnBackDesign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnBackDesign.Click += new System.EventHandler(this.bnBackDesign_Click);
            // 
            // OpenMedia
            // 
            this.OpenMedia.FileName = "openFileDialog1";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.pnlPersonalInformation);
            this.Controls.Add(this.pnlDesignInformation);
            this.Controls.Add(this.pnlUserInformation);
            this.Controls.Add(this.pnlContactInformation);
            this.Animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "SignUp";
            this.Size = new System.Drawing.Size(400, 400);
            this.VisibleChanged += new System.EventHandler(this.SignUp_VisibleChanged);
            this.pnlPersonalInformation.ResumeLayout(false);
            this.pnlContactInformation.ResumeLayout(false);
            this.pnlUserInformation.ResumeLayout(false);
            this.pnlDesignInformation.ResumeLayout(false);
            this.pnlDesignInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controles.LabelPro lbLogin;
        private System.Windows.Forms.Panel pnlPersonalInformation;
        private Controles.LabelPro lbDescription;
        private BunifuAnimatorNS.BunifuTransition Animator;
        private System.Windows.Forms.ToolTip toolTip1;
        private Controles.TextBoxValide txSecondSurname;
        private Controles.TextBoxValide txSurname;
        private Controles.TextBoxValide txSecondName;
        private Controles.TextBoxValide txFirstName;
        private Controles.TextBoxValide txDocumenNumber;
        public Bunifu.Framework.UI.BunifuThinButton2 bnNextPersonalInfo;
        private Controles.DateTimePro dtBirthday;
        private Controles.DropDownPro cbDocumentType;
        private Controles.DropDownPro cbGender;
        private System.Windows.Forms.Panel pnlContactInformation;
        private Controles.TextBoxValide txResidence;
        private Controles.TextBoxValide txCellphone;
        private Controles.TextBoxValide txLandline;
        private Controles.DropDownPro cbDepartament;
        public Bunifu.Framework.UI.BunifuThinButton2 bnNextContactInformation;
        public Bunifu.Framework.UI.BunifuThinButton2 bnBackContactInformation;
        private Controles.TextBoxValide txComune;
        private Controles.TextBoxValide txCity;
        private System.Windows.Forms.Panel pnlUserInformation;
        private Controles.TextBoxValide txUser;
        private Controles.TextBoxValide txEmail;
        private Controles.TextBoxValide txPin;
        private Controles.TextBoxValide txPassword;
        public Bunifu.Framework.UI.BunifuThinButton2 bnNextUserInformation;
        public Bunifu.Framework.UI.BunifuThinButton2 bnBackUserInformation;
        private Controles.DropDownPro cbSecurityQuestion;
        private Controles.TextBoxValide txAnswer;
        private System.Windows.Forms.Panel pnlDesignInformation;
        public Bunifu.Framework.UI.BunifuThinButton2 bnFinalize;
        public Bunifu.Framework.UI.BunifuThinButton2 bnBackDesign;
        private Controles.DropDownPro cbTheme;
        private Controles.LabelPro labelPro3;
        private Controles.LabelPro labelPro2;
        public System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.OpenFileDialog OpenMedia;
    }
}
