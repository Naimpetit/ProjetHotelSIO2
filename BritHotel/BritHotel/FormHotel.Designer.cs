namespace BritHotel
{
    partial class FormHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHotel));
            this.txtnom = new System.Windows.Forms.Label();
            this.txtemplacement = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.Label();
            this.txtprix = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // txtnom
            // 
            this.txtnom.AutoSize = true;
            this.txtnom.Location = new System.Drawing.Point(37, 36);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(53, 13);
            this.txtnom.TabIndex = 0;
            this.txtnom.Text = "nom: N/A";
            // 
            // txtemplacement
            // 
            this.txtemplacement.AutoSize = true;
            this.txtemplacement.Location = new System.Drawing.Point(37, 58);
            this.txtemplacement.Name = "txtemplacement";
            this.txtemplacement.Size = new System.Drawing.Size(96, 13);
            this.txtemplacement.TabIndex = 1;
            this.txtemplacement.Text = "emplacement: N/A";
            // 
            // txttel
            // 
            this.txttel.AutoSize = true;
            this.txttel.Location = new System.Drawing.Point(37, 83);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(80, 13);
            this.txttel.TabIndex = 2;
            this.txttel.Text = "téléphone: N/A";
            // 
            // txtdesc
            // 
            this.txtdesc.AutoSize = true;
            this.txtdesc.Location = new System.Drawing.Point(37, 108);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(87, 13);
            this.txtdesc.TabIndex = 3;
            this.txtdesc.Text = "description : N/A";
            // 
            // txtprix
            // 
            this.txtprix.AutoSize = true;
            this.txtprix.Location = new System.Drawing.Point(37, 132);
            this.txtprix.Name = "txtprix";
            this.txtprix.Size = new System.Drawing.Size(52, 13);
            this.txtprix.TabIndex = 4;
            this.txtprix.Text = "prix : N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "equipement :";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(417, 35);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(139, 210);
            this.checkedListBox1.TabIndex = 6;
            //this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // FormHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtprix);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtemplacement);
            this.Controls.Add(this.txtnom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHotel";
            this.Text = "Mon hôtel";
            this.Load += new System.EventHandler(this.FormHotel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtnom;
        private System.Windows.Forms.Label txtemplacement;
        private System.Windows.Forms.Label txttel;
        private System.Windows.Forms.Label txtdesc;
        private System.Windows.Forms.Label txtprix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}