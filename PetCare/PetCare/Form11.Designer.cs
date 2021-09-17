namespace PetCare
{
    partial class Form11
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
            System.Windows.Forms.Label iD_EspecieLabel;
            System.Windows.Forms.Label nome_EspecieLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.bD_PetCareDataSet = new PetCare.BD_PetCareDataSet();
            this.especieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.especieTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.EspecieTableAdapter();
            this.tableAdapterManager = new PetCare.BD_PetCareDataSetTableAdapters.TableAdapterManager();
            this.especieBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.especieBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_EspecieLabel1 = new System.Windows.Forms.Label();
            this.nome_EspecieTextBox = new System.Windows.Forms.TextBox();
            this.especieDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_EspecieLabel = new System.Windows.Forms.Label();
            nome_EspecieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PetCareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBindingNavigator)).BeginInit();
            this.especieBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especieDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_EspecieLabel
            // 
            iD_EspecieLabel.AutoSize = true;
            iD_EspecieLabel.Location = new System.Drawing.Point(42, 102);
            iD_EspecieLabel.Name = "iD_EspecieLabel";
            iD_EspecieLabel.Size = new System.Drawing.Size(62, 13);
            iD_EspecieLabel.TabIndex = 1;
            iD_EspecieLabel.Text = "ID Especie:";
            // 
            // nome_EspecieLabel
            // 
            nome_EspecieLabel.AutoSize = true;
            nome_EspecieLabel.Location = new System.Drawing.Point(42, 131);
            nome_EspecieLabel.Name = "nome_EspecieLabel";
            nome_EspecieLabel.Size = new System.Drawing.Size(79, 13);
            nome_EspecieLabel.TabIndex = 3;
            nome_EspecieLabel.Text = "Nome Especie:";
            // 
            // bD_PetCareDataSet
            // 
            this.bD_PetCareDataSet.DataSetName = "BD_PetCareDataSet";
            this.bD_PetCareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // especieBindingSource
            // 
            this.especieBindingSource.DataMember = "Especie";
            this.especieBindingSource.DataSource = this.bD_PetCareDataSet;
            // 
            // especieTableAdapter
            // 
            this.especieTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.RacaTableAdapter = null;
            this.tableAdapterManager.SexoTableAdapter = null;
            this.tableAdapterManager.TratamentosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PetCare.BD_PetCareDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VacinacaoTableAdapter = null;
            this.tableAdapterManager.VermifugacaoTableAdapter = null;
            // 
            // especieBindingNavigator
            // 
            this.especieBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.especieBindingNavigator.BindingSource = this.especieBindingSource;
            this.especieBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.especieBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.especieBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.especieBindingNavigatorSaveItem});
            this.especieBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.especieBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.especieBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.especieBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.especieBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.especieBindingNavigator.Name = "especieBindingNavigator";
            this.especieBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.especieBindingNavigator.Size = new System.Drawing.Size(663, 25);
            this.especieBindingNavigator.TabIndex = 0;
            this.especieBindingNavigator.Text = "bindingNavigator1";
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
            // especieBindingNavigatorSaveItem
            // 
            this.especieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.especieBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("especieBindingNavigatorSaveItem.Image")));
            this.especieBindingNavigatorSaveItem.Name = "especieBindingNavigatorSaveItem";
            this.especieBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.especieBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.especieBindingNavigatorSaveItem.Click += new System.EventHandler(this.especieBindingNavigatorSaveItem_Click);
            // 
            // iD_EspecieLabel1
            // 
            this.iD_EspecieLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.especieBindingSource, "ID_Especie", true));
            this.iD_EspecieLabel1.Location = new System.Drawing.Point(127, 102);
            this.iD_EspecieLabel1.Name = "iD_EspecieLabel1";
            this.iD_EspecieLabel1.Size = new System.Drawing.Size(211, 23);
            this.iD_EspecieLabel1.TabIndex = 2;
            this.iD_EspecieLabel1.Text = "label1";
            // 
            // nome_EspecieTextBox
            // 
            this.nome_EspecieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.especieBindingSource, "Nome_Especie", true));
            this.nome_EspecieTextBox.Location = new System.Drawing.Point(127, 128);
            this.nome_EspecieTextBox.Name = "nome_EspecieTextBox";
            this.nome_EspecieTextBox.Size = new System.Drawing.Size(211, 20);
            this.nome_EspecieTextBox.TabIndex = 4;
            // 
            // especieDataGridView
            // 
            this.especieDataGridView.AutoGenerateColumns = false;
            this.especieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.especieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.especieDataGridView.DataSource = this.especieBindingSource;
            this.especieDataGridView.Location = new System.Drawing.Point(404, 28);
            this.especieDataGridView.Name = "especieDataGridView";
            this.especieDataGridView.Size = new System.Drawing.Size(245, 269);
            this.especieDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Especie";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Especie";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome_Especie";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome_Especie";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 311);
            this.Controls.Add(this.especieDataGridView);
            this.Controls.Add(iD_EspecieLabel);
            this.Controls.Add(this.iD_EspecieLabel1);
            this.Controls.Add(nome_EspecieLabel);
            this.Controls.Add(this.nome_EspecieTextBox);
            this.Controls.Add(this.especieBindingNavigator);
            this.Name = "Form11";
            this.Text = "Cadastrar Espécie";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_PetCareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBindingNavigator)).EndInit();
            this.especieBindingNavigator.ResumeLayout(false);
            this.especieBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especieDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_PetCareDataSet bD_PetCareDataSet;
        private System.Windows.Forms.BindingSource especieBindingSource;
        private BD_PetCareDataSetTableAdapters.EspecieTableAdapter especieTableAdapter;
        private BD_PetCareDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator especieBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton especieBindingNavigatorSaveItem;
        private System.Windows.Forms.Label iD_EspecieLabel1;
        private System.Windows.Forms.TextBox nome_EspecieTextBox;
        private System.Windows.Forms.DataGridView especieDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}