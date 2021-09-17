namespace PetCare
{
    partial class Form3
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
            System.Windows.Forms.Label iD_ConsultaLabel;
            System.Windows.Forms.Label iD_PetLabel;
            System.Windows.Forms.Label data_ConsultaLabel;
            System.Windows.Forms.Label retornoLabel;
            System.Windows.Forms.Label veterinarioLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label diagnosticoLabel;
            System.Windows.Forms.Label tratamentoLabel;
            System.Windows.Forms.Label resultadoLabel;
            System.Windows.Forms.Label observacaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.bD_PetCareDataSet = new PetCare.BD_PetCareDataSet();
            this.consultasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultasTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.ConsultasTableAdapter();
            this.tableAdapterManager = new PetCare.BD_PetCareDataSetTableAdapters.TableAdapterManager();
            this.perfilTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.PerfilTableAdapter();
            this.consultasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.consultasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_ConsultaLabel1 = new System.Windows.Forms.Label();
            this.iD_PetTextBox = new System.Windows.Forms.TextBox();
            this.data_ConsultaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.retornoCheckBox = new System.Windows.Forms.CheckBox();
            this.veterinarioTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.diagnosticoTextBox = new System.Windows.Forms.TextBox();
            this.tratamentoTextBox = new System.Windows.Forms.TextBox();
            this.resultadoTextBox = new System.Windows.Forms.TextBox();
            this.observacaoTextBox = new System.Windows.Forms.TextBox();
            this.consultasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            iD_ConsultaLabel = new System.Windows.Forms.Label();
            iD_PetLabel = new System.Windows.Forms.Label();
            data_ConsultaLabel = new System.Windows.Forms.Label();
            retornoLabel = new System.Windows.Forms.Label();
            veterinarioLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            diagnosticoLabel = new System.Windows.Forms.Label();
            tratamentoLabel = new System.Windows.Forms.Label();
            resultadoLabel = new System.Windows.Forms.Label();
            observacaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PetCareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingNavigator)).BeginInit();
            this.consultasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_ConsultaLabel
            // 
            iD_ConsultaLabel.AutoSize = true;
            iD_ConsultaLabel.Location = new System.Drawing.Point(59, 45);
            iD_ConsultaLabel.Name = "iD_ConsultaLabel";
            iD_ConsultaLabel.Size = new System.Drawing.Size(65, 13);
            iD_ConsultaLabel.TabIndex = 1;
            iD_ConsultaLabel.Text = "ID Consulta:";
            // 
            // iD_PetLabel
            // 
            iD_PetLabel.AutoSize = true;
            iD_PetLabel.Location = new System.Drawing.Point(59, 74);
            iD_PetLabel.Name = "iD_PetLabel";
            iD_PetLabel.Size = new System.Drawing.Size(40, 13);
            iD_PetLabel.TabIndex = 3;
            iD_PetLabel.Text = "ID Pet:";
            // 
            // data_ConsultaLabel
            // 
            data_ConsultaLabel.AutoSize = true;
            data_ConsultaLabel.Location = new System.Drawing.Point(59, 101);
            data_ConsultaLabel.Name = "data_ConsultaLabel";
            data_ConsultaLabel.Size = new System.Drawing.Size(77, 13);
            data_ConsultaLabel.TabIndex = 5;
            data_ConsultaLabel.Text = "Data Consulta:";
            // 
            // retornoLabel
            // 
            retornoLabel.AutoSize = true;
            retornoLabel.Location = new System.Drawing.Point(59, 128);
            retornoLabel.Name = "retornoLabel";
            retornoLabel.Size = new System.Drawing.Size(48, 13);
            retornoLabel.TabIndex = 7;
            retornoLabel.Text = "Retorno:";
            // 
            // veterinarioLabel
            // 
            veterinarioLabel.AutoSize = true;
            veterinarioLabel.Location = new System.Drawing.Point(59, 156);
            veterinarioLabel.Name = "veterinarioLabel";
            veterinarioLabel.Size = new System.Drawing.Size(60, 13);
            veterinarioLabel.TabIndex = 9;
            veterinarioLabel.Text = "Veterinario:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(417, 156);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 11;
            telefoneLabel.Text = "Telefone:";
            // 
            // diagnosticoLabel
            // 
            diagnosticoLabel.AutoSize = true;
            diagnosticoLabel.Location = new System.Drawing.Point(59, 182);
            diagnosticoLabel.Name = "diagnosticoLabel";
            diagnosticoLabel.Size = new System.Drawing.Size(66, 13);
            diagnosticoLabel.TabIndex = 13;
            diagnosticoLabel.Text = "Diagnostico:";
            diagnosticoLabel.Click += new System.EventHandler(this.diagnosticoLabel_Click);
            // 
            // tratamentoLabel
            // 
            tratamentoLabel.AutoSize = true;
            tratamentoLabel.Location = new System.Drawing.Point(59, 253);
            tratamentoLabel.Name = "tratamentoLabel";
            tratamentoLabel.Size = new System.Drawing.Size(64, 13);
            tratamentoLabel.TabIndex = 15;
            tratamentoLabel.Text = "Tratamento:";
            tratamentoLabel.Click += new System.EventHandler(this.tratamentoLabel_Click);
            // 
            // resultadoLabel
            // 
            resultadoLabel.AutoSize = true;
            resultadoLabel.Location = new System.Drawing.Point(417, 182);
            resultadoLabel.Name = "resultadoLabel";
            resultadoLabel.Size = new System.Drawing.Size(58, 13);
            resultadoLabel.TabIndex = 17;
            resultadoLabel.Text = "Resultado:";
            resultadoLabel.Click += new System.EventHandler(this.resultadoLabel_Click);
            // 
            // observacaoLabel
            // 
            observacaoLabel.AutoSize = true;
            observacaoLabel.Location = new System.Drawing.Point(417, 253);
            observacaoLabel.Name = "observacaoLabel";
            observacaoLabel.Size = new System.Drawing.Size(68, 13);
            observacaoLabel.TabIndex = 19;
            observacaoLabel.Text = "Observacao:";
            observacaoLabel.Click += new System.EventHandler(this.observacaoLabel_Click);
            // 
            // bD_PetCareDataSet
            // 
            this.bD_PetCareDataSet.DataSetName = "BD_PetCareDataSet";
            this.bD_PetCareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultasBindingSource
            // 
            this.consultasBindingSource.DataMember = "Consultas";
            this.consultasBindingSource.DataSource = this.bD_PetCareDataSet;
            // 
            // consultasTableAdapter
            // 
            this.consultasTableAdapter.ClearBeforeFill = true;
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
            // perfilTableAdapter
            // 
            this.perfilTableAdapter.ClearBeforeFill = true;
            // 
            // consultasBindingNavigator
            // 
            this.consultasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.consultasBindingNavigator.BindingSource = this.consultasBindingSource;
            this.consultasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.consultasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.consultasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.consultasBindingNavigatorSaveItem});
            this.consultasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.consultasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.consultasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.consultasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.consultasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.consultasBindingNavigator.Name = "consultasBindingNavigator";
            this.consultasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.consultasBindingNavigator.Size = new System.Drawing.Size(895, 25);
            this.consultasBindingNavigator.TabIndex = 0;
            this.consultasBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
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
            // consultasBindingNavigatorSaveItem
            // 
            this.consultasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.consultasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("consultasBindingNavigatorSaveItem.Image")));
            this.consultasBindingNavigatorSaveItem.Name = "consultasBindingNavigatorSaveItem";
            this.consultasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.consultasBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.consultasBindingNavigatorSaveItem.Click += new System.EventHandler(this.consultasBindingNavigatorSaveItem_Click);
            // 
            // iD_ConsultaLabel1
            // 
            this.iD_ConsultaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "ID_Consulta", true));
            this.iD_ConsultaLabel1.Location = new System.Drawing.Point(142, 45);
            this.iD_ConsultaLabel1.Name = "iD_ConsultaLabel1";
            this.iD_ConsultaLabel1.Size = new System.Drawing.Size(249, 23);
            this.iD_ConsultaLabel1.TabIndex = 2;
            this.iD_ConsultaLabel1.Text = "label1";
            // 
            // iD_PetTextBox
            // 
            this.iD_PetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "ID_Pet", true));
            this.iD_PetTextBox.Location = new System.Drawing.Point(410, 65);
            this.iD_PetTextBox.Name = "iD_PetTextBox";
            this.iD_PetTextBox.Size = new System.Drawing.Size(249, 20);
            this.iD_PetTextBox.TabIndex = 4;
            // 
            // data_ConsultaDateTimePicker
            // 
            this.data_ConsultaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultasBindingSource, "Data_Consulta", true));
            this.data_ConsultaDateTimePicker.Location = new System.Drawing.Point(142, 97);
            this.data_ConsultaDateTimePicker.Name = "data_ConsultaDateTimePicker";
            this.data_ConsultaDateTimePicker.Size = new System.Drawing.Size(249, 20);
            this.data_ConsultaDateTimePicker.TabIndex = 6;
            // 
            // retornoCheckBox
            // 
            this.retornoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.consultasBindingSource, "Retorno", true));
            this.retornoCheckBox.Location = new System.Drawing.Point(142, 123);
            this.retornoCheckBox.Name = "retornoCheckBox";
            this.retornoCheckBox.Size = new System.Drawing.Size(249, 24);
            this.retornoCheckBox.TabIndex = 8;
            this.retornoCheckBox.Text = "checkBox1";
            this.retornoCheckBox.UseVisualStyleBackColor = true;
            // 
            // veterinarioTextBox
            // 
            this.veterinarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "Veterinario", true));
            this.veterinarioTextBox.Location = new System.Drawing.Point(142, 153);
            this.veterinarioTextBox.Name = "veterinarioTextBox";
            this.veterinarioTextBox.Size = new System.Drawing.Size(249, 20);
            this.veterinarioTextBox.TabIndex = 10;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "Telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(500, 153);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(249, 20);
            this.telefoneTextBox.TabIndex = 12;
            // 
            // diagnosticoTextBox
            // 
            this.diagnosticoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "Diagnostico", true));
            this.diagnosticoTextBox.Location = new System.Drawing.Point(142, 179);
            this.diagnosticoTextBox.Multiline = true;
            this.diagnosticoTextBox.Name = "diagnosticoTextBox";
            this.diagnosticoTextBox.Size = new System.Drawing.Size(249, 65);
            this.diagnosticoTextBox.TabIndex = 14;
            this.diagnosticoTextBox.TextChanged += new System.EventHandler(this.diagnosticoTextBox_TextChanged);
            // 
            // tratamentoTextBox
            // 
            this.tratamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "Tratamento", true));
            this.tratamentoTextBox.Location = new System.Drawing.Point(142, 250);
            this.tratamentoTextBox.Multiline = true;
            this.tratamentoTextBox.Name = "tratamentoTextBox";
            this.tratamentoTextBox.Size = new System.Drawing.Size(249, 66);
            this.tratamentoTextBox.TabIndex = 16;
            this.tratamentoTextBox.TextChanged += new System.EventHandler(this.tratamentoTextBox_TextChanged);
            // 
            // resultadoTextBox
            // 
            this.resultadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "Resultado", true));
            this.resultadoTextBox.Location = new System.Drawing.Point(500, 179);
            this.resultadoTextBox.Multiline = true;
            this.resultadoTextBox.Name = "resultadoTextBox";
            this.resultadoTextBox.Size = new System.Drawing.Size(249, 65);
            this.resultadoTextBox.TabIndex = 18;
            this.resultadoTextBox.TextChanged += new System.EventHandler(this.resultadoTextBox_TextChanged);
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "Observacao", true));
            this.observacaoTextBox.Location = new System.Drawing.Point(500, 250);
            this.observacaoTextBox.Multiline = true;
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.Size = new System.Drawing.Size(249, 66);
            this.observacaoTextBox.TabIndex = 20;
            this.observacaoTextBox.TextChanged += new System.EventHandler(this.observacaoTextBox_TextChanged);
            // 
            // consultasDataGridView
            // 
            this.consultasDataGridView.AutoGenerateColumns = false;
            this.consultasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.consultasDataGridView.DataSource = this.consultasBindingSource;
            this.consultasDataGridView.Location = new System.Drawing.Point(11, 337);
            this.consultasDataGridView.Name = "consultasDataGridView";
            this.consultasDataGridView.Size = new System.Drawing.Size(871, 252);
            this.consultasDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Consulta";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Consulta";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Data_Consulta";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data_Consulta";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Retorno";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Retorno";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Veterinario";
            this.dataGridViewTextBoxColumn4.HeaderText = "Veterinario";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Diagnostico";
            this.dataGridViewTextBoxColumn6.HeaderText = "Diagnostico";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Tratamento";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tratamento";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Resultado";
            this.dataGridViewTextBoxColumn8.HeaderText = "Resultado";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Observacao";
            this.dataGridViewTextBoxColumn9.HeaderText = "Observacao";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.perfilBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(145, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(246, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.ValueMember = "ID_Pet";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // perfilBindingSource
            // 
            this.perfilBindingSource.DataMember = "Perfil";
            this.perfilBindingSource.DataSource = this.bD_PetCareDataSet;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 619);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.consultasDataGridView);
            this.Controls.Add(iD_ConsultaLabel);
            this.Controls.Add(this.iD_ConsultaLabel1);
            this.Controls.Add(iD_PetLabel);
            this.Controls.Add(this.iD_PetTextBox);
            this.Controls.Add(data_ConsultaLabel);
            this.Controls.Add(this.data_ConsultaDateTimePicker);
            this.Controls.Add(retornoLabel);
            this.Controls.Add(this.retornoCheckBox);
            this.Controls.Add(veterinarioLabel);
            this.Controls.Add(this.veterinarioTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(diagnosticoLabel);
            this.Controls.Add(this.diagnosticoTextBox);
            this.Controls.Add(tratamentoLabel);
            this.Controls.Add(this.tratamentoTextBox);
            this.Controls.Add(resultadoLabel);
            this.Controls.Add(this.resultadoTextBox);
            this.Controls.Add(observacaoLabel);
            this.Controls.Add(this.observacaoTextBox);
            this.Controls.Add(this.consultasBindingNavigator);
            this.Name = "Form3";
            this.Text = "Cadastrar Nova Consulta";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_PetCareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingNavigator)).EndInit();
            this.consultasBindingNavigator.ResumeLayout(false);
            this.consultasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_PetCareDataSet bD_PetCareDataSet;
        private System.Windows.Forms.BindingSource consultasBindingSource;
        private BD_PetCareDataSetTableAdapters.ConsultasTableAdapter consultasTableAdapter;
        private BD_PetCareDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator consultasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton consultasBindingNavigatorSaveItem;
        private BD_PetCareDataSetTableAdapters.PerfilTableAdapter perfilTableAdapter;
        private System.Windows.Forms.Label iD_ConsultaLabel1;
        private System.Windows.Forms.TextBox iD_PetTextBox;
        private System.Windows.Forms.DateTimePicker data_ConsultaDateTimePicker;
        private System.Windows.Forms.CheckBox retornoCheckBox;
        private System.Windows.Forms.TextBox veterinarioTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox diagnosticoTextBox;
        private System.Windows.Forms.TextBox tratamentoTextBox;
        private System.Windows.Forms.TextBox resultadoTextBox;
        private System.Windows.Forms.TextBox observacaoTextBox;
        private System.Windows.Forms.DataGridView consultasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource perfilBindingSource;
    }
}