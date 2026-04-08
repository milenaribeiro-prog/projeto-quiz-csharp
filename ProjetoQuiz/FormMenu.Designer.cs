namespace ProjetoQuiz
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 8D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2D);
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabSimulador = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.picMateria = new System.Windows.Forms.PictureBox();
            this.lbl_nivel = new System.Windows.Forms.Label();
            this.lbl_contagem = new System.Windows.Forms.Label();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.lbl_pergunta = new System.Windows.Forms.Label();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.cbo_materia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabResultados = new System.Windows.Forms.TabPage();
            this.graficoResultados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvHistorico = new System.Windows.Forms.DataGridView();
            this.tabGestao = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.cboNivel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_verLista = new System.Windows.Forms.Button();
            this.dgvUtilizadores = new System.Windows.Forms.DataGridView();
            this.lblBoasVindas = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tabPrincipal.SuspendLayout();
            this.tabSimulador.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMateria)).BeginInit();
            this.tabResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            this.tabGestao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilizadores)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabSimulador);
            this.tabPrincipal.Controls.Add(this.tabResultados);
            this.tabPrincipal.Controls.Add(this.tabGestao);
            this.tabPrincipal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPrincipal.Location = new System.Drawing.Point(188, 80);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(719, 462);
            this.tabPrincipal.TabIndex = 0;
            // 
            // tabSimulador
            // 
            this.tabSimulador.Controls.Add(this.panel4);
            this.tabSimulador.Controls.Add(this.panel3);
            this.tabSimulador.Controls.Add(this.panel2);
            this.tabSimulador.Controls.Add(this.panel1);
            this.tabSimulador.Controls.Add(this.picMateria);
            this.tabSimulador.Controls.Add(this.lbl_nivel);
            this.tabSimulador.Controls.Add(this.lbl_contagem);
            this.tabSimulador.Controls.Add(this.btn_proximo);
            this.tabSimulador.Controls.Add(this.btn_anterior);
            this.tabSimulador.Controls.Add(this.lbl_pergunta);
            this.tabSimulador.Controls.Add(this.btn_iniciar);
            this.tabSimulador.Controls.Add(this.cbo_materia);
            this.tabSimulador.Controls.Add(this.label5);
            this.tabSimulador.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSimulador.Location = new System.Drawing.Point(4, 34);
            this.tabSimulador.Name = "tabSimulador";
            this.tabSimulador.Padding = new System.Windows.Forms.Padding(3);
            this.tabSimulador.Size = new System.Drawing.Size(711, 424);
            this.tabSimulador.TabIndex = 0;
            this.tabSimulador.Text = "Questões de Estudo";
            this.tabSimulador.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.rbD);
            this.panel4.Location = new System.Drawing.Point(8, 325);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(360, 41);
            this.panel4.TabIndex = 16;
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(3, 3);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(21, 20);
            this.rbD.TabIndex = 7;
            this.rbD.TabStop = true;
            this.rbD.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.rbC);
            this.panel3.Location = new System.Drawing.Point(8, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 41);
            this.panel3.TabIndex = 15;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(3, 3);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(21, 20);
            this.rbC.TabIndex = 6;
            this.rbC.TabStop = true;
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.rbB);
            this.panel2.Location = new System.Drawing.Point(8, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 37);
            this.panel2.TabIndex = 14;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(3, 3);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(21, 20);
            this.rbB.TabIndex = 5;
            this.rbB.TabStop = true;
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.rbA);
            this.panel1.Location = new System.Drawing.Point(7, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 34);
            this.panel1.TabIndex = 13;
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(4, 3);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(21, 20);
            this.rbA.TabIndex = 4;
            this.rbA.TabStop = true;
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // picMateria
            // 
            this.picMateria.Image = global::ProjetoQuiz.Properties.Resources.matematica;
            this.picMateria.Location = new System.Drawing.Point(403, 61);
            this.picMateria.Name = "picMateria";
            this.picMateria.Size = new System.Drawing.Size(285, 255);
            this.picMateria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMateria.TabIndex = 12;
            this.picMateria.TabStop = false;
            // 
            // lbl_nivel
            // 
            this.lbl_nivel.AutoSize = true;
            this.lbl_nivel.Location = new System.Drawing.Point(402, 19);
            this.lbl_nivel.Name = "lbl_nivel";
            this.lbl_nivel.Size = new System.Drawing.Size(67, 30);
            this.lbl_nivel.TabIndex = 11;
            this.lbl_nivel.Text = "Nivel:";
            // 
            // lbl_contagem
            // 
            this.lbl_contagem.AutoSize = true;
            this.lbl_contagem.Location = new System.Drawing.Point(431, 323);
            this.lbl_contagem.Name = "lbl_contagem";
            this.lbl_contagem.Size = new System.Drawing.Size(28, 30);
            this.lbl_contagem.TabIndex = 10;
            this.lbl_contagem.Text = "...";
            // 
            // btn_proximo
            // 
            this.btn_proximo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_proximo.FlatAppearance.BorderSize = 0;
            this.btn_proximo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btn_proximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proximo.ForeColor = System.Drawing.Color.White;
            this.btn_proximo.Location = new System.Drawing.Point(570, 369);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(40, 40);
            this.btn_proximo.TabIndex = 9;
            this.btn_proximo.Text = "→";
            this.btn_proximo.UseVisualStyleBackColor = false;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_anterior.FlatAppearance.BorderSize = 0;
            this.btn_anterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btn_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anterior.ForeColor = System.Drawing.Color.White;
            this.btn_anterior.Location = new System.Drawing.Point(512, 369);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(40, 40);
            this.btn_anterior.TabIndex = 8;
            this.btn_anterior.Text = "←";
            this.btn_anterior.UseVisualStyleBackColor = false;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // lbl_pergunta
            // 
            this.lbl_pergunta.Location = new System.Drawing.Point(3, 132);
            this.lbl_pergunta.Name = "lbl_pergunta";
            this.lbl_pergunta.Size = new System.Drawing.Size(635, 34);
            this.lbl_pergunta.TabIndex = 3;
            this.lbl_pergunta.Text = "Questões...";
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_iniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btn_iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciar.ForeColor = System.Drawing.Color.White;
            this.btn_iniciar.Location = new System.Drawing.Point(209, 47);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(103, 47);
            this.btn_iniciar.TabIndex = 2;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = false;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // cbo_materia
            // 
            this.cbo_materia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_materia.FormattingEnabled = true;
            this.cbo_materia.Location = new System.Drawing.Point(10, 52);
            this.cbo_materia.Name = "cbo_materia";
            this.cbo_materia.Size = new System.Drawing.Size(170, 38);
            this.cbo_materia.TabIndex = 1;
            this.cbo_materia.SelectedIndexChanged += new System.EventHandler(this.cbo_materia_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Escolha a Materia ↓";
            // 
            // tabResultados
            // 
            this.tabResultados.Controls.Add(this.graficoResultados);
            this.tabResultados.Controls.Add(this.dgvHistorico);
            this.tabResultados.Location = new System.Drawing.Point(4, 34);
            this.tabResultados.Name = "tabResultados";
            this.tabResultados.Padding = new System.Windows.Forms.Padding(3);
            this.tabResultados.Size = new System.Drawing.Size(711, 424);
            this.tabResultados.TabIndex = 1;
            this.tabResultados.Text = "Resultados";
            this.tabResultados.UseVisualStyleBackColor = true;
            // 
            // graficoResultados
            // 
            chartArea5.AxisX.MajorGrid.Enabled = false;
            chartArea5.AxisY.MajorGrid.Enabled = false;
            chartArea5.Name = "ChartArea1";
            this.graficoResultados.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.graficoResultados.Legends.Add(legend5);
            this.graficoResultados.Location = new System.Drawing.Point(3, 20);
            this.graficoResultados.Name = "graficoResultados";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            dataPoint9.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataPoint9.IsValueShownAsLabel = true;
            dataPoint10.Color = System.Drawing.Color.Red;
            dataPoint10.IsValueShownAsLabel = true;
            series5.Points.Add(dataPoint9);
            series5.Points.Add(dataPoint10);
            this.graficoResultados.Series.Add(series5);
            this.graficoResultados.Size = new System.Drawing.Size(273, 380);
            this.graficoResultados.TabIndex = 1;
            this.graficoResultados.Text = "chart1";
            // 
            // dgvHistorico
            // 
            this.dgvHistorico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(35)))), ((int)(((byte)(81)))));
            this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorico.Location = new System.Drawing.Point(282, 20);
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.RowHeadersWidth = 62;
            this.dgvHistorico.RowTemplate.Height = 28;
            this.dgvHistorico.Size = new System.Drawing.Size(402, 380);
            this.dgvHistorico.TabIndex = 0;
            // 
            // tabGestao
            // 
            this.tabGestao.Controls.Add(this.label4);
            this.tabGestao.Controls.Add(this.btn_limpar);
            this.tabGestao.Controls.Add(this.cboNivel);
            this.tabGestao.Controls.Add(this.label3);
            this.tabGestao.Controls.Add(this.txt_pass);
            this.tabGestao.Controls.Add(this.label2);
            this.tabGestao.Controls.Add(this.txt_nome);
            this.tabGestao.Controls.Add(this.label1);
            this.tabGestao.Controls.Add(this.txt_id);
            this.tabGestao.Controls.Add(this.btn_eliminar);
            this.tabGestao.Controls.Add(this.btn_atualizar);
            this.tabGestao.Controls.Add(this.btn_inserir);
            this.tabGestao.Controls.Add(this.btn_verLista);
            this.tabGestao.Controls.Add(this.dgvUtilizadores);
            this.tabGestao.Location = new System.Drawing.Point(4, 34);
            this.tabGestao.Name = "tabGestao";
            this.tabGestao.Padding = new System.Windows.Forms.Padding(3);
            this.tabGestao.Size = new System.Drawing.Size(711, 424);
            this.tabGestao.TabIndex = 2;
            this.tabGestao.Text = "Gestão Utilizadores";
            this.tabGestao.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nivel: ";
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.ForeColor = System.Drawing.Color.White;
            this.btn_limpar.Location = new System.Drawing.Point(594, 143);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(102, 40);
            this.btn_limpar.TabIndex = 12;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // cboNivel
            // 
            this.cboNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNivel.FormattingEnabled = true;
            this.cboNivel.Items.AddRange(new object[] {
            "admin",
            "guest"});
            this.cboNivel.Location = new System.Drawing.Point(349, 25);
            this.cboNivel.Name = "cboNivel";
            this.cboNivel.Size = new System.Drawing.Size(121, 33);
            this.cboNivel.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pass:";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(349, 94);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(100, 31);
            this.txt_pass.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(64, 94);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 31);
            this.txt_nome.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(64, 29);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 31);
            this.txt_id.TabIndex = 5;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Location = new System.Drawing.Point(594, 365);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(102, 40);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Text = "Eliminar User";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizar.ForeColor = System.Drawing.Color.White;
            this.btn_atualizar.Location = new System.Drawing.Point(594, 309);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(102, 40);
            this.btn_atualizar.TabIndex = 3;
            this.btn_atualizar.Text = "Atualizar User";
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_inserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inserir.ForeColor = System.Drawing.Color.White;
            this.btn_inserir.Location = new System.Drawing.Point(594, 253);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(102, 40);
            this.btn_inserir.TabIndex = 2;
            this.btn_inserir.Text = "Inserir User";
            this.btn_inserir.UseVisualStyleBackColor = false;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_verLista
            // 
            this.btn_verLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_verLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verLista.ForeColor = System.Drawing.Color.White;
            this.btn_verLista.Location = new System.Drawing.Point(594, 196);
            this.btn_verLista.Name = "btn_verLista";
            this.btn_verLista.Size = new System.Drawing.Size(102, 40);
            this.btn_verLista.TabIndex = 1;
            this.btn_verLista.Text = "Ver Lista";
            this.btn_verLista.UseVisualStyleBackColor = false;
            this.btn_verLista.Click += new System.EventHandler(this.btn_verLista_Click);
            // 
            // dgvUtilizadores
            // 
            this.dgvUtilizadores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(35)))), ((int)(((byte)(81)))));
            this.dgvUtilizadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtilizadores.Location = new System.Drawing.Point(16, 143);
            this.dgvUtilizadores.Name = "dgvUtilizadores";
            this.dgvUtilizadores.ReadOnly = true;
            this.dgvUtilizadores.RowHeadersWidth = 62;
            this.dgvUtilizadores.RowTemplate.Height = 28;
            this.dgvUtilizadores.Size = new System.Drawing.Size(543, 256);
            this.dgvUtilizadores.TabIndex = 0;
            // 
            // lblBoasVindas
            // 
            this.lblBoasVindas.AutoSize = true;
            this.lblBoasVindas.BackColor = System.Drawing.Color.Transparent;
            this.lblBoasVindas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBoasVindas.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoasVindas.ForeColor = System.Drawing.Color.White;
            this.lblBoasVindas.Location = new System.Drawing.Point(13, 13);
            this.lblBoasVindas.Name = "lblBoasVindas";
            this.lblBoasVindas.Size = new System.Drawing.Size(123, 23);
            this.lblBoasVindas.TabIndex = 1;
            this.lblBoasVindas.Text = "Boas Vindas: ";
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(35)))), ((int)(((byte)(81)))));
            this.lbl_data.Location = new System.Drawing.Point(623, 12);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(38, 26);
            this.lbl_data.TabIndex = 2;
            this.lbl_data.Text = "📅";
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(814, 13);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(82, 35);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "→";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoQuiz.Properties.Resources._64807570_94956521;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(964, 641);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.lblBoasVindas);
            this.Controls.Add(this.tabPrincipal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal - Quiz Estudo";
            this.Load += new System.EventHandler(this.FormMenu_Load_1);
            this.tabPrincipal.ResumeLayout(false);
            this.tabSimulador.ResumeLayout(false);
            this.tabSimulador.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMateria)).EndInit();
            this.tabResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graficoResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            this.tabGestao.ResumeLayout(false);
            this.tabGestao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilizadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabSimulador;
        private System.Windows.Forms.TabPage tabResultados;
        private System.Windows.Forms.TabPage tabGestao;
        private System.Windows.Forms.Label lblBoasVindas;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgvUtilizadores;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_verLista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.ComboBox cboNivel;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.Label lbl_pergunta;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.ComboBox cbo_materia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Label lbl_contagem;
        private System.Windows.Forms.Label lbl_nivel;
        private System.Windows.Forms.DataGridView dgvHistorico;
        private System.Windows.Forms.PictureBox picMateria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoResultados;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}