
namespace AgendaDeEstudos
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
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btn_Configuracoes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Encerrar = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelLateral.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLateral.Controls.Add(this.label1);
            this.panelLateral.Controls.Add(this.btn_Configuracoes);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(242, 754);
            this.panelLateral.TabIndex = 0;
            // 
            // btn_Configuracoes
            // 
            this.btn_Configuracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Configuracoes.FlatAppearance.BorderSize = 0;
            this.btn_Configuracoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btn_Configuracoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Configuracoes.ForeColor = System.Drawing.Color.White;
            this.btn_Configuracoes.Location = new System.Drawing.Point(8, 652);
            this.btn_Configuracoes.Name = "btn_Configuracoes";
            this.btn_Configuracoes.Size = new System.Drawing.Size(227, 90);
            this.btn_Configuracoes.TabIndex = 1;
            this.btn_Configuracoes.Text = "Configurações";
            this.btn_Configuracoes.UseVisualStyleBackColor = true;
            this.btn_Configuracoes.Click += new System.EventHandler(this.btn_Configuracoes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agenda De Estudos";
            // 
            // btn_Encerrar
            // 
            this.btn_Encerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Encerrar.FlatAppearance.BorderSize = 0;
            this.btn_Encerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Encerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Encerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Encerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Encerrar.Location = new System.Drawing.Point(697, 705);
            this.btn_Encerrar.Name = "btn_Encerrar";
            this.btn_Encerrar.Size = new System.Drawing.Size(109, 37);
            this.btn_Encerrar.TabIndex = 1;
            this.btn_Encerrar.Text = "Sair";
            this.btn_Encerrar.UseVisualStyleBackColor = true;
            this.btn_Encerrar.Click += new System.EventHandler(this.btn_Encerrar_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.btn_Encerrar);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(242, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(818, 754);
            this.panelPrincipal.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1060, 754);
            this.ControlBox = false;
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelLateral);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda de Estudos";
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Configuracoes;
        private System.Windows.Forms.Button btn_Encerrar;
        private System.Windows.Forms.Panel panelPrincipal;
    }
}

