namespace PetCare
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            System.Windows.Forms.Label iD_VermifugoLabel;
            System.Windows.Forms.Label iD_PetLabel;
            System.Windows.Forms.Label data_VermifugacaoLabel;
            System.Windows.Forms.Label vermifugoLabel;
            System.Windows.Forms.Label doseLabel;
            System.Windows.Forms.Label data_ReforcoLabel;
            this.bD_PetCareDataSet = new PetCare.BD_PetCareDataSet();
            this.vermifugacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vermifugacaoTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.VermifugacaoTableAdapter();
            this.tableAdapterManager = new PetCare.BD_PetCareDataSetTableAdapters.TableAdapterManager();
            this.vermifugacaoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vermifugacaoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_VermifugoLabel1 = new System.Windows.Forms.Label();
            this.iD_PetTextBox = new System.Windows.Forms.TextBox();
            this.data_VermifugacaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vermifugoTextBox = new System.Windows.Forms.TextBox();
            this.doseTextBox = new System.Windows.Forms.TextBox();
            this.data_ReforcoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vermifugacaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perfilTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.PerfilTableAdapter();
            iD_VermifugoLabel = new System.Windows.Forms.Label();
            iD_PetLabel = new System.Windows.Forms.Label();
            data_VermifugacaoLabel = new System.Windows.Forms.Label();
            vermifugoLabel = new System.Windows.Forms.Label();
            doseLabel = new System.Windows.Forms.Label();
            data_ReforcoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PetCareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vermifugacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vermifugacaoBindingNavigator)).BeginInit();
            this.vermifugacaoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vermifugacaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bD_PetCareDataSet
            // 
            this.bD_PetCareDataSet.DataSetName = "BD_PetCareDataSet";
            this.bD_PetCareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.TratamentosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PetCare.BD_PetCareDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VacinacaoTableAdapter = null;
            this.tableAdapterManager.VermifugacaoTableAdapter = this.vermifugacaoTableAdapter;
            // 
            // vermifugacaoBindingNavigator
            // 
            this.vermifugacaoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vermifugacaoBindingNavigator.BindingSource = this.vermifugacaoBindingSource;
            this.vermifugacaoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vermifugacaoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vermifugacaoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vermifugacaoBindingNavigatorSaveItem});
            this.vermifugacaoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vermifugacaoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vermifugacaoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vermifugacaoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vermifugacaoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vermifugacaoBindingNavigator.Name = "vermifugacaoBindingNavigator";
            this.vermifugacaoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vermifugacaoBindingNavigator.Size = new System.Drawing.Size(670, 25);
            this.vermifugacaoBindingNavigator.TabIndex = 0;
            this.vermifugacaoBindingNavigator.Text = "bindingNavigator1";
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
            // vermifugacaoBindingNavigatorSaveItem
            // 
            this.vermifugacaoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vermifugacaoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vermifugacaoBindingNavigatorSaveItem.Image")));
            this.vermifugacaoBindingNavigatorSaveItem.Name = "vermifugacaoBindingNavigatorSaveItem";
            this.vermifugacaoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.vermifugacaoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.vermifugacaoBindingNavigatorSaveItem.Click += new System.EventHandler(this.vermifugacaoBindingNavigatorSaveItem_Click);
            // 
            // iD_VermifugoLabel
            // 
            iD_VermifugoLabel.AutoSize = true;
            iD_VermifugoLabel.Location = new System.Drawing.Point(23, 63);
            iD_VermifugoLabel.Name = "iD_VermifugoLabel";
            iD_VermifugoLabel.Size = new System.Drawing.Size(71, 13);
            iD_VermifugoLabel.TabIndex = 1;
            iD_VermifugoLabel.Text = "ID Vermifugo:";
            // 
            // iD_VermifugoLabel1
            // 
            this.iD_VermifugoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vermifugacaoBindingSource, "ID_Vermifugo", true));
            this.iD_VermifugoLabel1.Location = new System.Drawing.Point(130, 63);
            this.iD_VermifugoLabel1.Name = "iD_VermifugoLabel1";
            this.iD_VermifugoLabel1.Size = new System.Drawing.Size(229, 23);
            this.iD_VermifugoLabel1.TabIndex = 2;
            this.iD_VermifugoLabel1.Text = "label1";
            // 
            // iD_PetLabel
            // 
            iD_PetLabel.AutoSize = true;
            iD_PetLabel.Location = new System.Drawing.Point(23, 92);
            iD_PetLabel.Name = "iD_PetLabel";
            iD_PetLabel.Size = new System.Drawing.Size(40, 13);
            iD_PetLabel.TabIndex = 3;
            iD_PetLabel.Text = "ID Pet:";
            // 
            // iD_PetTextBox
            // 
            this.iD_PetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vermifugacaoBindingSource, "ID_Pet", true));
            this.iD_PetTextBox.Location = new System.Drawing.Point(378, 89);
            this.iD_PetTextBox.Name = "iD_PetTextBox";
            this.iD_PetTextBox.Size = new System.Drawing.Size(229, 20);
            this.iD_PetTextBox.TabIndex = 4;
            // 
            // data_VermifugacaoLabel
            // 
            data_VermifugacaoLabel.AutoSize = true;
            data_VermifugacaoLabel.Location = new System.Drawing.Point(23, 119);
            data_VermifugacaoLabel.Name = "data_VermifugacaoLabel";
            data_VermifugacaoLabel.Size = new System.Drawing.Size(101, 13);
            data_VermifugacaoLabel.TabIndex = 5;
            data_VermifugacaoLabel.Text = "Data Vermifugacao:";
            // 
            // data_VermifugacaoDateTimePicker
            // 
            this.data_VermifugacaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vermifugacaoBindingSource, "Data_Vermifugacao", true));
            this.data_VermifugacaoDateTimePicker.Location = new System.Drawing.Point(130, 115);
            this.data_VermifugacaoDateTimePicker.Name = "data_VermifugacaoDateTimePicker";
            this.data_VermifugacaoDateTimePicker.Size = new System.Drawing.Size(229, 20);
            this.data_VermifugacaoDateTimePicker.TabIndex = 6;
            // 
            // vermifugoLabel
            // 
            vermifugoLabel.AutoSize = true;
            vermifugoLabel.Location = new System.Drawing.Point(23, 144);
            vermifugoLabel.Name = "vermifugoLabel";
            vermifugoLabel.Size = new System.Drawing.Size(57, 13);
            vermifugoLabel.TabIndex = 7;
            vermifugoLabel.Text = "Vermifugo:";
            // 
            // vermifugoTextBox
            // 
            this.vermifugoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vermifugacaoBindingSource, "Vermifugo", true));
            this.vermifugoTextBox.Location = new System.Drawing.Point(130, 141);
            this.vermifugoTextBox.Name = "vermifugoTextBox";
            this.vermifugoTextBox.Size = new System.Drawing.Size(229, 20);
            this.vermifugoTextBox.TabIndex = 8;
            // 
            // doseLabel
            // 
            doseLabel.AutoSize = true;
            doseLabel.Location = new System.Drawing.Point(23, 170);
            doseLabel.Name = "doseLabel";
            doseLabel.Size = new System.Drawing.Size(35, 13);
            doseLabel.TabIndex = 9;
            doseLabel.Text = "Dose:";
            // 
            // doseTextBox
            // 
            this.doseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vermifugacaoBindingSource, "Dose", true));
            this.doseTextBox.Location = new System.Drawing.Point(130, 167);
            this.doseTextBox.Name = "doseTextBox";
            this.doseTextBox.Size = new System.Drawing.Size(229, 20);
            this.doseTextBox.TabIndex = 10;
            // 
            // data_ReforcoLabel
            // 
            data_ReforcoLabel.AutoSize = true;
            data_ReforcoLabel.Location = new System.Drawing.Point(23, 197);
            data_ReforcoLabel.Name = "data_ReforcoLabel";
            data_ReforcoLabel.Size = new System.Drawing.Size(74, 13);
            data_ReforcoLabel.TabIndex = 11;
            data_ReforcoLabel.Text = "Data Reforco:";
            // 
            // data_ReforcoDateTimePicker
            // 
            this.data_ReforcoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vermifugacaoBindingSource, "Data_Reforco", true));
            this.data_ReforcoDateTimePicker.Location = new System.Drawing.Point(130, 193);
            this.data_ReforcoDateTimePicker.Name = "data_ReforcoDateTimePicker";
            this.data_ReforcoDateTimePicker.Size = new System.Drawing.Size(229, 20);
            this.data_ReforcoDateTimePicker.TabIndex = 12;
            // 
            // vermifugacaoDataGridView
            // 
            this.vermifugacaoDataGridView.AutoGenerateColumns = false;
            this.vermifugacaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vermifugacaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.vermifugacaoDataGridView.DataSource = this.vermifugacaoBindingSource;
            this.vermifugacaoDataGridView.Location = new System.Drawing.Point(12, 228);
            this.vermifugacaoDataGridView.Name = "vermifugacaoDataGridView";
            this.vermifugacaoDataGridView.Size = new System.Drawing.Size(644, 245);
            this.vermifugacaoDataGridView.TabIndex = 13;
            this.vermifugacaoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vermifugacaoDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Vermifugo";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Vermifugo";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Data_Vermifugacao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data_Vermifugacao";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Vermifugo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Vermifugo";
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
            // comboBox1
            // 
            this.comboBox1.DataSource = this.perfilBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(130, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 21);
            this.comboBox1.TabIndex = 14;
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
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 485);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.vermifugacaoDataGridView);
            this.Controls.Add(iD_VermifugoLabel);
            this.Controls.Add(this.iD_VermifugoLabel1);
            this.Controls.Add(iD_PetLabel);
            this.Controls.Add(this.iD_PetTextBox);
            this.Controls.Add(data_VermifugacaoLabel);
            this.Controls.Add(this.data_VermifugacaoDateTimePicker);
            this.Controls.Add(vermifugoLabel);
            this.Controls.Add(this.vermifugoTextBox);
            this.Controls.Add(doseLabel);
            this.Controls.Add(this.doseTextBox);
            this.Controls.Add(data_ReforcoLabel);
            this.Controls.Add(this.data_ReforcoDateTimePicker);
            this.Controls.Add(this.vermifugacaoBindingNavigator);
            this.Name = "Form7";
            this.Text = "Cadastrar Nova Vermifugação";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_PetCareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vermifugacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vermifugacaoBindingNavigator)).EndInit();
            this.vermifugacaoBindingNavigator.ResumeLayout(false);
            this.vermifugacaoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vermifugacaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_PetCareDataSet bD_PetCareDataSet;
        private System.Windows.Forms.BindingSource vermifugacaoBindingSource;
        private BD_PetCareDataSetTableAdapters.VermifugacaoTableAdapter vermifugacaoTableAdapter;
        private BD_PetCareDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vermifugacaoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vermifugacaoBindingNavigatorSaveItem;
        private BD_PetCareDataSetTableAdapters.PerfilTableAdapter perfilTableAdapter;
        private System.Windows.Forms.Label iD_VermifugoLabel1;
        private System.Windows.Forms.TextBox iD_PetTextBox;
        private System.Windows.Forms.DateTimePicker data_VermifugacaoDateTimePicker;
        private System.Windows.Forms.TextBox vermifugoTextBox;
        private System.Windows.Forms.TextBox doseTextBox;
        private System.Windows.Forms.DateTimePicker data_ReforcoDateTimePicker;
        private System.Windows.Forms.DataGridView vermifugacaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource perfilBindingSource;
    }
}