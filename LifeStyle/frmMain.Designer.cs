using LifeStyle.Properties;
namespace LifeStyle
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tooltMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMain1 = new DiseñoControles.Usuario.PanelMain();
            this.Animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.header = new DiseñoControles.Usuario.Header();
            this.Carga = new DiseñoControles.Usuario.Espera1();
            this.pnlContMenu = new System.Windows.Forms.Panel();
            this.userSettings1 = new DiseñoControles.Usuario.UserSettings();
            this.tools1 = new DiseñoControles.Usuario.Tools();
            this.login1 = new DiseñoControles.Usuario.Login();
            this.signUp1 = new DiseñoControles.Usuario.SignUp();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.tLoader = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.pnlContMenu.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelMain1);
            this.Animator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 402);
            this.panel1.TabIndex = 4;
            // 
            // panelMain1
            // 
            this.panelMain1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(52)))), ((int)(((byte)(91)))));
            this.Animator.SetDecoration(this.panelMain1, BunifuAnimatorNS.DecorationType.None);
            this.panelMain1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain1.FormParent = null;
            this.panelMain1.Location = new System.Drawing.Point(0, 0);
            this.panelMain1.Name = "panelMain1";
            this.panelMain1.Size = new System.Drawing.Size(270, 402);
            this.panelMain1.TabIndex = 0;
            this.panelMain1.TimeStepAnimation = 0.02F;
            this.panelMain1.LoginClick += new DiseñoControles.Usuario.PanelMain.LoginClickDelegate(this.panelMain1_LoginClick);
            this.panelMain1.SignUpClick += new DiseñoControles.Usuario.PanelMain.SignUpClickDelegate(this.panelMain1_SignUpClick);
            this.panelMain1.ToolsClick += new DiseñoControles.Usuario.PanelMain.ToolsClickDelegate(this.panelMain1_ToolsClick);
            this.panelMain1.SettingsClick += new DiseñoControles.Usuario.PanelMain.SettingsClickDelegate(this.panelMain1_SettingsClick);
            this.panelMain1.SizeChanged += new System.EventHandler(this.panelMain1_SizeChanged);
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
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.header.CompanyTitle = "Lifestyle";
            this.Animator.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.EnabledHour = true;
            this.header.EnabledTransitions = false;
            this.header.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.FormTitle = "Login Admin";
            this.header.HeaderButtonAbout = true;
            this.header.HeaderButtonBack = false;
            this.header.HeaderButtonExit = true;
            this.header.HeaderButtonHide = true;
            this.header.HeaderButtonHome = true;
            this.header.HeaderButtonMaxim = false;
            this.header.HeaderButtonMinim = true;
            this.header.HeaderIcon = ((System.Drawing.Image)(resources.GetObject("header.HeaderIcon")));
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(670, 38);
            this.header.TabIndex = 7;
            this.header.TimeStepAnimation = 0.01F;
            this.header.TrayIcon = ((System.Drawing.Icon)(resources.GetObject("header.TrayIcon")));
            this.header.TypeLabelAnimation = BunifuAnimatorNS.AnimationType.Leaf;
            this.header.Visible = false;
            // 
            // Carga
            // 
            this.Carga.BackColor = System.Drawing.Color.Black;
            this.Animator.SetDecoration(this.Carga, BunifuAnimatorNS.DecorationType.None);
            this.Carga.Location = new System.Drawing.Point(0, 0);
            this.Carga.Name = "Carga";
            this.Carga.Size = new System.Drawing.Size(670, 440);
            this.Carga.TabIndex = 8;
            // 
            // pnlContMenu
            // 
            this.pnlContMenu.Controls.Add(this.login1);
            this.pnlContMenu.Controls.Add(this.signUp1);
            this.pnlContMenu.Controls.Add(this.userSettings1);
            this.pnlContMenu.Controls.Add(this.tools1);
            this.Animator.SetDecoration(this.pnlContMenu, BunifuAnimatorNS.DecorationType.None);
            this.pnlContMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlContMenu.Name = "pnlContMenu";
            this.pnlContMenu.Size = new System.Drawing.Size(400, 402);
            this.pnlContMenu.TabIndex = 1;
            this.pnlContMenu.Visible = false;
            // 
            // userSettings1
            // 
            this.userSettings1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.Animator.SetDecoration(this.userSettings1, BunifuAnimatorNS.DecorationType.None);
            this.userSettings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userSettings1.Location = new System.Drawing.Point(0, 0);
            this.userSettings1.MinimumSize = new System.Drawing.Size(400, 400);
            this.userSettings1.Name = "userSettings1";
            this.userSettings1.Size = new System.Drawing.Size(400, 402);
            this.userSettings1.TabIndex = 4;
            this.userSettings1.Visible = false;
            // 
            // tools1
            // 
            this.tools1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.Animator.SetDecoration(this.tools1, BunifuAnimatorNS.DecorationType.None);
            this.tools1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tools1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.tools1.Location = new System.Drawing.Point(0, 0);
            this.tools1.Name = "tools1";
            this.tools1.Size = new System.Drawing.Size(400, 402);
            this.tools1.TabIndex = 3;
            this.tools1.Visible = false;
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.Animator.SetDecoration(this.login1, BunifuAnimatorNS.DecorationType.None);
            this.login1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login1.Location = new System.Drawing.Point(0, 0);
            this.login1.MinimumSize = new System.Drawing.Size(400, 400);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(400, 402);
            this.login1.TabIndex = 1;
            this.login1.SignUpClick += new DiseñoControles.Usuario.Login.SignUpClickDelegate(this.panelMain1_SignUpClick);
            this.login1.GoToHomeClick += new DiseñoControles.Usuario.Login.GoToHomeClickDelegate(this.login1_GoToHomeClick);
            this.login1.AutoValidateChanged += new System.EventHandler(this.login1_AutoValidateChanged);
            this.login1.VisibleChanged += new System.EventHandler(this.login1_VisibleChanged);
            // 
            // signUp1
            // 
            this.signUp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.Animator.SetDecoration(this.signUp1, BunifuAnimatorNS.DecorationType.None);
            this.signUp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signUp1.Location = new System.Drawing.Point(0, 0);
            this.signUp1.MinimumSize = new System.Drawing.Size(400, 400);
            this.signUp1.Name = "signUp1";
            this.signUp1.Size = new System.Drawing.Size(400, 402);
            this.signUp1.TabIndex = 2;
            this.signUp1.Visible = false;
            this.signUp1.UserSignUp += new DiseñoControles.Usuario.SignUp.UserSignUpDelegate(this.panelMain1_LoginClick);
            this.signUp1.AutoValidateChanged += new System.EventHandler(this.signUp1_Validated);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.pnlContMenu);
            this.Animator.SetDecoration(this.pnlContenedor, BunifuAnimatorNS.DecorationType.None);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(270, 38);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(400, 402);
            this.pnlContenedor.TabIndex = 9;
            // 
            // tLoader
            // 
            this.tLoader.Interval = 1500;
            this.tLoader.Tick += new System.EventHandler(this.tLoader_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(670, 440);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.Carga);
            this.Animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MetroForm";
            this.panel1.ResumeLayout(false);
            this.pnlContMenu.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ToolTip tooltMensaje;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tLoader;
        private BunifuAnimatorNS.BunifuTransition Animator;
        private DiseñoControles.Usuario.PanelMain panelMain1;
        private DiseñoControles.Usuario.Header header;
        private DiseñoControles.Usuario.Espera1 Carga;
        private System.Windows.Forms.Panel pnlContMenu;
        private DiseñoControles.Usuario.Login login1;
        private System.Windows.Forms.Panel pnlContenedor;
        private DiseñoControles.Usuario.SignUp signUp1;
        private DiseñoControles.Usuario.Tools tools1;
        private DiseñoControles.Usuario.UserSettings userSettings1;
    }
}