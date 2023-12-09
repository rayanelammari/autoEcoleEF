namespace autoEcoleEF
{
    partial class FrmAjoutLecon
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEleve = new System.Windows.Forms.ComboBox();
            this.bdgEleve = new System.Windows.Forms.BindingSource(this.components);
            this.dtLecon = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHeure = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdButton1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rdButton2 = new System.Windows.Forms.RadioButton();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdgEleve)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elève";
            // 
            // cmbEleve
            // 
            this.cmbEleve.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgEleve, "nom", true));
            this.cmbEleve.DataSource = this.bdgEleve;
            this.cmbEleve.DisplayMember = "nom";
            this.cmbEleve.FormattingEnabled = true;
            this.cmbEleve.Location = new System.Drawing.Point(150, 78);
            this.cmbEleve.Name = "cmbEleve";
            this.cmbEleve.Size = new System.Drawing.Size(246, 24);
            this.cmbEleve.TabIndex = 1;
            // 
            // bdgEleve
            // 
            this.bdgEleve.DataSource = typeof(autoEcoleEF.eleve);
            // 
            // dtLecon
            // 
            this.dtLecon.Location = new System.Drawing.Point(150, 130);
            this.dtLecon.Name = "dtLecon";
            this.dtLecon.Size = new System.Drawing.Size(264, 22);
            this.dtLecon.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date ";
            // 
            // cmbHeure
            // 
            this.cmbHeure.FormattingEnabled = true;
            this.cmbHeure.Location = new System.Drawing.Point(150, 178);
            this.cmbHeure.Name = "cmbHeure";
            this.cmbHeure.Size = new System.Drawing.Size(278, 24);
            this.cmbHeure.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Heure";
            // 
            // rdButton1
            // 
            this.rdButton1.AutoSize = true;
            this.rdButton1.Location = new System.Drawing.Point(150, 233);
            this.rdButton1.Name = "rdButton1";
            this.rdButton1.Size = new System.Drawing.Size(90, 20);
            this.rdButton1.TabIndex = 6;
            this.rdButton1.TabStop = true;
            this.rdButton1.Text = "Une heure";
            this.rdButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Durée";
            // 
            // rdButton2
            // 
            this.rdButton2.AutoSize = true;
            this.rdButton2.Location = new System.Drawing.Point(293, 233);
            this.rdButton2.Name = "rdButton2";
            this.rdButton2.Size = new System.Drawing.Size(103, 20);
            this.rdButton2.TabIndex = 8;
            this.rdButton2.TabStop = true;
            this.rdButton2.Text = "Deux heures";
            this.rdButton2.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(150, 338);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(127, 23);
            this.btnEnregistrer.TabIndex = 9;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // FrmAjoutLecon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.rdButton2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdButton1);
            this.Controls.Add(this.cmbHeure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtLecon);
            this.Controls.Add(this.cmbEleve);
            this.Controls.Add(this.label1);
            this.Name = "FrmAjoutLecon";
            this.Text = "Ajout d\'une leçon";
            ((System.ComponentModel.ISupportInitialize)(this.bdgEleve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEleve;
        private System.Windows.Forms.DateTimePicker dtLecon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHeure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdButton2;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.BindingSource bdgEleve;
    }
}