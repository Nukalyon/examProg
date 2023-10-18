namespace examProg
{
    partial class frmConfig
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_monsters = new System.Windows.Forms.Label();
            this.lbl_boxAidKit = new System.Windows.Forms.Label();
            this.lbl_boxVide = new System.Windows.Forms.Label();
            this.lbl_energie = new System.Windows.Forms.Label();
            this.txtb_nom = new System.Windows.Forms.TextBox();
            this.txtb_energie = new System.Windows.Forms.TextBox();
            this.cmb_monsters = new System.Windows.Forms.ComboBox();
            this.cmb_boxAidKit = new System.Windows.Forms.ComboBox();
            this.cmb_boxVide = new System.Windows.Forms.ComboBox();
            this.gp_choices = new System.Windows.Forms.GroupBox();
            this.rdb_loseOneLife = new System.Windows.Forms.RadioButton();
            this.rdb_moitieEnergie = new System.Windows.Forms.RadioButton();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.gp_choices.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(12, 31);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(79, 13);
            this.lbl_nom.TabIndex = 0;
            this.lbl_nom.Text = "Nom du joueur:";
            // 
            // lbl_monsters
            // 
            this.lbl_monsters.AutoSize = true;
            this.lbl_monsters.Location = new System.Drawing.Point(12, 58);
            this.lbl_monsters.Name = "lbl_monsters";
            this.lbl_monsters.Size = new System.Drawing.Size(157, 13);
            this.lbl_monsters.TabIndex = 1;
            this.lbl_monsters.Text = "Boîtes contenant des monstres:";
            // 
            // lbl_boxAidKit
            // 
            this.lbl_boxAidKit.AutoSize = true;
            this.lbl_boxAidKit.Location = new System.Drawing.Point(12, 83);
            this.lbl_boxAidKit.Name = "lbl_boxAidKit";
            this.lbl_boxAidKit.Size = new System.Drawing.Size(167, 13);
            this.lbl_boxAidKit.TabIndex = 2;
            this.lbl_boxAidKit.Text = "Boîte contenant des pansements:";
            // 
            // lbl_boxVide
            // 
            this.lbl_boxVide.AutoSize = true;
            this.lbl_boxVide.Location = new System.Drawing.Point(12, 113);
            this.lbl_boxVide.Name = "lbl_boxVide";
            this.lbl_boxVide.Size = new System.Drawing.Size(69, 13);
            this.lbl_boxVide.TabIndex = 3;
            this.lbl_boxVide.Text = "Boîtes vides:";
            // 
            // lbl_energie
            // 
            this.lbl_energie.AutoSize = true;
            this.lbl_energie.Location = new System.Drawing.Point(12, 143);
            this.lbl_energie.Name = "lbl_energie";
            this.lbl_energie.Size = new System.Drawing.Size(70, 13);
            this.lbl_energie.TabIndex = 4;
            this.lbl_energie.Text = "Energie (HP):";
            // 
            // txtb_nom
            // 
            this.txtb_nom.Location = new System.Drawing.Point(210, 31);
            this.txtb_nom.Name = "txtb_nom";
            this.txtb_nom.Size = new System.Drawing.Size(213, 20);
            this.txtb_nom.TabIndex = 5;
            // 
            // txtb_energie
            // 
            this.txtb_energie.Location = new System.Drawing.Point(210, 143);
            this.txtb_energie.Name = "txtb_energie";
            this.txtb_energie.Size = new System.Drawing.Size(213, 20);
            this.txtb_energie.TabIndex = 6;
            // 
            // cmb_monsters
            // 
            this.cmb_monsters.FormattingEnabled = true;
            this.cmb_monsters.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmb_monsters.Location = new System.Drawing.Point(210, 58);
            this.cmb_monsters.Name = "cmb_monsters";
            this.cmb_monsters.Size = new System.Drawing.Size(213, 21);
            this.cmb_monsters.TabIndex = 7;
            // 
            // cmb_boxAidKit
            // 
            this.cmb_boxAidKit.FormattingEnabled = true;
            this.cmb_boxAidKit.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cmb_boxAidKit.Location = new System.Drawing.Point(210, 89);
            this.cmb_boxAidKit.Name = "cmb_boxAidKit";
            this.cmb_boxAidKit.Size = new System.Drawing.Size(213, 21);
            this.cmb_boxAidKit.TabIndex = 8;
            // 
            // cmb_boxVide
            // 
            this.cmb_boxVide.FormattingEnabled = true;
            this.cmb_boxVide.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cmb_boxVide.Location = new System.Drawing.Point(210, 116);
            this.cmb_boxVide.Name = "cmb_boxVide";
            this.cmb_boxVide.Size = new System.Drawing.Size(213, 21);
            this.cmb_boxVide.TabIndex = 9;
            // 
            // gp_choices
            // 
            this.gp_choices.Controls.Add(this.rdb_loseOneLife);
            this.gp_choices.Controls.Add(this.rdb_moitieEnergie);
            this.gp_choices.Location = new System.Drawing.Point(15, 191);
            this.gp_choices.Name = "gp_choices";
            this.gp_choices.Size = new System.Drawing.Size(408, 94);
            this.gp_choices.TabIndex = 10;
            this.gp_choices.TabStop = false;
            this.gp_choices.Text = "Si le joeuur ne choisit pas de boîte avant le délai:";
            // 
            // rdb_loseOneLife
            // 
            this.rdb_loseOneLife.AutoSize = true;
            this.rdb_loseOneLife.Location = new System.Drawing.Point(19, 55);
            this.rdb_loseOneLife.Name = "rdb_loseOneLife";
            this.rdb_loseOneLife.Size = new System.Drawing.Size(94, 17);
            this.rdb_loseOneLife.TabIndex = 1;
            this.rdb_loseOneLife.TabStop = true;
            this.rdb_loseOneLife.Text = "Perdre une vie";
            this.rdb_loseOneLife.UseVisualStyleBackColor = true;
            // 
            // rdb_moitieEnergie
            // 
            this.rdb_moitieEnergie.AutoSize = true;
            this.rdb_moitieEnergie.Location = new System.Drawing.Point(19, 32);
            this.rdb_moitieEnergie.Name = "rdb_moitieEnergie";
            this.rdb_moitieEnergie.Size = new System.Drawing.Size(195, 17);
            this.rdb_moitieEnergie.TabIndex = 0;
            this.rdb_moitieEnergie.TabStop = true;
            this.rdb_moitieEnergie.Text = "Perdre la moitié de l\'énergie restante";
            this.rdb_moitieEnergie.UseVisualStyleBackColor = true;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(15, 300);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(234, 44);
            this.btn_start.TabIndex = 11;
            this.btn_start.Text = "Démarrer la partie";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.Location = new System.Drawing.Point(255, 300);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(168, 44);
            this.btn_quitter.TabIndex = 12;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 355);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.gp_choices);
            this.Controls.Add(this.cmb_boxVide);
            this.Controls.Add(this.cmb_boxAidKit);
            this.Controls.Add(this.cmb_monsters);
            this.Controls.Add(this.txtb_energie);
            this.Controls.Add(this.txtb_nom);
            this.Controls.Add(this.lbl_energie);
            this.Controls.Add(this.lbl_boxVide);
            this.Controls.Add(this.lbl_boxAidKit);
            this.Controls.Add(this.lbl_monsters);
            this.Controls.Add(this.lbl_nom);
            this.Name = "frmConfig";
            this.Text = "Form1";
            this.gp_choices.ResumeLayout(false);
            this.gp_choices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_monsters;
        private System.Windows.Forms.Label lbl_boxAidKit;
        private System.Windows.Forms.Label lbl_boxVide;
        private System.Windows.Forms.Label lbl_energie;
        private System.Windows.Forms.TextBox txtb_nom;
        private System.Windows.Forms.TextBox txtb_energie;
        private System.Windows.Forms.ComboBox cmb_monsters;
        private System.Windows.Forms.ComboBox cmb_boxAidKit;
        private System.Windows.Forms.ComboBox cmb_boxVide;
        private System.Windows.Forms.GroupBox gp_choices;
        private System.Windows.Forms.RadioButton rdb_loseOneLife;
        private System.Windows.Forms.RadioButton rdb_moitieEnergie;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_quitter;
    }
}

