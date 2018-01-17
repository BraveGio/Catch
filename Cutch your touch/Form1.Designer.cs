namespace Cutch_your_touch
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.przyciskScreen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.podglad = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.podglad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.przyciskScreen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 590);
            this.panel1.TabIndex = 0;
            // 
            // przyciskScreen
            // 
            this.przyciskScreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.przyciskScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.przyciskScreen.Location = new System.Drawing.Point(0, 0);
            this.przyciskScreen.Name = "przyciskScreen";
            this.przyciskScreen.Size = new System.Drawing.Size(178, 32);
            this.przyciskScreen.TabIndex = 0;
            this.przyciskScreen.Text = "Screen";
            this.przyciskScreen.UseVisualStyleBackColor = true;
            this.przyciskScreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.przyciskScreen_MouseDown);
            this.przyciskScreen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.przyciskScreen_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(180, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 32);
            this.panel2.TabIndex = 1;
            // 
            // podglad
            // 
            this.podglad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.podglad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.podglad.Location = new System.Drawing.Point(180, 32);
            this.podglad.Name = "podglad";
            this.podglad.Size = new System.Drawing.Size(797, 558);
            this.podglad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.podglad.TabIndex = 2;
            this.podglad.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "542729.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 590);
            this.Controls.Add(this.podglad);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.podglad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button przyciskScreen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox podglad;
        private System.Windows.Forms.ImageList imageList1;
    }
}

