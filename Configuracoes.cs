using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaDeEstudos
{
    public partial class Configuracoes : Form
    {
        private Form frmAtivo;

        public Configuracoes()
        {
            InitializeComponent();
        }

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelPrincipal.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
            {
                frmAtivo.Close();
            }
        }

        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in panelTop.Controls)
                ctrl.ForeColor = Color.White;

            frmAtivo.ForeColor = Color.Black;
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_GerarConexao_Click(object sender, EventArgs e)
        {
            ActiveButton(btn_GerarConexao);
            FormShow(new Conexao());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveButton(button1);
            FormShow(new CriarTabela());
        }
    }
}
