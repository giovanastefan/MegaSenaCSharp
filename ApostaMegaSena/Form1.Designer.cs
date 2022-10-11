namespace ApostaMegaSena
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAposta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPontos = new System.Windows.Forms.Label();
            this.btnFazerAposta = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblAposta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faça sua aposta(separe os números por espaço):";
            // 
            // txtAposta
            // 
            this.txtAposta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAposta.Location = new System.Drawing.Point(12, 115);
            this.txtAposta.Name = "txtAposta";
            this.txtAposta.Size = new System.Drawing.Size(500, 32);
            this.txtAposta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(12, 278);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(500, 32);
            this.txtResultado.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pontos Realizados:";
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos.Location = new System.Drawing.Point(209, 322);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(105, 23);
            this.lblPontos.TabIndex = 5;
            this.lblPontos.Text = " 0 pontos!";
            // 
            // btnFazerAposta
            // 
            this.btnFazerAposta.BackColor = System.Drawing.Color.White;
            this.btnFazerAposta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFazerAposta.FlatAppearance.BorderSize = 0;
            this.btnFazerAposta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFazerAposta.Location = new System.Drawing.Point(12, 153);
            this.btnFazerAposta.Name = "btnFazerAposta";
            this.btnFazerAposta.Size = new System.Drawing.Size(500, 34);
            this.btnFazerAposta.TabIndex = 6;
            this.btnFazerAposta.Text = "Fazer aposta";
            this.btnFazerAposta.UseVisualStyleBackColor = false;
            this.btnFazerAposta.Click += new System.EventHandler(this.btnFazerAposta_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLimpar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(374, 316);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(138, 35);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblAposta
            // 
            this.lblAposta.AutoSize = true;
            this.lblAposta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAposta.Location = new System.Drawing.Point(12, 200);
            this.lblAposta.Name = "lblAposta";
            this.lblAposta.Size = new System.Drawing.Size(92, 23);
            this.lblAposta.TabIndex = 8;
            this.lblAposta.Text = "Aposta: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 39);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mega-Sena:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblError.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblError.Location = new System.Drawing.Point(12, 93);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(14, 19);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(542, 368);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAposta);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFazerAposta);
            this.Controls.Add(this.lblPontos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAposta);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mega Sena";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAposta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.Button btnFazerAposta;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblAposta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblError;
    }
}

