namespace Projeto_Controle_Basico
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
            this.btnImagem = new System.Windows.Forms.Button();
            this.lblImagem = new System.Windows.Forms.Label();
            this.btnGcode = new System.Windows.Forms.Button();
            this.lblGcode = new System.Windows.Forms.Label();
            this.btnLed = new System.Windows.Forms.Button();
            this.lblStatusLed = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.pictureBoxImagem = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImagem
            // 
            this.btnImagem.Location = new System.Drawing.Point(73, 248);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(202, 33);
            this.btnImagem.TabIndex = 0;
            this.btnImagem.Text = "Selecionar Imagem";
            this.btnImagem.UseVisualStyleBackColor = true;
            this.btnImagem.Click += new System.EventHandler(this.BtnImagem_Click);
            // 
            // lblImagem
            // 
            this.lblImagem.AutoSize = true;
            this.lblImagem.Location = new System.Drawing.Point(85, 293);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(136, 16);
            this.lblImagem.TabIndex = 1;
            this.lblImagem.Text = "Imagem Selecionada";
            // 
            // btnGcode
            // 
            this.btnGcode.Location = new System.Drawing.Point(73, 350);
            this.btnGcode.Name = "btnGcode";
            this.btnGcode.Size = new System.Drawing.Size(202, 33);
            this.btnGcode.TabIndex = 2;
            this.btnGcode.Text = "Selecionar G-Code";
            this.btnGcode.UseVisualStyleBackColor = true;
            this.btnGcode.Click += new System.EventHandler(this.BtnGcode_Click);
            // 
            // lblGcode
            // 
            this.lblGcode.AutoSize = true;
            this.lblGcode.Location = new System.Drawing.Point(85, 400);
            this.lblGcode.Name = "lblGcode";
            this.lblGcode.Size = new System.Drawing.Size(134, 16);
            this.lblGcode.TabIndex = 3;
            this.lblGcode.Text = "G-Code Selecionado";
            // 
            // btnLed
            // 
            this.btnLed.Location = new System.Drawing.Point(372, 244);
            this.btnLed.Name = "btnLed";
            this.btnLed.Size = new System.Drawing.Size(188, 33);
            this.btnLed.TabIndex = 4;
            this.btnLed.Text = "Mudar estado LED";
            this.btnLed.UseVisualStyleBackColor = true;
            this.btnLed.Click += new System.EventHandler(this.BtnLed_Click);
            // 
            // lblStatusLed
            // 
            this.lblStatusLed.AutoSize = true;
            this.lblStatusLed.Location = new System.Drawing.Point(463, 297);
            this.lblStatusLed.Name = "lblStatusLed";
            this.lblStatusLed.Size = new System.Drawing.Size(87, 16);
            this.lblStatusLed.TabIndex = 5;
            this.lblStatusLed.Text = "Não Alterado";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(399, 404);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(151, 65);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar Arquivos";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // pictureBoxImagem
            // 
            this.pictureBoxImagem.Location = new System.Drawing.Point(615, 244);
            this.pictureBoxImagem.Name = "pictureBoxImagem";
            this.pictureBoxImagem.Size = new System.Drawing.Size(282, 225);
            this.pictureBoxImagem.TabIndex = 7;
            this.pictureBoxImagem.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Status LED:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Painel Principal de Controle";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(369, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "OVERMAQ 2025";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(656, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Exibição da Imagem";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(394, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Controle do LED";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Seleção de Arquivos";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 524);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxImagem);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblStatusLed);
            this.Controls.Add(this.btnLed);
            this.Controls.Add(this.lblGcode);
            this.Controls.Add(this.btnGcode);
            this.Controls.Add(this.lblImagem);
            this.Controls.Add(this.btnImagem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImagem;
        private System.Windows.Forms.Label lblImagem;
        private System.Windows.Forms.Button btnGcode;
        private System.Windows.Forms.Label lblGcode;
        private System.Windows.Forms.Button btnLed;
        private System.Windows.Forms.Label lblStatusLed;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.PictureBox pictureBoxImagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

