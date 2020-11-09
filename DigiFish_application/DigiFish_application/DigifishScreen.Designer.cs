namespace DigiFish_application
{
    partial class DigifishScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DigifishScreen));
            this.lbl_DigifishScreen_Barcode = new System.Windows.Forms.Label();
            this.lbl_DigifishScreen_gebruiker_invoer = new System.Windows.Forms.Label();
            this.lbl_DigifishScreen_gebruiker2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_DigifishScreen_aantalGevangen = new System.Windows.Forms.Label();
            this.btn_DigifishScreen_verhogen = new System.Windows.Forms.Button();
            this.txtbox_DigifishScreen_aantalGevangen = new System.Windows.Forms.TextBox();
            this.pctbox_barcode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_barcode)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_DigifishScreen_Barcode
            // 
            this.lbl_DigifishScreen_Barcode.AutoSize = true;
            this.lbl_DigifishScreen_Barcode.Location = new System.Drawing.Point(134, 150);
            this.lbl_DigifishScreen_Barcode.Name = "lbl_DigifishScreen_Barcode";
            this.lbl_DigifishScreen_Barcode.Size = new System.Drawing.Size(50, 13);
            this.lbl_DigifishScreen_Barcode.TabIndex = 1;
            this.lbl_DigifishScreen_Barcode.Text = "Barcode:";
            // 
            // lbl_DigifishScreen_gebruiker_invoer
            // 
            this.lbl_DigifishScreen_gebruiker_invoer.AutoSize = true;
            this.lbl_DigifishScreen_gebruiker_invoer.Location = new System.Drawing.Point(71, 9);
            this.lbl_DigifishScreen_gebruiker_invoer.Name = "lbl_DigifishScreen_gebruiker_invoer";
            this.lbl_DigifishScreen_gebruiker_invoer.Size = new System.Drawing.Size(16, 13);
            this.lbl_DigifishScreen_gebruiker_invoer.TabIndex = 2;
            this.lbl_DigifishScreen_gebruiker_invoer.Text = "...";
            // 
            // lbl_DigifishScreen_gebruiker2
            // 
            this.lbl_DigifishScreen_gebruiker2.AutoSize = true;
            this.lbl_DigifishScreen_gebruiker2.Location = new System.Drawing.Point(12, 9);
            this.lbl_DigifishScreen_gebruiker2.Name = "lbl_DigifishScreen_gebruiker2";
            this.lbl_DigifishScreen_gebruiker2.Size = new System.Drawing.Size(56, 13);
            this.lbl_DigifishScreen_gebruiker2.TabIndex = 3;
            this.lbl_DigifishScreen_gebruiker2.Text = "Gebruiker:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aantal gevangen:";
            // 
            // lbl_DigifishScreen_aantalGevangen
            // 
            this.lbl_DigifishScreen_aantalGevangen.AutoSize = true;
            this.lbl_DigifishScreen_aantalGevangen.Location = new System.Drawing.Point(109, 33);
            this.lbl_DigifishScreen_aantalGevangen.Name = "lbl_DigifishScreen_aantalGevangen";
            this.lbl_DigifishScreen_aantalGevangen.Size = new System.Drawing.Size(16, 13);
            this.lbl_DigifishScreen_aantalGevangen.TabIndex = 5;
            this.lbl_DigifishScreen_aantalGevangen.Text = "...";
            // 
            // btn_DigifishScreen_verhogen
            // 
            this.btn_DigifishScreen_verhogen.Location = new System.Drawing.Point(121, 68);
            this.btn_DigifishScreen_verhogen.Name = "btn_DigifishScreen_verhogen";
            this.btn_DigifishScreen_verhogen.Size = new System.Drawing.Size(75, 22);
            this.btn_DigifishScreen_verhogen.TabIndex = 6;
            this.btn_DigifishScreen_verhogen.Text = "Verhogen";
            this.btn_DigifishScreen_verhogen.UseVisualStyleBackColor = true;
            // 
            // txtbox_DigifishScreen_aantalGevangen
            // 
            this.txtbox_DigifishScreen_aantalGevangen.Location = new System.Drawing.Point(15, 68);
            this.txtbox_DigifishScreen_aantalGevangen.Name = "txtbox_DigifishScreen_aantalGevangen";
            this.txtbox_DigifishScreen_aantalGevangen.Size = new System.Drawing.Size(100, 20);
            this.txtbox_DigifishScreen_aantalGevangen.TabIndex = 7;
            // 
            // pctbox_barcode
            // 
            this.pctbox_barcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctbox_barcode.Location = new System.Drawing.Point(87, 166);
            this.pctbox_barcode.Name = "pctbox_barcode";
            this.pctbox_barcode.Size = new System.Drawing.Size(144, 57);
            this.pctbox_barcode.TabIndex = 0;
            this.pctbox_barcode.TabStop = false;
            // 
            // DigifishScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(319, 350);
            this.Controls.Add(this.txtbox_DigifishScreen_aantalGevangen);
            this.Controls.Add(this.btn_DigifishScreen_verhogen);
            this.Controls.Add(this.lbl_DigifishScreen_aantalGevangen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_DigifishScreen_gebruiker2);
            this.Controls.Add(this.lbl_DigifishScreen_gebruiker_invoer);
            this.Controls.Add(this.lbl_DigifishScreen_Barcode);
            this.Controls.Add(this.pctbox_barcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DigifishScreen";
            this.ShowInTaskbar = false;
            this.Text = "DigifishScreen";
            this.Load += new System.EventHandler(this.DigifishScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_barcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctbox_barcode;
        private System.Windows.Forms.Label lbl_DigifishScreen_Barcode;
        private System.Windows.Forms.Label lbl_DigifishScreen_gebruiker_invoer;
        private System.Windows.Forms.Label lbl_DigifishScreen_gebruiker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_DigifishScreen_aantalGevangen;
        private System.Windows.Forms.Button btn_DigifishScreen_verhogen;
        private System.Windows.Forms.TextBox txtbox_DigifishScreen_aantalGevangen;
    }
}