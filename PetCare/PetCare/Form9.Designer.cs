namespace PetCare
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            System.Windows.Forms.Label iD_BanhoTosaLabel;
            System.Windows.Forms.Label iD_PetLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label banhoLabel;
            System.Windows.Forms.Label tosaLabel;
            System.Windows.Forms.Label foto_ResultadoLabel;
            System.Windows.Forms.Label localLabel;
            System.Windows.Forms.Label observacaoLabel;
            this.bD_PetCareDataSet = new PetCare.BD_PetCareDataSet();
            this.banho_TosaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banho_TosaTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.Banho_TosaTableAdapter();
            this.tableAdapterManager = new PetCare.BD_PetCareDataSetTableAdapters.TableAdapterManager();
            this.banho_TosaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.banho_TosaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_BanhoTosaLabel1 = new System.Windows.Forms.Label();
            this.iD_PetTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.banhoCheckBox = new System.Windows.Forms.CheckBox();
            this.tosaCheckBox = new System.Windows.Forms.CheckBox();
            this.foto_ResultadoTextBox = new System.Windows.Forms.TextBox();
            this.localTextBox = new System.Windows.Forms.TextBox();
            this.observacaoTextBox = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.outrosRemédiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outros_RemédiosTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.Outros_RemédiosTableAdapter();
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perfilTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.PerfilTableAdapter();
            this.banho_TosaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_BanhoTosaLabel = new System.Windows.Forms.Label();
            iD_PetLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            banhoLabel = new System.Windows.Forms.Label();
            tosaLabel = new System.Windows.Forms.Label();
            foto_ResultadoLabel = new System.Windows.Forms.Label();
            localLabel = new System.Windows.Forms.Label();
            observacaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PetCareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banho_TosaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banho_TosaBindingNavigator)).BeginInit();
            this.banho_TosaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outrosRemédiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banho_TosaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bD_PetCareDataSet
            // 
            this.bD_PetCareDataSet.DataSetName = "BD_PetCareDataSet";
            this.bD_PetCareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Banho_TosaTableAdapter = this.banho_TosaTableAdapter;
            this.tableAdapterManager.ConsultasTableAdapter = null;
            this.tableAdapterManager.EspecieTableAdapter = null;
            this.tableAdapterManager.Outros_RemédiosTableAdapter = this.outros_RemédiosTableAdapter;
            this.tableAdapterManager.PerfilTableAdapter = this.perfilTableAdapter;
            this.tableAdapterManager.PesoTableAdapter = null;
            this.tableAdapterManager.RacaTableAdapter = null;
            this.tableAdapterManager.SexoTableAdapter = null;
            this.tableAdapterManager.TratamentosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PetCare.BD_PetCareDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VacinacaoTableAdapter = null;
            this.tableAdapterManager.VermifugacaoTableAdapter = null;
            // 
            // banho_TosaBindingNavigator
            // 
            this.banho_TosaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.banho_TosaBindingNavigator.BindingSource = this.banho_TosaBindingSource;
            this.banho_TosaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.banho_TosaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.banho_TosaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.banho_TosaBindingNavigatorSaveItem});
            this.banho_TosaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.banho_TosaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.banho_TosaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.banho_TosaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.banho_TosaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.banho_TosaBindingNavigator.Name = "banho_TosaBindingNavigator";
            this.banho_TosaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.banho_TosaBindingNavigator.Size = new System.Drawing.Size(868, 25);
            this.banho_TosaBindingNavigator.TabIndex = 0;
            this.banho_TosaBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // banho_TosaBindingNavigatorSaveItem
            // 
            this.banho_TosaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.banho_TosaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("banho_TosaBindingNavigatorSaveItem.Image")));
            this.banho_TosaBindingNavigatorSaveItem.Name = "banho_TosaBindingNavigatorSaveItem";
            this.banho_TosaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.banho_TosaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.banho_TosaBindingNavigatorSaveItem.Click += new System.EventHandler(this.banho_TosaBindingNavigatorSaveItem_Click);
            // 
            // iD_BanhoTosaLabel
            // 
            iD_BanhoTosaLabel.AutoSize = true;
            iD_BanhoTosaLabel.Location = new System.Drawing.Point(23, 42);
            iD_BanhoTosaLabel.Name = "iD_BanhoTosaLabel";
            iD_BanhoTosaLabel.Size = new System.Drawing.Size(82, 13);
            iD_BanhoTosaLabel.TabIndex = 1;
            iD_BanhoTosaLabel.Text = "ID Banho Tosa:";
            // 
            // iD_BanhoTosaLabel1
            // 
            this.iD_BanhoTosaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.banho_TosaBindingSource, "ID_BanhoTosa", true));
            this.iD_BanhoTosaLabel1.Location = new System.Drawing.Point(111, 42);
            this.iD_BanhoTosaLabel1.Name = "iD_BanhoTosaLabel1";
            this.iD_BanhoTosaLabel1.Size = new System.Drawing.Size(238, 23);
            this.iD_BanhoTosaLabel1.TabIndex = 2;
            this.iD_BanhoTosaLabel1.Text = "label1";
            // 
            // iD_PetLabel
            // 
            iD_PetLabel.AutoSize = true;
            iD_PetLabel.Location = new System.Drawing.Point(23, 71);
            iD_PetLabel.Name = "iD_PetLabel";
            iD_PetLabel.Size = new System.Drawing.Size(40, 13);
            iD_PetLabel.TabIndex = 3;
            iD_PetLabel.Text = "ID Pet:";
            // 
            // iD_PetTextBox
            // 
            this.iD_PetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.banho_TosaBindingSource, "ID_Pet", true));
            this.iD_PetTextBox.Location = new System.Drawing.Point(355, 68);
            this.iD_PetTextBox.Name = "iD_PetTextBox";
            this.iD_PetTextBox.Size = new System.Drawing.Size(238, 20);
            this.iD_PetTextBox.TabIndex = 4;
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(23, 98);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 5;
            dataLabel.Text = "Data:";
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.banho_TosaBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(111, 94);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(238, 20);
            this.dataDateTimePicker.TabIndex = 6;
            // 
            // banhoLabel
            // 
            banhoLabel.AutoSize = true;
            banhoLabel.Location = new System.Drawing.Point(23, 125);
            banhoLabel.Name = "banhoLabel";
            banhoLabel.Size = new System.Drawing.Size(41, 13);
            banhoLabel.TabIndex = 7;
            banhoLabel.Text = "Banho:";
            // 
            // banhoCheckBox
            // 
            this.banhoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.banho_TosaBindingSource, "Banho", true));
            this.banhoCheckBox.Location = new System.Drawing.Point(111, 120);
            this.banhoCheckBox.Name = "banhoCheckBox";
            this.banhoCheckBox.Size = new System.Drawing.Size(238, 24);
            this.banhoCheckBox.TabIndex = 8;
            this.banhoCheckBox.UseVisualStyleBackColor = true;
            // 
            // tosaLabel
            // 
            tosaLabel.AutoSize = true;
            tosaLabel.Location = new System.Drawing.Point(23, 155);
            tosaLabel.Name = "tosaLabel";
            tosaLabel.Size = new System.Drawing.Size(34, 13);
            tosaLabel.TabIndex = 9;
            tosaLabel.Text = "Tosa:";
            // 
            // tosaCheckBox
            // 
            this.tosaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.banho_TosaBindingSource, "Tosa", true));
            this.tosaCheckBox.Location = new System.Drawing.Point(111, 150);
            this.tosaCheckBox.Name = "tosaCheckBox";
            this.tosaCheckBox.Size = new System.Drawing.Size(238, 24);
            this.tosaCheckBox.TabIndex = 10;
            this.tosaCheckBox.UseVisualStyleBackColor = true;
            // 
            // foto_ResultadoLabel
            // 
            foto_ResultadoLabel.AutoSize = true;
            foto_ResultadoLabel.Location = new System.Drawing.Point(23, 183);
            foto_ResultadoLabel.Name = "foto_ResultadoLabel";
            foto_ResultadoLabel.Size = new System.Drawing.Size(82, 13);
            foto_ResultadoLabel.TabIndex = 11;
            foto_ResultadoLabel.Text = "Foto Resultado:";
            // 
            // foto_ResultadoTextBox
            // 
            this.foto_ResultadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.banho_TosaBindingSource, "Foto_Resultado", true));
            this.foto_ResultadoTextBox.Location = new System.Drawing.Point(111, 180);
            this.foto_ResultadoTextBox.Name = "foto_ResultadoTextBox";
            this.foto_ResultadoTextBox.Size = new System.Drawing.Size(238, 20);
            this.foto_ResultadoTextBox.TabIndex = 12;
            // 
            // localLabel
            // 
            localLabel.AutoSize = true;
            localLabel.Location = new System.Drawing.Point(23, 209);
            localLabel.Name = "localLabel";
            localLabel.Size = new System.Drawing.Size(36, 13);
            localLabel.TabIndex = 13;
            localLabel.Text = "Local:";
            // 
            // localTextBox
            // 
            this.localTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.banho_TosaBindingSource, "Local", true));
            this.localTextBox.Location = new System.Drawing.Point(111, 206);
            this.localTextBox.Name = "localTextBox";
            this.localTextBox.Size = new System.Drawing.Size(238, 20);
            this.localTextBox.TabIndex = 14;
            // 
            // observacaoLabel
            // 
            observacaoLabel.AutoSize = true;
            observacaoLabel.Location = new System.Drawing.Point(23, 235);
            observacaoLabel.Name = "observacaoLabel";
            observacaoLabel.Size = new System.Drawing.Size(68, 13);
            observacaoLabel.TabIndex = 15;
            observacaoLabel.Text = "Observacao:";
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.banho_TosaBindingSource, "Observacao", true));
            this.observacaoTextBox.Location = new System.Drawing.Point(111, 232);
            this.observacaoTextBox.Multiline = true;
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.Size = new System.Drawing.Size(238, 57);
            this.observacaoTextBox.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.perfilBindingSource;
            this.comboBox2.DisplayMember = "Nome";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(111, 68);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(238, 21);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.ValueMember = "ID_Pet";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // outrosRemédiosBindingSource
            // 
            this.outrosRemédiosBindingSource.DataMember = "Outros_Remédios";
            this.outrosRemédiosBindingSource.DataSource = this.bD_PetCareDataSet;
            // 
            // outros_RemédiosTableAdapter
            // 
            this.outros_RemédiosTableAdapter.ClearBeforeFill = true;
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
            // banho_TosaDataGridView
            // 
            this.banho_TosaDataGridView.AutoGenerateColumns = false;
            this.banho_TosaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.banho_TosaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.banho_TosaDataGridView.DataSource = this.banho_TosaBindingSource;
            this.banho_TosaDataGridView.Location = new System.Drawing.Point(12, 308);
            this.banho_TosaDataGridView.Name = "banho_TosaDataGridView";
            this.banho_TosaDataGridView.Size = new System.Drawing.Size(845, 238);
            this.banho_TosaDataGridView.TabIndex = 19;
            this.banho_TosaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.banho_TosaDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_BanhoTosa";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_BanhoTosa";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Banho";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Banho";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Tosa";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Tosa";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Foto_Resultado";
            this.dataGridViewTextBoxColumn4.HeaderText = "Foto_Resultado";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Local";
            this.dataGridViewTextBoxColumn5.HeaderText = "Local";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Observacao";
            this.dataGridViewTextBoxColumn6.HeaderText = "Observacao";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 558);
            this.Controls.Add(this.banho_TosaDataGridView);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(iD_BanhoTosaLabel);
            this.Controls.Add(this.iD_BanhoTosaLabel1);
            this.Controls.Add(iD_PetLabel);
            this.Controls.Add(this.iD_PetTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(banhoLabel);
            this.Controls.Add(this.banhoCheckBox);
            this.Controls.Add(tosaLabel);
            this.Controls.Add(this.tosaCheckBox);
            this.Controls.Add(foto_ResultadoLabel);
            this.Controls.Add(this.foto_ResultadoTextBox);
            this.Controls.Add(localLabel);
            this.Controls.Add(this.localTextBox);
            this.Controls.Add(observacaoLabel);
            this.Controls.Add(this.observacaoTextBox);
            this.Controls.Add(this.banho_TosaBindingNavigator);
            this.Name = "Form9";
            this.Text = "Cadastrar Novo Banho e Tosa";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_PetCareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banho_TosaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banho_TosaBindingNavigator)).EndInit();
            this.banho_TosaBindingNavigator.ResumeLayout(false);
            this.banho_TosaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outrosRemédiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banho_TosaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_PetCareDataSet bD_PetCareDataSet;
        private System.Windows.Forms.BindingSource banho_TosaBindingSource;
        private BD_PetCareDataSetTableAdapters.Banho_TosaTableAdapter banho_TosaTableAdapter;
        private BD_PetCareDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator banho_TosaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton banho_TosaBindingNavigatorSaveItem;
        private BD_PetCareDataSetTableAdapters.Outros_RemédiosTableAdapter outros_RemédiosTableAdapter;
        private System.Windows.Forms.Label iD_BanhoTosaLabel1;
        private System.Windows.Forms.TextBox iD_PetTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.CheckBox banhoCheckBox;
        private System.Windows.Forms.CheckBox tosaCheckBox;
        private System.Windows.Forms.TextBox foto_ResultadoTextBox;
        private System.Windows.Forms.TextBox localTextBox;
        private System.Windows.Forms.TextBox observacaoTextBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource outrosRemédiosBindingSource;
        private BD_PetCareDataSetTableAdapters.PerfilTableAdapter perfilTableAdapter;
        private System.Windows.Forms.BindingSource perfilBindingSource;
        private System.Windows.Forms.DataGridView banho_TosaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}