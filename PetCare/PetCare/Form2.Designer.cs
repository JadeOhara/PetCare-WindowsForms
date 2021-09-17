namespace PetCare
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bD_PetCareDataSet = new PetCare.BD_PetCareDataSet();
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perfilTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.PerfilTableAdapter();
            this.tableAdapterManager = new PetCare.BD_PetCareDataSetTableAdapters.TableAdapterManager();
            this.especieTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.EspecieTableAdapter();
            this.racaTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.RacaTableAdapter();
            this.sexoTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.SexoTableAdapter();
            this.perfilBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.perfilBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1AddEspecie = new System.Windows.Forms.Button();
            this.button2AddRaca = new System.Windows.Forms.Button();
            this.especieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.especieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.racaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_PetLabel1 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.data_NascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iD_EspecieTextBox = new System.Windows.Forms.TextBox();
            this.especieTextBox = new System.Windows.Forms.TextBox();
            this.iD_RacaTextBox = new System.Windows.Forms.TextBox();
            this.racaTextBox = new System.Windows.Forms.TextBox();
            this.iD_SexoTextBox = new System.Windows.Forms.TextBox();
            this.sexoTextBox = new System.Windows.Forms.TextBox();
            this.corTextBox = new System.Windows.Forms.TextBox();
            this.fotoTextBox = new System.Windows.Forms.TextBox();
            this.doencasTextBox = new System.Windows.Forms.TextBox();
            this.alergiasTextBox = new System.Windows.Forms.TextBox();
            this.observacoesTextBox = new System.Windows.Forms.TextBox();
            this.especieComboBox1 = new System.Windows.Forms.ComboBox();
            this.racaComboBox2 = new System.Windows.Forms.ComboBox();
            this.sexoComboBox3 = new System.Windows.Forms.ComboBox();
            this.perfilDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.bD_PetCareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingNavigator)).BeginInit();
            this.perfilBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_PetLabel
            // 
            iD_PetLabel.AutoSize = true;
            iD_PetLabel.Location = new System.Drawing.Point(41, 47);
            iD_PetLabel.Name = "iD_PetLabel";
            iD_PetLabel.Size = new System.Drawing.Size(40, 13);
            iD_PetLabel.TabIndex = 30;
            iD_PetLabel.Text = "ID Pet:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(41, 76);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 32;
            nomeLabel.Text = "Nome:";
            // 
            // data_NascimentoLabel
            // 
            data_NascimentoLabel.AutoSize = true;
            data_NascimentoLabel.Location = new System.Drawing.Point(41, 103);
            data_NascimentoLabel.Name = "data_NascimentoLabel";
            data_NascimentoLabel.Size = new System.Drawing.Size(92, 13);
            data_NascimentoLabel.TabIndex = 34;
            data_NascimentoLabel.Text = "Data Nascimento:";
            // 
            // iD_EspecieLabel
            // 
            iD_EspecieLabel.AutoSize = true;
            iD_EspecieLabel.Location = new System.Drawing.Point(533, 90);
            iD_EspecieLabel.Name = "iD_EspecieLabel";
            iD_EspecieLabel.Size = new System.Drawing.Size(62, 13);
            iD_EspecieLabel.TabIndex = 36;
            iD_EspecieLabel.Text = "ID Especie:";
            // 
            // especieLabel
            // 
            especieLabel.AutoSize = true;
            especieLabel.Location = new System.Drawing.Point(41, 129);
            especieLabel.Name = "especieLabel";
            especieLabel.Size = new System.Drawing.Size(48, 13);
            especieLabel.TabIndex = 38;
            especieLabel.Text = "Especie:";
            // 
            // iD_RacaLabel
            // 
            iD_RacaLabel.AutoSize = true;
            iD_RacaLabel.Location = new System.Drawing.Point(533, 142);
            iD_RacaLabel.Name = "iD_RacaLabel";
            iD_RacaLabel.Size = new System.Drawing.Size(50, 13);
            iD_RacaLabel.TabIndex = 40;
            iD_RacaLabel.Text = "ID Raca:";
            // 
            // racaLabel
            // 
            racaLabel.AutoSize = true;
            racaLabel.Location = new System.Drawing.Point(41, 156);
            racaLabel.Name = "racaLabel";
            racaLabel.Size = new System.Drawing.Size(36, 13);
            racaLabel.TabIndex = 42;
            racaLabel.Text = "Raca:";
            // 
            // iD_SexoLabel
            // 
            iD_SexoLabel.AutoSize = true;
            iD_SexoLabel.Location = new System.Drawing.Point(533, 194);
            iD_SexoLabel.Name = "iD_SexoLabel";
            iD_SexoLabel.Size = new System.Drawing.Size(48, 13);
            iD_SexoLabel.TabIndex = 44;
            iD_SexoLabel.Text = "ID Sexo:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(41, 183);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(34, 13);
            sexoLabel.TabIndex = 46;
            sexoLabel.Text = "Sexo:";
            // 
            // corLabel
            // 
            corLabel.AutoSize = true;
            corLabel.Location = new System.Drawing.Point(41, 209);
            corLabel.Name = "corLabel";
            corLabel.Size = new System.Drawing.Size(26, 13);
            corLabel.TabIndex = 48;
            corLabel.Text = "Cor:";
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(41, 235);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(31, 13);
            fotoLabel.TabIndex = 50;
            fotoLabel.Text = "Foto:";
            // 
            // doencasLabel
            // 
            doencasLabel.AutoSize = true;
            doencasLabel.Location = new System.Drawing.Point(41, 261);
            doencasLabel.Name = "doencasLabel";
            doencasLabel.Size = new System.Drawing.Size(53, 13);
            doencasLabel.TabIndex = 52;
            doencasLabel.Text = "Doencas:";
            // 
            // alergiasLabel
            // 
            alergiasLabel.AutoSize = true;
            alergiasLabel.Location = new System.Drawing.Point(41, 287);
            alergiasLabel.Name = "alergiasLabel";
            alergiasLabel.Size = new System.Drawing.Size(47, 13);
            alergiasLabel.TabIndex = 54;
            alergiasLabel.Text = "Alergias:";
            // 
            // observacoesLabel
            // 
            observacoesLabel.AutoSize = true;
            observacoesLabel.Location = new System.Drawing.Point(41, 313);
            observacoesLabel.Name = "observacoesLabel";
            observacoesLabel.Size = new System.Drawing.Size(73, 13);
            observacoesLabel.TabIndex = 56;
            observacoesLabel.Text = "Observacoes:";
            // 
            // bD_PetCareDataSet
            // 
            this.bD_PetCareDataSet.DataSetName = "BD_PetCareDataSet";
            this.bD_PetCareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // perfilBindingSource
            // 
            this.perfilBindingSource.DataMember = "Perfil";
            this.perfilBindingSource.DataSource = this.bD_PetCareDataSet;
            // 
            // perfilTableAdapter
            // 
            this.perfilTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Banho_TosaTableAdapter = null;
            this.tableAdapterManager.ConsultasTableAdapter = null;
            this.tableAdapterManager.EspecieTableAdapter = this.especieTableAdapter;
            this.tableAdapterManager.Outros_RemédiosTableAdapter = null;
            this.tableAdapterManager.PerfilTableAdapter = this.perfilTableAdapter;
            this.tableAdapterManager.PesoTableAdapter = null;
            this.tableAdapterManager.RacaTableAdapter = this.racaTableAdapter;
            this.tableAdapterManager.SexoTableAdapter = this.sexoTableAdapter;
            this.tableAdapterManager.TratamentosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PetCare.BD_PetCareDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VacinacaoTableAdapter = null;
            this.tableAdapterManager.VermifugacaoTableAdapter = null;
            // 
            // especieTableAdapter
            // 
            this.especieTableAdapter.ClearBeforeFill = true;
            // 
            // racaTableAdapter
            // 
            this.racaTableAdapter.ClearBeforeFill = true;
            // 
            // sexoTableAdapter
            // 
            this.sexoTableAdapter.ClearBeforeFill = true;
            // 
            // perfilBindingNavigator
            // 
            this.perfilBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.perfilBindingNavigator.BindingSource = this.perfilBindingSource;
            this.perfilBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.perfilBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.perfilBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.perfilBindingNavigatorSaveItem});
            this.perfilBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.perfilBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.perfilBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.perfilBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.perfilBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.perfilBindingNavigator.Name = "perfilBindingNavigator";
            this.perfilBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.perfilBindingNavigator.Size = new System.Drawing.Size(879, 25);
            this.perfilBindingNavigator.TabIndex = 0;
            this.perfilBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // perfilBindingNavigatorSaveItem
            // 
            this.perfilBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.perfilBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("perfilBindingNavigatorSaveItem.Image")));
            this.perfilBindingNavigatorSaveItem.Name = "perfilBindingNavigatorSaveItem";
            this.perfilBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.perfilBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.perfilBindingNavigatorSaveItem.Click += new System.EventHandler(this.perfilBindingNavigatorSaveItem_Click);
            // 
            // button1AddEspecie
            // 
            this.button1AddEspecie.Location = new System.Drawing.Point(359, 124);
            this.button1AddEspecie.Name = "button1AddEspecie";
            this.button1AddEspecie.Size = new System.Drawing.Size(131, 23);
            this.button1AddEspecie.TabIndex = 29;
            this.button1AddEspecie.Text = "Cadastrar Especie";
            this.button1AddEspecie.UseVisualStyleBackColor = true;
            this.button1AddEspecie.Click += new System.EventHandler(this.button1AddEspecie_Click);
            // 
            // button2AddRaca
            // 
            this.button2AddRaca.Location = new System.Drawing.Point(359, 153);
            this.button2AddRaca.Name = "button2AddRaca";
            this.button2AddRaca.Size = new System.Drawing.Size(131, 23);
            this.button2AddRaca.TabIndex = 30;
            this.button2AddRaca.Text = "Cadastrar Raça";
            this.button2AddRaca.UseVisualStyleBackColor = true;
            this.button2AddRaca.Click += new System.EventHandler(this.button2AddRaca_Click);
            // 
            // especieBindingSource
            // 
            this.especieBindingSource.DataMember = "Especie";
            this.especieBindingSource.DataSource = this.bD_PetCareDataSet;
            // 
            // racaBindingSource
            // 
            this.racaBindingSource.DataMember = "Raca";
            this.racaBindingSource.DataSource = this.bD_PetCareDataSet;
            // 
            // especieBindingSource1
            // 
            this.especieBindingSource1.DataMember = "Especie";
            this.especieBindingSource1.DataSource = this.bD_PetCareDataSet;
            // 
            // racaBindingSource1
            // 
            this.racaBindingSource1.DataMember = "Raca";
            this.racaBindingSource1.DataSource = this.bD_PetCareDataSet;
            // 
            // sexoBindingSource
            // 
            this.sexoBindingSource.DataMember = "Sexo";
            this.sexoBindingSource.DataSource = this.bD_PetCareDataSet;
            // 
            // iD_PetLabel1
            // 
            this.iD_PetLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "ID_Pet", true));
            this.iD_PetLabel1.Location = new System.Drawing.Point(139, 47);
            this.iD_PetLabel1.Name = "iD_PetLabel1";
            this.iD_PetLabel1.Size = new System.Drawing.Size(214, 23);
            this.iD_PetLabel1.TabIndex = 31;
            this.iD_PetLabel1.Text = "label1";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(139, 73);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(214, 20);
            this.nomeTextBox.TabIndex = 33;
            // 
            // data_NascimentoDateTimePicker
            // 
            this.data_NascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.perfilBindingSource, "Data_Nascimento", true));
            this.data_NascimentoDateTimePicker.Location = new System.Drawing.Point(139, 99);
            this.data_NascimentoDateTimePicker.Name = "data_NascimentoDateTimePicker";
            this.data_NascimentoDateTimePicker.Size = new System.Drawing.Size(214, 20);
            this.data_NascimentoDateTimePicker.TabIndex = 35;
            // 
            // iD_EspecieTextBox
            // 
            this.iD_EspecieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "ID_Especie", true));
            this.iD_EspecieTextBox.Location = new System.Drawing.Point(631, 87);
            this.iD_EspecieTextBox.Name = "iD_EspecieTextBox";
            this.iD_EspecieTextBox.Size = new System.Drawing.Size(214, 20);
            this.iD_EspecieTextBox.TabIndex = 37;
            // 
            // especieTextBox
            // 
            this.especieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "Especie", true));
            this.especieTextBox.Location = new System.Drawing.Point(631, 113);
            this.especieTextBox.Name = "especieTextBox";
            this.especieTextBox.Size = new System.Drawing.Size(214, 20);
            this.especieTextBox.TabIndex = 39;
            // 
            // iD_RacaTextBox
            // 
            this.iD_RacaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "ID_Raca", true));
            this.iD_RacaTextBox.Location = new System.Drawing.Point(631, 139);
            this.iD_RacaTextBox.Name = "iD_RacaTextBox";
            this.iD_RacaTextBox.Size = new System.Drawing.Size(214, 20);
            this.iD_RacaTextBox.TabIndex = 41;
            // 
            // racaTextBox
            // 
            this.racaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "Raca", true));
            this.racaTextBox.Location = new System.Drawing.Point(631, 165);
            this.racaTextBox.Name = "racaTextBox";
            this.racaTextBox.Size = new System.Drawing.Size(214, 20);
            this.racaTextBox.TabIndex = 43;
            // 
            // iD_SexoTextBox
            // 
            this.iD_SexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "ID_Sexo", true));
            this.iD_SexoTextBox.Location = new System.Drawing.Point(631, 191);
            this.iD_SexoTextBox.Name = "iD_SexoTextBox";
            this.iD_SexoTextBox.Size = new System.Drawing.Size(214, 20);
            this.iD_SexoTextBox.TabIndex = 45;
            // 
            // sexoTextBox
            // 
            this.sexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "Sexo", true));
            this.sexoTextBox.Location = new System.Drawing.Point(631, 217);
            this.sexoTextBox.Name = "sexoTextBox";
            this.sexoTextBox.Size = new System.Drawing.Size(214, 20);
            this.sexoTextBox.TabIndex = 47;
            // 
            // corTextBox
            // 
            this.corTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "Cor", true));
            this.corTextBox.Location = new System.Drawing.Point(139, 206);
            this.corTextBox.Name = "corTextBox";
            this.corTextBox.Size = new System.Drawing.Size(214, 20);
            this.corTextBox.TabIndex = 49;
            // 
            // fotoTextBox
            // 
            this.fotoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "Foto", true));
            this.fotoTextBox.Location = new System.Drawing.Point(139, 232);
            this.fotoTextBox.Name = "fotoTextBox";
            this.fotoTextBox.Size = new System.Drawing.Size(214, 20);
            this.fotoTextBox.TabIndex = 51;
            // 
            // doencasTextBox
            // 
            this.doencasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "Doencas", true));
            this.doencasTextBox.Location = new System.Drawing.Point(139, 258);
            this.doencasTextBox.Name = "doencasTextBox";
            this.doencasTextBox.Size = new System.Drawing.Size(214, 20);
            this.doencasTextBox.TabIndex = 53;
            // 
            // alergiasTextBox
            // 
            this.alergiasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "Alergias", true));
            this.alergiasTextBox.Location = new System.Drawing.Point(139, 284);
            this.alergiasTextBox.Name = "alergiasTextBox";
            this.alergiasTextBox.Size = new System.Drawing.Size(214, 20);
            this.alergiasTextBox.TabIndex = 55;
            // 
            // observacoesTextBox
            // 
            this.observacoesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "Observacoes", true));
            this.observacoesTextBox.Location = new System.Drawing.Point(139, 310);
            this.observacoesTextBox.Multiline = true;
            this.observacoesTextBox.Name = "observacoesTextBox";
            this.observacoesTextBox.Size = new System.Drawing.Size(214, 73);
            this.observacoesTextBox.TabIndex = 57;
            // 
            // especieComboBox1
            // 
            this.especieComboBox1.DataSource = this.especieBindingSource;
            this.especieComboBox1.DisplayMember = "Nome_Especie";
            this.especieComboBox1.FormattingEnabled = true;
            this.especieComboBox1.Location = new System.Drawing.Point(139, 126);
            this.especieComboBox1.Name = "especieComboBox1";
            this.especieComboBox1.Size = new System.Drawing.Size(214, 21);
            this.especieComboBox1.TabIndex = 58;
            this.especieComboBox1.ValueMember = "ID_Especie";
            this.especieComboBox1.SelectedIndexChanged += new System.EventHandler(this.especieComboBox1_SelectedIndexChanged);
            // 
            // racaComboBox2
            // 
            this.racaComboBox2.DataSource = this.racaBindingSource;
            this.racaComboBox2.DisplayMember = "Nome_Raca";
            this.racaComboBox2.FormattingEnabled = true;
            this.racaComboBox2.Location = new System.Drawing.Point(139, 153);
            this.racaComboBox2.Name = "racaComboBox2";
            this.racaComboBox2.Size = new System.Drawing.Size(214, 21);
            this.racaComboBox2.TabIndex = 59;
            this.racaComboBox2.ValueMember = "ID_Raca";
            this.racaComboBox2.SelectedIndexChanged += new System.EventHandler(this.racaComboBox2_SelectedIndexChanged);
            // 
            // sexoComboBox3
            // 
            this.sexoComboBox3.DataSource = this.sexoBindingSource;
            this.sexoComboBox3.DisplayMember = "Sexo";
            this.sexoComboBox3.FormattingEnabled = true;
            this.sexoComboBox3.Location = new System.Drawing.Point(139, 181);
            this.sexoComboBox3.Name = "sexoComboBox3";
            this.sexoComboBox3.Size = new System.Drawing.Size(214, 21);
            this.sexoComboBox3.TabIndex = 60;
            this.sexoComboBox3.ValueMember = "ID_Sexo";
            this.sexoComboBox3.SelectedIndexChanged += new System.EventHandler(this.sexoComboBox3_SelectedIndexChanged);
            // 
            // perfilDataGridView
            // 
            this.perfilDataGridView.AutoGenerateColumns = false;
            this.perfilDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.perfilDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.perfilDataGridView.DataSource = this.perfilBindingSource;
            this.perfilDataGridView.Location = new System.Drawing.Point(12, 397);
            this.perfilDataGridView.Name = "perfilDataGridView";
            this.perfilDataGridView.Size = new System.Drawing.Size(855, 271);
            this.perfilDataGridView.TabIndex = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Pet";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Pet";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Data_Nascimento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data_Nascimento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_Especie";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID_Especie";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Especie";
            this.dataGridViewTextBoxColumn5.HeaderText = "Especie";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID_Raca";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID_Raca";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Raca";
            this.dataGridViewTextBoxColumn7.HeaderText = "Raca";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ID_Sexo";
            this.dataGridViewTextBoxColumn8.HeaderText = "ID_Sexo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Sexo";
            this.dataGridViewTextBoxColumn9.HeaderText = "Sexo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Cor";
            this.dataGridViewTextBoxColumn10.HeaderText = "Cor";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Foto";
            this.dataGridViewTextBoxColumn11.HeaderText = "Foto";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Doencas";
            this.dataGridViewTextBoxColumn12.HeaderText = "Doencas";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Alergias";
            this.dataGridViewTextBoxColumn13.HeaderText = "Alergias";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Observacoes";
            this.dataGridViewTextBoxColumn14.HeaderText = "Observacoes";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 680);
            this.Controls.Add(this.perfilDataGridView);
            this.Controls.Add(this.sexoComboBox3);
            this.Controls.Add(this.racaComboBox2);
            this.Controls.Add(this.especieComboBox1);
            this.Controls.Add(iD_PetLabel);
            this.Controls.Add(this.iD_PetLabel1);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(data_NascimentoLabel);
            this.Controls.Add(this.data_NascimentoDateTimePicker);
            this.Controls.Add(iD_EspecieLabel);
            this.Controls.Add(this.iD_EspecieTextBox);
            this.Controls.Add(especieLabel);
            this.Controls.Add(this.especieTextBox);
            this.Controls.Add(iD_RacaLabel);
            this.Controls.Add(this.iD_RacaTextBox);
            this.Controls.Add(racaLabel);
            this.Controls.Add(this.racaTextBox);
            this.Controls.Add(iD_SexoLabel);
            this.Controls.Add(this.iD_SexoTextBox);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoTextBox);
            this.Controls.Add(corLabel);
            this.Controls.Add(this.corTextBox);
            this.Controls.Add(fotoLabel);
            this.Controls.Add(this.fotoTextBox);
            this.Controls.Add(doencasLabel);
            this.Controls.Add(this.doencasTextBox);
            this.Controls.Add(alergiasLabel);
            this.Controls.Add(this.alergiasTextBox);
            this.Controls.Add(observacoesLabel);
            this.Controls.Add(this.observacoesTextBox);
            this.Controls.Add(this.button2AddRaca);
            this.Controls.Add(this.button1AddEspecie);
            this.Controls.Add(this.perfilBindingNavigator);
            this.Name = "Form2";
            this.Text = "Cadastrar Pet";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_PetCareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingNavigator)).EndInit();
            this.perfilBindingNavigator.ResumeLayout(false);
            this.perfilBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_PetCareDataSet bD_PetCareDataSet;
        private System.Windows.Forms.BindingSource perfilBindingSource;
        private BD_PetCareDataSetTableAdapters.PerfilTableAdapter perfilTableAdapter;
        private BD_PetCareDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator perfilBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton perfilBindingNavigatorSaveItem;
        private BD_PetCareDataSetTableAdapters.EspecieTableAdapter especieTableAdapter;
        private System.Windows.Forms.Button button1AddEspecie;
        private System.Windows.Forms.Button button2AddRaca;
        private System.Windows.Forms.BindingSource especieBindingSource;
        private BD_PetCareDataSetTableAdapters.RacaTableAdapter racaTableAdapter;
        private System.Windows.Forms.BindingSource racaBindingSource;
        private BD_PetCareDataSetTableAdapters.SexoTableAdapter sexoTableAdapter;
        private System.Windows.Forms.BindingSource especieBindingSource1;
        private System.Windows.Forms.BindingSource racaBindingSource1;
        private System.Windows.Forms.BindingSource sexoBindingSource;
        private System.Windows.Forms.Label iD_PetLabel1;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.DateTimePicker data_NascimentoDateTimePicker;
        private System.Windows.Forms.TextBox iD_EspecieTextBox;
        private System.Windows.Forms.TextBox especieTextBox;
        private System.Windows.Forms.TextBox iD_RacaTextBox;
        private System.Windows.Forms.TextBox racaTextBox;
        private System.Windows.Forms.TextBox iD_SexoTextBox;
        private System.Windows.Forms.TextBox sexoTextBox;
        private System.Windows.Forms.TextBox corTextBox;
        private System.Windows.Forms.TextBox fotoTextBox;
        private System.Windows.Forms.TextBox doencasTextBox;
        private System.Windows.Forms.TextBox alergiasTextBox;
        private System.Windows.Forms.TextBox observacoesTextBox;
        private System.Windows.Forms.ComboBox especieComboBox1;
        private System.Windows.Forms.ComboBox racaComboBox2;
        private System.Windows.Forms.ComboBox sexoComboBox3;
        private System.Windows.Forms.DataGridView perfilDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}