namespace calculadora
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
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbnumero1 = new System.Windows.Forms.TextBox();
            this.lbresultado = new System.Windows.Forms.Label();
            this.btnmais = new System.Windows.Forms.Button();
            this.btnmenos = new System.Windows.Forms.Button();
            this.btnvezes = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.bntigual = new System.Windows.Forms.Button();
            this.bnt1 = new System.Windows.Forms.Button();
            this.bnt4 = new System.Windows.Forms.Button();
            this.bnt7 = new System.Windows.Forms.Button();
            this.bnt8 = new System.Windows.Forms.Button();
            this.bnt2 = new System.Windows.Forms.Button();
            this.bnt5 = new System.Windows.Forms.Button();
            this.bnt9 = new System.Windows.Forms.Button();
            this.bnt3 = new System.Windows.Forms.Button();
            this.bnt6 = new System.Windows.Forms.Button();
            this.bnt0 = new System.Windows.Forms.Button();
            this.bntapagar = new System.Windows.Forms.Button();
            this.lbtemp = new System.Windows.Forms.Label();
            this.lboperador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbnumero1
            // 
            this.txbnumero1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnumero1.Location = new System.Drawing.Point(27, 41);
            this.txbnumero1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txbnumero1.Name = "txbnumero1";
            this.txbnumero1.ReadOnly = true;
            this.txbnumero1.Size = new System.Drawing.Size(182, 29);
            this.txbnumero1.TabIndex = 0;
            // 
            // lbresultado
            // 
            this.lbresultado.AutoSize = true;
            this.lbresultado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbresultado.Location = new System.Drawing.Point(229, 41);
            this.lbresultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbresultado.Name = "lbresultado";
            this.lbresultado.Size = new System.Drawing.Size(24, 22);
            this.lbresultado.TabIndex = 2;
            this.lbresultado.Text = "R";
            // 
            // btnmais
            // 
            this.btnmais.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmais.Location = new System.Drawing.Point(248, 275);
            this.btnmais.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnmais.Name = "btnmais";
            this.btnmais.Size = new System.Drawing.Size(68, 58);
            this.btnmais.TabIndex = 3;
            this.btnmais.Text = "+";
            this.btnmais.UseVisualStyleBackColor = true;
            this.btnmais.Click += new System.EventHandler(this.btnmais_Click);
            // 
            // btnmenos
            // 
            this.btnmenos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenos.Location = new System.Drawing.Point(247, 211);
            this.btnmenos.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnmenos.Name = "btnmenos";
            this.btnmenos.Size = new System.Drawing.Size(69, 58);
            this.btnmenos.TabIndex = 4;
            this.btnmenos.Text = "-";
            this.btnmenos.UseVisualStyleBackColor = true;
            this.btnmenos.Click += new System.EventHandler(this.btnmais_Click);
            // 
            // btnvezes
            // 
            this.btnvezes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvezes.Location = new System.Drawing.Point(247, 147);
            this.btnvezes.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnvezes.Name = "btnvezes";
            this.btnvezes.Size = new System.Drawing.Size(69, 58);
            this.btnvezes.TabIndex = 5;
            this.btnvezes.Text = "X";
            this.btnvezes.UseVisualStyleBackColor = true;
            this.btnvezes.Click += new System.EventHandler(this.btnmais_Click);
            // 
            // btndividir
            // 
            this.btndividir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndividir.Location = new System.Drawing.Point(248, 78);
            this.btndividir.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(68, 58);
            this.btndividir.TabIndex = 6;
            this.btndividir.Text = "/";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.btnmais_Click);
            // 
            // bntigual
            // 
            this.bntigual.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntigual.Location = new System.Drawing.Point(248, 340);
            this.bntigual.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.bntigual.Name = "bntigual";
            this.bntigual.Size = new System.Drawing.Size(68, 58);
            this.bntigual.TabIndex = 8;
            this.bntigual.Text = "=";
            this.bntigual.UseVisualStyleBackColor = true;
            // 
            // bnt1
            // 
            this.bnt1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt1.Location = new System.Drawing.Point(27, 275);
            this.bnt1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.bnt1.Name = "bnt1";
            this.bnt1.Size = new System.Drawing.Size(68, 58);
            this.bnt1.TabIndex = 16;
            this.bnt1.Text = "1";
            this.bnt1.UseVisualStyleBackColor = true;
            this.bnt1.Click += new System.EventHandler(this.bnt0_Click);
            // 
            // bnt4
            // 
            this.bnt4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt4.Location = new System.Drawing.Point(27, 211);
            this.bnt4.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.bnt4.Name = "bnt4";
            this.bnt4.Size = new System.Drawing.Size(68, 58);
            this.bnt4.TabIndex = 15;
            this.bnt4.Text = "4";
            this.bnt4.UseVisualStyleBackColor = true;
            this.bnt4.Click += new System.EventHandler(this.bnt0_Click);
            // 
            // bnt7
            // 
            this.bnt7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt7.Location = new System.Drawing.Point(27, 147);
            this.bnt7.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.bnt7.Name = "bnt7";
            this.bnt7.Size = new System.Drawing.Size(68, 58);
            this.bnt7.TabIndex = 17;
            this.bnt7.Text = "7";
            this.bnt7.UseVisualStyleBackColor = true;
            this.bnt7.Click += new System.EventHandler(this.bnt0_Click);
            // 
            // bnt8
            // 
            this.bnt8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt8.Location = new System.Drawing.Point(101, 147);
            this.bnt8.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.bnt8.Name = "bnt8";
            this.bnt8.Size = new System.Drawing.Size(68, 58);
            this.bnt8.TabIndex = 20;
            this.bnt8.Text = "8";
            this.bnt8.UseVisualStyleBackColor = true;
            this.bnt8.Click += new System.EventHandler(this.bnt0_Click);
            // 
            // bnt2
            // 
            this.bnt2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt2.Location = new System.Drawing.Point(101, 275);
            this.bnt2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.bnt2.Name = "bnt2";
            this.bnt2.Size = new System.Drawing.Size(68, 58);
            this.bnt2.TabIndex = 19;
            this.bnt2.Text = "2";
            this.bnt2.UseVisualStyleBackColor = true;
            this.bnt2.Click += new System.EventHandler(this.bnt0_Click);
            // 
            // bnt5
            // 
            this.bnt5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt5.Location = new System.Drawing.Point(101, 211);
            this.bnt5.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.bnt5.Name = "bnt5";
            this.bnt5.Size = new System.Drawing.Size(68, 58);
            this.bnt5.TabIndex = 18;
            this.bnt5.Text = "5";
            this.bnt5.UseVisualStyleBackColor = true;
            this.bnt5.Click += new System.EventHandler(this.bnt0_Click);
            // 
            // bnt9
            // 
            this.bnt9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt9.Location = new System.Drawing.Point(174, 147);
            this.bnt9.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.bnt9.Name = "bnt9";
            this.bnt9.Size = new System.Drawing.Size(68, 58);
            this.bnt9.TabIndex = 23;
            this.bnt9.Text = "9";
            this.bnt9.UseVisualStyleBackColor = true;
            this.bnt9.Click += new System.EventHandler(this.bnt0_Click);
            // 
            // bnt3
            // 
            this.bnt3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt3.Location = new System.Drawing.Point(174, 275);
            this.bnt3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.bnt3.Name = "bnt3";
            this.bnt3.Size = new System.Drawing.Size(68, 58);
            this.bnt3.TabIndex = 22;
            this.bnt3.Text = "3";
            this.bnt3.UseVisualStyleBackColor = true;
            this.bnt3.Click += new System.EventHandler(this.bnt0_Click);
            // 
            // bnt6
            // 
            this.bnt6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt6.Location = new System.Drawing.Point(174, 211);
            this.bnt6.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.bnt6.Name = "bnt6";
            this.bnt6.Size = new System.Drawing.Size(68, 58);
            this.bnt6.TabIndex = 21;
            this.bnt6.Text = "6";
            this.bnt6.UseVisualStyleBackColor = true;
            this.bnt6.Click += new System.EventHandler(this.bnt0_Click);
            // 
            // bnt0
            // 
            this.bnt0.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt0.Location = new System.Drawing.Point(101, 340);
            this.bnt0.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.bnt0.Name = "bnt0";
            this.bnt0.Size = new System.Drawing.Size(68, 58);
            this.bnt0.TabIndex = 24;
            this.bnt0.Text = "0";
            this.bnt0.UseVisualStyleBackColor = true;
            this.bnt0.Click += new System.EventHandler(this.bnt0_Click);
            // 
            // bntapagar
            // 
            this.bntapagar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntapagar.Location = new System.Drawing.Point(27, 340);
            this.bntapagar.Name = "bntapagar";
            this.bntapagar.Size = new System.Drawing.Size(68, 58);
            this.bntapagar.TabIndex = 25;
            this.bntapagar.Text = "C";
            this.bntapagar.UseVisualStyleBackColor = true;
            this.bntapagar.Click += new System.EventHandler(this.bnt0_Click);
            // 
            // lbtemp
            // 
            this.lbtemp.AutoSize = true;
            this.lbtemp.Location = new System.Drawing.Point(24, 78);
            this.lbtemp.Name = "lbtemp";
            this.lbtemp.Size = new System.Drawing.Size(32, 14);
            this.lbtemp.TabIndex = 26;
            this.lbtemp.Text = "TEMP";
            // 
            // lboperador
            // 
            this.lboperador.AutoSize = true;
            this.lboperador.Location = new System.Drawing.Point(62, 78);
            this.lboperador.Name = "lboperador";
            this.lboperador.Size = new System.Drawing.Size(19, 14);
            this.lboperador.TabIndex = 27;
            this.lboperador.Text = "OP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(340, 417);
            this.Controls.Add(this.lboperador);
            this.Controls.Add(this.lbtemp);
            this.Controls.Add(this.bntapagar);
            this.Controls.Add(this.bnt0);
            this.Controls.Add(this.bnt9);
            this.Controls.Add(this.bnt3);
            this.Controls.Add(this.bnt6);
            this.Controls.Add(this.bnt8);
            this.Controls.Add(this.bnt2);
            this.Controls.Add(this.bnt5);
            this.Controls.Add(this.bnt7);
            this.Controls.Add(this.bnt1);
            this.Controls.Add(this.bnt4);
            this.Controls.Add(this.bntigual);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.btnvezes);
            this.Controls.Add(this.btnmenos);
            this.Controls.Add(this.btnmais);
            this.Controls.Add(this.lbresultado);
            this.Controls.Add(this.txbnumero1);
            this.Font = new System.Drawing.Font("NewsGoth Cn BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbnumero1;
        private System.Windows.Forms.Label lbresultado;
        private System.Windows.Forms.Button btnmais;
        private System.Windows.Forms.Button btnmenos;
        private System.Windows.Forms.Button btnvezes;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.Button bntigual;
        private System.Windows.Forms.Button bnt1;
        private System.Windows.Forms.Button bnt4;
        private System.Windows.Forms.Button bnt7;
        private System.Windows.Forms.Button bnt8;
        private System.Windows.Forms.Button bnt2;
        private System.Windows.Forms.Button bnt5;
        private System.Windows.Forms.Button bnt9;
        private System.Windows.Forms.Button bnt3;
        private System.Windows.Forms.Button bnt6;
        private System.Windows.Forms.Button bnt0;
        private System.Windows.Forms.Button bntapagar;
        private System.Windows.Forms.Label lbtemp;
        private System.Windows.Forms.Label lboperador;
    }
}

