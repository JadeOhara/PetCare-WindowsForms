namespace PetCare
{
    partial class Form12
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
            System.Windows.Forms.Label iD_RacaLabel;
            System.Windows.Forms.Label nome_RacaLabel;
            System.Windows.Forms.Label iD_EspecieLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.bD_PetCareDataSet = new PetCare.BD_PetCareDataSet();
            this.racaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racaTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.RacaTableAdapter();
            this.tableAdapterManager = new PetCare.BD_PetCareDataSetTableAdapters.TableAdapterManager();
            this.especieTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.EspecieTableAdapter();
            this.racaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.racaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_RacaLabel1 = new System.Windows.Forms.Label();
            this.nome_RacaTextBox = new System.Windows.Forms.TextBox();
            this.iD_EspecieTextBox = new System.Windows.Forms.TextBox();
            this.racaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.especieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            iD_RacaLabel = new System.Windows.Forms.Label();
            nome_RacaLabel = new System.Windows.Forms.Label();
            iD_EspecieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PetCareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingNavigator)).BeginInit();
            this.racaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_RacaLabel
            // 
            iD_RacaLabel.AutoSize = true;
            iD_RacaLabel.Location = new System.Drawing.Point(39, 97);
            iD_RacaLabel.Name = "iD_RacaLabel";
            iD_RacaLabel.Size = new System.Drawing.Size(50, 13);
            iD_RacaLabel.TabIndex = 1;
            iD_RacaLabel.Text = "ID Raca:";
            // 
            // nome_RacaLabel
            // 
            nome_RacaLabel.AutoSize = true;
            nome_RacaLabel.Location = new System.Drawing.Point(39, 126);
            nome_RacaLabel.Name = "nome_RacaLabel";
            nome_RacaLabel.Size = new System.Drawing.Size(67, 13);
            nome_RacaLabel.TabIndex = 3;
            nome_RacaLabel.Text = "Nome Raca:";
            // 
            // iD_EspecieLabel
            // 
            iD_EspecieLabel.AutoSize = true;
            iD_EspecieLabel.Location = new System.Drawing.Point(39, 152);
            iD_EspecieLabel.Name = "iD_EspecieLabel";
            iD_EspecieLabel.Size = new System.Drawing.Size(48, 13);
            iD_EspecieLabel.TabIndex = 5;
            iD_EspecieLabel.Text = "Especie:";
            // 
            // bD_PetCareDataSet
            // 
            this.bD_PetCareDataSet.DataSetName = "BD_PetCareDataSet";
            this.bD_PetCareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // racaBindingSource
            // 
            this.racaBindingSource.DataMember = "Raca";
            this.racaBindingSource.DataSource = this.bD_PetCareDataSet;
            // 
            // racaTableAdapter
            // 
            this.racaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Banho_TosaTableAdapter = null;
            this.tableAdapterManager.ConsultasTableAdapter = null;
            this.tableAdapterManager.EspecieTableAdapter = this.especieTableAdapter;
            this.tableAdapterManager.Outros_RemédiosTableAdapter = null;
            this.tableAdapterManager.PerfilTableAdapter = null;
            this.tableAdapterManager.PesoTableAdapter = null;
            this.tableAdapterManager.RacaTableAdapter = this.racaTableAdapter;
            this.tableAdapterManager.SexoTableAdapter = null;
            this.tableAdapterManager.TratamentosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PetCare.BD_PetCareDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VacinacaoTableAdapter = null;
            this.tableAdapterManager.VermifugacaoTableAdapter = null;
            // 
            // especieTableAdapter
            // 
            this.especieTableAdapter.ClearBeforeFill = true;
            // 
            // racaBindingNavigator
            // 
            this.racaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.racaBindingNavigator.BindingSource = this.racaBindingSource;
            this.racaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.racaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.racaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.racaBindingNavigatorSaveItem});
            this.racaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.racaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.racaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.racaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.racaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.racaBindingNavigator.Name = "racaBindingNavigator";
            this.racaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.racaBindingNavigator.Size = new System.Drawing.Size(726, 25);
            this.racaBindingNavigator.TabIndex = 0;
            this.racaBindingNavigator.Text = "bindingNavigator1";
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
            // racaBindingNavigatorSaveItem
            // 
            this.racaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.racaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("racaBindingNavigatorSaveItem.Image")));
            this.racaBindingNavigatorSaveItem.Name = "racaBindingNavigatorSaveItem";
            this.racaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.racaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.racaBindingNavigatorSaveItem.Click += new System.EventHandler(this.racaBindingNavigatorSaveItem_Click);
            // 
            // iD_RacaLabel1
            // 
            this.iD_RacaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racaBindingSource, "ID_Raca", true));
            this.iD_RacaLabel1.Location = new System.Drawing.Point(112, 97);
            this.iD_RacaLabel1.Name = "iD_RacaLabel1";
            this.iD_RacaLabel1.Size = new System.Drawing.Size(204, 23);
            this.iD_RacaLabel1.TabIndex = 2;
            this.iD_RacaLabel1.Text = "label1";
            // 
            // nome_RacaTextBox
            // 
            this.nome_RacaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racaBindingSource, "Nome_Raca", true));
            this.nome_RacaTextBox.Location = new System.Drawing.Point(112, 123);
            this.nome_RacaTextBox.Name = "nome_RacaTextBox";
            this.nome_RacaTextBox.Size = new System.Drawing.Size(204, 20);
            this.nome_RacaTextBox.TabIndex = 4;
            // 
            // iD_EspecieTextBox
            // 
            this.iD_EspecieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racaBindingSource, "ID_Especie", true));
            this.iD_EspecieTextBox.Location = new System.Drawing.Point(112, 180);
            this.iD_EspecieTextBox.Name = "iD_EspecieTextBox";
            this.iD_EspecieTextBox.Size = new System.Drawing.Size(204, 20);
            this.iD_EspecieTextBox.TabIndex = 6;
            // 
            // racaDataGridView
            // 
            this.racaDataGridView.AutoGenerateColumns = false;
            this.racaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.racaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.racaDataGridView.DataSource = this.racaBindingSource;
            this.racaDataGridView.Location = new System.Drawing.Point(370, 32);
            this.racaDataGridView.Name = "racaDataGridView";
            this.racaDataGridView.Size = new System.Drawing.Size(344, 304);
            this.racaDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Raca";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Raca";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome_Raca";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome_Raca";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_Especie";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_Especie";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.especieBindingSource;
            this.comboBox1.DisplayMember = "Nome_Especie";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "ID_Especie";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // especieBindingSource
            // 
            this.especieBindingSource.DataMember = "Especie";
            this.especieBindingSource.DataSource = this.bD_PetCareDataSet;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 348);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.racaDataGridView);
            this.Controls.Add(iD_RacaLabel);
            this.Controls.Add(this.iD_RacaLabel1);
            this.Controls.Add(nome_RacaLabel);
            this.Controls.Add(this.nome_RacaTextBox);
            this.Controls.Add(iD_EspecieLabel);
            this.Controls.Add(this.iD_EspecieTextBox);
            this.Controls.Add(this.racaBindingNavigator);
            this.Name = "Form12";
            this.Text = "Cadastrar Raça";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_PetCareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingNavigator)).EndInit();
            this.racaBindingNavigator.ResumeLayout(false);
            this.racaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_PetCareDataSet bD_PetCareDataSet;
        private System.Windows.Forms.BindingSource racaBindingSource;
        private BD_PetCareDataSetTableAdapters.RacaTableAdapter racaTableAdapter;
        private BD_PetCareDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator racaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton racaBindingNavigatorSaveItem;
        private System.Windows.Forms.Label iD_RacaLabel1;
        private System.Windows.Forms.TextBox nome_RacaTextBox;
        private System.Windows.Forms.TextBox iD_EspecieTextBox;
        private System.Windows.Forms.DataGridView racaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private BD_PetCareDataSetTableAdapters.EspecieTableAdapter especieTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource especieBindingSource;
    }
}