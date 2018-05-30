namespace övning_2._8
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
            this.lblVara = new System.Windows.Forms.Label();
            this.lblPris = new System.Windows.Forms.Label();
            this.lblMängd = new System.Windows.Forms.Label();
            this.tbxVara = new System.Windows.Forms.TextBox();
            this.tbxPris = new System.Windows.Forms.TextBox();
            this.tbxMängd = new System.Windows.Forms.TextBox();
            this.lblVarutyp = new System.Windows.Forms.Label();
            this.rbnLösvikt = new System.Windows.Forms.RadioButton();
            this.rbnStycksak = new System.Windows.Forms.RadioButton();
            this.btnLäggTill = new System.Windows.Forms.Button();
            this.lbxLista = new System.Windows.Forms.ListBox();
            this.lblSumma = new System.Windows.Forms.Label();
            this.tbxSumma = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblVara
            // 
            this.lblVara.AutoSize = true;
            this.lblVara.Location = new System.Drawing.Point(26, 47);
            this.lblVara.Name = "lblVara";
            this.lblVara.Size = new System.Drawing.Size(29, 13);
            this.lblVara.TabIndex = 0;
            this.lblVara.Text = "Vara";
            // 
            // lblPris
            // 
            this.lblPris.AutoSize = true;
            this.lblPris.Location = new System.Drawing.Point(26, 81);
            this.lblPris.Name = "lblPris";
            this.lblPris.Size = new System.Drawing.Size(24, 13);
            this.lblPris.TabIndex = 1;
            this.lblPris.Text = "Pris";
            // 
            // lblMängd
            // 
            this.lblMängd.AutoSize = true;
            this.lblMängd.Location = new System.Drawing.Point(26, 116);
            this.lblMängd.Name = "lblMängd";
            this.lblMängd.Size = new System.Drawing.Size(40, 13);
            this.lblMängd.TabIndex = 2;
            this.lblMängd.Text = "Mängd";
            // 
            // tbxVara
            // 
            this.tbxVara.Location = new System.Drawing.Point(99, 44);
            this.tbxVara.Name = "tbxVara";
            this.tbxVara.Size = new System.Drawing.Size(100, 20);
            this.tbxVara.TabIndex = 3;
            // 
            // tbxPris
            // 
            this.tbxPris.Location = new System.Drawing.Point(99, 78);
            this.tbxPris.Name = "tbxPris";
            this.tbxPris.Size = new System.Drawing.Size(100, 20);
            this.tbxPris.TabIndex = 4;
            // 
            // tbxMängd
            // 
            this.tbxMängd.Location = new System.Drawing.Point(99, 113);
            this.tbxMängd.Name = "tbxMängd";
            this.tbxMängd.Size = new System.Drawing.Size(100, 20);
            this.tbxMängd.TabIndex = 5;
            // 
            // lblVarutyp
            // 
            this.lblVarutyp.AutoSize = true;
            this.lblVarutyp.Location = new System.Drawing.Point(116, 147);
            this.lblVarutyp.Name = "lblVarutyp";
            this.lblVarutyp.Size = new System.Drawing.Size(43, 13);
            this.lblVarutyp.TabIndex = 6;
            this.lblVarutyp.Text = "Varutyp";
            // 
            // rbnLösvikt
            // 
            this.rbnLösvikt.AutoSize = true;
            this.rbnLösvikt.Location = new System.Drawing.Point(116, 163);
            this.rbnLösvikt.Name = "rbnLösvikt";
            this.rbnLösvikt.Size = new System.Drawing.Size(59, 17);
            this.rbnLösvikt.TabIndex = 7;
            this.rbnLösvikt.TabStop = true;
            this.rbnLösvikt.Text = "Lösvikt";
            this.rbnLösvikt.UseVisualStyleBackColor = true;
            // 
            // rbnStycksak
            // 
            this.rbnStycksak.AutoSize = true;
            this.rbnStycksak.Location = new System.Drawing.Point(116, 187);
            this.rbnStycksak.Name = "rbnStycksak";
            this.rbnStycksak.Size = new System.Drawing.Size(69, 17);
            this.rbnStycksak.TabIndex = 8;
            this.rbnStycksak.TabStop = true;
            this.rbnStycksak.Text = "Stycksak";
            this.rbnStycksak.UseVisualStyleBackColor = true;
            // 
            // btnLäggTill
            // 
            this.btnLäggTill.Location = new System.Drawing.Point(29, 346);
            this.btnLäggTill.Name = "btnLäggTill";
            this.btnLäggTill.Size = new System.Drawing.Size(75, 23);
            this.btnLäggTill.TabIndex = 9;
            this.btnLäggTill.Text = "Lägg till";
            this.btnLäggTill.UseVisualStyleBackColor = true;
            this.btnLäggTill.Click += new System.EventHandler(this.btnLäggTill_Click);
            // 
            // lbxLista
            // 
            this.lbxLista.FormattingEnabled = true;
            this.lbxLista.Location = new System.Drawing.Point(251, 44);
            this.lbxLista.Name = "lbxLista";
            this.lbxLista.Size = new System.Drawing.Size(234, 290);
            this.lbxLista.TabIndex = 10;
            // 
            // lblSumma
            // 
            this.lblSumma.AutoSize = true;
            this.lblSumma.Location = new System.Drawing.Point(248, 351);
            this.lblSumma.Name = "lblSumma";
            this.lblSumma.Size = new System.Drawing.Size(63, 13);
            this.lblSumma.TabIndex = 11;
            this.lblSumma.Text = "Summa (kr):";
            // 
            // tbxSumma
            // 
            this.tbxSumma.Location = new System.Drawing.Point(347, 349);
            this.tbxSumma.Name = "tbxSumma";
            this.tbxSumma.Size = new System.Drawing.Size(100, 20);
            this.tbxSumma.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 402);
            this.Controls.Add(this.tbxSumma);
            this.Controls.Add(this.lblSumma);
            this.Controls.Add(this.lbxLista);
            this.Controls.Add(this.btnLäggTill);
            this.Controls.Add(this.rbnStycksak);
            this.Controls.Add(this.rbnLösvikt);
            this.Controls.Add(this.lblVarutyp);
            this.Controls.Add(this.tbxMängd);
            this.Controls.Add(this.tbxPris);
            this.Controls.Add(this.tbxVara);
            this.Controls.Add(this.lblMängd);
            this.Controls.Add(this.lblPris);
            this.Controls.Add(this.lblVara);
            this.Name = "Form1";
            this.Text = "Inköpslista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVara;
        private System.Windows.Forms.Label lblPris;
        private System.Windows.Forms.Label lblMängd;
        private System.Windows.Forms.TextBox tbxVara;
        private System.Windows.Forms.TextBox tbxPris;
        private System.Windows.Forms.TextBox tbxMängd;
        private System.Windows.Forms.Label lblVarutyp;
        private System.Windows.Forms.RadioButton rbnLösvikt;
        private System.Windows.Forms.RadioButton rbnStycksak;
        private System.Windows.Forms.Button btnLäggTill;
        private System.Windows.Forms.ListBox lbxLista;
        private System.Windows.Forms.Label lblSumma;
        private System.Windows.Forms.TextBox tbxSumma;
    }
}

