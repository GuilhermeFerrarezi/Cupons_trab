namespace TESTECUP
{
    partial class Resultado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultado));
            this.Pesquisa = new System.Windows.Forms.TextBox();
            this.bfiltros2 = new System.Windows.Forms.Button();
            this.Filtros2 = new System.Windows.Forms.CheckedListBox();
            this.Nike = new System.Windows.Forms.Label();
            this.Samsung = new System.Windows.Forms.Label();
            this.Apple = new System.Windows.Forms.Label();
            this.Amazon = new System.Windows.Forms.Label();
            this.iFood = new System.Windows.Forms.Label();
            this.imgapple = new System.Windows.Forms.PictureBox();
            this.imgamaz = new System.Windows.Forms.PictureBox();
            this.imgsam = new System.Windows.Forms.PictureBox();
            this.imgnike = new System.Windows.Forms.PictureBox();
            this.imgifood = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgapple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgamaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgsam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgnike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgifood)).BeginInit();
            this.SuspendLayout();
            // 
            // Pesquisa
            // 
            this.Pesquisa.Location = new System.Drawing.Point(12, 12);
            this.Pesquisa.Name = "Pesquisa";
            this.Pesquisa.Size = new System.Drawing.Size(258, 20);
            this.Pesquisa.TabIndex = 1;
            // 
            // bfiltros2
            // 
            this.bfiltros2.Location = new System.Drawing.Point(276, 12);
            this.bfiltros2.Name = "bfiltros2";
            this.bfiltros2.Size = new System.Drawing.Size(75, 23);
            this.bfiltros2.TabIndex = 7;
            this.bfiltros2.Text = "Filtros >";
            this.bfiltros2.UseVisualStyleBackColor = true;
            this.bfiltros2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Filtros2
            // 
            this.Filtros2.FormattingEnabled = true;
            this.Filtros2.Items.AddRange(new object[] {
            "10%",
            "25%",
            "50%"});
            this.Filtros2.Location = new System.Drawing.Point(357, 12);
            this.Filtros2.Name = "Filtros2";
            this.Filtros2.Size = new System.Drawing.Size(112, 49);
            this.Filtros2.TabIndex = 8;
            this.Filtros2.Visible = false;
            // 
            // Nike
            // 
            this.Nike.AutoSize = true;
            this.Nike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Nike.Location = new System.Drawing.Point(128, 163);
            this.Nike.Name = "Nike";
            this.Nike.Size = new System.Drawing.Size(40, 20);
            this.Nike.TabIndex = 9;
            this.Nike.Text = "Nike";
            this.Nike.Visible = false;
            this.Nike.Click += new System.EventHandler(this.label1_Click);
            // 
            // Samsung
            // 
            this.Samsung.AutoSize = true;
            this.Samsung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Samsung.Location = new System.Drawing.Point(128, 230);
            this.Samsung.Name = "Samsung";
            this.Samsung.Size = new System.Drawing.Size(77, 20);
            this.Samsung.TabIndex = 10;
            this.Samsung.Text = "Samsung";
            this.Samsung.Visible = false;
            this.Samsung.Click += new System.EventHandler(this.Samsung_Click);
            // 
            // Apple
            // 
            this.Apple.AutoSize = true;
            this.Apple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Apple.Location = new System.Drawing.Point(128, 309);
            this.Apple.Name = "Apple";
            this.Apple.Size = new System.Drawing.Size(50, 20);
            this.Apple.TabIndex = 11;
            this.Apple.Text = "Apple";
            this.Apple.Visible = false;
            // 
            // Amazon
            // 
            this.Amazon.AutoSize = true;
            this.Amazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Amazon.Location = new System.Drawing.Point(128, 382);
            this.Amazon.Name = "Amazon";
            this.Amazon.Size = new System.Drawing.Size(68, 20);
            this.Amazon.TabIndex = 12;
            this.Amazon.Text = "Amazon";
            this.Amazon.Visible = false;
            // 
            // iFood
            // 
            this.iFood.AutoSize = true;
            this.iFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.iFood.Location = new System.Drawing.Point(128, 88);
            this.iFood.Name = "iFood";
            this.iFood.Size = new System.Drawing.Size(49, 20);
            this.iFood.TabIndex = 13;
            this.iFood.Text = "iFood";
            this.iFood.Visible = false;
            // 
            // imgapple
            // 
            this.imgapple.Image = global::TESTECUP.Properties.Resources.apple_logo_1_1;
            this.imgapple.Location = new System.Drawing.Point(29, 275);
            this.imgapple.Name = "imgapple";
            this.imgapple.Size = new System.Drawing.Size(70, 80);
            this.imgapple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgapple.TabIndex = 19;
            this.imgapple.TabStop = false;
            this.imgapple.Visible = false;
            // 
            // imgamaz
            // 
            this.imgamaz.Image = global::TESTECUP.Properties.Resources.amazon_logo_transparent;
            this.imgamaz.Location = new System.Drawing.Point(8, 371);
            this.imgamaz.Name = "imgamaz";
            this.imgamaz.Size = new System.Drawing.Size(114, 43);
            this.imgamaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgamaz.TabIndex = 18;
            this.imgamaz.TabStop = false;
            this.imgamaz.Visible = false;
            // 
            // imgsam
            // 
            this.imgsam.Image = global::TESTECUP.Properties.Resources.Samsung_Logo;
            this.imgsam.Location = new System.Drawing.Point(15, 210);
            this.imgsam.Name = "imgsam";
            this.imgsam.Size = new System.Drawing.Size(107, 59);
            this.imgsam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgsam.TabIndex = 17;
            this.imgsam.TabStop = false;
            this.imgsam.Visible = false;
            // 
            // imgnike
            // 
            this.imgnike.Image = global::TESTECUP.Properties.Resources.Logo_NIKE_svg;
            this.imgnike.Location = new System.Drawing.Point(12, 137);
            this.imgnike.Name = "imgnike";
            this.imgnike.Size = new System.Drawing.Size(110, 67);
            this.imgnike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgnike.TabIndex = 16;
            this.imgnike.TabStop = false;
            this.imgnike.Visible = false;
            // 
            // imgifood
            // 
            this.imgifood.Image = global::TESTECUP.Properties.Resources.ifood_43;
            this.imgifood.Location = new System.Drawing.Point(12, 66);
            this.imgifood.Name = "imgifood";
            this.imgifood.Size = new System.Drawing.Size(110, 59);
            this.imgifood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgifood.TabIndex = 15;
            this.imgifood.TabStop = false;
            this.imgifood.Visible = false;
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgapple);
            this.Controls.Add(this.imgamaz);
            this.Controls.Add(this.imgsam);
            this.Controls.Add(this.imgnike);
            this.Controls.Add(this.imgifood);
            this.Controls.Add(this.iFood);
            this.Controls.Add(this.Amazon);
            this.Controls.Add(this.Apple);
            this.Controls.Add(this.Samsung);
            this.Controls.Add(this.Nike);
            this.Controls.Add(this.Filtros2);
            this.Controls.Add(this.bfiltros2);
            this.Controls.Add(this.Pesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Resultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resultado";
            this.Load += new System.EventHandler(this.Resultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgapple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgamaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgsam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgnike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgifood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bfiltros2;
        public System.Windows.Forms.TextBox Pesquisa;
        protected internal System.Windows.Forms.CheckedListBox Filtros2;
        public System.Windows.Forms.Label Nike;
        private System.Windows.Forms.Label Samsung;
        private System.Windows.Forms.Label Apple;
        private System.Windows.Forms.Label Amazon;
        private System.Windows.Forms.Label iFood;
        private System.Windows.Forms.PictureBox imgifood;
        private System.Windows.Forms.PictureBox imgnike;
        private System.Windows.Forms.PictureBox imgsam;
        private System.Windows.Forms.PictureBox imgamaz;
        private System.Windows.Forms.PictureBox imgapple;
    }
}