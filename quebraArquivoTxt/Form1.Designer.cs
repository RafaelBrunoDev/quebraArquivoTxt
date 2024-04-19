namespace quebraArquivoTxt
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
            this.txtQuebrar = new System.Windows.Forms.Button();
            this.txtSelecionar = new System.Windows.Forms.TextBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnDestino = new System.Windows.Forms.Button();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCaminhosArquivosQuebrados = new System.Windows.Forms.TextBox();
            this.txtCaminhoDestinoUnificado = new System.Windows.Forms.TextBox();
            this.btnSelecionarArquivosUnificar = new System.Windows.Forms.Button();
            this.btnSelecionarDestinoUnificado = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUnificarTxt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQuebrar
            // 
            this.txtQuebrar.Location = new System.Drawing.Point(17, 156);
            this.txtQuebrar.Name = "txtQuebrar";
            this.txtQuebrar.Size = new System.Drawing.Size(246, 44);
            this.txtQuebrar.TabIndex = 0;
            this.txtQuebrar.Text = "Quebrar TXT";
            this.txtQuebrar.UseVisualStyleBackColor = true;
            this.txtQuebrar.Click += new System.EventHandler(this.txtQuebrar_Click);
            // 
            // txtSelecionar
            // 
            this.txtSelecionar.Location = new System.Drawing.Point(17, 37);
            this.txtSelecionar.Multiline = true;
            this.txtSelecionar.Name = "txtSelecionar";
            this.txtSelecionar.Size = new System.Drawing.Size(585, 29);
            this.txtSelecionar.TabIndex = 1;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(608, 37);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(196, 30);
            this.btnSelecionar.TabIndex = 2;
            this.btnSelecionar.Text = "Selecionar para Quebrar TXT";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnDestino
            // 
            this.btnDestino.Location = new System.Drawing.Point(608, 113);
            this.btnDestino.Name = "btnDestino";
            this.btnDestino.Size = new System.Drawing.Size(196, 28);
            this.btnDestino.TabIndex = 3;
            this.btnDestino.Text = "Selecionar Destino Quebra TXT";
            this.btnDestino.UseVisualStyleBackColor = true;
            this.btnDestino.Click += new System.EventHandler(this.btnDestino_Click);
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(17, 113);
            this.txtDestino.Multiline = true;
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(585, 28);
            this.txtDestino.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecionar Arquivo TXT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selecionar Destino da Quebra TXT";
            // 
            // txtCaminhosArquivosQuebrados
            // 
            this.txtCaminhosArquivosQuebrados.Location = new System.Drawing.Point(17, 296);
            this.txtCaminhosArquivosQuebrados.Multiline = true;
            this.txtCaminhosArquivosQuebrados.Name = "txtCaminhosArquivosQuebrados";
            this.txtCaminhosArquivosQuebrados.Size = new System.Drawing.Size(585, 29);
            this.txtCaminhosArquivosQuebrados.TabIndex = 7;
            // 
            // txtCaminhoDestinoUnificado
            // 
            this.txtCaminhoDestinoUnificado.Location = new System.Drawing.Point(17, 406);
            this.txtCaminhoDestinoUnificado.Multiline = true;
            this.txtCaminhoDestinoUnificado.Name = "txtCaminhoDestinoUnificado";
            this.txtCaminhoDestinoUnificado.Size = new System.Drawing.Size(585, 28);
            this.txtCaminhoDestinoUnificado.TabIndex = 8;
            // 
            // btnSelecionarArquivosUnificar
            // 
            this.btnSelecionarArquivosUnificar.Location = new System.Drawing.Point(608, 296);
            this.btnSelecionarArquivosUnificar.Name = "btnSelecionarArquivosUnificar";
            this.btnSelecionarArquivosUnificar.Size = new System.Drawing.Size(196, 29);
            this.btnSelecionarArquivosUnificar.TabIndex = 9;
            this.btnSelecionarArquivosUnificar.Text = "Selecionar para Unificar TXT ";
            this.btnSelecionarArquivosUnificar.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivosUnificar.Click += new System.EventHandler(this.btnSelecionarArquivosUnificar_Click);
            // 
            // btnSelecionarDestinoUnificado
            // 
            this.btnSelecionarDestinoUnificado.Location = new System.Drawing.Point(608, 406);
            this.btnSelecionarDestinoUnificado.Name = "btnSelecionarDestinoUnificado";
            this.btnSelecionarDestinoUnificado.Size = new System.Drawing.Size(196, 28);
            this.btnSelecionarDestinoUnificado.TabIndex = 10;
            this.btnSelecionarDestinoUnificado.Text = "Selecionar Destino Unificação TXT";
            this.btnSelecionarDestinoUnificado.UseVisualStyleBackColor = true;
            this.btnSelecionarDestinoUnificado.Click += new System.EventHandler(this.btnSelecionarDestinoUnificado_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(395, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Selecionar Arquivos TXT Quebrados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(412, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Selecionar Destino da Unificação TXT";
            // 
            // btnUnificarTxt
            // 
            this.btnUnificarTxt.Location = new System.Drawing.Point(17, 457);
            this.btnUnificarTxt.Name = "btnUnificarTxt";
            this.btnUnificarTxt.Size = new System.Drawing.Size(246, 45);
            this.btnUnificarTxt.TabIndex = 13;
            this.btnUnificarTxt.Text = "Unificar TXT";
            this.btnUnificarTxt.UseVisualStyleBackColor = true;
            this.btnUnificarTxt.Click += new System.EventHandler(this.btnUnificarTxt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 613);
            this.Controls.Add(this.btnUnificarTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelecionarDestinoUnificado);
            this.Controls.Add(this.btnSelecionarArquivosUnificar);
            this.Controls.Add(this.txtCaminhoDestinoUnificado);
            this.Controls.Add(this.txtCaminhosArquivosQuebrados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.btnDestino);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.txtSelecionar);
            this.Controls.Add(this.txtQuebrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtQuebrar;
        private System.Windows.Forms.TextBox txtSelecionar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnDestino;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCaminhosArquivosQuebrados;
        private System.Windows.Forms.TextBox txtCaminhoDestinoUnificado;
        private System.Windows.Forms.Button btnSelecionarArquivosUnificar;
        private System.Windows.Forms.Button btnSelecionarDestinoUnificado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUnificarTxt;
    }
}

