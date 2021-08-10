
namespace AgendaDeEstudos
{
    partial class Conexao
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Caminho = new System.Windows.Forms.TextBox();
            this.btn_GerarConexao = new System.Windows.Forms.Button();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caminho Base de Dados";
            // 
            // txt_Caminho
            // 
            this.txt_Caminho.Location = new System.Drawing.Point(135, 145);
            this.txt_Caminho.Name = "txt_Caminho";
            this.txt_Caminho.ReadOnly = true;
            this.txt_Caminho.Size = new System.Drawing.Size(527, 31);
            this.txt_Caminho.TabIndex = 1;
            this.txt_Caminho.Text = "\\db\\banco.sdf";
            // 
            // btn_GerarConexao
            // 
            this.btn_GerarConexao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GerarConexao.FlatAppearance.BorderSize = 0;
            this.btn_GerarConexao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btn_GerarConexao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_GerarConexao.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GerarConexao.ForeColor = System.Drawing.Color.White;
            this.btn_GerarConexao.Location = new System.Drawing.Point(598, 487);
            this.btn_GerarConexao.Name = "btn_GerarConexao";
            this.btn_GerarConexao.Size = new System.Drawing.Size(183, 68);
            this.btn_GerarConexao.TabIndex = 3;
            this.btn_GerarConexao.Text = "Gerar Conexão";
            this.btn_GerarConexao.UseVisualStyleBackColor = true;
            this.btn_GerarConexao.Click += new System.EventHandler(this.btn_GerarConexao_Click);
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(135, 211);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.ReadOnly = true;
            this.txt_Senha.Size = new System.Drawing.Size(527, 31);
            this.txt_Senha.TabIndex = 5;
            this.txt_Senha.Text = "0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(131, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "PassWorld:";
            // 
            // Conexao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(793, 567);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_GerarConexao);
            this.Controls.Add(this.txt_Caminho);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Conexao";
            this.Text = "Conexao";
            this.Load += new System.EventHandler(this.Conexao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Caminho;
        private System.Windows.Forms.Button btn_GerarConexao;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label label2;
    }
}