namespace DigiFish_application
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overOnsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.digiFishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visInformatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_home = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctbox_homescreen_digiFishLogo = new System.Windows.Forms.PictureBox();
            this.pctbox_digiFish_footer = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_homescreen_digiFishLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_digiFish_footer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.digiFishToolStripMenuItem,
            this.visInformatieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(359, 50);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inloggenToolStripMenuItem,
            this.afsluitenToolStripMenuItem,
            this.overOnsToolStripMenuItem1});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(66, 46);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // inloggenToolStripMenuItem
            // 
            this.inloggenToolStripMenuItem.Name = "inloggenToolStripMenuItem";
            this.inloggenToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.inloggenToolStripMenuItem.Text = "Inloggen";
            this.inloggenToolStripMenuItem.Click += new System.EventHandler(this.inloggenToolStripMenuItem_Click);
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.afsluitenToolStripMenuItem.Text = "Afsluiten";
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.afsluitenToolStripMenuItem_Click);
            // 
            // overOnsToolStripMenuItem1
            // 
            this.overOnsToolStripMenuItem1.Name = "overOnsToolStripMenuItem1";
            this.overOnsToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.overOnsToolStripMenuItem1.Text = "Over ons";
            // 
            // digiFishToolStripMenuItem
            // 
            this.digiFishToolStripMenuItem.Name = "digiFishToolStripMenuItem";
            this.digiFishToolStripMenuItem.Size = new System.Drawing.Size(83, 46);
            this.digiFishToolStripMenuItem.Text = "DigiFish";
            this.digiFishToolStripMenuItem.Click += new System.EventHandler(this.digiFishToolStripMenuItem_Click);
            // 
            // visInformatieToolStripMenuItem
            // 
            this.visInformatieToolStripMenuItem.Name = "visInformatieToolStripMenuItem";
            this.visInformatieToolStripMenuItem.Size = new System.Drawing.Size(131, 46);
            this.visInformatieToolStripMenuItem.Text = "Vis informatie";
            this.visInformatieToolStripMenuItem.Click += new System.EventHandler(this.visInformatieToolStripMenuItem_Click);
            // 
            // pnl_home
            // 
            this.pnl_home.Location = new System.Drawing.Point(12, 65);
            this.pnl_home.Name = "pnl_home";
            this.pnl_home.Size = new System.Drawing.Size(335, 389);
            this.pnl_home.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DigiFish_application.Properties.Resources.Digi_fish_footer2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 460);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pctbox_homescreen_digiFishLogo
            // 
            this.pctbox_homescreen_digiFishLogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pctbox_homescreen_digiFishLogo.Image = global::DigiFish_application.Properties.Resources.Digi_fish_logo;
            this.pctbox_homescreen_digiFishLogo.Location = new System.Drawing.Point(287, 0);
            this.pctbox_homescreen_digiFishLogo.Name = "pctbox_homescreen_digiFishLogo";
            this.pctbox_homescreen_digiFishLogo.Size = new System.Drawing.Size(51, 50);
            this.pctbox_homescreen_digiFishLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbox_homescreen_digiFishLogo.TabIndex = 1;
            this.pctbox_homescreen_digiFishLogo.TabStop = false;
            // 
            // pctbox_digiFish_footer
            // 
            this.pctbox_digiFish_footer.Image = global::DigiFish_application.Properties.Resources.Digi_fish_footer2;
            this.pctbox_digiFish_footer.Location = new System.Drawing.Point(0, 650);
            this.pctbox_digiFish_footer.Name = "pctbox_digiFish_footer";
            this.pctbox_digiFish_footer.Size = new System.Drawing.Size(359, 123);
            this.pctbox_digiFish_footer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbox_digiFish_footer.TabIndex = 3;
            this.pctbox_digiFish_footer.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(359, 575);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pctbox_homescreen_digiFishLogo);
            this.Controls.Add(this.pctbox_digiFish_footer);
            this.Controls.Add(this.pnl_home);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "DigiFish";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_homescreen_digiFishLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_digiFish_footer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inloggenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digiFishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visInformatieToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_home;
        private System.Windows.Forms.PictureBox pctbox_homescreen_digiFishLogo;
        private System.Windows.Forms.PictureBox pctbox_digiFish_footer;
        private System.Windows.Forms.ToolStripMenuItem overOnsToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

