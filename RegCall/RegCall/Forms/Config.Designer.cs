namespace RegCall
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.ckb_visivel = new System.Windows.Forms.CheckBox();
            this.ckb_remote = new System.Windows.Forms.CheckBox();
            this.txt_remote = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_padrao = new System.Windows.Forms.Button();
            this.btn_abrirEm = new System.Windows.Forms.Button();
            this.ckb_registro = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txt_registro = new System.Windows.Forms.TextBox();
            this.txt_rangeServer = new System.Windows.Forms.TextBox();
            this.ckb_rangeServer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ckb_visivel
            // 
            this.ckb_visivel.AutoSize = true;
            this.ckb_visivel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.ckb_visivel.ForeColor = System.Drawing.Color.White;
            this.ckb_visivel.Location = new System.Drawing.Point(11, 12);
            this.ckb_visivel.Name = "ckb_visivel";
            this.ckb_visivel.Size = new System.Drawing.Size(118, 20);
            this.ckb_visivel.TabIndex = 0;
            this.ckb_visivel.Text = "Sempre Visível";
            this.ckb_visivel.UseVisualStyleBackColor = false;
            // 
            // ckb_remote
            // 
            this.ckb_remote.AutoSize = true;
            this.ckb_remote.ForeColor = System.Drawing.Color.White;
            this.ckb_remote.Location = new System.Drawing.Point(11, 130);
            this.ckb_remote.Name = "ckb_remote";
            this.ckb_remote.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckb_remote.Size = new System.Drawing.Size(106, 20);
            this.ckb_remote.TabIndex = 1;
            this.ckb_remote.Text = "Abrir Remote";
            this.ckb_remote.UseVisualStyleBackColor = true;
            this.ckb_remote.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            this.ckb_remote.Click += new System.EventHandler(this.ckb_remote_Click);
            this.ckb_remote.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ckb_remote_MouseClick);
            // 
            // txt_remote
            // 
            this.txt_remote.BackColor = System.Drawing.Color.Black;
            this.txt_remote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_remote.Enabled = false;
            this.txt_remote.ForeColor = System.Drawing.Color.White;
            this.txt_remote.Location = new System.Drawing.Point(12, 156);
            this.txt_remote.Name = "txt_remote";
            this.txt_remote.Size = new System.Drawing.Size(272, 22);
            this.txt_remote.TabIndex = 2;
            this.txt_remote.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_remote_MouseClick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(196, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(11, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_padrao
            // 
            this.btn_padrao.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_padrao.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btn_padrao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_padrao.Location = new System.Drawing.Point(104, 281);
            this.btn_padrao.Name = "btn_padrao";
            this.btn_padrao.Size = new System.Drawing.Size(87, 28);
            this.btn_padrao.TabIndex = 5;
            this.btn_padrao.Text = "Padrões";
            this.btn_padrao.UseVisualStyleBackColor = true;
            this.btn_padrao.Click += new System.EventHandler(this.btn_padrao_Click);
            // 
            // btn_abrirEm
            // 
            this.btn_abrirEm.Enabled = false;
            this.btn_abrirEm.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btn_abrirEm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abrirEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abrirEm.Location = new System.Drawing.Point(80, 184);
            this.btn_abrirEm.Name = "btn_abrirEm";
            this.btn_abrirEm.Size = new System.Drawing.Size(132, 31);
            this.btn_abrirEm.TabIndex = 6;
            this.btn_abrirEm.Text = "Abrir em...";
            this.btn_abrirEm.UseVisualStyleBackColor = true;
            this.btn_abrirEm.Click += new System.EventHandler(this.button4_Click);
            // 
            // ckb_registro
            // 
            this.ckb_registro.AutoSize = true;
            this.ckb_registro.ForeColor = System.Drawing.Color.White;
            this.ckb_registro.Location = new System.Drawing.Point(11, 38);
            this.ckb_registro.Name = "ckb_registro";
            this.ckb_registro.Size = new System.Drawing.Size(120, 20);
            this.ckb_registro.TabIndex = 7;
            this.ckb_registro.Text = "Salvar Registro";
            this.ckb_registro.UseVisualStyleBackColor = true;
            this.ckb_registro.Click += new System.EventHandler(this.ckb_registro_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(80, 92);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 32);
            this.button5.TabIndex = 9;
            this.button5.Text = "Abrir Diretorio";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt_registro
            // 
            this.txt_registro.BackColor = System.Drawing.Color.Black;
            this.txt_registro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_registro.Enabled = false;
            this.txt_registro.ForeColor = System.Drawing.Color.White;
            this.txt_registro.Location = new System.Drawing.Point(11, 64);
            this.txt_registro.Name = "txt_registro";
            this.txt_registro.ReadOnly = true;
            this.txt_registro.Size = new System.Drawing.Size(272, 22);
            this.txt_registro.TabIndex = 8;
            // 
            // txt_rangeServer
            // 
            this.txt_rangeServer.BackColor = System.Drawing.Color.Black;
            this.txt_rangeServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_rangeServer.Enabled = false;
            this.txt_rangeServer.ForeColor = System.Drawing.Color.White;
            this.txt_rangeServer.Location = new System.Drawing.Point(11, 247);
            this.txt_rangeServer.Name = "txt_rangeServer";
            this.txt_rangeServer.Size = new System.Drawing.Size(272, 22);
            this.txt_rangeServer.TabIndex = 10;
            // 
            // ckb_rangeServer
            // 
            this.ckb_rangeServer.AutoSize = true;
            this.ckb_rangeServer.ForeColor = System.Drawing.Color.White;
            this.ckb_rangeServer.Location = new System.Drawing.Point(11, 221);
            this.ckb_rangeServer.Name = "ckb_rangeServer";
            this.ckb_rangeServer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckb_rangeServer.Size = new System.Drawing.Size(172, 20);
            this.ckb_rangeServer.TabIndex = 11;
            this.ckb_rangeServer.Text = "Alterar Range do Server";
            this.ckb_rangeServer.UseVisualStyleBackColor = true;
            this.ckb_rangeServer.Click += new System.EventHandler(this.ckb_rangeServer_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(295, 321);
            this.Controls.Add(this.ckb_rangeServer);
            this.Controls.Add(this.txt_rangeServer);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txt_registro);
            this.Controls.Add(this.ckb_registro);
            this.Controls.Add(this.btn_abrirEm);
            this.Controls.Add(this.btn_padrao);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_remote);
            this.Controls.Add(this.ckb_remote);
            this.Controls.Add(this.ckb_visivel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Config";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckb_visivel;
        private System.Windows.Forms.CheckBox ckb_remote;
        private System.Windows.Forms.TextBox txt_remote;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_padrao;
        private System.Windows.Forms.Button btn_abrirEm;
        private System.Windows.Forms.CheckBox ckb_registro;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txt_registro;
        private System.Windows.Forms.TextBox txt_rangeServer;
        private System.Windows.Forms.CheckBox ckb_rangeServer;
    }
}