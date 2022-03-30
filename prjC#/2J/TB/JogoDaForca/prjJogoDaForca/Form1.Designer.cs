namespace prjJogoDaForca
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnJogar = new System.Windows.Forms.Button();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnPalavra = new System.Windows.Forms.Panel();
            this.lbCronometro = new System.Windows.Forms.Label();
            this.pbForca = new System.Windows.Forms.PictureBox();
            this.pbBoneco = new System.Windows.Forms.PictureBox();
            this.lbLetras = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbDica = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnPalavra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbForca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoneco)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnJogar);
            this.panel1.Controls.Add(this.txtLetra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(36, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 174);
            this.panel1.TabIndex = 0;
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.Transparent;
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.ForeColor = System.Drawing.Color.White;
            this.btnJogar.Location = new System.Drawing.Point(3, 114);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(184, 42);
            this.btnJogar.TabIndex = 2;
            this.btnJogar.Text = "JOGAR";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // txtLetra
            // 
            this.txtLetra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetra.Location = new System.Drawing.Point(3, 63);
            this.txtLetra.MaxLength = 1;
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(184, 31);
            this.txtLetra.TabIndex = 1;
            this.txtLetra.Text = "A";
            this.txtLetra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIGITE UMA LETRA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnPalavra
            // 
            this.pnPalavra.BackColor = System.Drawing.Color.Transparent;
            this.pnPalavra.Controls.Add(this.lbCronometro);
            this.pnPalavra.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnPalavra.Location = new System.Drawing.Point(251, 38);
            this.pnPalavra.Name = "pnPalavra";
            this.pnPalavra.Size = new System.Drawing.Size(724, 173);
            this.pnPalavra.TabIndex = 1;
            // 
            // lbCronometro
            // 
            this.lbCronometro.BackColor = System.Drawing.Color.Transparent;
            this.lbCronometro.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCronometro.ForeColor = System.Drawing.Color.White;
            this.lbCronometro.Location = new System.Drawing.Point(664, 0);
            this.lbCronometro.Name = "lbCronometro";
            this.lbCronometro.Size = new System.Drawing.Size(60, 50);
            this.lbCronometro.TabIndex = 15;
            this.lbCronometro.Text = "120";
            this.lbCronometro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbForca
            // 
            this.pbForca.BackColor = System.Drawing.Color.Transparent;
            this.pbForca.Image = ((System.Drawing.Image)(resources.GetObject("pbForca.Image")));
            this.pbForca.Location = new System.Drawing.Point(39, 278);
            this.pbForca.Name = "pbForca";
            this.pbForca.Size = new System.Drawing.Size(238, 310);
            this.pbForca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbForca.TabIndex = 2;
            this.pbForca.TabStop = false;
            // 
            // pbBoneco
            // 
            this.pbBoneco.BackColor = System.Drawing.Color.Transparent;
            this.pbBoneco.Location = new System.Drawing.Point(170, 336);
            this.pbBoneco.Name = "pbBoneco";
            this.pbBoneco.Size = new System.Drawing.Size(194, 317);
            this.pbBoneco.TabIndex = 3;
            this.pbBoneco.TabStop = false;
            // 
            // lbLetras
            // 
            this.lbLetras.BackColor = System.Drawing.Color.Transparent;
            this.lbLetras.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbLetras.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLetras.ForeColor = System.Drawing.Color.White;
            this.lbLetras.Location = new System.Drawing.Point(0, 665);
            this.lbLetras.Name = "lbLetras";
            this.lbLetras.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lbLetras.Size = new System.Drawing.Size(1231, 36);
            this.lbLetras.TabIndex = 13;
            this.lbLetras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbDica
            // 
            this.lbDica.BackColor = System.Drawing.Color.Transparent;
            this.lbDica.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDica.ForeColor = System.Drawing.Color.White;
            this.lbDica.Location = new System.Drawing.Point(248, 214);
            this.lbDica.Name = "lbDica";
            this.lbDica.Size = new System.Drawing.Size(727, 23);
            this.lbDica.TabIndex = 14;
            this.lbDica.Text = "DICA:";
            this.lbDica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1231, 701);
            this.Controls.Add(this.lbDica);
            this.Controls.Add(this.lbLetras);
            this.Controls.Add(this.pbBoneco);
            this.Controls.Add(this.pbForca);
            this.Controls.Add(this.pnPalavra);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JOGO DA FORCA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnPalavra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbForca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoneco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Panel pnPalavra;
        private System.Windows.Forms.PictureBox pbForca;
        private System.Windows.Forms.PictureBox pbBoneco;
        private System.Windows.Forms.Label lbLetras;
        private System.Windows.Forms.Label lbCronometro;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbDica;
    }
}

