namespace DiseñoControles.Usuario
{
    partial class Header
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Header));
            this.toolMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.bnMaxim = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnMinim = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnHide = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnHome = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnAbout = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.lbHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pbHeaderIcon = new System.Windows.Forms.PictureBox();
            this.dragPanel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragPicture = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dragHeader = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.contextMenuPro1 = new DiseñoControles.Controles.ContextMenuPro();
            this.tsmAbrir = new DiseñoControles.Controles.ToolStripMenuItemPro();
            this.tsmSalir = new DiseñoControles.Controles.ToolStripMenuItemPro();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tHora = new System.Windows.Forms.Timer(this.components);
            this.tTransparencia = new System.Windows.Forms.Timer(this.components);
            this.DragLabel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.trayBar = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bnMaxim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnMinim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnExit)).BeginInit();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeaderIcon)).BeginInit();
            this.contextMenuPro1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnMaxim
            // 
            this.bnMaxim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnMaxim.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.bnMaxim, BunifuAnimatorNS.DecorationType.None);
            this.bnMaxim.Image = ((System.Drawing.Image)(resources.GetObject("bnMaxim.Image")));
            this.bnMaxim.ImageActive = global::DiseñoControles.Properties.Resources.Hexagon_64px;
            this.bnMaxim.Location = new System.Drawing.Point(590, 0);
            this.bnMaxim.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bnMaxim.Name = "bnMaxim";
            this.bnMaxim.Size = new System.Drawing.Size(25, 25);
            this.bnMaxim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnMaxim.TabIndex = 7;
            this.bnMaxim.TabStop = false;
            this.toolMensaje.SetToolTip(this.bnMaxim, "Maximize");
            this.bnMaxim.Visible = false;
            this.bnMaxim.Zoom = 0;
            this.bnMaxim.Click += new System.EventHandler(this.bnMaxim_Click);
            // 
            // bnMinim
            // 
            this.bnMinim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnMinim.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.bnMinim, BunifuAnimatorNS.DecorationType.None);
            this.bnMinim.Image = ((System.Drawing.Image)(resources.GetObject("bnMinim.Image")));
            this.bnMinim.ImageActive = global::DiseñoControles.Properties.Resources.Rhombus_64px;
            this.bnMinim.Location = new System.Drawing.Point(565, 0);
            this.bnMinim.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bnMinim.Name = "bnMinim";
            this.bnMinim.Size = new System.Drawing.Size(25, 25);
            this.bnMinim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnMinim.TabIndex = 6;
            this.bnMinim.TabStop = false;
            this.toolMensaje.SetToolTip(this.bnMinim, "Minimize");
            this.bnMinim.Zoom = 0;
            this.bnMinim.Click += new System.EventHandler(this.bnMinim_Click);
            // 
            // bnHide
            // 
            this.bnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnHide.BackColor = System.Drawing.Color.Transparent;
            this.bnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Animator.SetDecoration(this.bnHide, BunifuAnimatorNS.DecorationType.None);
            this.bnHide.Image = ((System.Drawing.Image)(resources.GetObject("bnHide.Image")));
            this.bnHide.ImageActive = global::DiseñoControles.Properties.Resources.Hide_64px;
            this.bnHide.Location = new System.Drawing.Point(540, 0);
            this.bnHide.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bnHide.Name = "bnHide";
            this.bnHide.Size = new System.Drawing.Size(25, 25);
            this.bnHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnHide.TabIndex = 11;
            this.bnHide.TabStop = false;
            this.toolMensaje.SetToolTip(this.bnHide, "Hide");
            this.bnHide.Zoom = 0;
            this.bnHide.Click += new System.EventHandler(this.bnHide_Click);
            // 
            // bnHome
            // 
            this.bnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnHome.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.bnHome, BunifuAnimatorNS.DecorationType.None);
            this.bnHome.Image = ((System.Drawing.Image)(resources.GetObject("bnHome.Image")));
            this.bnHome.ImageActive = global::DiseñoControles.Properties.Resources.Full_Moon_64px;
            this.bnHome.Location = new System.Drawing.Point(515, 0);
            this.bnHome.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bnHome.Name = "bnHome";
            this.bnHome.Size = new System.Drawing.Size(25, 25);
            this.bnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnHome.TabIndex = 8;
            this.bnHome.TabStop = false;
            this.toolMensaje.SetToolTip(this.bnHome, "Home");
            this.bnHome.Zoom = 0;
            this.bnHome.Click += new System.EventHandler(this.bnHome_Click);
            // 
            // bnBack
            // 
            this.bnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnBack.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.bnBack, BunifuAnimatorNS.DecorationType.None);
            this.bnBack.Image = global::DiseñoControles.Properties.Resources.Punto;
            this.bnBack.ImageActive = global::DiseñoControles.Properties.Resources.Triangle_64px;
            this.bnBack.Location = new System.Drawing.Point(490, 0);
            this.bnBack.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bnBack.Name = "bnBack";
            this.bnBack.Size = new System.Drawing.Size(25, 25);
            this.bnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnBack.TabIndex = 9;
            this.bnBack.TabStop = false;
            this.toolMensaje.SetToolTip(this.bnBack, "Go Back");
            this.bnBack.Visible = false;
            this.bnBack.Zoom = 0;
            this.bnBack.Click += new System.EventHandler(this.bnBack_Click);
            // 
            // bnAbout
            // 
            this.bnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnAbout.BackColor = System.Drawing.Color.Transparent;
            this.bnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Animator.SetDecoration(this.bnAbout, BunifuAnimatorNS.DecorationType.None);
            this.bnAbout.Image = ((System.Drawing.Image)(resources.GetObject("bnAbout.Image")));
            this.bnAbout.ImageActive = global::DiseñoControles.Properties.Resources.Star_64px;
            this.bnAbout.Location = new System.Drawing.Point(465, 0);
            this.bnAbout.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bnAbout.Name = "bnAbout";
            this.bnAbout.Size = new System.Drawing.Size(25, 25);
            this.bnAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnAbout.TabIndex = 10;
            this.bnAbout.TabStop = false;
            this.toolMensaje.SetToolTip(this.bnAbout, "About");
            this.bnAbout.Zoom = 0;
            this.bnAbout.Click += new System.EventHandler(this.bnAbout_Click);
            // 
            // bnExit
            // 
            this.bnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnExit.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.bnExit, BunifuAnimatorNS.DecorationType.None);
            this.bnExit.Image = ((System.Drawing.Image)(resources.GetObject("bnExit.Image")));
            this.bnExit.ImageActive = global::DiseñoControles.Properties.Resources.Delete_64px;
            this.bnExit.Location = new System.Drawing.Point(615, 0);
            this.bnExit.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bnExit.Name = "bnExit";
            this.bnExit.Size = new System.Drawing.Size(25, 25);
            this.bnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnExit.TabIndex = 5;
            this.bnExit.TabStop = false;
            this.toolMensaje.SetToolTip(this.bnExit, "Exit");
            this.bnExit.Zoom = 0;
            this.bnExit.Click += new System.EventHandler(this.bnSalir_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedor.Controls.Add(this.bnExit);
            this.pnlContenedor.Controls.Add(this.bnMaxim);
            this.pnlContenedor.Controls.Add(this.bnMinim);
            this.pnlContenedor.Controls.Add(this.bnHide);
            this.pnlContenedor.Controls.Add(this.bnHome);
            this.pnlContenedor.Controls.Add(this.bnBack);
            this.pnlContenedor.Controls.Add(this.bnAbout);
            this.pnlContenedor.Controls.Add(this.lbHeader);
            this.pnlContenedor.Controls.Add(this.pbHeaderIcon);
            this.Animator.SetDecoration(this.pnlContenedor, BunifuAnimatorNS.DecorationType.None);
            this.pnlContenedor.Location = new System.Drawing.Point(15, 7);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(640, 25);
            this.pnlContenedor.TabIndex = 8;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.Animator.SetDecoration(this.lbHeader, BunifuAnimatorNS.DecorationType.None);
            this.lbHeader.ForeColor = System.Drawing.Color.White;
            this.lbHeader.Location = new System.Drawing.Point(19, 0);
            this.lbHeader.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(127, 25);
            this.lbHeader.TabIndex = 3;
            this.lbHeader.Text = "Title -Company";
            this.lbHeader.UseCompatibleTextRendering = true;
            this.lbHeader.Click += new System.EventHandler(this.lbHeader_Click);
            // 
            // pbHeaderIcon
            // 
            this.Animator.SetDecoration(this.pbHeaderIcon, BunifuAnimatorNS.DecorationType.None);
            this.pbHeaderIcon.Image = global::DiseñoControles.Properties.Resources.Play_24px;
            this.pbHeaderIcon.Location = new System.Drawing.Point(0, 2);
            this.pbHeaderIcon.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pbHeaderIcon.Name = "pbHeaderIcon";
            this.pbHeaderIcon.Size = new System.Drawing.Size(20, 20);
            this.pbHeaderIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeaderIcon.TabIndex = 4;
            this.pbHeaderIcon.TabStop = false;
            // 
            // dragPanel
            // 
            this.dragPanel.Fixed = true;
            this.dragPanel.Horizontal = true;
            this.dragPanel.TargetControl = this.pnlContenedor;
            this.dragPanel.Vertical = true;
            // 
            // DragPicture
            // 
            this.DragPicture.Fixed = true;
            this.DragPicture.Horizontal = true;
            this.DragPicture.TargetControl = this.pbHeaderIcon;
            this.DragPicture.Vertical = true;
            // 
            // dragHeader
            // 
            this.dragHeader.Fixed = true;
            this.dragHeader.Horizontal = true;
            this.dragHeader.TargetControl = this;
            this.dragHeader.Vertical = true;
            // 
            // Animator
            // 
            this.Animator.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.Animator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
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
            this.Animator.TimeStep = 0.01F;
            // 
            // contextMenuPro1
            // 
            this.contextMenuPro1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Animator.SetDecoration(this.contextMenuPro1, BunifuAnimatorNS.DecorationType.None);
            this.contextMenuPro1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAbrir,
            this.tsmSalir});
            this.contextMenuPro1.Name = "contextMenuPro1";
            this.contextMenuPro1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuPro1.ShowItemToolTips = false;
            this.contextMenuPro1.Size = new System.Drawing.Size(154, 48);
            // 
            // tsmAbrir
            // 
            this.tsmAbrir.AutoToolTip = true;
            this.tsmAbrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tsmAbrir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmAbrir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsmAbrir.Image = global::DiseñoControles.Properties.Resources.Rhombus_64px;
            this.tsmAbrir.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tsmAbrir.Name = "tsmAbrir";
            this.tsmAbrir.ShortcutKeyDisplayString = "";
            this.tsmAbrir.Size = new System.Drawing.Size(153, 22);
            this.tsmAbrir.Text = "Abrir ventana";
            this.tsmAbrir.Click += new System.EventHandler(this.trayBar_DoubleClick);
            // 
            // tsmSalir
            // 
            this.tsmSalir.AutoToolTip = true;
            this.tsmSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tsmSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmSalir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsmSalir.Image = global::DiseñoControles.Properties.Resources.Exit_24px;
            this.tsmSalir.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.ShortcutKeyDisplayString = "";
            this.tsmSalir.Size = new System.Drawing.Size(153, 22);
            this.tsmSalir.Text = "Salir";
            this.tsmSalir.Click += new System.EventHandler(this.bnSalir_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // tHora
            // 
            this.tHora.Enabled = true;
            this.tHora.Interval = 1000;
            this.tHora.Tick += new System.EventHandler(this.tHora_Tick);
            // 
            // tTransparencia
            // 
            this.tTransparencia.Interval = 10;
            this.tTransparencia.Tick += new System.EventHandler(this.tTransparencia_Tick);
            // 
            // DragLabel
            // 
            this.DragLabel.Fixed = true;
            this.DragLabel.Horizontal = true;
            this.DragLabel.TargetControl = this.lbHeader;
            this.DragLabel.Vertical = true;
            // 
            // trayBar
            // 
            this.trayBar.ContextMenuStrip = this.contextMenuPro1;
            this.trayBar.Icon = global::DiseñoControles.Properties.Resources.Panda;
            this.trayBar.Text = "Title -Company";
            this.trayBar.DoubleClick += new System.EventHandler(this.trayBar_DoubleClick);
            // 
            // Header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.pnlContenedor);
            this.Animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Header";
            this.Size = new System.Drawing.Size(670, 40);
            this.FontChanged += new System.EventHandler(this.Header_FontChanged);
            ((System.ComponentModel.ISupportInitialize)(this.bnMaxim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnMinim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnExit)).EndInit();
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeaderIcon)).EndInit();
            this.contextMenuPro1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bnExit;
        private System.Windows.Forms.PictureBox pbHeaderIcon;
        private Bunifu.Framework.UI.BunifuCustomLabel lbHeader;
        private System.Windows.Forms.ToolTip toolMensaje;
        private Bunifu.Framework.UI.BunifuImageButton bnMinim;
        private Bunifu.Framework.UI.BunifuImageButton bnMaxim;
        private System.Windows.Forms.Panel pnlContenedor;
        private Bunifu.Framework.UI.BunifuDragControl dragPanel;
        private Bunifu.Framework.UI.BunifuDragControl DragPicture;
        private Bunifu.Framework.UI.BunifuDragControl DragLabel;
        private Bunifu.Framework.UI.BunifuImageButton bnAbout;
        private Bunifu.Framework.UI.BunifuImageButton bnBack;
        private Bunifu.Framework.UI.BunifuImageButton bnHome;
        private Bunifu.Framework.UI.BunifuDragControl dragHeader;
        public BunifuAnimatorNS.BunifuTransition Animator;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer tHora;
        private Bunifu.Framework.UI.BunifuImageButton bnHide;
        private System.Windows.Forms.NotifyIcon trayBar;
        private System.Windows.Forms.Timer tTransparencia;
        private Controles.ContextMenuPro contextMenuPro1;
        private Controles.ToolStripMenuItemPro tsmAbrir;
        private Controles.ToolStripMenuItemPro tsmSalir;
    }
}
