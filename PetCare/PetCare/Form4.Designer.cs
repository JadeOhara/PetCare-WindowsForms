namespace PetCare
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.Label iD_PesoLabel;
            System.Windows.Forms.Label iD_PetLabel;
            System.Windows.Forms.Label data_PesagemLabel;
            System.Windows.Forms.Label pesoLabel;
            System.Windows.Forms.Label observacaoLabel;
            this.bD_PetCareDataSet = new PetCare.BD_PetCareDataSet();
            this.pesoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pesoTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.PesoTableAdapter();
            this.tableAdapterManager = new PetCare.BD_PetCareDataSetTableAdapters.TableAdapterManager();
            this.pesoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pesoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_PesoLabel1 = new System.Windows.Forms.Label();
            this.iD_PetTextBox = new System.Windows.Forms.TextBox();
            this.data_PesagemDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pesoTextBox = new System.Windows.Forms.TextBox();
            this.observacaoTextBox = new System.Windows.Forms.TextBox();
            this.pesoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perfilTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.PerfilTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            iD_PesoLabel = new System.Windows.Forms.Label();
            iD_PetLabel = new System.Windows.Forms.Label();
            data_PesagemLabel = new System.Windows.Forms.Label();
            pesoLabel = new System.Windows.Forms.Label();
            observacaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PetCareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoBindingNavigator)).BeginInit();
            this.pesoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bD_PetCareDataSet
            // 
            this.bD_PetCareDataSet.DataSetName = "BD_PetCareDataSet";
            this.bD_PetCareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Banho_TosaTableAdapter = null;
            this.tableAdapterManager.ConsultasTableAdapter = null;
            this.tableAdapterManager.EspecieTableAdapter = null;
            this.tableAdapterManager.Outros_RemédiosTableAdapter = null;
            this.tableAdapterManager.PerfilTableAdapter = this.perfilTableAdapter;
            this.tableAdapterManager.PesoTableAdapter = this.pesoTableAdapter;
            this.tableAdapterManager.RacaTableAdapter = null;
            this.tableAdapterManager.SexoTableAdapter = null;
            this.tableAdapterManager.TratamentosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PetCare.BD_PetCareDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VacinacaoTableAdapter = null;
            this.tableAdapterManager.VermifugacaoTableAdapter = null;
            // 
            // pesoBindingNavigator
            // 
            this.pesoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pesoBindingNavigator.BindingSource = this.pesoBindingSource;
            this.pesoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pesoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pesoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pesoBindingNavigatorSaveItem});
            this.pesoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pesoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pesoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pesoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pesoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pesoBindingNavigator.Name = "pesoBindingNavigator";
            this.pesoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pesoBindingNavigator.Size = new System.Drawing.Size(744, 25);
            this.pesoBindingNavigator.TabIndex = 0;
            this.pesoBindingNavigator.Text = "bindingNavigator1";
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
            // pesoBindingNavigatorSaveItem
            // 
            this.pesoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pesoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pesoBindingNavigatorSaveItem.Image")));
            this.pesoBindingNavigatorSaveItem.Name = "pesoBindingNavigatorSaveItem";
            this.pesoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.pesoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.pesoBindingNavigatorSaveItem.Click += new System.EventHandler(this.pesoBindingNavigatorSaveItem_Click);
            // 
            // iD_PesoLabel
            // 
            iD_PesoLabel.AutoSize = true;
            iD_PesoLabel.Location = new System.Drawing.Point(26, 38);
            iD_PesoLabel.Name = "iD_PesoLabel";
            iD_PesoLabel.Size = new System.Drawing.Size(48, 13);
            iD_PesoLabel.TabIndex = 1;
            iD_PesoLabel.Text = "ID Peso:";
            // 
            // iD_PesoLabel1
            // 
            this.iD_PesoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pesoBindingSource, "ID_Peso", true));
            this.iD_PesoLabel1.Location = new System.Drawing.Point(112, 38);
            this.iD_PesoLabel1.Name = "iD_PesoLabel1";
            this.iD_PesoLabel1.Size = new System.Drawing.Size(200, 23);
            this.iD_PesoLabel1.TabIndex = 2;
            this.iD_PesoLabel1.Text = "label1";
            // 
            // iD_PetLabel
            // 
            iD_PetLabel.AutoSize = true;
            iD_PetLabel.Location = new System.Drawing.Point(26, 67);
            iD_PetLabel.Name = "iD_PetLabel";
            iD_PetLabel.Size = new System.Drawing.Size(40, 13);
            iD_PetLabel.TabIndex = 3;
            iD_PetLabel.Text = "ID Pet:";
            // 
            // iD_PetTextBox
            // 
            this.iD_PetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pesoBindingSource, "ID_Pet", true));
            this.iD_PetTextBox.Location = new System.Drawing.Point(330, 59);
            this.iD_PetTextBox.Name = "iD_PetTextBox";
            this.iD_PetTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_PetTextBox.TabIndex = 4;
            // 
            // data_PesagemLabel
            // 
            data_PesagemLabel.AutoSize = true;
            data_PesagemLabel.Location = new System.Drawing.Point(26, 94);
            data_PesagemLabel.Name = "data_PesagemLabel";
            data_PesagemLabel.Size = new System.Drawing.Size(80, 13);
            data_PesagemLabel.TabIndex = 5;
            data_PesagemLabel.Text = "Data Pesagem:";
            // 
            // data_PesagemDateTimePicker
            // 
            this.data_PesagemDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pesoBindingSource, "Data_Pesagem", true));
            this.data_PesagemDateTimePicker.Location = new System.Drawing.Point(112, 90);
            this.data_PesagemDateTimePicker.Name = "data_PesagemDateTimePicker";
            this.data_PesagemDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_PesagemDateTimePicker.TabIndex = 6;
            // 
            // pesoLabel
            // 
            pesoLabel.AutoSize = true;
            pesoLabel.Location = new System.Drawing.Point(26, 119);
            pesoLabel.Name = "pesoLabel";
            pesoLabel.Size = new System.Drawing.Size(34, 13);
            pesoLabel.TabIndex = 7;
            pesoLabel.Text = "Peso:";
            // 
            // pesoTextBox
            // 
            this.pesoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pesoBindingSource, "Peso", true));
            this.pesoTextBox.Location = new System.Drawing.Point(112, 116);
            this.pesoTextBox.Name = "pesoTextBox";
            this.pesoTextBox.Size = new System.Drawing.Size(200, 20);
            this.pesoTextBox.TabIndex = 8;
            // 
            // observacaoLabel
            // 
            observacaoLabel.AutoSize = true;
            observacaoLabel.Location = new System.Drawing.Point(26, 145);
            observacaoLabel.Name = "observacaoLabel";
            observacaoLabel.Size = new System.Drawing.Size(68, 13);
            observacaoLabel.TabIndex = 9;
            observacaoLabel.Text = "Observacao:";
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pesoBindingSource, "Observacao", true));
            this.observacaoTextBox.Location = new System.Drawing.Point(112, 142);
            this.observacaoTextBox.Multiline = true;
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.Size = new System.Drawing.Size(200, 50);
            this.observacaoTextBox.TabIndex = 10;
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
            this.pesoDataGridView.Location = new System.Drawing.Point(12, 228);
            this.pesoDataGridView.Name = "pesoDataGridView";
            this.pesoDataGridView.Size = new System.Drawing.Size(720, 239);
            this.pesoDataGridView.TabIndex = 11;
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
            // comboBox1
            // 
            this.comboBox1.DataSource = this.perfilBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 12;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "kg";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 479);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pesoDataGridView);
            this.Controls.Add(iD_PesoLabel);
            this.Controls.Add(this.iD_PesoLabel1);
            this.Controls.Add(iD_PetLabel);
            this.Controls.Add(this.iD_PetTextBox);
            this.Controls.Add(data_PesagemLabel);
            this.Controls.Add(this.data_PesagemDateTimePicker);
            this.Controls.Add(pesoLabel);
            this.Controls.Add(this.pesoTextBox);
            this.Controls.Add(observacaoLabel);
            this.Controls.Add(this.observacaoTextBox);
            this.Controls.Add(this.pesoBindingNavigator);
            this.Name = "Form4";
            this.Text = "Cadastrar Nova Medição de Peso";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_PetCareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoBindingNavigator)).EndInit();
            this.pesoBindingNavigator.ResumeLayout(false);
            this.pesoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_PetCareDataSet bD_PetCareDataSet;
        private System.Windows.Forms.BindingSource pesoBindingSource;
        private BD_PetCareDataSetTableAdapters.PesoTableAdapter pesoTableAdapter;
        private BD_PetCareDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pesoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pesoBindingNavigatorSaveItem;
        private BD_PetCareDataSetTableAdapters.PerfilTableAdapter perfilTableAdapter;
        private System.Windows.Forms.Label iD_PesoLabel1;
        private System.Windows.Forms.TextBox iD_PetTextBox;
        private System.Windows.Forms.DateTimePicker data_PesagemDateTimePicker;
        private System.Windows.Forms.TextBox pesoTextBox;
        private System.Windows.Forms.TextBox observacaoTextBox;
        private System.Windows.Forms.DataGridView pesoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource perfilBindingSource;
        private System.Windows.Forms.Label label1;
    }
}