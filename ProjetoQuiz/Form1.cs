using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing;

namespace ProjetoQuiz
{
    public partial class Form1 : Form
    {
        // Certifica-te que o nome no App.config é "minhaConnectionApp"
        string strConn = ConfigurationManager.ConnectionStrings["minhaConnectionApp"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
            lblErro.Visible = false;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT lg_id, lg_nome, lg_nivel FROM utilizadores WHERE lg_nome=@u AND lg_password=@p";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@u", txtUser.Text);
                    cmd.Parameters.AddWithValue("@p", txtPassword.Text);

                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        int id = Convert.ToInt32(dr["lg_id"]);
                        string nome = dr["lg_nome"].ToString();
                        string nivel = dr["lg_nivel"].ToString();

                        // Abre o menu usando a tua classe de gestão
                        FormMenu menu = new FormMenu(id, nome, nivel);
                        GerirForms.TrocarForms(this, menu);
                    }
                    else
                    {
                        lblErro.Text = "Erro ao efetuar Login!!";
                        lblErro.ForeColor = Color.Red;
                        lblErro.Visible = true;
                        txtUser.Clear();
                        txtPassword.Clear();
                        txtUser.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de ligação: " + ex.Message);
                }
            }
        }

       

        

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            // Exibe uma caixa de diálogo para confirmar a saída
            DialogResult confirmacao = MessageBox.Show("Deseja realmente sair da aplicação?", "Sair",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                // Encerra todos os formulários e para o processo da aplicação
                Application.Exit();
            }
        }

      

       

       

        private void chkVerSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = chkVerSenha.Checked;
        }
    }
}