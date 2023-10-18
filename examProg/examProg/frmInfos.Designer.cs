namespace examProg
{
    partial class frmInfos
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
            this.lbl_timeLeft = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb_timeLeft = new System.Windows.Forms.TextBox();
            this.txtb_pointage = new System.Windows.Forms.TextBox();
            this.txtb_ronde = new System.Windows.Forms.TextBox();
            this.txtb_events = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_timeLeft
            // 
            this.lbl_timeLeft.AutoSize = true;
            this.lbl_timeLeft.Location = new System.Drawing.Point(22, 22);
            this.lbl_timeLeft.Name = "lbl_timeLeft";
            this.lbl_timeLeft.Size = new System.Drawing.Size(77, 13);
            this.lbl_timeLeft.TabIndex = 0;
            this.lbl_timeLeft.Text = "Temps restant:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pointage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ronde:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Evènements:";
            // 
            // txtb_timeLeft
            // 
            this.txtb_timeLeft.Enabled = false;
            this.txtb_timeLeft.Location = new System.Drawing.Point(105, 19);
            this.txtb_timeLeft.Name = "txtb_timeLeft";
            this.txtb_timeLeft.Size = new System.Drawing.Size(36, 20);
            this.txtb_timeLeft.TabIndex = 4;
            this.txtb_timeLeft.Text = "10";
            // 
            // txtb_pointage
            // 
            this.txtb_pointage.Enabled = false;
            this.txtb_pointage.Location = new System.Drawing.Point(105, 49);
            this.txtb_pointage.Name = "txtb_pointage";
            this.txtb_pointage.Size = new System.Drawing.Size(36, 20);
            this.txtb_pointage.TabIndex = 5;
            this.txtb_pointage.Text = "0";
            // 
            // txtb_ronde
            // 
            this.txtb_ronde.Enabled = false;
            this.txtb_ronde.Location = new System.Drawing.Point(105, 81);
            this.txtb_ronde.Name = "txtb_ronde";
            this.txtb_ronde.Size = new System.Drawing.Size(36, 20);
            this.txtb_ronde.TabIndex = 6;
            this.txtb_ronde.Text = "1";
            // 
            // txtb_events
            // 
            this.txtb_events.Location = new System.Drawing.Point(25, 134);
            this.txtb_events.Multiline = true;
            this.txtb_events.Name = "txtb_events";
            this.txtb_events.Size = new System.Drawing.Size(237, 109);
            this.txtb_events.TabIndex = 7;
            // 
            // frmInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 275);
            this.Controls.Add(this.txtb_events);
            this.Controls.Add(this.txtb_ronde);
            this.Controls.Add(this.txtb_pointage);
            this.Controls.Add(this.txtb_timeLeft);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_timeLeft);
            this.Name = "frmInfos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_timeLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtb_timeLeft;
        private System.Windows.Forms.TextBox txtb_pointage;
        private System.Windows.Forms.TextBox txtb_ronde;
        private System.Windows.Forms.TextBox txtb_events;
    }
}