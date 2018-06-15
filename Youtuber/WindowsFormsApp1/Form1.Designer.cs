namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeDoCanal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantidadeDeInscritos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantidadeDeLikes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRenda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuantidadeDeVisualizacoes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbNacionalidade = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.rbSimStreamer = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.rbNaoStreamer = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.cbPlataforma = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbQuantidadeDeStrikes = new System.Windows.Forms.ComboBox();
            this.rbNaoPossuiPatrocinador = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.rbSimPossuiPatrocinador = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.txtQuantidadeDeVideos = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCanalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeStrikesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RendaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeInscritosColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.circularButton3 = new WindowsFormsApp1.CircularButton();
            this.circularButton2 = new WindowsFormsApp1.CircularButton();
            this.circularButton1 = new WindowsFormsApp1.CircularButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(577, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Youtuber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(133, 98);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(303, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(566, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sobrenome";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(664, 98);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(303, 20);
            this.txtSobrenome.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1074, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apelido";
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(1142, 98);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(303, 20);
            this.txtApelido.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nome do canal";
            // 
            // txtNomeDoCanal
            // 
            this.txtNomeDoCanal.Location = new System.Drawing.Point(133, 159);
            this.txtNomeDoCanal.Name = "txtNomeDoCanal";
            this.txtNomeDoCanal.Size = new System.Drawing.Size(303, 20);
            this.txtNomeDoCanal.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(482, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Quantidade de inscritos";
            // 
            // txtQuantidadeDeInscritos
            // 
            this.txtQuantidadeDeInscritos.Location = new System.Drawing.Point(664, 159);
            this.txtQuantidadeDeInscritos.Name = "txtQuantidadeDeInscritos";
            this.txtQuantidadeDeInscritos.Size = new System.Drawing.Size(303, 20);
            this.txtQuantidadeDeInscritos.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(987, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Quantidade de likes";
            // 
            // txtQuantidadeDeLikes
            // 
            this.txtQuantidadeDeLikes.Location = new System.Drawing.Point(1142, 159);
            this.txtQuantidadeDeLikes.Name = "txtQuantidadeDeLikes";
            this.txtQuantidadeDeLikes.Size = new System.Drawing.Size(303, 20);
            this.txtQuantidadeDeLikes.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Renda";
            // 
            // txtRenda
            // 
            this.txtRenda.Location = new System.Drawing.Point(133, 222);
            this.txtRenda.Name = "txtRenda";
            this.txtRenda.Size = new System.Drawing.Size(303, 20);
            this.txtRenda.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(447, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Quantidade de visualizações";
            // 
            // txtQuantidadeDeVisualizacoes
            // 
            this.txtQuantidadeDeVisualizacoes.Location = new System.Drawing.Point(664, 222);
            this.txtQuantidadeDeVisualizacoes.Name = "txtQuantidadeDeVisualizacoes";
            this.txtQuantidadeDeVisualizacoes.Size = new System.Drawing.Size(303, 20);
            this.txtQuantidadeDeVisualizacoes.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(117, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Nacionalidade";
            // 
            // cbNacionalidade
            // 
            this.cbNacionalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNacionalidade.FormattingEnabled = true;
            this.cbNacionalidade.IntegralHeight = false;
            this.cbNacionalidade.Items.AddRange(new object[] {
            "Antiguano",
            "Argentino",
            "Bahamense",
            "Barbadiano",
            "Belizenho",
            "Boliviano",
            "Brasileiro",
            "Chileno",
            "Colombiano",
            "Costarriquenho",
            "Cubano",
            "Dominicano",
            "Equatoriano",
            "Salvadorenho",
            "Granadino",
            "Guatemalteco",
            "Guianês",
            "Guianense",
            "Haitiano",
            "Hondurenho",
            "Jamaicano",
            "Mexicano",
            "Nicaraguense",
            "Panamenho",
            "Paraguaio",
            "Peruano",
            "Portorriquenho",
            "Dominicana",
            "São-cristovense",
            "São-vicentino",
            "Santa-lucense",
            "Surinamês",
            "Trindadense",
            "Uruguaio",
            "Venezuelano",
            "Alemão",
            "Austríaco",
            "Belga",
            "Croata",
            "Dinamarquês",
            "Eslovaco",
            "Esloveno",
            "Espanhol",
            "Francês",
            "Grego",
            "Húngaro",
            "Irlandês",
            "Italiano",
            "Noruego",
            "Holandês",
            "Polonês",
            "Português",
            "Britânico",
            "Inglês",
            "Galês",
            "Escocês",
            "Romeno",
            "Russo",
            "Sérvio",
            "Sueco",
            "Suíço",
            "Turco",
            "Ucraniano",
            "Americano",
            "Canadense",
            "Angolano",
            "Moçambicano",
            "Sul-africano",
            "Zimbabuense",
            "Argélia",
            "Comorense",
            "Egípcio",
            "Líbio",
            "Marroquino",
            "Ganés",
            "Queniano",
            "Ruandês",
            "Ugandense",
            "Bechuano",
            "Marfinense",
            "Camaronense",
            "Nigeriano",
            "Somali",
            "Australiano",
            "Neozelandês",
            "Afegão",
            "Saudita",
            "Armeno",
            "Bangladesh",
            "Chinês",
            "Norte-coreano",
            "Coreano",
            "Indiano",
            "Indonésio",
            "Iraquiano",
            "Iraniano",
            "Israelita",
            "Japonês",
            "Malaio",
            "Nepalês",
            "Omanense",
            "Paquistanês",
            "Palestino",
            "Qatarense",
            "Sírio",
            "Cingalês",
            "Tailandês",
            "Timorense",
            "Árabe",
            "Vietnamita",
            "Iemenita"});
            this.cbNacionalidade.Location = new System.Drawing.Point(232, 313);
            this.cbNacionalidade.Name = "cbNacionalidade";
            this.cbNacionalidade.Size = new System.Drawing.Size(156, 21);
            this.cbNacionalidade.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(148, 351);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.IntegralHeight = false;
            this.cbCategoria.Items.AddRange(new object[] {
            "Educativo",
            "Terror",
            "Aventura",
            "Ação",
            "Estudos",
            "Música",
            "Ficção científica"});
            this.cbCategoria.Location = new System.Drawing.Point(232, 353);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(156, 21);
            this.cbCategoria.TabIndex = 12;
            // 
            // rbSimStreamer
            // 
            this.rbSimStreamer.AutoSize = true;
            this.rbSimStreamer.Checked = true;
            this.rbSimStreamer.Location = new System.Drawing.Point(295, 405);
            this.rbSimStreamer.Name = "rbSimStreamer";
            this.rbSimStreamer.Size = new System.Drawing.Size(42, 17);
            this.rbSimStreamer.TabIndex = 15;
            this.rbSimStreamer.TabStop = true;
            this.rbSimStreamer.Text = "Sim";
            this.rbSimStreamer.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(190, 405);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "É Streamer?";
            // 
            // rbNaoStreamer
            // 
            this.rbNaoStreamer.AutoSize = true;
            this.rbNaoStreamer.Location = new System.Drawing.Point(343, 405);
            this.rbNaoStreamer.Name = "rbNaoStreamer";
            this.rbNaoStreamer.Size = new System.Drawing.Size(45, 17);
            this.rbNaoStreamer.TabIndex = 16;
            this.rbNaoStreamer.Text = "Não";
            this.rbNaoStreamer.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(472, 315);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Plataforma";
            // 
            // cbPlataforma
            // 
            this.cbPlataforma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlataforma.FormattingEnabled = true;
            this.cbPlataforma.IntegralHeight = false;
            this.cbPlataforma.Items.AddRange(new object[] {
            "Pc",
            "PS3",
            "PS4",
            "Xbox 360",
            "Xbox One",
            "Nintendo Wii",
            "Nintendo Wii U",
            "Nintendo Switch",
            ""});
            this.cbPlataforma.Location = new System.Drawing.Point(564, 314);
            this.cbPlataforma.Name = "cbPlataforma";
            this.cbPlataforma.Size = new System.Drawing.Size(156, 21);
            this.cbPlataforma.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(394, 354);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Quantidade de strikes";
            // 
            // cbQuantidadeDeStrikes
            // 
            this.cbQuantidadeDeStrikes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuantidadeDeStrikes.FormattingEnabled = true;
            this.cbQuantidadeDeStrikes.IntegralHeight = false;
            this.cbQuantidadeDeStrikes.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cbQuantidadeDeStrikes.Location = new System.Drawing.Point(564, 353);
            this.cbQuantidadeDeStrikes.Name = "cbQuantidadeDeStrikes";
            this.cbQuantidadeDeStrikes.Size = new System.Drawing.Size(156, 21);
            this.cbQuantidadeDeStrikes.TabIndex = 13;
            // 
            // rbNaoPossuiPatrocinador
            // 
            this.rbNaoPossuiPatrocinador.AutoSize = true;
            this.rbNaoPossuiPatrocinador.Location = new System.Drawing.Point(220, 25);
            this.rbNaoPossuiPatrocinador.Name = "rbNaoPossuiPatrocinador";
            this.rbNaoPossuiPatrocinador.Size = new System.Drawing.Size(45, 17);
            this.rbNaoPossuiPatrocinador.TabIndex = 18;
            this.rbNaoPossuiPatrocinador.Text = "Não";
            this.rbNaoPossuiPatrocinador.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "Possui patrocinador?";
            // 
            // rbSimPossuiPatrocinador
            // 
            this.rbSimPossuiPatrocinador.AutoSize = true;
            this.rbSimPossuiPatrocinador.Checked = true;
            this.rbSimPossuiPatrocinador.Location = new System.Drawing.Point(172, 25);
            this.rbSimPossuiPatrocinador.Name = "rbSimPossuiPatrocinador";
            this.rbSimPossuiPatrocinador.Size = new System.Drawing.Size(42, 17);
            this.rbSimPossuiPatrocinador.TabIndex = 17;
            this.rbSimPossuiPatrocinador.TabStop = true;
            this.rbSimPossuiPatrocinador.Text = "Sim";
            this.rbSimPossuiPatrocinador.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(973, 220);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(163, 20);
            this.label16.TabIndex = 31;
            this.label16.Text = "Quantidade de vídeos";
            // 
            // txtQuantidadeDeVideos
            // 
            this.txtQuantidadeDeVideos.Location = new System.Drawing.Point(1142, 220);
            this.txtQuantidadeDeVideos.Name = "txtQuantidadeDeVideos";
            this.txtQuantidadeDeVideos.Size = new System.Drawing.Size(303, 20);
            this.txtQuantidadeDeVideos.TabIndex = 9;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(4, 60);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(536, 147);
            this.txtDescricao.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 530);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 20);
            this.label17.TabIndex = 37;
            this.label17.Text = "Descrição";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1222, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 69);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(902, 317);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(303, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "https://www.youtube.com/";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(794, 315);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 20);
            this.label18.TabIndex = 39;
            this.label18.Text = "Link do canal\r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeColumn,
            this.NomeCanalColumn,
            this.QuantidadeStrikesColumn,
            this.RendaColumn,
            this.QuantidadeInscritosColumn});
            this.dataGridView1.Location = new System.Drawing.Point(583, 452);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(834, 296);
            this.dataGridView1.TabIndex = 20;
            // 
            // NomeColumn
            // 
            this.NomeColumn.HeaderText = "Nome";
            this.NomeColumn.Name = "NomeColumn";
            this.NomeColumn.ReadOnly = true;
            this.NomeColumn.Width = 175;
            // 
            // NomeCanalColumn
            // 
            this.NomeCanalColumn.HeaderText = "Nome do canal";
            this.NomeCanalColumn.Name = "NomeCanalColumn";
            this.NomeCanalColumn.ReadOnly = true;
            this.NomeCanalColumn.Width = 175;
            // 
            // QuantidadeStrikesColumn
            // 
            this.QuantidadeStrikesColumn.HeaderText = "Quantidade de strikes";
            this.QuantidadeStrikesColumn.Name = "QuantidadeStrikesColumn";
            this.QuantidadeStrikesColumn.ReadOnly = true;
            this.QuantidadeStrikesColumn.Width = 140;
            // 
            // RendaColumn
            // 
            this.RendaColumn.HeaderText = "Renda";
            this.RendaColumn.Name = "RendaColumn";
            this.RendaColumn.ReadOnly = true;
            this.RendaColumn.Width = 150;
            // 
            // QuantidadeInscritosColumn
            // 
            this.QuantidadeInscritosColumn.HeaderText = "Quantidade de inscritos";
            this.QuantidadeInscritosColumn.Name = "QuantidadeInscritosColumn";
            this.QuantidadeInscritosColumn.ReadOnly = true;
            this.QuantidadeInscritosColumn.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSimPossuiPatrocinador);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.rbNaoPossuiPatrocinador);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Location = new System.Drawing.Point(12, 508);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 213);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descrição";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1305, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 37);
            this.button2.TabIndex = 43;
            this.button2.Text = "Como programar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // circularButton3
            // 
            this.circularButton3.BackColor = System.Drawing.Color.Transparent;
            this.circularButton3.ForeColor = System.Drawing.Color.Transparent;
            this.circularButton3.Image = ((System.Drawing.Image)(resources.GetObject("circularButton3.Image")));
            this.circularButton3.Location = new System.Drawing.Point(1142, 12);
            this.circularButton3.Name = "circularButton3";
            this.circularButton3.Size = new System.Drawing.Size(69, 69);
            this.circularButton3.TabIndex = 21;
            this.circularButton3.UseVisualStyleBackColor = false;
            this.circularButton3.Click += new System.EventHandler(this.circularButton3_Click);
            // 
            // circularButton2
            // 
            this.circularButton2.BackColor = System.Drawing.Color.Transparent;
            this.circularButton2.ForeColor = System.Drawing.Color.Transparent;
            this.circularButton2.Image = ((System.Drawing.Image)(resources.GetObject("circularButton2.Image")));
            this.circularButton2.Location = new System.Drawing.Point(1298, 12);
            this.circularButton2.Name = "circularButton2";
            this.circularButton2.Size = new System.Drawing.Size(69, 69);
            this.circularButton2.TabIndex = 23;
            this.circularButton2.UseVisualStyleBackColor = false;
            this.circularButton2.Click += new System.EventHandler(this.circularButton2_Click);
            // 
            // circularButton1
            // 
            this.circularButton1.BackColor = System.Drawing.Color.Transparent;
            this.circularButton1.Image = ((System.Drawing.Image)(resources.GetObject("circularButton1.Image")));
            this.circularButton1.Location = new System.Drawing.Point(1373, 12);
            this.circularButton1.Name = "circularButton1";
            this.circularButton1.Size = new System.Drawing.Size(68, 72);
            this.circularButton1.TabIndex = 24;
            this.circularButton1.UseVisualStyleBackColor = false;
            this.circularButton1.Click += new System.EventHandler(this.circularButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1444, 749);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.circularButton3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.circularButton2);
            this.Controls.Add(this.circularButton1);
            this.Controls.Add(this.txtQuantidadeDeVideos);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbQuantidadeDeStrikes);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbPlataforma);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.rbNaoStreamer);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rbSimStreamer);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbNacionalidade);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtQuantidadeDeVisualizacoes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRenda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtQuantidadeDeLikes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQuantidadeDeInscritos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNomeDoCanal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeDoCanal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantidadeDeInscritos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuantidadeDeLikes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRenda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuantidadeDeVisualizacoes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbNacionalidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.RadioButton rbSimStreamer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rbNaoStreamer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbPlataforma;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbQuantidadeDeStrikes;
        private System.Windows.Forms.RadioButton rbNaoPossuiPatrocinador;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton rbSimPossuiPatrocinador;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtQuantidadeDeVideos;
        private CircularButton circularButton1;
        private CircularButton circularButton2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCanalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeStrikesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RendaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeInscritosColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private CircularButton circularButton3;
        private System.Windows.Forms.Button button2;
    }
}

