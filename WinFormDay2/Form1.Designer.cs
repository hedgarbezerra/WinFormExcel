namespace WinFormDay2
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
            this.lblEmailDestinario = new System.Windows.Forms.Label();
            this.btnEnviarRelatorio = new System.Windows.Forms.Button();
            this.txtMensagem = new System.Windows.Forms.RichTextBox();
            this.txtEmailDestinario = new System.Windows.Forms.TextBox();
            this.lblMain = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.txtCaminhoArq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmailDestinario
            // 
            this.lblEmailDestinario.AutoSize = true;
            this.lblEmailDestinario.Location = new System.Drawing.Point(12, 112);
            this.lblEmailDestinario.Name = "lblEmailDestinario";
            this.lblEmailDestinario.Size = new System.Drawing.Size(54, 13);
            this.lblEmailDestinario.TabIndex = 0;
            this.lblEmailDestinario.Text = "Destinário";
            // 
            // btnEnviarRelatorio
            // 
            this.btnEnviarRelatorio.Location = new System.Drawing.Point(237, 250);
            this.btnEnviarRelatorio.Name = "btnEnviarRelatorio";
            this.btnEnviarRelatorio.Size = new System.Drawing.Size(142, 39);
            this.btnEnviarRelatorio.TabIndex = 1;
            this.btnEnviarRelatorio.Text = "Enviar Relátorio";
            this.btnEnviarRelatorio.UseVisualStyleBackColor = true;
            this.btnEnviarRelatorio.Click += new System.EventHandler(this.BtnEnviarRelatorio_Click);
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(356, 80);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(246, 111);
            this.txtMensagem.TabIndex = 2;
            this.txtMensagem.Text = "";
            // 
            // txtEmailDestinario
            // 
            this.txtEmailDestinario.Location = new System.Drawing.Point(12, 128);
            this.txtEmailDestinario.Name = "txtEmailDestinario";
            this.txtEmailDestinario.Size = new System.Drawing.Size(247, 20);
            this.txtEmailDestinario.TabIndex = 3;
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(261, 9);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(93, 13);
            this.lblMain.TabIndex = 4;
            this.lblMain.Text = "Excel de Relátorio";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(12, 182);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(247, 20);
            this.txtAssunto.TabIndex = 6;
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Location = new System.Drawing.Point(12, 166);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(45, 13);
            this.lblAssunto.TabIndex = 5;
            this.lblAssunto.Text = "Assunto";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(459, 64);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(59, 13);
            this.lblMensagem.TabIndex = 7;
            this.lblMensagem.Text = "Mensagem";
            this.lblMensagem.Click += new System.EventHandler(this.LblMensagem_Click);
            // 
            // txtCaminhoArq
            // 
            this.txtCaminhoArq.Enabled = false;
            this.txtCaminhoArq.Location = new System.Drawing.Point(12, 80);
            this.txtCaminhoArq.Name = "txtCaminhoArq";
            this.txtCaminhoArq.Size = new System.Drawing.Size(247, 20);
            this.txtCaminhoArq.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Destino do Relátorio";
            // 
            // btnArquivo
            // 
            this.btnArquivo.Location = new System.Drawing.Point(283, 80);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(67, 21);
            this.btnArquivo.TabIndex = 10;
            this.btnArquivo.Text = "Abrir";
            this.btnArquivo.UseVisualStyleBackColor = true;
            this.btnArquivo.Click += new System.EventHandler(this.BtnArquivo_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(614, 301);
            this.Controls.Add(this.btnArquivo);
            this.Controls.Add(this.txtCaminhoArq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.lblAssunto);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.txtEmailDestinario);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.btnEnviarRelatorio);
            this.Controls.Add(this.lblEmailDestinario);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmailDestinario;
        private System.Windows.Forms.Button btnEnviarRelatorio;
        private System.Windows.Forms.RichTextBox txtMensagem;
        private System.Windows.Forms.TextBox txtEmailDestinario;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.TextBox txtCaminhoArq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnArquivo;
    }
}

