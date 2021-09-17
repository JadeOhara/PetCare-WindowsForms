namespace PetCare
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_PetLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label data_NascimentoLabel;
            System.Windows.Forms.Label iD_EspecieLabel;
            System.Windows.Forms.Label especieLabel;
            System.Windows.Forms.Label iD_RacaLabel;
            System.Windows.Forms.Label racaLabel;
            System.Windows.Forms.Label iD_SexoLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label corLabel;
            System.Windows.Forms.Label fotoLabel;
            System.Windows.Forms.Label doencasLabel;
            System.Windows.Forms.Label alergiasLabel;
            System.Windows.Forms.Label observacoesLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2Perfil = new System.Windows.Forms.TabPage();
            this.iD_PetLabel1 = new System.Windows.Forms.Label();
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_PetCareDataSet = new PetCare.BD_PetCareDataSet();
            this.nomeLabel1 = new System.Windows.Forms.Label();
            this.data_NascimentoLabel1 = new System.Windows.Forms.Label();
            this.iD_EspecieLabel1 = new System.Windows.Forms.Label();
            this.especieLabel1 = new System.Windows.Forms.Label();
            this.iD_RacaLabel1 = new System.Windows.Forms.Label();
            this.racaLabel1 = new System.Windows.Forms.Label();
            this.iD_SexoLabel1 = new System.Windows.Forms.Label();
            this.sexoLabel1 = new System.Windows.Forms.Label();
            this.corLabel1 = new System.Windows.Forms.Label();
            this.fotoLabel1 = new System.Windows.Forms.Label();
            this.doencasLabel1 = new System.Windows.Forms.Label();
            this.alergiasLabel1 = new System.Windows.Forms.Label();
            this.observacoesLabel1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1AddPet = new System.Windows.Forms.Button();
            this.tabPage1Saude = new System.Windows.Forms.TabPage();
            this.button2AddTrat = new System.Windows.Forms.Button();
            this.consultasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4RelatorioPeso = new System.Windows.Forms.Button();
            this.button3AddPeso = new System.Windows.Forms.Button();
            this.button1AddConsulta = new System.Windows.Forms.Button();
            this.tabPage3Periodicos = new System.Windows.Forms.TabPage();
            this.button4AddOutrosTrat = new System.Windows.Forms.Button();
            this.button3AddVermif = new System.Windows.Forms.Button();
            this.button2AddVacin = new System.Windows.Forms.Button();
            this.tabPage4BanhoTosa = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.perfilTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.PerfilTableAdapter();
            this.tableAdapterManager = new PetCare.BD_PetCareDataSetTableAdapters.TableAdapterManager();
            this.consultasTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.ConsultasTableAdapter();
            this.tratamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tratamentosTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.TratamentosTableAdapter();
            this.pesoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pesoTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.PesoTableAdapter();
            this.tratamentosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.consultasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pesoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.pesoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tratamentosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vermifugacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vermifugacaoTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.VermifugacaoTableAdapter();
            this.vermifugacaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacinacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacinacaoTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.VacinacaoTableAdapter();
            this.vacinacaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outros_RemédiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outros_RemédiosTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.Outros_RemédiosTableAdapter();
            this.outros_RemédiosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banho_TosaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banho_TosaTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.Banho_TosaTableAdapter();
            this.banho_TosaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_PetLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            data_NascimentoLabel = new System.Windows.Forms.Label();
            iD_EspecieLabel = new System.Windows.Forms.Label();
            especieLabel = new System.Windows.Forms.Label();
            iD_RacaLabel = new System.Windows.Forms.Label();
            racaLabel = new System.Windows.Forms.Label();
            iD_SexoLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            corLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            doencasLabel = new System.Windows.Forms.Label();
            alergiasLabel = new System.Windows.Forms.Label();
            observacoesLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2Perfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PetCareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1Saude.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).BeginInit();
            this.tabPage3Periodicos.SuspendLayout();
            this.tabPage4BanhoTosa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tratamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamentosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoBindingSource1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamentosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vermifugacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vermifugacaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacinacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacinacaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outros_RemédiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outros_RemédiosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banho_TosaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banho_TosaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_PetLabel
            // 
            iD_PetLabel.AutoSize = true;
            iD_PetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_PetLabel.Location = new System.Drawing.Point(13, 9);
            iD_PetLabel.Name = "iD_PetLabel";
            iD_PetLabel.Size = new System.Drawing.Size(50, 17);
            iD_PetLabel.TabIndex = 29;
            iD_PetLabel.Text = "ID Pet:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(13, 32);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(49, 17);
            nomeLabel.TabIndex = 31;
            nomeLabel.Text = "Nome:";
            // 
            // data_NascimentoLabel
            // 
            data_NascimentoLabel.AutoSize = true;
            data_NascimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_NascimentoLabel.Location = new System.Drawing.Point(13, 55);
            data_NascimentoLabel.Name = "data_NascimentoLabel";
            data_NascimentoLabel.Size = new System.Drawing.Size(120, 17);
            data_NascimentoLabel.TabIndex = 33;
            data_NascimentoLabel.Text = "Data Nascimento:";
            // 
            // iD_EspecieLabel
            // 
            iD_EspecieLabel.AutoSize = true;
            iD_EspecieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_EspecieLabel.Location = new System.Drawing.Point(13, 78);
            iD_EspecieLabel.Name = "iD_EspecieLabel";
            iD_EspecieLabel.Size = new System.Drawing.Size(79, 17);
            iD_EspecieLabel.TabIndex = 35;
            iD_EspecieLabel.Text = "ID Especie:";
            // 
            // especieLabel
            // 
            especieLabel.AutoSize = true;
            especieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            especieLabel.Location = new System.Drawing.Point(13, 101);
            especieLabel.Name = "especieLabel";
            especieLabel.Size = new System.Drawing.Size(62, 17);
            especieLabel.TabIndex = 37;
            especieLabel.Text = "Especie:";
            // 
            // iD_RacaLabel
            // 
            iD_RacaLabel.AutoSize = true;
            iD_RacaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_RacaLabel.Location = new System.Drawing.Point(13, 124);
            iD_RacaLabel.Name = "iD_RacaLabel";
            iD_RacaLabel.Size = new System.Drawing.Size(62, 17);
            iD_RacaLabel.TabIndex = 39;
            iD_RacaLabel.Text = "ID Raca:";
            // 
            // racaLabel
            // 
            racaLabel.AutoSize = true;
            racaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            racaLabel.Location = new System.Drawing.Point(13, 147);
            racaLabel.Name = "racaLabel";
            racaLabel.Size = new System.Drawing.Size(45, 17);
            racaLabel.TabIndex = 41;
            racaLabel.Text = "Raca:";
            // 
            // iD_SexoLabel
            // 
            iD_SexoLabel.AutoSize = true;
            iD_SexoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_SexoLabel.Location = new System.Drawing.Point(13, 170);
            iD_SexoLabel.Name = "iD_SexoLabel";
            iD_SexoLabel.Size = new System.Drawing.Size(60, 17);
            iD_SexoLabel.TabIndex = 43;
            iD_SexoLabel.Text = "ID Sexo:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexoLabel.Location = new System.Drawing.Point(13, 193);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(43, 17);
            sexoLabel.TabIndex = 45;
            sexoLabel.Text = "Sexo:";
            // 
            // corLabel
            // 
            corLabel.AutoSize = true;
            corLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            corLabel.Location = new System.Drawing.Point(13, 216);
            corLabel.Name = "corLabel";
            corLabel.Size = new System.Drawing.Size(34, 17);
            corLabel.TabIndex = 47;
            corLabel.Text = "Cor:";
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fotoLabel.Location = new System.Drawing.Point(531, 9);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(40, 17);
            fotoLabel.TabIndex = 49;
            fotoLabel.Text = "Foto:";
            // 
            // doencasLabel
            // 
            doencasLabel.AutoSize = true;
            doencasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doencasLabel.Location = new System.Drawing.Point(13, 239);
            doencasLabel.Name = "doencasLabel";
            doencasLabel.Size = new System.Drawing.Size(68, 17);
            doencasLabel.TabIndex = 51;
            doencasLabel.Text = "Doencas:";
            // 
            // alergiasLabel
            // 
            alergiasLabel.AutoSize = true;
            alergiasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            alergiasLabel.Location = new System.Drawing.Point(13, 285);
            alergiasLabel.Name = "alergiasLabel";
            alergiasLabel.Size = new System.Drawing.Size(63, 17);
            alergiasLabel.TabIndex = 53;
            alergiasLabel.Text = "Alergias:";
            // 
            // observacoesLabel
            // 
            observacoesLabel.AutoSize = true;
            observacoesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            observacoesLabel.Location = new System.Drawing.Point(13, 336);
            observacoesLabel.Name = "observacoesLabel";
            observacoesLabel.Size = new System.Drawing.Size(96, 17);
            observacoesLabel.TabIndex = 55;
            observacoesLabel.Text = "Observacoes:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2Perfil);
            this.tabControl1.Controls.Add(this.tabPage1Saude);
            this.tabControl1.Controls.Add(this.tabPage3Periodicos);
            this.tabControl1.Controls.Add(this.tabPage4BanhoTosa);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(881, 494);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2Perfil
            // 
            this.tabPage2Perfil.AutoScroll = true;
            this.tabPage2Perfil.Controls.Add(this.panel4);
            this.tabPage2Perfil.Controls.Add(this.button1AddPet);
            this.tabPage2Perfil.Location = new System.Drawing.Point(4, 22);
            this.tabPage2Perfil.Name = "tabPage2Perfil";
            this.tabPage2Perfil.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2Perfil.Size = new System.Drawing.Size(873, 468);
            this.tabPage2Perfil.TabIndex = 1;
            this.tabPage2Perfil.Text = "Perfil";
            this.tabPage2Perfil.UseVisualStyleBackColor = true;
            // 
            // iD_PetLabel1
            // 
            this.iD_PetLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "ID_Pet", true));
            this.iD_PetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_PetLabel1.Location = new System.Drawing.Point(148, 9);
            this.iD_PetLabel1.Name = "iD_PetLabel1";
            this.iD_PetLabel1.Size = new System.Drawing.Size(277, 23);
            this.iD_PetLabel1.TabIndex = 30;
            this.iD_PetLabel1.Text = "label2";
            this.iD_PetLabel1.Click += new System.EventHandler(this.iD_PetLabel1_Click);
            // 
            // perfilBindingSource
            // 
            this.perfilBindingSource.DataMember = "Perfil";
            this.perfilBindingSource.DataSource = this.bD_PetCareDataSet;
            // 
            // bD_PetCareDataSet
            // 
            this.bD_PetCareDataSet.DataSetName = "BD_PetCareDataSet";
            this.bD_PetCareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nomeLabel1
            // 
            this.nomeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "Nome", true));
            this.nomeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLabel1.Location = new System.Drawing.Point(148, 32);
            this.nomeLabel1.Name = "nomeLabel1";
            this.nomeLabel1.Size = new System.Drawing.Size(277, 23);
            this.nomeLabel1.TabIndex = 32;
            this.nomeLabel1.Text = "label2";
            // 
            // data_NascimentoLabel1
            // 
            this.data_NascimentoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "Data_Nascimento", true));
            this.data_NascimentoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_NascimentoLabel1.Location = new System.Drawing.Point(148, 55);
            this.data_NascimentoLabel1.Name = "data_NascimentoLabel1";
            this.data_NascimentoLabel1.Size = new System.Drawing.Size(277, 23);
            this.data_NascimentoLabel1.TabIndex = 34;
            this.data_NascimentoLabel1.Text = "label2";
            // 
            // iD_EspecieLabel1
            // 
            this.iD_EspecieLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "ID_Especie", true));
            this.iD_EspecieLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_EspecieLabel1.Location = new System.Drawing.Point(148, 78);
            this.iD_EspecieLabel1.Name = "iD_EspecieLabel1";
            this.iD_EspecieLabel1.Size = new System.Drawing.Size(277, 23);
            this.iD_EspecieLabel1.TabIndex = 36;
            this.iD_EspecieLabel1.Text = "label2";
            // 
            // especieLabel1
            // 
            this.especieLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "Especie", true));
            this.especieLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especieLabel1.Location = new System.Drawing.Point(148, 101);
            this.especieLabel1.Name = "especieLabel1";
            this.especieLabel1.Size = new System.Drawing.Size(277, 23);
            this.especieLabel1.TabIndex = 38;
            this.especieLabel1.Text = "label2";
            // 
            // iD_RacaLabel1
            // 
            this.iD_RacaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "ID_Raca", true));
            this.iD_RacaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_RacaLabel1.Location = new System.Drawing.Point(148, 124);
            this.iD_RacaLabel1.Name = "iD_RacaLabel1";
            this.iD_RacaLabel1.Size = new System.Drawing.Size(277, 23);
            this.iD_RacaLabel1.TabIndex = 40;
            this.iD_RacaLabel1.Text = "label2";
            // 
            // racaLabel1
            // 
            this.racaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "Raca", true));
            this.racaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.racaLabel1.Location = new System.Drawing.Point(148, 147);
            this.racaLabel1.Name = "racaLabel1";
            this.racaLabel1.Size = new System.Drawing.Size(277, 23);
            this.racaLabel1.TabIndex = 42;
            this.racaLabel1.Text = "label2";
            // 
            // iD_SexoLabel1
            // 
            this.iD_SexoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "ID_Sexo", true));
            this.iD_SexoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_SexoLabel1.Location = new System.Drawing.Point(148, 170);
            this.iD_SexoLabel1.Name = "iD_SexoLabel1";
            this.iD_SexoLabel1.Size = new System.Drawing.Size(277, 23);
            this.iD_SexoLabel1.TabIndex = 44;
            this.iD_SexoLabel1.Text = "label2";
            // 
            // sexoLabel1
            // 
            this.sexoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "Sexo", true));
            this.sexoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexoLabel1.Location = new System.Drawing.Point(148, 193);
            this.sexoLabel1.Name = "sexoLabel1";
            this.sexoLabel1.Size = new System.Drawing.Size(277, 23);
            this.sexoLabel1.TabIndex = 46;
            this.sexoLabel1.Text = "label2";
            // 
            // corLabel1
            // 
            this.corLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "Cor", true));
            this.corLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corLabel1.Location = new System.Drawing.Point(148, 216);
            this.corLabel1.Name = "corLabel1";
            this.corLabel1.Size = new System.Drawing.Size(277, 23);
            this.corLabel1.TabIndex = 48;
            this.corLabel1.Text = "label2";
            // 
            // fotoLabel1
            // 
            this.fotoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "Foto", true));
            this.fotoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fotoLabel1.Location = new System.Drawing.Point(574, 275);
            this.fotoLabel1.Name = "fotoLabel1";
            this.fotoLabel1.Size = new System.Drawing.Size(253, 23);
            this.fotoLabel1.TabIndex = 50;
            this.fotoLabel1.Text = "label2";
            // 
            // doencasLabel1
            // 
            this.doencasLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "Doencas", true));
            this.doencasLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doencasLabel1.Location = new System.Drawing.Point(148, 239);
            this.doencasLabel1.Name = "doencasLabel1";
            this.doencasLabel1.Size = new System.Drawing.Size(277, 46);
            this.doencasLabel1.TabIndex = 52;
            this.doencasLabel1.Text = "label2";
            // 
            // alergiasLabel1
            // 
            this.alergiasLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "Alergias", true));
            this.alergiasLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alergiasLabel1.Location = new System.Drawing.Point(148, 285);
            this.alergiasLabel1.Name = "alergiasLabel1";
            this.alergiasLabel1.Size = new System.Drawing.Size(277, 46);
            this.alergiasLabel1.TabIndex = 54;
            this.alergiasLabel1.Text = "label2";
            // 
            // observacoesLabel1
            // 
            this.observacoesLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "Observacoes", true));
            this.observacoesLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observacoesLabel1.Location = new System.Drawing.Point(148, 336);
            this.observacoesLabel1.Name = "observacoesLabel1";
            this.observacoesLabel1.Size = new System.Drawing.Size(277, 65);
            this.observacoesLabel1.TabIndex = 56;
            this.observacoesLabel1.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(577, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // button1AddPet
            // 
            this.button1AddPet.Location = new System.Drawing.Point(374, 434);
            this.button1AddPet.Name = "button1AddPet";
            this.button1AddPet.Size = new System.Drawing.Size(141, 23);
            this.button1AddPet.TabIndex = 1;
            this.button1AddPet.Text = "Adicionar Pet";
            this.button1AddPet.UseVisualStyleBackColor = true;
            this.button1AddPet.Click += new System.EventHandler(this.button1AddPet_Click);
            // 
            // tabPage1Saude
            // 
            this.tabPage1Saude.AutoScroll = true;
            this.tabPage1Saude.Controls.Add(this.tratamentosDataGridView);
            this.tabPage1Saude.Controls.Add(this.consultasDataGridView);
            this.tabPage1Saude.Controls.Add(this.pesoDataGridView);
            this.tabPage1Saude.Controls.Add(this.button2AddTrat);
            this.tabPage1Saude.Controls.Add(this.button4RelatorioPeso);
            this.tabPage1Saude.Controls.Add(this.button3AddPeso);
            this.tabPage1Saude.Controls.Add(this.button1AddConsulta);
            this.tabPage1Saude.Location = new System.Drawing.Point(4, 22);
            this.tabPage1Saude.Name = "tabPage1Saude";
            this.tabPage1Saude.Size = new System.Drawing.Size(873, 468);
            this.tabPage1Saude.TabIndex = 2;
            this.tabPage1Saude.Text = "Saúde";
            this.tabPage1Saude.UseVisualStyleBackColor = true;
            // 
            // button2AddTrat
            // 
            this.button2AddTrat.Location = new System.Drawing.Point(717, 211);
            this.button2AddTrat.Name = "button2AddTrat";
            this.button2AddTrat.Size = new System.Drawing.Size(153, 23);
            this.button2AddTrat.TabIndex = 2;
            this.button2AddTrat.Text = "Adicionar Tratamento";
            this.button2AddTrat.UseVisualStyleBackColor = true;
            this.button2AddTrat.Click += new System.EventHandler(this.button2AddTrat_Click);
            // 
            // consultasBindingSource
            // 
            this.consultasBindingSource.DataMember = "Consultas";
            this.consultasBindingSource.DataSource = this.bD_PetCareDataSet;
            // 
            // button4RelatorioPeso
            // 
            this.button4RelatorioPeso.Location = new System.Drawing.Point(717, 394);
            this.button4RelatorioPeso.Name = "button4RelatorioPeso";
            this.button4RelatorioPeso.Size = new System.Drawing.Size(153, 23);
            this.button4RelatorioPeso.TabIndex = 3;
            this.button4RelatorioPeso.Text = "Relatório de Peso";
            this.button4RelatorioPeso.UseVisualStyleBackColor = true;
            this.button4RelatorioPeso.Click += new System.EventHandler(this.button4RelatorioPeso_Click);
            // 
            // button3AddPeso
            // 
            this.button3AddPeso.Location = new System.Drawing.Point(717, 372);
            this.button3AddPeso.Name = "button3AddPeso";
            this.button3AddPeso.Size = new System.Drawing.Size(153, 23);
            this.button3AddPeso.TabIndex = 1;
            this.button3AddPeso.Text = "Adicionar Peso";
            this.button3AddPeso.UseVisualStyleBackColor = true;
            this.button3AddPeso.Click += new System.EventHandler(this.button3AddPeso_Click);
            // 
            // button1AddConsulta
            // 
            this.button1AddConsulta.Location = new System.Drawing.Point(717, 61);
            this.button1AddConsulta.Name = "button1AddConsulta";
            this.button1AddConsulta.Size = new System.Drawing.Size(153, 23);
            this.button1AddConsulta.TabIndex = 0;
            this.button1AddConsulta.Text = "Adicionar Consulta";
            this.button1AddConsulta.UseVisualStyleBackColor = true;
            this.button1AddConsulta.Click += new System.EventHandler(this.button1AddConsulta_Click);
            // 
            // tabPage3Periodicos
            // 
            this.tabPage3Periodicos.AutoScroll = true;
            this.tabPage3Periodicos.Controls.Add(this.outros_RemédiosDataGridView);
            this.tabPage3Periodicos.Controls.Add(this.vacinacaoDataGridView);
            this.tabPage3Periodicos.Controls.Add(this.vermifugacaoDataGridView);
            this.tabPage3Periodicos.Controls.Add(this.button4AddOutrosTrat);
            this.tabPage3Periodicos.Controls.Add(this.button3AddVermif);
            this.tabPage3Periodicos.Controls.Add(this.button2AddVacin);
            this.tabPage3Periodicos.Location = new System.Drawing.Point(4, 22);
            this.tabPage3Periodicos.Name = "tabPage3Periodicos";
            this.tabPage3Periodicos.Size = new System.Drawing.Size(873, 468);
            this.tabPage3Periodicos.TabIndex = 3;
            this.tabPage3Periodicos.Text = "Periódicos";
            this.tabPage3Periodicos.UseVisualStyleBackColor = true;
            // 
            // button4AddOutrosTrat
            // 
            this.button4AddOutrosTrat.Location = new System.Drawing.Point(699, 379);
            this.button4AddOutrosTrat.Name = "button4AddOutrosTrat";
            this.button4AddOutrosTrat.Size = new System.Drawing.Size(171, 23);
            this.button4AddOutrosTrat.TabIndex = 3;
            this.button4AddOutrosTrat.Text = "Adicionar Outros Tratamentos";
            this.button4AddOutrosTrat.UseVisualStyleBackColor = true;
            this.button4AddOutrosTrat.Click += new System.EventHandler(this.button4AddOutrosTrat_Click);
            // 
            // button3AddVermif
            // 
            this.button3AddVermif.Location = new System.Drawing.Point(699, 222);
            this.button3AddVermif.Name = "button3AddVermif";
            this.button3AddVermif.Size = new System.Drawing.Size(171, 23);
            this.button3AddVermif.TabIndex = 2;
            this.button3AddVermif.Text = "Adicionar Vermifugação";
            this.button3AddVermif.UseVisualStyleBackColor = true;
            this.button3AddVermif.Click += new System.EventHandler(this.button3AddVermif_Click);
            // 
            // button2AddVacin
            // 
            this.button2AddVacin.Location = new System.Drawing.Point(699, 63);
            this.button2AddVacin.Name = "button2AddVacin";
            this.button2AddVacin.Size = new System.Drawing.Size(171, 23);
            this.button2AddVacin.TabIndex = 1;
            this.button2AddVacin.Text = "Adicionar Vacinação";
            this.button2AddVacin.UseVisualStyleBackColor = true;
            this.button2AddVacin.Click += new System.EventHandler(this.button2AddVacin_Click);
            // 
            // tabPage4BanhoTosa
            // 
            this.tabPage4BanhoTosa.Controls.Add(this.banho_TosaDataGridView);
            this.tabPage4BanhoTosa.Controls.Add(this.button1);
            this.tabPage4BanhoTosa.Location = new System.Drawing.Point(4, 22);
            this.tabPage4BanhoTosa.Name = "tabPage4BanhoTosa";
            this.tabPage4BanhoTosa.Size = new System.Drawing.Size(873, 468);
            this.tabPage4BanhoTosa.TabIndex = 4;
            this.tabPage4BanhoTosa.Text = "Banho e Tosa";
            this.tabPage4BanhoTosa.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adicionar Banho e Tosa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.perfilBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 535);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "ID_Pet";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pet";
            // 
            // perfilTableAdapter
            // 
            this.perfilTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Banho_TosaTableAdapter = null;
            this.tableAdapterManager.ConsultasTableAdapter = this.consultasTableAdapter;
            this.tableAdapterManager.EspecieTableAdapter = null;
            this.tableAdapterManager.Outros_RemédiosTableAdapter = null;
            this.tableAdapterManager.PerfilTableAdapter = this.perfilTableAdapter;
            this.tableAdapterManager.PesoTableAdapter = null;
            this.tableAdapterManager.RacaTableAdapter = null;
            this.tableAdapterManager.SexoTableAdapter = null;
            this.tableAdapterManager.TratamentosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PetCare.BD_PetCareDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VacinacaoTableAdapter = null;
            this.tableAdapterManager.VermifugacaoTableAdapter = null;
            // 
            // consultasTableAdapter
            // 
            this.consultasTableAdapter.ClearBeforeFill = true;
            // 
            // tratamentosBindingSource
            // 
            this.tratamentosBindingSource.DataMember = "Tratamentos";
            this.tratamentosBindingSource.DataSource = this.bD_PetCareDataSet;
            // 
            // tratamentosTableAdapter
            // 
            this.tratamentosTableAdapter.ClearBeforeFill = true;
            // 
            // pesoBindingSource
            // 
            this.pesoBindingSource.DataMember = "Peso";
            this.pesoBindingSource.DataSource = this.bD_PetCareDataSet;
            // 
            // pesoTableAdapter
            // 
            this.pesoTableAdapter.ClearBeforeFill = true;
            // 
            // tratamentosBindingSource1
            // 
            this.tratamentosBindingSource1.DataMember = "Tratamentos";
            this.tratamentosBindingSource1.DataSource = this.bD_PetCareDataSet;
            // 
            // consultasBindingSource1
            // 
            this.consultasBindingSource1.DataMember = "Consultas";
            this.consultasBindingSource1.DataSource = this.bD_PetCareDataSet;
            // 
            // pesoBindingSource1
            // 
            this.pesoBindingSource1.DataMember = "Peso";
            this.pesoBindingSource1.DataSource = this.bD_PetCareDataSet;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.AliceBlue;
            this.panel4.Controls.Add(iD_PetLabel);
            this.panel4.Controls.Add(fotoLabel);
            this.panel4.Controls.Add(this.fotoLabel1);
            this.panel4.Controls.Add(this.observacoesLabel1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.iD_PetLabel1);
            this.panel4.Controls.Add(observacoesLabel);
            this.panel4.Controls.Add(nomeLabel);
            this.panel4.Controls.Add(this.alergiasLabel1);
            this.panel4.Controls.Add(this.nomeLabel1);
            this.panel4.Controls.Add(alergiasLabel);
            this.panel4.Controls.Add(data_NascimentoLabel);
            this.panel4.Controls.Add(this.doencasLabel1);
            this.panel4.Controls.Add(this.data_NascimentoLabel1);
            this.panel4.Controls.Add(doencasLabel);
            this.panel4.Controls.Add(iD_EspecieLabel);
            this.panel4.Controls.Add(this.corLabel1);
            this.panel4.Controls.Add(this.iD_EspecieLabel1);
            this.panel4.Controls.Add(corLabel);
            this.panel4.Controls.Add(especieLabel);
            this.panel4.Controls.Add(this.sexoLabel1);
            this.panel4.Controls.Add(this.especieLabel1);
            this.panel4.Controls.Add(sexoLabel);
            this.panel4.Controls.Add(iD_RacaLabel);
            this.panel4.Controls.Add(this.iD_SexoLabel1);
            this.panel4.Controls.Add(this.iD_RacaLabel1);
            this.panel4.Controls.Add(iD_SexoLabel);
            this.panel4.Controls.Add(racaLabel);
            this.panel4.Controls.Add(this.racaLabel1);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(861, 411);
            this.panel4.TabIndex = 57;
            // 
            // pesoDataGridView
            // 
            this.pesoDataGridView.AutoGenerateColumns = false;
            this.pesoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pesoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pesoDataGridView.DataSource = this.pesoBindingSource;
            this.pesoDataGridView.Location = new System.Drawing.Point(3, 332);
            this.pesoDataGridView.Name = "pesoDataGridView";
            this.pesoDataGridView.Size = new System.Drawing.Size(708, 133);
            this.pesoDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Peso";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Peso";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Pet";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Pet";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Data_Pesagem";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data_Pesagem";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Peso";
            this.dataGridViewTextBoxColumn4.HeaderText = "Peso";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Observacao";
            this.dataGridViewTextBoxColumn5.HeaderText = "Observacao";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // consultasDataGridView
            // 
            this.consultasDataGridView.AutoGenerateColumns = false;
            this.consultasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.consultasDataGridView.DataSource = this.consultasBindingSource;
            this.consultasDataGridView.Location = new System.Drawing.Point(3, 3);
            this.consultasDataGridView.Name = "consultasDataGridView";
            this.consultasDataGridView.Size = new System.Drawing.Size(708, 158);
            this.consultasDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID_Consulta";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID_Consulta";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ID_Pet";
            this.dataGridViewTextBoxColumn7.HeaderText = "ID_Pet";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Data_Consulta";
            this.dataGridViewTextBoxColumn8.HeaderText = "Data_Consulta";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Retorno";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Retorno";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Veterinario";
            this.dataGridViewTextBoxColumn9.HeaderText = "Veterinario";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn10.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Diagnostico";
            this.dataGridViewTextBoxColumn11.HeaderText = "Diagnostico";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Tratamento";
            this.dataGridViewTextBoxColumn12.HeaderText = "Tratamento";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Resultado";
            this.dataGridViewTextBoxColumn13.HeaderText = "Resultado";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Observacao";
            this.dataGridViewTextBoxColumn14.HeaderText = "Observacao";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // tratamentosDataGridView
            // 
            this.tratamentosDataGridView.AutoGenerateColumns = false;
            this.tratamentosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tratamentosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22});
            this.tratamentosDataGridView.DataSource = this.tratamentosBindingSource;
            this.tratamentosDataGridView.Location = new System.Drawing.Point(3, 167);
            this.tratamentosDataGridView.Name = "tratamentosDataGridView";
            this.tratamentosDataGridView.Size = new System.Drawing.Size(708, 159);
            this.tratamentosDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Código";
            this.dataGridViewTextBoxColumn15.HeaderText = "Código";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "ID_Pet";
            this.dataGridViewTextBoxColumn16.HeaderText = "ID_Pet";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Remedio";
            this.dataGridViewTextBoxColumn17.HeaderText = "Remedio";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Dose";
            this.dataGridViewTextBoxColumn18.HeaderText = "Dose";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Frequencia";
            this.dataGridViewTextBoxColumn19.HeaderText = "Frequencia";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Duracao";
            this.dataGridViewTextBoxColumn20.HeaderText = "Duracao";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Data_Inicio";
            this.dataGridViewTextBoxColumn21.HeaderText = "Data_Inicio";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Data_Fim";
            this.dataGridViewTextBoxColumn22.HeaderText = "Data_Fim";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // vermifugacaoBindingSource
            // 
            this.vermifugacaoBindingSource.DataMember = "Vermifugacao";
            this.vermifugacaoBindingSource.DataSource = this.bD_PetCareDataSet;
            // 
            // vermifugacaoTableAdapter
            // 
            this.vermifugacaoTableAdapter.ClearBeforeFill = true;
            // 
            // vermifugacaoDataGridView
            // 
            this.vermifugacaoDataGridView.AutoGenerateColumns = false;
            this.vermifugacaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vermifugacaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28});
            this.vermifugacaoDataGridView.DataSource = this.vermifugacaoBindingSource;
            this.vermifugacaoDataGridView.Location = new System.Drawing.Point(3, 154);
            this.vermifugacaoDataGridView.Name = "vermifugacaoDataGridView";
            this.vermifugacaoDataGridView.Size = new System.Drawing.Size(690, 148);
            this.vermifugacaoDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "ID_Vermifugo";
            this.dataGridViewTextBoxColumn23.HeaderText = "ID_Vermifugo";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "ID_Pet";
            this.dataGridViewTextBoxColumn24.HeaderText = "ID_Pet";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Data_Vermifugacao";
            this.dataGridViewTextBoxColumn25.HeaderText = "Data_Vermifugacao";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Vermifugo";
            this.dataGridViewTextBoxColumn26.HeaderText = "Vermifugo";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Dose";
            this.dataGridViewTextBoxColumn27.HeaderText = "Dose";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Data_Reforco";
            this.dataGridViewTextBoxColumn28.HeaderText = "Data_Reforco";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // vacinacaoBindingSource
            // 
            this.vacinacaoBindingSource.DataMember = "Vacinacao";
            this.vacinacaoBindingSource.DataSource = this.bD_PetCareDataSet;
            // 
            // vacinacaoTableAdapter
            // 
            this.vacinacaoTableAdapter.ClearBeforeFill = true;
            // 
            // vacinacaoDataGridView
            // 
            this.vacinacaoDataGridView.AutoGenerateColumns = false;
            this.vacinacaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vacinacaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35});
            this.vacinacaoDataGridView.DataSource = this.vacinacaoBindingSource;
            this.vacinacaoDataGridView.Location = new System.Drawing.Point(3, 3);
            this.vacinacaoDataGridView.Name = "vacinacaoDataGridView";
            this.vacinacaoDataGridView.Size = new System.Drawing.Size(690, 145);
            this.vacinacaoDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "ID_Vacina";
            this.dataGridViewTextBoxColumn29.HeaderText = "ID_Vacina";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "ID_Pet";
            this.dataGridViewTextBoxColumn30.HeaderText = "ID_Pet";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "Nome_Vacina";
            this.dataGridViewTextBoxColumn31.HeaderText = "Nome_Vacina";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn32.HeaderText = "Data";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "Data_Repetir";
            this.dataGridViewTextBoxColumn33.HeaderText = "Data_Repetir";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "Veterinario";
            this.dataGridViewTextBoxColumn34.HeaderText = "Veterinario";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn35.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            // 
            // outros_RemédiosBindingSource
            // 
            this.outros_RemédiosBindingSource.DataMember = "Outros_Remédios";
            this.outros_RemédiosBindingSource.DataSource = this.bD_PetCareDataSet;
            // 
            // outros_RemédiosTableAdapter
            // 
            this.outros_RemédiosTableAdapter.ClearBeforeFill = true;
            // 
            // outros_RemédiosDataGridView
            // 
            this.outros_RemédiosDataGridView.AutoGenerateColumns = false;
            this.outros_RemédiosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outros_RemédiosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38,
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43});
            this.outros_RemédiosDataGridView.DataSource = this.outros_RemédiosBindingSource;
            this.outros_RemédiosDataGridView.Location = new System.Drawing.Point(3, 308);
            this.outros_RemédiosDataGridView.Name = "outros_RemédiosDataGridView";
            this.outros_RemédiosDataGridView.Size = new System.Drawing.Size(690, 157);
            this.outros_RemédiosDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "ID_Outros";
            this.dataGridViewTextBoxColumn36.HeaderText = "ID_Outros";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "ID_Pet";
            this.dataGridViewTextBoxColumn37.HeaderText = "ID_Pet";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn38.HeaderText = "Data";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn39.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "Dose";
            this.dataGridViewTextBoxColumn40.HeaderText = "Dose";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "Data_Reforco";
            this.dataGridViewTextBoxColumn41.HeaderText = "Data_Reforco";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "Frequencia";
            this.dataGridViewTextBoxColumn42.HeaderText = "Frequencia";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "Observacao";
            this.dataGridViewTextBoxColumn43.HeaderText = "Observacao";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            // 
            // banho_TosaBindingSource
            // 
            this.banho_TosaBindingSource.DataMember = "Banho_Tosa";
            this.banho_TosaBindingSource.DataSource = this.bD_PetCareDataSet;
            // 
            // banho_TosaTableAdapter
            // 
            this.banho_TosaTableAdapter.ClearBeforeFill = true;
            // 
            // banho_TosaDataGridView
            // 
            this.banho_TosaDataGridView.AutoGenerateColumns = false;
            this.banho_TosaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.banho_TosaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn44,
            this.dataGridViewTextBoxColumn45,
            this.dataGridViewTextBoxColumn46,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewTextBoxColumn47,
            this.dataGridViewTextBoxColumn48,
            this.dataGridViewTextBoxColumn49});
            this.banho_TosaDataGridView.DataSource = this.banho_TosaBindingSource;
            this.banho_TosaDataGridView.Location = new System.Drawing.Point(9, 16);
            this.banho_TosaDataGridView.Name = "banho_TosaDataGridView";
            this.banho_TosaDataGridView.Size = new System.Drawing.Size(847, 384);
            this.banho_TosaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "ID_BanhoTosa";
            this.dataGridViewTextBoxColumn44.HeaderText = "ID_BanhoTosa";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "ID_Pet";
            this.dataGridViewTextBoxColumn45.HeaderText = "ID_Pet";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn46.HeaderText = "Data";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Banho";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Banho";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "Tosa";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Tosa";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.DataPropertyName = "Foto_Resultado";
            this.dataGridViewTextBoxColumn47.HeaderText = "Foto_Resultado";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.DataPropertyName = "Local";
            this.dataGridViewTextBoxColumn48.HeaderText = "Local";
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.DataPropertyName = "Observacao";
            this.dataGridViewTextBoxColumn49.HeaderText = "Observacao";
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 568);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "PetCare";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2Perfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PetCareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1Saude.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).EndInit();
            this.tabPage3Periodicos.ResumeLayout(false);
            this.tabPage4BanhoTosa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tratamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamentosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoBindingSource1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamentosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vermifugacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vermifugacaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacinacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacinacaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outros_RemédiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outros_RemédiosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banho_TosaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banho_TosaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2Perfil;
        private System.Windows.Forms.Button button1AddPet;
        private System.Windows.Forms.TabPage tabPage1Saude;
        private System.Windows.Forms.TabPage tabPage3Periodicos;
        private System.Windows.Forms.TabPage tabPage4BanhoTosa;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3AddPeso;
        private System.Windows.Forms.Button button1AddConsulta;
        private System.Windows.Forms.Button button4AddOutrosTrat;
        private System.Windows.Forms.Button button3AddVermif;
        private System.Windows.Forms.Button button2AddVacin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2AddTrat;
        private System.Windows.Forms.Button button4RelatorioPeso;
        private BD_PetCareDataSet bD_PetCareDataSet;
        private System.Windows.Forms.BindingSource perfilBindingSource;
        private BD_PetCareDataSetTableAdapters.PerfilTableAdapter perfilTableAdapter;
        private System.Windows.Forms.Label iD_PetLabel1;
        private System.Windows.Forms.Label nomeLabel1;
        private System.Windows.Forms.Label data_NascimentoLabel1;
        private System.Windows.Forms.Label iD_EspecieLabel1;
        private System.Windows.Forms.Label especieLabel1;
        private System.Windows.Forms.Label iD_RacaLabel1;
        private System.Windows.Forms.Label racaLabel1;
        private System.Windows.Forms.Label iD_SexoLabel1;
        private System.Windows.Forms.Label sexoLabel1;
        private System.Windows.Forms.Label corLabel1;
        private System.Windows.Forms.Label fotoLabel1;
        private System.Windows.Forms.Label doencasLabel1;
        private System.Windows.Forms.Label alergiasLabel1;
        private System.Windows.Forms.Label observacoesLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BD_PetCareDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BD_PetCareDataSetTableAdapters.ConsultasTableAdapter consultasTableAdapter;
        private System.Windows.Forms.BindingSource consultasBindingSource;
        private System.Windows.Forms.BindingSource tratamentosBindingSource;
        private BD_PetCareDataSetTableAdapters.TratamentosTableAdapter tratamentosTableAdapter;
        private System.Windows.Forms.BindingSource pesoBindingSource;
        private BD_PetCareDataSetTableAdapters.PesoTableAdapter pesoTableAdapter;
        private System.Windows.Forms.BindingSource tratamentosBindingSource1;
        private System.Windows.Forms.BindingSource pesoBindingSource1;
        private System.Windows.Forms.BindingSource consultasBindingSource1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView tratamentosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridView consultasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridView pesoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource vermifugacaoBindingSource;
        private BD_PetCareDataSetTableAdapters.VermifugacaoTableAdapter vermifugacaoTableAdapter;
        private System.Windows.Forms.DataGridView vermifugacaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.BindingSource vacinacaoBindingSource;
        private BD_PetCareDataSetTableAdapters.VacinacaoTableAdapter vacinacaoTableAdapter;
        private System.Windows.Forms.DataGridView vacinacaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.BindingSource outros_RemédiosBindingSource;
        private BD_PetCareDataSetTableAdapters.Outros_RemédiosTableAdapter outros_RemédiosTableAdapter;
        private System.Windows.Forms.DataGridView outros_RemédiosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.BindingSource banho_TosaBindingSource;
        private BD_PetCareDataSetTableAdapters.Banho_TosaTableAdapter banho_TosaTableAdapter;
        private System.Windows.Forms.DataGridView banho_TosaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
    }
}

