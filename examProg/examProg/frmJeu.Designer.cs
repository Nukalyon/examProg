﻿namespace examProg
{
    partial class frmJeu
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
            this.pnl_player = new System.Windows.Forms.Panel();
            this.txtb_currentLife = new System.Windows.Forms.TextBox();
            this.prgb_life = new System.Windows.Forms.ProgressBar();
            this.txt_namePlayer = new System.Windows.Forms.TextBox();
            this.pic_player = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_heart3 = new System.Windows.Forms.PictureBox();
            this.pic_heart2 = new System.Windows.Forms.PictureBox();
            this.pic_heart1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pnl_player.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_player)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_player
            // 
            this.pnl_player.Controls.Add(this.txtb_currentLife);
            this.pnl_player.Controls.Add(this.prgb_life);
            this.pnl_player.Controls.Add(this.txt_namePlayer);
            this.pnl_player.Controls.Add(this.pic_player);
            this.pnl_player.Location = new System.Drawing.Point(263, 173);
            this.pnl_player.Name = "pnl_player";
            this.pnl_player.Size = new System.Drawing.Size(136, 159);
            this.pnl_player.TabIndex = 1;
            // 
            // txtb_currentLife
            // 
            this.txtb_currentLife.Enabled = false;
            this.txtb_currentLife.Location = new System.Drawing.Point(87, 20);
            this.txtb_currentLife.Name = "txtb_currentLife";
            this.txtb_currentLife.Size = new System.Drawing.Size(46, 20);
            this.txtb_currentLife.TabIndex = 3;
            // 
            // prgb_life
            // 
            this.prgb_life.Location = new System.Drawing.Point(3, 32);
            this.prgb_life.Name = "prgb_life";
            this.prgb_life.Size = new System.Drawing.Size(130, 20);
            this.prgb_life.TabIndex = 2;
            // 
            // txt_namePlayer
            // 
            this.txt_namePlayer.Enabled = false;
            this.txt_namePlayer.Location = new System.Drawing.Point(3, 3);
            this.txt_namePlayer.Name = "txt_namePlayer";
            this.txt_namePlayer.Size = new System.Drawing.Size(130, 20);
            this.txt_namePlayer.TabIndex = 1;
            // 
            // pic_player
            // 
            this.pic_player.Image = global::examProg.Properties.Resources.kid1;
            this.pic_player.InitialImage = global::examProg.Properties.Resources.kid1;
            this.pic_player.Location = new System.Drawing.Point(3, 58);
            this.pic_player.Name = "pic_player";
            this.pic_player.Size = new System.Drawing.Size(130, 98);
            this.pic_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_player.TabIndex = 0;
            this.pic_player.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pic_heart3);
            this.panel1.Controls.Add(this.pic_heart2);
            this.panel1.Controls.Add(this.pic_heart1);
            this.panel1.Location = new System.Drawing.Point(646, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 46);
            this.panel1.TabIndex = 7;
            // 
            // pic_heart3
            // 
            this.pic_heart3.Image = global::examProg.Properties.Resources.coeur;
            this.pic_heart3.Location = new System.Drawing.Point(99, 3);
            this.pic_heart3.Name = "pic_heart3";
            this.pic_heart3.Size = new System.Drawing.Size(40, 38);
            this.pic_heart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_heart3.TabIndex = 2;
            this.pic_heart3.TabStop = false;
            // 
            // pic_heart2
            // 
            this.pic_heart2.Image = global::examProg.Properties.Resources.coeur;
            this.pic_heart2.Location = new System.Drawing.Point(53, 3);
            this.pic_heart2.Name = "pic_heart2";
            this.pic_heart2.Size = new System.Drawing.Size(40, 38);
            this.pic_heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_heart2.TabIndex = 1;
            this.pic_heart2.TabStop = false;
            // 
            // pic_heart1
            // 
            this.pic_heart1.Image = global::examProg.Properties.Resources.coeur;
            this.pic_heart1.Location = new System.Drawing.Point(7, 3);
            this.pic_heart1.Name = "pic_heart1";
            this.pic_heart1.Size = new System.Drawing.Size(40, 38);
            this.pic_heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_heart1.TabIndex = 0;
            this.pic_heart1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::examProg.Properties.Resources.vecteezy_carton_box_clipart_design_illustration_9380341_257;
            this.pictureBox4.Location = new System.Drawing.Point(393, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(95, 104);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::examProg.Properties.Resources.vecteezy_carton_box_clipart_design_illustration_9380341_257;
            this.pictureBox3.Location = new System.Drawing.Point(586, 173);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 104);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::examProg.Properties.Resources.box;
            this.pictureBox2.Location = new System.Drawing.Point(467, 310);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::examProg.Properties.Resources.vecteezy_carton_box_clipart_design_illustration_9380341_257;
            this.pictureBox1.Location = new System.Drawing.Point(111, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::examProg.Properties.Resources.vecteezy_carton_box_clipart_design_illustration_9380341_257;
            this.pictureBox5.Location = new System.Drawing.Point(66, 310);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(95, 104);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // frmJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pnl_player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmJeu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmJeu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmJeu_KeyDown);
            this.pnl_player.ResumeLayout(false);
            this.pnl_player.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_player)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_player;
        private System.Windows.Forms.Panel pnl_player;
        private System.Windows.Forms.TextBox txtb_currentLife;
        private System.Windows.Forms.ProgressBar prgb_life;
        private System.Windows.Forms.TextBox txt_namePlayer;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_heart3;
        private System.Windows.Forms.PictureBox pic_heart2;
        private System.Windows.Forms.PictureBox pic_heart1;
    }
}