namespace BritHotel
{
    partial class FormGestionClient
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.Label();
            this.txtboxNom = new System.Windows.Forms.TextBox();
            this.txtboxMail = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.Label();
            this.txtboxMDP = new System.Windows.Forms.TextBox();
            this.txtMDP = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id : ";
            // 
            // txtnom
            // 
            this.txtnom.AutoSize = true;
            this.txtnom.Location = new System.Drawing.Point(10, 93);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(33, 13);
            this.txtnom.TabIndex = 2;
            this.txtnom.Text = "nom :";
            // 
            // txtboxNom
            // 
            this.txtboxNom.Location = new System.Drawing.Point(49, 90);
            this.txtboxNom.Name = "txtboxNom";
            this.txtboxNom.Size = new System.Drawing.Size(123, 20);
            this.txtboxNom.TabIndex = 3;
            // 
            // txtboxMail
            // 
            this.txtboxMail.Location = new System.Drawing.Point(49, 129);
            this.txtboxMail.Name = "txtboxMail";
            this.txtboxMail.Size = new System.Drawing.Size(123, 20);
            this.txtboxMail.TabIndex = 5;
            // 
            // txtMail
            // 
            this.txtMail.AutoSize = true;
            this.txtMail.Location = new System.Drawing.Point(10, 132);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(31, 13);
            this.txtMail.TabIndex = 4;
            this.txtMail.Text = "mail :";
            // 
            // txtboxMDP
            // 
            this.txtboxMDP.Location = new System.Drawing.Point(92, 166);
            this.txtboxMDP.Name = "txtboxMDP";
            this.txtboxMDP.Size = new System.Drawing.Size(123, 20);
            this.txtboxMDP.TabIndex = 7;
            // 
            // txtMDP
            // 
            this.txtMDP.AutoSize = true;
            this.txtMDP.Location = new System.Drawing.Point(10, 169);
            this.txtMDP.Name = "txtMDP";
            this.txtMDP.Size = new System.Drawing.Size(76, 13);
            this.txtMDP.TabIndex = 6;
            this.txtMDP.Text = "mot de passe :";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(9, 48);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 8;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(78, 214);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmer.TabIndex = 9;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // FormGestionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 252);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtboxMDP);
            this.Controls.Add(this.txtMDP);
            this.Controls.Add(this.txtboxMail);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtboxNom);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "FormGestionClient";
            this.Text = "FormGestionClient";
            this.Load += new System.EventHandler(this.FormGestionClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtnom;
        private System.Windows.Forms.TextBox txtboxNom;
        private System.Windows.Forms.TextBox txtboxMail;
        private System.Windows.Forms.Label txtMail;
        private System.Windows.Forms.TextBox txtboxMDP;
        private System.Windows.Forms.Label txtMDP;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnConfirmer;
    }
}