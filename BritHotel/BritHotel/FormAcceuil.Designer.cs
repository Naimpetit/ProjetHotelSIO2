namespace BritHotel
{
    partial class FormAcceuil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAcceuil));
            this.btnconnexion = new System.Windows.Forms.Button();
            this.txtboxmdp = new System.Windows.Forms.TextBox();
            this.txtboxidentifiant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnconnexion
            // 
            this.btnconnexion.Location = new System.Drawing.Point(173, 189);
            this.btnconnexion.Name = "btnconnexion";
            this.btnconnexion.Size = new System.Drawing.Size(88, 26);
            this.btnconnexion.TabIndex = 0;
            this.btnconnexion.Text = "Connexion";
            this.btnconnexion.UseVisualStyleBackColor = true;
            // 
            // txtboxmdp
            // 
            this.txtboxmdp.Location = new System.Drawing.Point(120, 155);
            this.txtboxmdp.Name = "txtboxmdp";
            this.txtboxmdp.PasswordChar = '•';
            this.txtboxmdp.Size = new System.Drawing.Size(189, 20);
            this.txtboxmdp.TabIndex = 1;
            // 
            // txtboxidentifiant
            // 
            this.txtboxidentifiant.Location = new System.Drawing.Point(120, 111);
            this.txtboxidentifiant.Multiline = true;
            this.txtboxidentifiant.Name = "txtboxidentifiant";
            this.txtboxidentifiant.Size = new System.Drawing.Size(189, 20);
            this.txtboxidentifiant.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(157, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Saisisez votre identifiant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(148, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Saisisez votre mot de passe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(422, 273);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxidentifiant);
            this.Controls.Add(this.txtboxmdp);
            this.Controls.Add(this.btnconnexion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconnexion;
        private System.Windows.Forms.TextBox txtboxmdp;
        private System.Windows.Forms.TextBox txtboxidentifiant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

