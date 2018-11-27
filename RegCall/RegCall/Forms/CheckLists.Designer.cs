namespace RegCall
{
    partial class CheckLists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckLists));
            this.pnl_fundo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_telefonia = new System.Windows.Forms.Button();
            this.btn_field = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_fundo
            // 
            this.pnl_fundo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_fundo.Location = new System.Drawing.Point(1, 42);
            this.pnl_fundo.Name = "pnl_fundo";
            this.pnl_fundo.Size = new System.Drawing.Size(483, 382);
            this.pnl_fundo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_telefonia);
            this.panel1.Controls.Add(this.btn_field);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 38);
            this.panel1.TabIndex = 0;
            // 
            // btn_telefonia
            // 
            this.btn_telefonia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_telefonia.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_telefonia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_telefonia.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_telefonia.ForeColor = System.Drawing.Color.White;
            this.btn_telefonia.Location = new System.Drawing.Point(261, 2);
            this.btn_telefonia.Name = "btn_telefonia";
            this.btn_telefonia.Size = new System.Drawing.Size(200, 34);
            this.btn_telefonia.TabIndex = 1;
            this.btn_telefonia.Text = "Telefonia";
            this.btn_telefonia.UseVisualStyleBackColor = true;
            this.btn_telefonia.Click += new System.EventHandler(this.btn_telefonia_Click);
            // 
            // btn_field
            // 
            this.btn_field.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_field.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_field.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_field.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_field.ForeColor = System.Drawing.Color.White;
            this.btn_field.Location = new System.Drawing.Point(23, 2);
            this.btn_field.Name = "btn_field";
            this.btn_field.Size = new System.Drawing.Size(200, 34);
            this.btn_field.TabIndex = 0;
            this.btn_field.Text = "Field";
            this.btn_field.UseVisualStyleBackColor = true;
            this.btn_field.Click += new System.EventHandler(this.btn_field_Click);
            // 
            // CheckLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(484, 427);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_fundo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CheckLists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckLists";
            this.Load += new System.EventHandler(this.CheckLists_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_fundo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_telefonia;
        private System.Windows.Forms.Button btn_field;
    }
}