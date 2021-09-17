namespace PetCare
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.Label códigoLabel;
            System.Windows.Forms.Label iD_PetLabel;
            System.Windows.Forms.Label remedioLabel;
            System.Windows.Forms.Label doseLabel;
            System.Windows.Forms.Label frequenciaLabel;
            System.Windows.Forms.Label duracaoLabel;
            System.Windows.Forms.Label data_InicioLabel;
            System.Windows.Forms.Label data_FimLabel;
            this.bD_PetCareDataSet = new PetCare.BD_PetCareDataSet();
            this.tratamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tratamentosTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.TratamentosTableAdapter();
            this.tableAdapterManager = new PetCare.BD_PetCareDataSetTableAdapters.TableAdapterManager();
            this.tratamentosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tratamentosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tratamentosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.códigoLabel1 = new System.Windows.Forms.Label();
            this.iD_PetTextBox = new System.Windows.Forms.TextBox();
            this.remedioTextBox = new System.Windows.Forms.TextBox();
            this.doseTextBox = new System.Windows.Forms.TextBox();
            this.frequenciaTextBox = new System.Windows.Forms.TextBox();
            this.duracaoTextBox = new System.Windows.Forms.TextBox();
            this.data_InicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_FimDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perfilTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.PerfilTableAdapter();
            códigoLabel = new System.Windows.Forms.Label();
            iD_PetLabel = new System.Windows.Forms.Label();
            remedioLabel = new System.Windows.Forms.Label();
            doseLabel = new System.Windows.Forms.Label();
            frequenciaLabel = new System.Windows.Forms.Label();
            duracaoLabel = new System.Windows.Forms.Label();
            data_InicioLabel = new System.Windows.Forms.Label();
            data_FimLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PetCareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamentosBindingNavigator)).BeginInit();
            this.tratamentosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tratamentosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bD_PetCareDataSet
            // 
            this.bD_PetCareDataSet.DataSetName = "BD_PetCareDataSet";
            this.bD_PetCareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Banho_TosaTableAdapter = null;
            this.tableAdapterManager.ConsultasTableAdapter = null;
            this.tableAdapterManager.EspecieTableAdapter = null;
            this.tableAdapterManager.Outros_RemédiosTableAdapter = null;
            this.tableAdapterManager.PerfilTableAdapter = this.perfilTableAdapter;
            this.tableAdapterManager.PesoTableAdapter = null;
            this.tableAdapterManager.RacaTableAdapter = null;
            this.tableAdapterManager.SexoTableAdapter = null;
            this.tableAdapterManager.TratamentosTableAdapter = this.tratamentosTableAdapter;
            this.tableAdapterManager.UpdateOrder = PetCare.BD_PetCareDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VacinacaoTableAdapter = null;
            this.tableAdapterManager.VermifugacaoTableAdapter = null;
            // 
            // tratamentosBindingNavigator
            // 
            this.tratamentosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tratamentosBindingNavigator.BindingSource = this.tratamentosBindingSource;
            this.tratamentosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tratamentosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tratamentosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tratamentosBindingNavigatorSaveItem});
            this.tratamentosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tratamentosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tratamentosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tratamentosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tratamentosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tratamentosBindingNavigator.Name = "tratamentosBindingNavigator";
            this.tratamentosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tratamentosBindingNavigator.Size = new System.Drawing.Size(869, 25);
            this.tratamentosBindingNavigator.TabIndex = 0;
            this.tratamentosBindingNavigator.Text = "bindingNavigator1";
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
            // tratamentosBindingNavigatorSaveItem
            // 
            this.tratamentosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tratamentosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tratamentosBindingNavigatorSaveItem.Image")));
            this.tratamentosBindingNavigatorSaveItem.Name = "tratamentosBindingNavigatorSaveItem";
            this.tratamentosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tratamentosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tratamentosBindingNavigatorSaveItem.Click += new System.EventHandler(this.tratamentosBindingNavigatorSaveItem_Click);
            // 
            // tratamentosDataGridView
            // 
            this.tratamentosDataGridView.AutoGenerateColumns = false;
            this.tratamentosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tratamentosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.tratamentosDataGridView.DataSource = this.tratamentosBindingSource;
            this.tratamentosDataGridView.Location = new System.Drawing.Point(12, 275);
            this.tratamentosDataGridView.Name = "tratamentosDataGridView";
            this.tratamentosDataGridView.Size = new System.Drawing.Size(844, 193);
            this.tratamentosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Código";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Remedio";
            this.dataGridViewTextBoxColumn3.HeaderText = "Remedio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Dose";
            this.dataGridViewTextBoxColumn4.HeaderText = "Dose";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Frequencia";
            this.dataGridViewTextBoxColumn5.HeaderText = "Frequencia";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Duracao";
            this.dataGridViewTextBoxColumn6.HeaderText = "Duracao";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Data_Inicio";
            this.dataGridViewTextBoxColumn7.HeaderText = "Data_Inicio";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Data_Fim";
            this.dataGridViewTextBoxColumn8.HeaderText = "Data_Fim";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // códigoLabel
            // 
            códigoLabel.AutoSize = true;
            códigoLabel.Location = new System.Drawing.Point(57, 46);
            códigoLabel.Name = "códigoLabel";
            códigoLabel.Size = new System.Drawing.Size(43, 13);
            códigoLabel.TabIndex = 2;
            códigoLabel.Text = "Código:";
            // 
            // códigoLabel1
            // 
            this.códigoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamentosBindingSource, "Código", true));
            this.códigoLabel1.Location = new System.Drawing.Point(126, 46);
            this.códigoLabel1.Name = "códigoLabel1";
            this.códigoLabel1.Size = new System.Drawing.Size(200, 23);
            this.códigoLabel1.TabIndex = 3;
            this.códigoLabel1.Text = "label1";
            // 
            // iD_PetLabel
            // 
            iD_PetLabel.AutoSize = true;
            iD_PetLabel.Location = new System.Drawing.Point(57, 75);
            iD_PetLabel.Name = "iD_PetLabel";
            iD_PetLabel.Size = new System.Drawing.Size(40, 13);
            iD_PetLabel.TabIndex = 4;
            iD_PetLabel.Text = "ID Pet:";
            // 
            // iD_PetTextBox
            // 
            this.iD_PetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamentosBindingSource, "ID_Pet", true));
            this.iD_PetTextBox.Location = new System.Drawing.Point(343, 72);
            this.iD_PetTextBox.Name = "iD_PetTextBox";
            this.iD_PetTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_PetTextBox.TabIndex = 5;
            // 
            // remedioLabel
            // 
            remedioLabel.AutoSize = true;
            remedioLabel.Location = new System.Drawing.Point(57, 101);
            remedioLabel.Name = "remedioLabel";
            remedioLabel.Size = new System.Drawing.Size(52, 13);
            remedioLabel.TabIndex = 6;
            remedioLabel.Text = "Remedio:";
            // 
            // remedioTextBox
            // 
            this.remedioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamentosBindingSource, "Remedio", true));
            this.remedioTextBox.Location = new System.Drawing.Point(126, 98);
            this.remedioTextBox.Name = "remedioTextBox";
            this.remedioTextBox.Size = new System.Drawing.Size(200, 20);
            this.remedioTextBox.TabIndex = 7;
            // 
            // doseLabel
            // 
            doseLabel.AutoSize = true;
            doseLabel.Location = new System.Drawing.Point(57, 127);
            doseLabel.Name = "doseLabel";
            doseLabel.Size = new System.Drawing.Size(35, 13);
            doseLabel.TabIndex = 8;
            doseLabel.Text = "Dose:";
            // 
            // doseTextBox
            // 
            this.doseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamentosBindingSource, "Dose", true));
            this.doseTextBox.Location = new System.Drawing.Point(126, 124);
            this.doseTextBox.Name = "doseTextBox";
            this.doseTextBox.Size = new System.Drawing.Size(200, 20);
            this.doseTextBox.TabIndex = 9;
            // 
            // frequenciaLabel
            // 
            frequenciaLabel.AutoSize = true;
            frequenciaLabel.Location = new System.Drawing.Point(57, 153);
            frequenciaLabel.Name = "frequenciaLabel";
            frequenciaLabel.Size = new System.Drawing.Size(63, 13);
            frequenciaLabel.TabIndex = 10;
            frequenciaLabel.Text = "Frequencia:";
            // 
            // frequenciaTextBox
            // 
            this.frequenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamentosBindingSource, "Frequencia", true));
            this.frequenciaTextBox.Location = new System.Drawing.Point(126, 150);
            this.frequenciaTextBox.Name = "frequenciaTextBox";
            this.frequenciaTextBox.Size = new System.Drawing.Size(200, 20);
            this.frequenciaTextBox.TabIndex = 11;
            // 
            // duracaoLabel
            // 
            duracaoLabel.AutoSize = true;
            duracaoLabel.Location = new System.Drawing.Point(57, 179);
            duracaoLabel.Name = "duracaoLabel";
            duracaoLabel.Size = new System.Drawing.Size(51, 13);
            duracaoLabel.TabIndex = 12;
            duracaoLabel.Text = "Duracao:";
            // 
            // duracaoTextBox
            // 
            this.duracaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamentosBindingSource, "Duracao", true));
            this.duracaoTextBox.Location = new System.Drawing.Point(126, 176);
            this.duracaoTextBox.Name = "duracaoTextBox";
            this.duracaoTextBox.Size = new System.Drawing.Size(200, 20);
            this.duracaoTextBox.TabIndex = 13;
            // 
            // data_InicioLabel
            // 
            data_InicioLabel.AutoSize = true;
            data_InicioLabel.Location = new System.Drawing.Point(57, 206);
            data_InicioLabel.Name = "data_InicioLabel";
            data_InicioLabel.Size = new System.Drawing.Size(61, 13);
            data_InicioLabel.TabIndex = 14;
            data_InicioLabel.Text = "Data Inicio:";
            // 
            // data_InicioDateTimePicker
            // 
            this.data_InicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tratamentosBindingSource, "Data_Inicio", true));
            this.data_InicioDateTimePicker.Location = new System.Drawing.Point(126, 202);
            this.data_InicioDateTimePicker.Name = "data_InicioDateTimePicker";
            this.data_InicioDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_InicioDateTimePicker.TabIndex = 15;
            // 
            // data_FimLabel
            // 
            data_FimLabel.AutoSize = true;
            data_FimLabel.Location = new System.Drawing.Point(57, 232);
            data_FimLabel.Name = "data_FimLabel";
            data_FimLabel.Size = new System.Drawing.Size(52, 13);
            data_FimLabel.TabIndex = 16;
            data_FimLabel.Text = "Data Fim:";
            // 
            // data_FimDateTimePicker
            // 
            this.data_FimDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tratamentosBindingSource, "Data_Fim", true));
            this.data_FimDateTimePicker.Location = new System.Drawing.Point(126, 228);
            this.data_FimDateTimePicker.Name = "data_FimDateTimePicker";
            this.data_FimDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_FimDateTimePicker.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.perfilBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
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
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 480);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(códigoLabel);
            this.Controls.Add(this.códigoLabel1);
            this.Controls.Add(iD_PetLabel);
            this.Controls.Add(this.iD_PetTextBox);
            this.Controls.Add(remedioLabel);
            this.Controls.Add(this.remedioTextBox);
            this.Controls.Add(doseLabel);
            this.Controls.Add(this.doseTextBox);
            this.Controls.Add(frequenciaLabel);
            this.Controls.Add(this.frequenciaTextBox);
            this.Controls.Add(duracaoLabel);
            this.Controls.Add(this.duracaoTextBox);
            this.Controls.Add(data_InicioLabel);
            this.Controls.Add(this.data_InicioDateTimePicker);
            this.Controls.Add(data_FimLabel);
            this.Controls.Add(this.data_FimDateTimePicker);
            this.Controls.Add(this.tratamentosDataGridView);
            this.Controls.Add(this.tratamentosBindingNavigator);
            this.Name = "Form5";
            this.Text = "Cadastrar Novo Tratamento";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_PetCareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamentosBindingNavigator)).EndInit();
            this.tratamentosBindingNavigator.ResumeLayout(false);
            this.tratamentosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tratamentosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_PetCareDataSet bD_PetCareDataSet;
        private System.Windows.Forms.BindingSource tratamentosBindingSource;
        private BD_PetCareDataSetTableAdapters.TratamentosTableAdapter tratamentosTableAdapter;
        private BD_PetCareDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tratamentosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tratamentosBindingNavigatorSaveItem;
        private BD_PetCareDataSetTableAdapters.PerfilTableAdapter perfilTableAdapter;
        private System.Windows.Forms.DataGridView tratamentosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label códigoLabel1;
        private System.Windows.Forms.TextBox iD_PetTextBox;
        private System.Windows.Forms.TextBox remedioTextBox;
        private System.Windows.Forms.TextBox doseTextBox;
        private System.Windows.Forms.TextBox frequenciaTextBox;
        private System.Windows.Forms.TextBox duracaoTextBox;
        private System.Windows.Forms.DateTimePicker data_InicioDateTimePicker;
        private System.Windows.Forms.DateTimePicker data_FimDateTimePicker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource perfilBindingSource;
    }
}