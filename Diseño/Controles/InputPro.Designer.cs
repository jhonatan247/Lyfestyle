namespace DiseñoControles.Controles
{
    partial class InputPro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputPro));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.bnOk = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnCancel = new Bunifu.Framework.UI.BunifuImageButton();
            this.header1 = new DiseñoControles.Usuario.Header();
            this.txInput = new DiseñoControles.Controles.TextBoxValide();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlButtons.Controls.Add(this.bnOk);
            this.pnlButtons.Controls.Add(this.bnCancel);
            this.pnlButtons.Location = new System.Drawing.Point(12, 89);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(258, 25);
            this.pnlButtons.TabIndex = 5;
            // 
            // bnOk
            // 
            this.bnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnOk.BackColor = System.Drawing.Color.Transparent;
            this.bnOk.Image = global::DiseñoControles.Properties.Resources.Checkmark_black;
            this.bnOk.ImageActive = null;
            this.bnOk.Location = new System.Drawing.Point(231, 0);
            this.bnOk.Name = "bnOk";
            this.bnOk.Size = new System.Drawing.Size(27, 25);
            this.bnOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnOk.TabIndex = 6;
            this.bnOk.TabStop = false;
            this.bnOk.Zoom = 15;
            this.bnOk.Click += new System.EventHandler(this.bnOk_Click);
            // 
            // bnCancel
            // 
            this.bnCancel.BackColor = System.Drawing.Color.Transparent;
            this.bnCancel.Image = global::DiseñoControles.Properties.Resources.Cancel_2_black;
            this.bnCancel.ImageActive = null;
            this.bnCancel.Location = new System.Drawing.Point(0, 0);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(27, 25);
            this.bnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnCancel.TabIndex = 4;
            this.bnCancel.TabStop = false;
            this.bnCancel.Zoom = 15;
            this.bnCancel.Click += new System.EventHandler(this.bnCancel_Click);
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(213)))));
            this.header1.CompanyTitle = "LifeStyle";
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.EnabledHour = false;
            this.header1.EnabledTransitions = true;
            this.header1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.header1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.header1.FormTitle = "Input";
            this.header1.HeaderButtonAbout = false;
            this.header1.HeaderButtonBack = false;
            this.header1.HeaderButtonExit = true;
            this.header1.HeaderButtonHide = false;
            this.header1.HeaderButtonHome = false;
            this.header1.HeaderButtonMaxim = false;
            this.header1.HeaderButtonMinim = false;
            this.header1.HeaderIcon = ((System.Drawing.Image)(resources.GetObject("header1.HeaderIcon")));
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(279, 22);
            this.header1.TabIndex = 4;
            this.header1.TimeStepAnimation = 0.01F;
            this.header1.TrayIcon = ((System.Drawing.Icon)(resources.GetObject("header1.TrayIcon")));
            this.header1.TypeLabelAnimation = BunifuAnimatorNS.AnimationType.HorizSlide;
            // 
            // txInput
            // 
            this.txInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txInput.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txInput.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txInput.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txInput.BorderThickness = 3;
            this.txInput.CampoObligatorio = true;
            this.txInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txInput.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.txInput.isPassword = false;
            this.txInput.Location = new System.Drawing.Point(20, 33);
            this.txInput.Margin = new System.Windows.Forms.Padding(4);
            this.txInput.MaxLength = ((uint)(2000u));
            this.txInput.MinimLengtth = ((uint)(0u));
            this.txInput.Name = "txInput";
            this.txInput.OverText = "Value";
            this.txInput.PermEspacios = true;
            this.txInput.Size = new System.Drawing.Size(238, 44);
            this.txInput.TabIndex = 6;
            this.txInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txInput.TextBoxCompare = null;
            this.txInput.TextCompare = "";
            this.txInput.Underline = true;
            this.txInput.Validacion = DiseñoControles.Controles.ValidatingType.Ninguna;
            // 
            // InputPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(279, 119);
            this.Controls.Add(this.txInput);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.header1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputPro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input";
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnCancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlButtons;
        private Bunifu.Framework.UI.BunifuImageButton bnOk;
        private Bunifu.Framework.UI.BunifuImageButton bnCancel;
        private Usuario.Header header1;
        private TextBoxValide txInput;
    }
}