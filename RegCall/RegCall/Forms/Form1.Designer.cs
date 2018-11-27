namespace RegCall
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_LjCd = new System.Windows.Forms.TextBox();
            this.txt_Telefone = new System.Windows.Forms.TextBox();
            this.txt_Ip = new System.Windows.Forms.TextBox();
            this.btn_CopiarIP = new System.Windows.Forms.Button();
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Refazer = new System.Windows.Forms.Button();
            this.btn_Copiar = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_config = new System.Windows.Forms.Button();
            this.btn_pingIP = new System.Windows.Forms.Button();
            this.btn_pingServer = new System.Windows.Forms.Button();
            this.btn_classificacao = new System.Windows.Forms.Button();
            this.btn_checkList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Nome
            // 
            this.txt_Nome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_Nome.Location = new System.Drawing.Point(2, 3);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(108, 23);
            this.txt_Nome.TabIndex = 0;
            this.txt_Nome.Tag = "";
            this.txt_Nome.Text = "Nome";
            this.txt_Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Nome.Enter += new System.EventHandler(this.txt_Nome_Enter);
            this.txt_Nome.Leave += new System.EventHandler(this.txt_Nome_Leave);
            // 
            // txt_LjCd
            // 
            this.txt_LjCd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LjCd.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_LjCd.Location = new System.Drawing.Point(2, 32);
            this.txt_LjCd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_LjCd.MaxLength = 4;
            this.txt_LjCd.Name = "txt_LjCd";
            this.txt_LjCd.Size = new System.Drawing.Size(42, 23);
            this.txt_LjCd.TabIndex = 1;
            this.txt_LjCd.Text = "Loja";
            this.txt_LjCd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_LjCd.TextChanged += new System.EventHandler(this.txt_loja_TextChanged);
            this.txt_LjCd.Enter += new System.EventHandler(this.txt_LjCd_Enter);
            this.txt_LjCd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_LjCd_KeyPress);
            this.txt_LjCd.Leave += new System.EventHandler(this.txt_LjCd_Leave);
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefone.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_Telefone.Location = new System.Drawing.Point(114, 3);
            this.txt_Telefone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(108, 23);
            this.txt_Telefone.TabIndex = 2;
            this.txt_Telefone.Tag = "";
            this.txt_Telefone.Text = "Telefone";
            this.txt_Telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Telefone.Enter += new System.EventHandler(this.txt_Telefone_Enter);
            this.txt_Telefone.Leave += new System.EventHandler(this.txt_Telefone_Leave);
            // 
            // txt_Ip
            // 
            this.txt_Ip.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ip.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_Ip.Location = new System.Drawing.Point(47, 32);
            this.txt_Ip.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Ip.Name = "txt_Ip";
            this.txt_Ip.Size = new System.Drawing.Size(108, 23);
            this.txt_Ip.TabIndex = 5;
            this.txt_Ip.Tag = "";
            this.txt_Ip.Text = "IP";
            this.txt_Ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Ip.Enter += new System.EventHandler(this.txt_Ip_Enter);
            this.txt_Ip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Ip_KeyPress);
            this.txt_Ip.Leave += new System.EventHandler(this.txt_Ip_Leave);
            // 
            // btn_CopiarIP
            // 
            this.btn_CopiarIP.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btn_CopiarIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CopiarIP.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CopiarIP.ForeColor = System.Drawing.Color.White;
            this.btn_CopiarIP.Location = new System.Drawing.Point(161, 31);
            this.btn_CopiarIP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_CopiarIP.Name = "btn_CopiarIP";
            this.btn_CopiarIP.Size = new System.Drawing.Size(61, 24);
            this.btn_CopiarIP.TabIndex = 6;
            this.btn_CopiarIP.Text = "Copiar";
            this.btn_CopiarIP.UseVisualStyleBackColor = true;
            this.btn_CopiarIP.Click += new System.EventHandler(this.btn_CopiarIP_Click);
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_Descricao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descricao.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_Descricao.Location = new System.Drawing.Point(2, 122);
            this.txt_Descricao.Multiline = true;
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Descricao.Size = new System.Drawing.Size(220, 96);
            this.txt_Descricao.TabIndex = 4;
            this.txt_Descricao.Text = "Descrição\r\n\r\nUsuario informa que...";
            this.txt_Descricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Descricao.Enter += new System.EventHandler(this.txt_Descricao_Enter);
            this.txt_Descricao.Leave += new System.EventHandler(this.txt_Descricao_Leave);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Limpar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpar.Location = new System.Drawing.Point(2, 224);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(70, 26);
            this.btn_Limpar.TabIndex = 9;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Refazer
            // 
            this.btn_Refazer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Refazer.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btn_Refazer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refazer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refazer.ForeColor = System.Drawing.Color.White;
            this.btn_Refazer.Location = new System.Drawing.Point(77, 224);
            this.btn_Refazer.Name = "btn_Refazer";
            this.btn_Refazer.Size = new System.Drawing.Size(70, 26);
            this.btn_Refazer.TabIndex = 8;
            this.btn_Refazer.Text = "Refazer";
            this.btn_Refazer.UseVisualStyleBackColor = true;
            this.btn_Refazer.Click += new System.EventHandler(this.btn_Refazer_Click);
            // 
            // btn_Copiar
            // 
            this.btn_Copiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Copiar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_Copiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Copiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Copiar.ForeColor = System.Drawing.Color.White;
            this.btn_Copiar.Location = new System.Drawing.Point(152, 224);
            this.btn_Copiar.Name = "btn_Copiar";
            this.btn_Copiar.Size = new System.Drawing.Size(70, 26);
            this.btn_Copiar.TabIndex = 7;
            this.btn_Copiar.Text = "Copiar";
            this.btn_Copiar.UseVisualStyleBackColor = true;
            this.btn_Copiar.Click += new System.EventHandler(this.btn_Copiar_Click);
            // 
            // btn_info
            // 
            this.btn_info.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_info.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_info.ForeColor = System.Drawing.Color.White;
            this.btn_info.Location = new System.Drawing.Point(2, 93);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(70, 23);
            this.btn_info.TabIndex = 11;
            this.btn_info.TabStop = false;
            this.btn_info.Text = "INFO";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_config
            // 
            this.btn_config.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_config.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_config.ForeColor = System.Drawing.Color.White;
            this.btn_config.Location = new System.Drawing.Point(77, 93);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(70, 23);
            this.btn_config.TabIndex = 12;
            this.btn_config.TabStop = false;
            this.btn_config.Text = "CONFIG";
            this.btn_config.UseVisualStyleBackColor = true;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // btn_pingIP
            // 
            this.btn_pingIP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_pingIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pingIP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pingIP.ForeColor = System.Drawing.Color.White;
            this.btn_pingIP.Location = new System.Drawing.Point(77, 61);
            this.btn_pingIP.Name = "btn_pingIP";
            this.btn_pingIP.Size = new System.Drawing.Size(70, 26);
            this.btn_pingIP.TabIndex = 14;
            this.btn_pingIP.TabStop = false;
            this.btn_pingIP.Text = "Ping IP";
            this.btn_pingIP.UseVisualStyleBackColor = true;
            this.btn_pingIP.Click += new System.EventHandler(this.btn_pingIP_Click);
            // 
            // btn_pingServer
            // 
            this.btn_pingServer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_pingServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pingServer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pingServer.ForeColor = System.Drawing.Color.White;
            this.btn_pingServer.Location = new System.Drawing.Point(2, 61);
            this.btn_pingServer.Name = "btn_pingServer";
            this.btn_pingServer.Size = new System.Drawing.Size(70, 26);
            this.btn_pingServer.TabIndex = 13;
            this.btn_pingServer.TabStop = false;
            this.btn_pingServer.Text = "Server";
            this.btn_pingServer.UseVisualStyleBackColor = true;
            this.btn_pingServer.Click += new System.EventHandler(this.btn_pingServer_Click);
            // 
            // btn_classificacao
            // 
            this.btn_classificacao.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_classificacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_classificacao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_classificacao.ForeColor = System.Drawing.Color.White;
            this.btn_classificacao.Location = new System.Drawing.Point(152, 93);
            this.btn_classificacao.Name = "btn_classificacao";
            this.btn_classificacao.Size = new System.Drawing.Size(70, 23);
            this.btn_classificacao.TabIndex = 15;
            this.btn_classificacao.TabStop = false;
            this.btn_classificacao.Text = "CLASS";
            this.btn_classificacao.UseVisualStyleBackColor = true;
            // 
            // btn_checkList
            // 
            this.btn_checkList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_checkList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_checkList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkList.ForeColor = System.Drawing.Color.White;
            this.btn_checkList.Location = new System.Drawing.Point(152, 61);
            this.btn_checkList.Name = "btn_checkList";
            this.btn_checkList.Size = new System.Drawing.Size(70, 26);
            this.btn_checkList.TabIndex = 16;
            this.btn_checkList.TabStop = false;
            this.btn_checkList.Text = "Check";
            this.btn_checkList.UseVisualStyleBackColor = true;
            this.btn_checkList.Click += new System.EventHandler(this.btn_checkList_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(224, 252);
            this.Controls.Add(this.btn_checkList);
            this.Controls.Add(this.btn_classificacao);
            this.Controls.Add(this.btn_pingIP);
            this.Controls.Add(this.btn_pingServer);
            this.Controls.Add(this.btn_config);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.btn_Copiar);
            this.Controls.Add(this.btn_Refazer);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.txt_Descricao);
            this.Controls.Add(this.btn_CopiarIP);
            this.Controls.Add(this.txt_Ip);
            this.Controls.Add(this.txt_Telefone);
            this.Controls.Add(this.txt_LjCd);
            this.Controls.Add(this.txt_Nome);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegCall";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Enter += new System.EventHandler(this.MainForm_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_LjCd;
        private System.Windows.Forms.TextBox txt_Telefone;
        private System.Windows.Forms.TextBox txt_Ip;
        private System.Windows.Forms.Button btn_CopiarIP;
        private System.Windows.Forms.TextBox txt_Descricao;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Refazer;
        private System.Windows.Forms.Button btn_Copiar;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_config;
        private System.Windows.Forms.Button btn_pingIP;
        private System.Windows.Forms.Button btn_pingServer;
        private System.Windows.Forms.Button btn_classificacao;
        private System.Windows.Forms.Button btn_checkList;
    }
}

