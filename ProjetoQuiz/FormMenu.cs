using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjetoQuiz
{
    public partial class FormMenu : Form
    {
        // Configuração de conexão obtida do App.config
        string cs = ConfigurationManager.ConnectionStrings["minhaConnectionApp"].ConnectionString;
        // Variáveis de controlo de sessão e estado do Quiz
        int idLogado;
        string nomeLogado, nivelLogado;
        DataTable dtQuestoes;
        int indexQuestao = 0;
        int certas = 0, erradas = 0;
        /// Verifica se a opção selecionada pelo utilizador coincide com a resposta_correta na BD
        private void validarResposta()
        {
           
            string correta = dtQuestoes.Rows[indexQuestao]["resposta_correta"].ToString().ToLower();
            string escolhida = "";

            // Verifica qual RadioButton o utilizador marcou
            if (rbA.Checked) escolhida = "a";
            else if (rbB.Checked) escolhida = "b";
            else if (rbC.Checked) escolhida = "c";
            else if (rbD.Checked) escolhida = "d";

            // Compara e atualiza os pontos
            if (escolhida == correta)
            {
                certas++;
            }
            else
            {
                erradas++;
            }
        }
        private void gravarHistorico()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(cs))
                {
                    // Query baseada na  tabela 'historico'
                    string query = "INSERT INTO historico (id_utilizador, Nome_TesteFeito, Certas, Erradas) " +
                                   "VALUES (@uid, @teste, @c, @e)";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    // idLogado é o ID que recebeste ao entrar no FormMenu
                    cmd.Parameters.AddWithValue("@uid", idLogado);
                    cmd.Parameters.AddWithValue("@teste", cbo_materia.Text);
                    cmd.Parameters.AddWithValue("@c", certas);
                    cmd.Parameters.AddWithValue("@e", erradas);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Resultado guardado no histórico!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao guardar histórico: " + ex.Message);
            }
        }
        /// Construtor: Recebe os dados do utilizador validados no Login
        public FormMenu(int id, string nome, string nivel)
        {
            InitializeComponent();
            this.idLogado = id;
            this.nomeLogado = nome;
            this.nivelLogado = nivel;
        }

      

        // Método central para atualizar a lista
        private void atualizarTabela()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(cs))
                {
                    string query = "SELECT lg_id AS ID, lg_nome AS Nome, lg_nivel AS Nivel FROM utilizadores";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvUtilizadores.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }
        private void carregarMaterias()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(cs))
                {
                    string query = "SELECT DISTINCT materia FROM questoes";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    con.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();

                    cbo_materia.Items.Clear();
                    while (dr.Read())
                    {
                        cbo_materia.Items.Add(dr["materia"].ToString());
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro ao carregar matérias: " + ex.Message); }
        }

        // Exibe a questão atual nos componentes do ecrã
        private void mostrarQuestao()
        {
            if (dtQuestoes != null && dtQuestoes.Rows.Count > 0)
            {
                // Limpa seleções anteriores
                rbA.Checked = rbB.Checked = rbC.Checked = rbD.Checked = false;

                // Preenche a pergunta e as opções
                lbl_pergunta.Text = dtQuestoes.Rows[indexQuestao]["pergunta"].ToString();
                rbA.Text = "a) " + dtQuestoes.Rows[indexQuestao]["opcao_a"].ToString();
                rbB.Text = "b) " + dtQuestoes.Rows[indexQuestao]["opcao_b"].ToString();
                rbC.Text = "c) " + dtQuestoes.Rows[indexQuestao]["opcao_c"].ToString();
                rbD.Text = "d) " + dtQuestoes.Rows[indexQuestao]["opcao_d"].ToString();

                // Atualiza o contador de navegação
                lbl_contagem.Text = $"Pergunta {indexQuestao + 1} de {dtQuestoes.Rows.Count}";
            }
        }

        // Método Limpar unificado
        private void limpar()
        {
            txt_id.Clear();
            txt_nome.Clear();
            txt_pass.Clear();
           
            if (cboNivel != null) cboNivel.SelectedIndex = -1;
            txt_nome.Focus();
        }

        private void btn_verLista_Click(object sender, EventArgs e)
        {
            atualizarTabela();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_nome.Text) || string.IsNullOrWhiteSpace(txt_pass.Text))
            {
                MessageBox.Show("Preencha o nome e a password.");
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(cs))
                {
                    string query = "INSERT INTO utilizadores (lg_nome, lg_password, lg_nivel) VALUES (@nome, @pass, @nivel)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nome", txt_nome.Text);
                    cmd.Parameters.AddWithValue("@pass", txt_pass.Text);
                    cmd.Parameters.AddWithValue("@nivel", cboNivel.Text ?? "guest");

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Utilizador inserido com sucesso!");

                    atualizarTabela();
                    limpar();
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro ao inserir: " + ex.Message); }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id.Text))
            {
                MessageBox.Show("Selecione um utilizador na lista primeiro.");
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(cs))
                {
                    string query = "UPDATE utilizadores SET lg_nome=@nome, lg_password=@pass, lg_nivel=@nivel WHERE lg_id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", txt_id.Text);
                    cmd.Parameters.AddWithValue("@nome", txt_nome.Text);
                    cmd.Parameters.AddWithValue("@pass", txt_pass.Text);
                    cmd.Parameters.AddWithValue("@nivel", cboNivel.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados atualizados!");
                    atualizarTabela();
                    limpar();
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro ao atualizar: " + ex.Message); }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id.Text)) return;

            DialogResult dr = MessageBox.Show("Deseja eliminar este utilizador?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection(cs))
                    {
                        string query = "DELETE FROM utilizadores WHERE lg_id=@id";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", txt_id.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        atualizarTabela();
                        limpar();
                    }
                }
                catch (Exception ex) { MessageBox.Show("Erro ao eliminar: " + ex.Message); }
            }
        }

        

        private void btn_iniciar_Click(object sender, EventArgs e)
        {

            if (cbo_materia.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione uma matéria.");
                return;
            }

            certas = 0; erradas = 0;

            try
            {
                using (MySqlConnection con = new MySqlConnection(cs))
                {
                    // sorteio aleatorio usando Rand para apnas 10 questões de 20
                    string query = "SELECT * FROM questoes WHERE materia = @materia ORDER BY RAND() LIMIT 10";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@materia", cbo_materia.Text);

                    dtQuestoes = new DataTable();
                    da.Fill(dtQuestoes);

                    if (dtQuestoes.Rows.Count > 0)
                    {
                        indexQuestao = 0;
                        mostrarQuestao();
                    }
                    else
                    {
                        MessageBox.Show("Não existem questões para esta matéria.");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            if (dtQuestoes == null || dtQuestoes.Rows.Count == 0) return;

            if (!rbA.Checked && !rbB.Checked && !rbC.Checked && !rbD.Checked)
            {
                MessageBox.Show("Por favor, selecione uma resposta!");
                return;
            }

            validarResposta();
            // Verifica se ainda há mais perguntas ou se o quiz terminou

            if (indexQuestao < dtQuestoes.Rows.Count - 1)
            {
                indexQuestao++;
                mostrarQuestao();
            }
            else
            {
                MessageBox.Show("Final das perguntas!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gravarHistorico();

               
                atualizarGrafico();
                carregarHistorico(); 

                tabPrincipal.SelectedTab = tabResultados;
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            // 1. Verifica se já existem questões carregadas
            if (dtQuestoes == null) return;

            // 2. Bloqueio: a regra  não permiti voltar para rever respostas já dadas
            if (indexQuestao > 0)
            {
                MessageBox.Show("Neste modo de estudo, não é permitido alterar respostas anteriores.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {
                // Alerta de limite conforme o requisito
                MessageBox.Show("Primeiro Registo!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormMenu_Load_1(object sender, EventArgs e)
        {
            // 1. Informações do utilizador
            lblBoasVindas.Text = "Bem-vindo: " + nomeLogado;
            lbl_nivel.Text = "nível: " + nivelLogado;
            lbl_data.Text = DateTime.Now.ToString("dd/MM/yyyy");

            // 2. Bloqueio de Segurança para o guest
            if (nivelLogado.Trim().ToLower() != "admin")
            {
                tabPrincipal.TabPages.Remove(tabGestao);
            }

            // 3. Inicialização de dados
            dgvUtilizadores.ReadOnly = true;
            dgvUtilizadores.AllowUserToAddRows = false;
            dgvUtilizadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            carregarMaterias();
            atualizarTabela();
            // carregarHistorico(); // Deixei aqui caso eu precise
            try
            {
                picMateria.Image = Properties.Resources.estudo;
            }
            catch
            {
                
            }
        }


        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //  classe GerirForms para trocar de ecrã
            Form1 login = new Form1();
            GerirForms.TrocarForms(this, login);
        }

        private void cbo_materia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_materia.SelectedItem == null) return;

            string materia = cbo_materia.SelectedItem.ToString().ToLower();

           
            if (materia.Contains("geografia"))
                picMateria.Image = Properties.Resources.geografia;
            else if (materia.Contains("matematica") || materia.Contains("matemática"))
                picMateria.Image = Properties.Resources.matematica;
            else
                picMateria.Image = Properties.Resources.estudo;
        }
        /// Gera um gráfico circular (Pie Chart) com o desempenho do último teste
        private void atualizarGrafico()
        {
           
            graficoResultados.Series.Clear();
            graficoResultados.Titles.Clear();

           
            Series serie = new Series("Desempenho");
            serie.ChartType = SeriesChartType.Pie;

          
            DataPoint pCertas = new DataPoint(0, certas);
            pCertas.Color = Color.Green;
            pCertas.Label = certas.ToString();
            pCertas.AxisLabel = "Certas";

            DataPoint pErradas = new DataPoint(0, erradas);
            pErradas.Color = Color.Red;
            pErradas.Label = erradas.ToString();
            pErradas.AxisLabel = "Incorretas";

            serie.Points.Add(pCertas);
            serie.Points.Add(pErradas);

            graficoResultados.Series.Add(serie);
        }
        private void carregarHistorico()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(cs))
                {
                    // Query que seleciona os dados da  tabela historico
                    string query = "SELECT Nome_TesteFeito AS Materia, Certas, Erradas, DataHora " +
                                   "FROM historico WHERE id_utilizador = @uid ORDER BY DataHora DESC";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@uid", idLogado); // Filtra pelo utilizador atual

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                   
                   
                    dgvHistorico.DataSource = dt;

                    // Formatação visual 
                    dgvHistorico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvHistorico.AllowUserToAddRows = false;
                    dgvHistorico.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar histórico: " + ex.Message);
            }
        }
    }
}