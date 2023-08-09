using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CheckPecas
{
    public partial class frmLogin : Form
    {
        string strConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=dbCheckPecas;User ID=sa;Password=sql2022";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            using (SqlConnection conexao = new SqlConnection(strConexao))
            {
                conexao.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT senhaUsuario FROM tblUsuarios WHERE loginUsuario = @usuario", conexao))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    string senhaArmazenada = cmd.ExecuteScalar() as string;

                    if (senhaArmazenada == null)
                    {
                        DialogResult resposta = MessageBox.Show("Usuário inexistente! Deseja realizar o cadastro?", "CADASTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resposta == DialogResult.Yes)
                        {
                            using (SqlCommand insertCmd = new SqlCommand("INSERT INTO tblUsuarios (loginUsuario, senhaUsuario) VALUES (@login, @senha)", conexao))
                            {
                                insertCmd.Parameters.AddWithValue("@login", usuario);
                                insertCmd.Parameters.AddWithValue("@senha", senha); // Lembre-se de usar técnicas seguras de hashing para armazenar senhas!
                                insertCmd.ExecuteNonQuery();
                                MessageBox.Show("Cadastro realizado com sucesso");
                            }
                        }
                        else
                        {
                            txtUsuario.ResetText();
                            txtSenha.ResetText();
                        }
                    }
                    else
                    {
                        if (senha != senhaArmazenada)
                        {
                            MessageBox.Show("A senha não confere");
                        }
                        else
                        {
                            frmControlePecaProduzidas fControle = new frmControlePecaProduzidas();
                            fControle.ShowDialog();
                        }

                        MessageBox.Show("Erro"); // Certifique-se de substituir isso por uma mensagem mais adequada
                    }
                }
            }
        }
    }
}
