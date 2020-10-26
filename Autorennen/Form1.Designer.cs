namespace Autorennen
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlFahrbahn = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnGas = new System.Windows.Forms.Button();
            this.btnBremse = new System.Windows.Forms.Button();
            this.btnHupe = new System.Windows.Forms.Button();
            this.lblTacho = new System.Windows.Forms.Label();
            this.btnKlingel = new System.Windows.Forms.Button();
            this.btnFahrradbremse = new System.Windows.Forms.Button();
            this.btnTreten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlFahrbahn
            // 
            this.pnlFahrbahn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFahrbahn.Location = new System.Drawing.Point(0, 0);
            this.pnlFahrbahn.Margin = new System.Windows.Forms.Padding(6);
            this.pnlFahrbahn.Name = "pnlFahrbahn";
            this.pnlFahrbahn.Size = new System.Drawing.Size(1432, 666);
            this.pnlFahrbahn.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnGas
            // 
            this.btnGas.Location = new System.Drawing.Point(263, 879);
            this.btnGas.Name = "btnGas";
            this.btnGas.Size = new System.Drawing.Size(104, 80);
            this.btnGas.TabIndex = 1;
            this.btnGas.Text = "Gas";
            this.btnGas.UseVisualStyleBackColor = true;
            this.btnGas.Click += new System.EventHandler(this.btnGas_Click);
            // 
            // btnBremse
            // 
            this.btnBremse.Location = new System.Drawing.Point(85, 879);
            this.btnBremse.Name = "btnBremse";
            this.btnBremse.Size = new System.Drawing.Size(156, 79);
            this.btnBremse.TabIndex = 2;
            this.btnBremse.Text = "Bremse";
            this.btnBremse.UseVisualStyleBackColor = true;
            this.btnBremse.Click += new System.EventHandler(this.btnBremse_Click);
            // 
            // btnHupe
            // 
            this.btnHupe.Location = new System.Drawing.Point(85, 767);
            this.btnHupe.Name = "btnHupe";
            this.btnHupe.Size = new System.Drawing.Size(96, 90);
            this.btnHupe.TabIndex = 3;
            this.btnHupe.Text = "Hupe";
            this.btnHupe.UseVisualStyleBackColor = true;
            this.btnHupe.Click += new System.EventHandler(this.btnHupe_Click);
            // 
            // lblTacho
            // 
            this.lblTacho.AutoSize = true;
            this.lblTacho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTacho.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacho.Location = new System.Drawing.Point(226, 783);
            this.lblTacho.Name = "lblTacho";
            this.lblTacho.Size = new System.Drawing.Size(111, 52);
            this.lblTacho.TabIndex = 4;
            this.lblTacho.Text = "000";
            // 
            // btnKlingel
            // 
            this.btnKlingel.Location = new System.Drawing.Point(465, 768);
            this.btnKlingel.Name = "btnKlingel";
            this.btnKlingel.Size = new System.Drawing.Size(96, 90);
            this.btnKlingel.TabIndex = 7;
            this.btnKlingel.Text = "Klingel";
            this.btnKlingel.UseVisualStyleBackColor = true;
            this.btnKlingel.Click += new System.EventHandler(this.btnKlingel_Click);
            // 
            // btnFahrradbremse
            // 
            this.btnFahrradbremse.Location = new System.Drawing.Point(465, 880);
            this.btnFahrradbremse.Name = "btnFahrradbremse";
            this.btnFahrradbremse.Size = new System.Drawing.Size(156, 79);
            this.btnFahrradbremse.TabIndex = 6;
            this.btnFahrradbremse.Text = "Bremse";
            this.btnFahrradbremse.UseVisualStyleBackColor = true;
            this.btnFahrradbremse.Click += new System.EventHandler(this.btnFahrradbremse_Click);
            // 
            // btnTreten
            // 
            this.btnTreten.Location = new System.Drawing.Point(643, 880);
            this.btnTreten.Name = "btnTreten";
            this.btnTreten.Size = new System.Drawing.Size(104, 80);
            this.btnTreten.TabIndex = 5;
            this.btnTreten.Text = "Treten";
            this.btnTreten.UseVisualStyleBackColor = true;
            this.btnTreten.Click += new System.EventHandler(this.btnTreten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 1062);
            this.Controls.Add(this.btnKlingel);
            this.Controls.Add(this.btnFahrradbremse);
            this.Controls.Add(this.btnTreten);
            this.Controls.Add(this.lblTacho);
            this.Controls.Add(this.btnHupe);
            this.Controls.Add(this.btnBremse);
            this.Controls.Add(this.btnGas);
            this.Controls.Add(this.pnlFahrbahn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFahrbahn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnGas;
        private System.Windows.Forms.Button btnBremse;
        private System.Windows.Forms.Button btnHupe;
        private System.Windows.Forms.Label lblTacho;
        private System.Windows.Forms.Button btnKlingel;
        private System.Windows.Forms.Button btnFahrradbremse;
        private System.Windows.Forms.Button btnTreten;
    }
}

