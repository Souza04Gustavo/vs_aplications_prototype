namespace TesteCameraBasico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictCamImagem = new PictureBox();
            pictImagemRecortada = new PictureBox();
            cmbCameras = new ComboBox();
            btnIniciar = new Button();
            btnEncerrar = new Button();
            btnSalvarImagem = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictCamImagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictImagemRecortada).BeginInit();
            SuspendLayout();
            // 
            // pictCamImagem
            // 
            pictCamImagem.Location = new Point(73, 37);
            pictCamImagem.Name = "pictCamImagem";
            pictCamImagem.Size = new Size(434, 333);
            pictCamImagem.SizeMode = PictureBoxSizeMode.Zoom;
            pictCamImagem.TabIndex = 0;
            pictCamImagem.TabStop = false;
            pictCamImagem.Click += pictCamImagem_Click;
            // 
            // pictImagemRecortada
            // 
            pictImagemRecortada.Location = new Point(766, 37);
            pictImagemRecortada.Name = "pictImagemRecortada";
            pictImagemRecortada.Size = new Size(434, 333);
            pictImagemRecortada.SizeMode = PictureBoxSizeMode.Zoom;
            pictImagemRecortada.TabIndex = 2;
            pictImagemRecortada.TabStop = false;
            pictImagemRecortada.Click += pictImagemRecortada_Click;
            // 
            // cmbCameras
            // 
            cmbCameras.Cursor = Cursors.Hand;
            cmbCameras.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCameras.FormattingEnabled = true;
            cmbCameras.Location = new Point(564, 78);
            cmbCameras.Name = "cmbCameras";
            cmbCameras.Size = new Size(159, 28);
            cmbCameras.TabIndex = 4;
            cmbCameras.SelectedIndexChanged += cmbCameras_SelectedIndexChanged;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.Chartreuse;
            btnIniciar.Cursor = Cursors.Hand;
            btnIniciar.Location = new Point(564, 147);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(159, 53);
            btnIniciar.TabIndex = 5;
            btnIniciar.Text = "INICIAR";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += button1_Click;
            // 
            // btnEncerrar
            // 
            btnEncerrar.BackColor = Color.Tomato;
            btnEncerrar.Cursor = Cursors.Hand;
            btnEncerrar.Location = new Point(564, 225);
            btnEncerrar.Name = "btnEncerrar";
            btnEncerrar.Size = new Size(159, 53);
            btnEncerrar.TabIndex = 6;
            btnEncerrar.Text = "ENCERRAR";
            btnEncerrar.UseVisualStyleBackColor = false;
            btnEncerrar.Click += button2_Click;
            // 
            // btnSalvarImagem
            // 
            btnSalvarImagem.BackColor = SystemColors.ActiveCaption;
            btnSalvarImagem.Cursor = Cursors.Hand;
            btnSalvarImagem.Location = new Point(564, 304);
            btnSalvarImagem.Name = "btnSalvarImagem";
            btnSalvarImagem.Size = new Size(159, 53);
            btnSalvarImagem.TabIndex = 7;
            btnSalvarImagem.Text = "SALVAR";
            btnSalvarImagem.UseVisualStyleBackColor = false;
            btnSalvarImagem.Click += btnSalvarImagem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Artifakt Element", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(895, 373);
            label1.Name = "label1";
            label1.Size = new Size(167, 32);
            label1.TabIndex = 8;
            label1.Text = "Imagem salva";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Artifakt Element", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(158, 373);
            label2.Name = "label2";
            label2.Size = new Size(266, 32);
            label2.TabIndex = 9;
            label2.Text = "Imagem em tempo real";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 452);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalvarImagem);
            Controls.Add(btnEncerrar);
            Controls.Add(btnIniciar);
            Controls.Add(cmbCameras);
            Controls.Add(pictImagemRecortada);
            Controls.Add(pictCamImagem);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictCamImagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictImagemRecortada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictCamImagem;
        private PictureBox pictImagemRecortada;
        private ComboBox cmbCameras;
        private Button btnIniciar;
        private Button btnEncerrar;
        private Button btnSalvarImagem;
        private Label label1;
        private Label label2;
    }
}
