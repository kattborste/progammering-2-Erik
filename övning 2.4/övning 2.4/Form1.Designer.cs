namespace övning_2._4
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
            this.lblSkapa = new System.Windows.Forms.Label();
            this.lblBredd = new System.Windows.Forms.Label();
            this.lblHöjd = new System.Windows.Forms.Label();
            this.tbxBredd = new System.Windows.Forms.TextBox();
            this.tbxHöjd = new System.Windows.Forms.TextBox();
            this.btnTriangel = new System.Windows.Forms.Button();
            this.btnCirkel = new System.Windows.Forms.Button();
            this.btnLinje = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.lbxLista = new System.Windows.Forms.ListBox();
            this.tbxArea = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSkapa
            // 
            this.lblSkapa.AutoSize = true;
            this.lblSkapa.Location = new System.Drawing.Point(24, 53);
            this.lblSkapa.Name = "lblSkapa";
            this.lblSkapa.Size = new System.Drawing.Size(38, 13);
            this.lblSkapa.TabIndex = 0;
            this.lblSkapa.Text = "Skapa";
            // 
            // lblBredd
            // 
            this.lblBredd.AutoSize = true;
            this.lblBredd.Location = new System.Drawing.Point(27, 85);
            this.lblBredd.Name = "lblBredd";
            this.lblBredd.Size = new System.Drawing.Size(35, 13);
            this.lblBredd.TabIndex = 1;
            this.lblBredd.Text = "Bredd";
            // 
            // lblHöjd
            // 
            this.lblHöjd.AutoSize = true;
            this.lblHöjd.Location = new System.Drawing.Point(27, 118);
            this.lblHöjd.Name = "lblHöjd";
            this.lblHöjd.Size = new System.Drawing.Size(29, 13);
            this.lblHöjd.TabIndex = 2;
            this.lblHöjd.Text = "Höjd";
            // 
            // tbxBredd
            // 
            this.tbxBredd.Location = new System.Drawing.Point(69, 85);
            this.tbxBredd.Name = "tbxBredd";
            this.tbxBredd.Size = new System.Drawing.Size(100, 20);
            this.tbxBredd.TabIndex = 3;
            // 
            // tbxHöjd
            // 
            this.tbxHöjd.Location = new System.Drawing.Point(69, 111);
            this.tbxHöjd.Name = "tbxHöjd";
            this.tbxHöjd.Size = new System.Drawing.Size(100, 20);
            this.tbxHöjd.TabIndex = 4;
            // 
            // btnTriangel
            // 
            this.btnTriangel.Location = new System.Drawing.Point(69, 147);
            this.btnTriangel.Name = "btnTriangel";
            this.btnTriangel.Size = new System.Drawing.Size(100, 23);
            this.btnTriangel.TabIndex = 5;
            this.btnTriangel.Text = "Skapa triangel";
            this.btnTriangel.UseVisualStyleBackColor = true;
            this.btnTriangel.Click += new System.EventHandler(this.btnTriangel_Click);
            // 
            // btnCirkel
            // 
            this.btnCirkel.Location = new System.Drawing.Point(69, 176);
            this.btnCirkel.Name = "btnCirkel";
            this.btnCirkel.Size = new System.Drawing.Size(100, 23);
            this.btnCirkel.TabIndex = 6;
            this.btnCirkel.Text = "Skapa cirkel";
            this.btnCirkel.UseVisualStyleBackColor = true;
            this.btnCirkel.Click += new System.EventHandler(this.btnCirkel_Click);
            // 
            // btnLinje
            // 
            this.btnLinje.Location = new System.Drawing.Point(69, 205);
            this.btnLinje.Name = "btnLinje";
            this.btnLinje.Size = new System.Drawing.Size(100, 23);
            this.btnLinje.TabIndex = 7;
            this.btnLinje.Text = "Skapa linje";
            this.btnLinje.UseVisualStyleBackColor = true;
            this.btnLinje.Click += new System.EventHandler(this.btnLinje_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(69, 284);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(100, 23);
            this.btnArea.TabIndex = 8;
            this.btnArea.Text = "Sammanlagd area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(267, 53);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(48, 13);
            this.lblLista.TabIndex = 9;
            this.lblLista.Text = "Figurlista";
            // 
            // lbxLista
            // 
            this.lbxLista.FormattingEnabled = true;
            this.lbxLista.Location = new System.Drawing.Point(270, 85);
            this.lbxLista.Name = "lbxLista";
            this.lbxLista.Size = new System.Drawing.Size(141, 160);
            this.lbxLista.TabIndex = 10;
            // 
            // tbxArea
            // 
            this.tbxArea.Location = new System.Drawing.Point(270, 284);
            this.tbxArea.Name = "tbxArea";
            this.tbxArea.ReadOnly = true;
            this.tbxArea.Size = new System.Drawing.Size(100, 20);
            this.tbxArea.TabIndex = 11;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(273, 268);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(92, 13);
            this.lblArea.TabIndex = 12;
            this.lblArea.Text = "Sammanlagd area";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 388);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.tbxArea);
            this.Controls.Add(this.lbxLista);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnLinje);
            this.Controls.Add(this.btnCirkel);
            this.Controls.Add(this.btnTriangel);
            this.Controls.Add(this.tbxHöjd);
            this.Controls.Add(this.tbxBredd);
            this.Controls.Add(this.lblHöjd);
            this.Controls.Add(this.lblBredd);
            this.Controls.Add(this.lblSkapa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSkapa;
        private System.Windows.Forms.Label lblBredd;
        private System.Windows.Forms.Label lblHöjd;
        private System.Windows.Forms.TextBox tbxBredd;
        private System.Windows.Forms.TextBox tbxHöjd;
        private System.Windows.Forms.Button btnTriangel;
        private System.Windows.Forms.Button btnCirkel;
        private System.Windows.Forms.Button btnLinje;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.ListBox lbxLista;
        private System.Windows.Forms.TextBox tbxArea;
        private System.Windows.Forms.Label lblArea;
    }
}

