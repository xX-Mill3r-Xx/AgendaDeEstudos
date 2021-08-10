
namespace AgendaDeEstudos
{
    partial class Configuracoes
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
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btn_GerarConexao = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Voltar.FlatAppearance.BorderSize = 0;
            this.btn_Voltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Voltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Voltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Voltar.Location = new System.Drawing.Point(697, 707);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(109, 37);
            this.btn_Voltar.TabIndex = 2;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Location = new System.Drawing.Point(13, 134);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(793, 567);
            this.panelPrincipal.TabIndex = 3;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTop.Controls.Add(this.button1);
            this.panelTop.Controls.Add(this.btn_GerarConexao);
            this.panelTop.Location = new System.Drawing.Point(13, 12);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(793, 116);
            this.panelTop.TabIndex = 4;
            // 
            // btn_GerarConexao
            // 
            this.btn_GerarConexao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GerarConexao.FlatAppearance.BorderSize = 0;
            this.btn_GerarConexao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btn_GerarConexao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_GerarConexao.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GerarConexao.ForeColor = System.Drawing.Color.White;
            this.btn_GerarConexao.Location = new System.Drawing.Point(30, 24);
            this.btn_GerarConexao.Name = "btn_GerarConexao";
            this.btn_GerarConexao.Size = new System.Drawing.Size(183, 68);
            this.btn_GerarConexao.TabIndex = 2;
            this.btn_GerarConexao.Text = "Gerar Conexão";
            this.btn_GerarConexao.UseVisualStyleBackColor = true;
            this.btn_GerarConexao.Click += new System.EventHandler(this.btn_GerarConexao_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(573, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 68);
            this.button1.TabIndex = 3;
            this.button1.Text = "Criar Tabela";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(818, 754);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.panelPrincipal);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Configuracoes";
            this.Text = "Configuracoes";
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btn_GerarConexao;
        private System.Windows.Forms.Button button1;
    }
}