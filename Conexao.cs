using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;

namespace AgendaDeEstudos
{
    public partial class Conexao : Form
    {
        public Conexao()
        {
            InitializeComponent();
        }

        private void btn_GerarConexao_Click(object sender, EventArgs e)
        {
            string bancoDados = Application.StartupPath + txt_Caminho.Text;
            string pass = txt_Senha.Text;
            string strConection = @"DataSource = " + bancoDados + ";Password = '" + pass + "'";

            SqlCeEngine db = new SqlCeEngine(strConection);
            if (!File.Exists(bancoDados))
            {
                db.CreateDatabase();
            }
            db.Dispose();

            SqlCeConnection conexao = new SqlCeConnection(strConection);
            try
            {
                conexao.Open();
                MessageBox.Show("Conexão estabelecida com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void Conexao_Load(object sender, EventArgs e)
        {
            string bancoDados = Application.StartupPath + txt_Caminho.Text;
            string pass = txt_Senha.Text;
            string strConection = @"DataSource = " + bancoDados + ";Password = '" + pass + "'";

            //SqlCeEngine db = new SqlCeEngine(strConection);
            if (File.Exists(bancoDados))
            {
                btn_GerarConexao.Text = "Conexão Existente";
                btn_GerarConexao.Enabled = false;
                txt_Caminho.Text = "Conexão Criada";
            }
        }
    }
}
