namespace PetCare
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            System.Windows.Forms.Label iD_OutrosLabel;
            System.Windows.Forms.Label iD_PetLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label doseLabel;
            System.Windows.Forms.Label data_ReforcoLabel;
            System.Windows.Forms.Label frequenciaLabel;
            System.Windows.Forms.Label observacaoLabel;
            this.bD_PetCareDataSet = new PetCare.BD_PetCareDataSet();
            this.outros_RemédiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outros_RemédiosTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.Outros_RemédiosTableAdapter();
            this.tableAdapterManager = new PetCare.BD_PetCareDataSetTableAdapters.TableAdapterManager();
            this.outros_RemédiosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.outros_RemédiosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_OutrosLabel1 = new System.Windows.Forms.Label();
            this.iD_PetTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.doseTextBox = new System.Windows.Forms.TextBox();
            this.data_ReforcoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.frequenciaTextBox = new System.Windows.Forms.TextBox();
            this.observacaoTextBox = new System.Windows.Forms.TextBox();
            this.outros_RemédiosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perfilTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.PerfilTableAdapter();
            iD_OutrosLabel = new System.Windows.Forms.Label();
            iD_PetLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            doseLabel = new System.Windows.Forms.Label();
            data_ReforcoLabel = new System.Windows.Forms.Label();
            frequenciaLabel = new System.Windows.Forms.Label();
            observacaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PetCareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outros_RemédiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outros_RemédiosBindingNavigator)).BeginInit();
            this.outros_RemédiosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outros_RemédiosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bD_PetCareDataSet
            // 
            this.bD_PetCareDataSet.DataSetName = "BD_PetCareDataSet";
            this.bD_PetCareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Banho_TosaTableAdapter = null;
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
            // outros_RemédiosBindingNavigator
            // 
            this.outros_RemédiosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.outros_RemédiosBindingNavigator.BindingSource = this.outros_RemédiosBindingSource;
            this.outros_RemédiosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.outros_RemédiosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.outros_RemédiosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.outros_RemédiosBindingNavigatorSaveItem});
            this.outros_RemédiosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.outros_RemédiosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.outros_RemédiosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.outros_RemédiosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.outros_RemédiosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.outros_RemédiosBindingNavigator.Name = "outros_RemédiosBindingNavigator";
            this.outros_RemédiosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.outros_RemédiosBindingNavigator.Size = new System.Drawing.Size(871, 25);
            this.outros_RemédiosBindingNavigator.TabIndex = 0;
            this.outros_RemédiosBindingNavigator.Text = "bindingNavigator1";
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
            // outros_RemédiosBindingNavigatorSaveItem
            // 
            this.outros_RemédiosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.outros_RemédiosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("outros_RemédiosBindingNavigatorSaveItem.Image")));
            this.outros_RemédiosBindingNavigatorSaveItem.Name = "outros_RemédiosBindingNavigatorSaveItem";
            this.outros_RemédiosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.outros_RemédiosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.outros_RemédiosBindingNavigatorSaveItem.Click += new System.EventHandler(this.outros_RemédiosBindingNavigatorSaveItem_Click);
            // 
            // iD_OutrosLabel
            // 
            iD_OutrosLabel.AutoSize = true;
            iD_OutrosLabel.Location = new System.Drawing.Point(24, 50);
            iD_OutrosLabel.Name = "iD_OutrosLabel";
            iD_OutrosLabel.Size = new System.Drawing.Size(55, 13);
            iD_OutrosLabel.TabIndex = 1;
            iD_OutrosLabel.Text = "ID Outros:";
            // 
            // iD_OutrosLabel1
            // 
            this.iD_OutrosLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.outros_RemédiosBindingSource, "ID_Outros", true));
            this.iD_OutrosLabel1.Location = new System.Drawing.Point(104, 50);
            this.iD_OutrosLabel1.Name = "iD_OutrosLabel1";
            this.iD_OutrosLabel1.Size = new System.Drawing.Size(232, 23);
            this.iD_OutrosLabel1.TabIndex = 2;
            this.iD_OutrosLabel1.Text = "label1";
            // 
            // iD_PetLabel
            // 
            iD_PetLabel.AutoSize = true;
            iD_PetLabel.Location = new System.Drawing.Point(24, 79);
            iD_PetLabel.Name = "iD_PetLabel";
            iD_PetLabel.Size = new System.Drawing.Size(40, 13);
            iD_PetLabel.TabIndex = 3;
            iD_PetLabel.Text = "ID Pet:";
            // 
            // iD_PetTextBox
            // 
            this.iD_PetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.outros_RemédiosBindingSource, "ID_Pet", true));
            this.iD_PetTextBox.Location = new System.Drawing.Point(360, 76);
            this.iD_PetTextBox.Name = "iD_PetTextBox";
            this.iD_PetTextBox.Size = new System.Drawing.Size(232, 20);
            this.iD_PetTextBox.TabIndex = 4;
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(24, 106);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 5;
            dataLabel.Text = "Data:";
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.outros_RemédiosBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(104, 102);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(232, 20);
            this.dataDateTimePicker.TabIndex = 6;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(24, 131);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 7;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.outros_RemédiosBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(104, 128);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(232, 20);
            this.nomeTextBox.TabIndex = 8;
            // 
            // doseLabel
            // 
            doseLabel.AutoSize = true;
            doseLabel.Location = new System.Drawing.Point(24, 157);
            doseLabel.Name = "doseLabel";
            doseLabel.Size = new System.Drawing.Size(35, 13);
            doseLabel.TabIndex = 9;
            doseLabel.Text = "Dose:";
            // 
            // doseTextBox
            // 
            this.doseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.outros_RemédiosBindingSource, "Dose", true));
            this.doseTextBox.Location = new System.Drawing.Point(104, 154);
            this.doseTextBox.Name = "doseTextBox";
            this.doseTextBox.Size = new System.Drawing.Size(232, 20);
            this.doseTextBox.TabIndex = 10;
            // 
            // data_ReforcoLabel
            // 
            data_ReforcoLabel.AutoSize = true;
            data_ReforcoLabel.Location = new System.Drawing.Point(24, 184);
            data_ReforcoLabel.Name = "data_ReforcoLabel";
            data_ReforcoLabel.Size = new System.Drawing.Size(74, 13);
            data_ReforcoLabel.TabIndex = 11;
            data_ReforcoLabel.Text = "Data Reforco:";
            // 
            // data_ReforcoDateTimePicker
            // 
            this.data_ReforcoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.outros_RemédiosBindingSource, "Data_Reforco", true));
            this.data_ReforcoDateTimePicker.Location = new System.Drawing.Point(104, 180);
            this.data_ReforcoDateTimePicker.Name = "data_ReforcoDateTimePicker";
            this.data_ReforcoDateTimePicker.Size = new System.Drawing.Size(232, 20);
            this.data_ReforcoDateTimePicker.TabIndex = 12;
            // 
            // frequenciaLabel
            // 
            frequenciaLabel.AutoSize = true;
            frequenciaLabel.Location = new System.Drawing.Point(24, 209);
            frequenciaLabel.Name = "frequenciaLabel";
            frequenciaLabel.Size = new System.Drawing.Size(63, 13);
            frequenciaLabel.TabIndex = 13;
            frequenciaLabel.Text = "Frequencia:";
            // 
            // frequenciaTextBox
            // 
            this.frequenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.outros_RemédiosBindingSource, "Frequencia", true));
            this.frequenciaTextBox.Location = new System.Drawing.Point(104, 206);
            this.frequenciaTextBox.Name = "frequenciaTextBox";
            this.frequenciaTextBox.Size = new System.Drawing.Size(232, 20);
            this.frequenciaTextBox.TabIndex = 14;
            // 
            // observacaoLabel
            // 
            observacaoLabel.AutoSize = true;
            observacaoLabel.Location = new System.Drawing.Point(24, 235);
            observacaoLabel.Name = "observacaoLabel";
            observacaoLabel.Size = new System.Drawing.Size(68, 13);
            observacaoLabel.TabIndex = 15;
            observacaoLabel.Text = "Observacao:";
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.outros_RemédiosBindingSource, "Observacao", true));
            this.observacaoTextBox.Location = new System.Drawing.Point(104, 232);
            this.observacaoTextBox.Multiline = true;
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.Size = new System.Drawing.Size(232, 67);
            this.observacaoTextBox.TabIndex = 16;
            // 
            // outros_RemédiosDataGridView
            // 
            this.outros_RemédiosDataGridView.AutoGenerateColumns = false;
            this.outros_RemédiosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outros_RemédiosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.outros_RemédiosDataGridView.DataSource = this.outros_RemédiosBindingSource;
            this.outros_RemédiosDataGridView.Location = new System.Drawing.Point(12, 317);
            this.outros_RemédiosDataGridView.Name = "outros_RemédiosDataGridView";
            this.outros_RemédiosDataGridView.Size = new System.Drawing.Size(847, 238);
            this.outros_RemédiosDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Outros";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Outros";
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Dose";
            this.dataGridViewTextBoxColumn5.HeaderText = "Dose";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Data_Reforco";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data_Reforco";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Frequencia";
            this.dataGridViewTextBoxColumn7.HeaderText = "Frequencia";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Observacao";
            this.dataGridViewTextBoxColumn8.HeaderText = "Observacao";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.perfilBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "ID_Pet";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 567);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.outros_RemédiosDataGridView);
            this.Controls.Add(iD_OutrosLabel);
            this.Controls.Add(this.iD_OutrosLabel1);
            this.Controls.Add(iD_PetLabel);
            this.Controls.Add(this.iD_PetTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(doseLabel);
            this.Controls.Add(this.doseTextBox);
            this.Controls.Add(data_ReforcoLabel);
            this.Controls.Add(this.data_ReforcoDateTimePicker);
            this.Controls.Add(frequenciaLabel);
            this.Controls.Add(this.frequenciaTextBox);
            this.Controls.Add(observacaoLabel);
            this.Controls.Add(this.observacaoTextBox);
            this.Controls.Add(this.outros_RemédiosBindingNavigator);
            this.Name = "Form8";
            this.Text = "Cadastrar Outros Tratamentos Periódicos";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_PetCareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outros_RemédiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outros_RemédiosBindingNavigator)).EndInit();
            this.outros_RemédiosBindingNavigator.ResumeLayout(false);
            this.outros_RemédiosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outros_RemédiosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_PetCareDataSet bD_PetCareDataSet;
        private System.Windows.Forms.BindingSource outros_RemédiosBindingSource;
        private BD_PetCareDataSetTableAdapters.Outros_RemédiosTableAdapter outros_RemédiosTableAdapter;
        private BD_PetCareDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator outros_RemédiosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton outros_RemédiosBindingNavigatorSaveItem;
        private BD_PetCareDataSetTableAdapters.PerfilTableAdapter perfilTableAdapter;
        private System.Windows.Forms.Label iD_OutrosLabel1;
        private System.Windows.Forms.TextBox iD_PetTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox doseTextBox;
        private System.Windows.Forms.DateTimePicker data_ReforcoDateTimePicker;
        private System.Windows.Forms.TextBox frequenciaTextBox;
        private System.Windows.Forms.TextBox observacaoTextBox;
        private System.Windows.Forms.DataGridView outros_RemédiosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource perfilBindingSource;
    }
}