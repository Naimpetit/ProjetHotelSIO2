namespace BritHotel
{
    partial class FormInfosClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfosClient));
            this.btnValider = new System.Windows.Forms.Button();
            this.txtboxMail = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.Label();
            this.txtboxNom = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRech = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(17, 38);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 15;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtboxMail
            // 
            this.txtboxMail.Location = new System.Drawing.Point(57, 119);
            this.txtboxMail.Name = "txtboxMail";
            this.txtboxMail.Size = new System.Drawing.Size(123, 20);
            this.txtboxMail.TabIndex = 14;
            // 
            // txtMail
            // 
            this.txtMail.AutoSize = true;
            this.txtMail.Location = new System.Drawing.Point(18, 122);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(31, 13);
            this.txtMail.TabIndex = 13;
            this.txtMail.Text = "mail :";
            // 
            // txtboxNom
            // 
            this.txtboxNom.Location = new System.Drawing.Point(57, 80);
            this.txtboxNom.Name = "txtboxNom";
            this.txtboxNom.Size = new System.Drawing.Size(123, 20);
            this.txtboxNom.TabIndex = 12;
            // 
            // txtnom
            // 
            this.txtnom.AutoSize = true;
            this.txtnom.Location = new System.Drawing.Point(18, 83);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(33, 13);
            this.txtnom.TabIndex = 11;
            this.txtnom.Text = "nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Id : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 9;
            // 
            // btnRech
            // 
            this.btnRech.Location = new System.Drawing.Point(57, 145);
            this.btnRech.Name = "btnRech";
            this.btnRech.Size = new System.Drawing.Size(123, 36);
            this.btnRech.TabIndex = 16;
            this.btnRech.Text = "Rechercher réservation";
            this.btnRech.UseVisualStyleBackColor = true;
            this.btnRech.Click += new System.EventHandler(this.btnRech_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Date,
            this.DateF,
            this.Client,
            this.Num});
            this.dataGridView1.Location = new System.Drawing.Point(210, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(467, 397);
            this.dataGridView1.TabIndex = 17;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 41;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.HeaderText = "Date début";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // DateF
            // 
            this.DateF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateF.HeaderText = "Date fin";
            this.DateF.Name = "DateF";
            this.DateF.ReadOnly = true;
            // 
            // Client
            // 
            this.Client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Client.HeaderText = "Clients";
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            // 
            // Num
            // 
            this.Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Num.HeaderText = "Num chambre";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            // 
            // FormInfosClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 430);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRech);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtboxMail);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtboxNom);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInfosClient";
            this.Text = "Infos Client";
            this.Load += new System.EventHandler(this.FormInfosClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtboxMail;
        private System.Windows.Forms.Label txtMail;
        private System.Windows.Forms.TextBox txtboxNom;
        private System.Windows.Forms.Label txtnom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRech;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
    }
}