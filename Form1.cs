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
    public partial class Form1 : Form
    {
        private Form frmAtivo;

        public Form1()
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
            foreach (Control ctrl in panelLateral.Controls)
                ctrl.ForeColor = Color.White;

            frmAtivo.ForeColor = Color.Black;
        }

        private void btn_Encerrar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja sair?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Configuracoes_Click(object sender, EventArgs e)
        {
            ActiveButton(btn_Configuracoes);
            FormShow(new Configuracoes());
        }
    }
}
