namespace PetCare
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            System.Windows.Forms.Label iD_VacinaLabel;
            System.Windows.Forms.Label iD_PetLabel;
            System.Windows.Forms.Label nome_VacinaLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label data_RepetirLabel;
            System.Windows.Forms.Label veterinarioLabel;
            System.Windows.Forms.Label telefoneLabel;
            this.bD_PetCareDataSet = new PetCare.BD_PetCareDataSet();
            this.vacinacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacinacaoTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.VacinacaoTableAdapter();
            this.tableAdapterManager = new PetCare.BD_PetCareDataSetTableAdapters.TableAdapterManager();
            this.vacinacaoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vacinacaoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_VacinaLabel1 = new System.Windows.Forms.Label();
            this.iD_PetTextBox = new System.Windows.Forms.TextBox();
            this.nome_VacinaTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_RepetirDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.veterinarioTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vacinacaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perfilTableAdapter = new PetCare.BD_PetCareDataSetTableAdapters.PerfilTableAdapter();
            iD_VacinaLabel = new System.Windows.Forms.Label();
            iD_PetLabel = new System.Windows.Forms.Label();
            nome_VacinaLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            data_RepetirLabel = new System.Windows.Forms.Label();
            veterinarioLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PetCareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacinacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacinacaoBindingNavigator)).BeginInit();
            this.vacinacaoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vacinacaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bD_PetCareDataSet
            // 
            this.bD_PetCareDataSet.DataSetName = "BD_PetCareDataSet";
            this.bD_PetCareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.VacinacaoTableAdapter = this.vacinacaoTableAdapter;
            this.tableAdapterManager.VermifugacaoTableAdapter = null;
            // 
            // vacinacaoBindingNavigator
            // 
            this.vacinacaoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vacinacaoBindingNavigator.BindingSource = this.vacinacaoBindingSource;
            this.vacinacaoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vacinacaoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vacinacaoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vacinacaoBindingNavigatorSaveItem});
            this.vacinacaoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vacinacaoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vacinacaoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vacinacaoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vacinacaoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vacinacaoBindingNavigator.Name = "vacinacaoBindingNavigator";
            this.vacinacaoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vacinacaoBindingNavigator.Size = new System.Drawing.Size(771, 25);
            this.vacinacaoBindingNavigator.TabIndex = 0;
            this.vacinacaoBindingNavigator.Text = "bindingNavigator1";
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
            // vacinacaoBindingNavigatorSaveItem
            // 
            this.vacinacaoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vacinacaoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vacinacaoBindingNavigatorSaveItem.Image")));
            this.vacinacaoBindingNavigatorSaveItem.Name = "vacinacaoBindingNavigatorSaveItem";
            this.vacinacaoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vacinacaoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.vacinacaoBindingNavigatorSaveItem.Click += new System.EventHandler(this.vacinacaoBindingNavigatorSaveItem_Click);
            // 
            // iD_VacinaLabel
            // 
            iD_VacinaLabel.AutoSize = true;
            iD_VacinaLabel.Location = new System.Drawing.Point(29, 45);
            iD_VacinaLabel.Name = "iD_VacinaLabel";
            iD_VacinaLabel.Size = new System.Drawing.Size(57, 13);
            iD_VacinaLabel.TabIndex = 1;
            iD_VacinaLabel.Text = "ID Vacina:";
            // 
            // iD_VacinaLabel1
            // 
            this.iD_VacinaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacinacaoBindingSource, "ID_Vacina", true));
            this.iD_VacinaLabel1.Location = new System.Drawing.Point(109, 45);
            this.iD_VacinaLabel1.Name = "iD_VacinaLabel1";
            this.iD_VacinaLabel1.Size = new System.Drawing.Size(200, 23);
            this.iD_VacinaLabel1.TabIndex = 2;
            this.iD_VacinaLabel1.Text = "label1";
            // 
            // iD_PetLabel
            // 
            iD_PetLabel.AutoSize = true;
            iD_PetLabel.Location = new System.Drawing.Point(29, 74);
            iD_PetLabel.Name = "iD_PetLabel";
            iD_PetLabel.Size = new System.Drawing.Size(40, 13);
            iD_PetLabel.TabIndex = 3;
            iD_PetLabel.Text = "ID Pet:";
            // 
            // iD_PetTextBox
            // 
            this.iD_PetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacinacaoBindingSource, "ID_Pet", true));
            this.iD_PetTextBox.Location = new System.Drawing.Point(325, 71);
            this.iD_PetTextBox.Name = "iD_PetTextBox";
            this.iD_PetTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_PetTextBox.TabIndex = 4;
            // 
            // nome_VacinaLabel
            // 
            nome_VacinaLabel.AutoSize = true;
            nome_VacinaLabel.Location = new System.Drawing.Point(29, 100);
            nome_VacinaLabel.Name = "nome_VacinaLabel";
            nome_VacinaLabel.Size = new System.Drawing.Size(74, 13);
            nome_VacinaLabel.TabIndex = 5;
            nome_VacinaLabel.Text = "Nome Vacina:";
            // 
            // nome_VacinaTextBox
            // 
            this.nome_VacinaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacinacaoBindingSource, "Nome_Vacina", true));
            this.nome_VacinaTextBox.Location = new System.Drawing.Point(109, 97);
            this.nome_VacinaTextBox.Name = "nome_VacinaTextBox";
            this.nome_VacinaTextBox.Size = new System.Drawing.Size(200, 20);
            this.nome_VacinaTextBox.TabIndex = 6;
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(29, 127);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 7;
            dataLabel.Text = "Data:";
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vacinacaoBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(109, 123);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 8;
            // 
            // data_RepetirLabel
            // 
            data_RepetirLabel.AutoSize = true;
            data_RepetirLabel.Location = new System.Drawing.Point(29, 153);
            data_RepetirLabel.Name = "data_RepetirLabel";
            data_RepetirLabel.Size = new System.Drawing.Size(70, 13);
            data_RepetirLabel.TabIndex = 9;
            data_RepetirLabel.Text = "Data Repetir:";
            // 
            // data_RepetirDateTimePicker
            // 
            this.data_RepetirDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vacinacaoBindingSource, "Data_Repetir", true));
            this.data_RepetirDateTimePicker.Location = new System.Drawing.Point(109, 149);
            this.data_RepetirDateTimePicker.Name = "data_RepetirDateTimePicker";
            this.data_RepetirDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_RepetirDateTimePicker.TabIndex = 10;
            // 
            // veterinarioLabel
            // 
            veterinarioLabel.AutoSize = true;
            veterinarioLabel.Location = new System.Drawing.Point(29, 178);
            veterinarioLabel.Name = "veterinarioLabel";
            veterinarioLabel.Size = new System.Drawing.Size(60, 13);
            veterinarioLabel.TabIndex = 11;
            veterinarioLabel.Text = "Veterinario:";
            // 
            // veterinarioTextBox
            // 
            this.veterinarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacinacaoBindingSource, "Veterinario", true));
            this.veterinarioTextBox.Location = new System.Drawing.Point(109, 175);
            this.veterinarioTextBox.Name = "veterinarioTextBox";
            this.veterinarioTextBox.Size = new System.Drawing.Size(200, 20);
            this.veterinarioTextBox.TabIndex = 12;
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(29, 204);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 13;
            telefoneLabel.Text = "Telefone:";
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacinacaoBindingSource, "Telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(109, 201);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefoneTextBox.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.perfilBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "ID_Pet";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // vacinacaoDataGridView
            // 
            this.vacinacaoDataGridView.AutoGenerateColumns = false;
            this.vacinacaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vacinacaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.vacinacaoDataGridView.DataSource = this.vacinacaoBindingSource;
            this.vacinacaoDataGridView.Location = new System.Drawing.Point(12, 240);
            this.vacinacaoDataGridView.Name = "vacinacaoDataGridView";
            this.vacinacaoDataGridView.Size = new System.Drawing.Size(746, 234);
            this.vacinacaoDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Vacina";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Vacina";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nome_Vacina";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome_Vacina";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Data_Repetir";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data_Repetir";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Veterinario";
            this.dataGridViewTextBoxColumn6.HeaderText = "Veterinario";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn7.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
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
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 488);
            this.Controls.Add(this.vacinacaoDataGridView);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(iD_VacinaLabel);
            this.Controls.Add(this.iD_VacinaLabel1);
            this.Controls.Add(iD_PetLabel);
            this.Controls.Add(this.iD_PetTextBox);
            this.Controls.Add(nome_VacinaLabel);
            this.Controls.Add(this.nome_VacinaTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(data_RepetirLabel);
            this.Controls.Add(this.data_RepetirDateTimePicker);
            this.Controls.Add(veterinarioLabel);
            this.Controls.Add(this.veterinarioTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(this.vacinacaoBindingNavigator);
            this.Name = "Form6";
            this.Text = "Cadastrar Nova Vacinação";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_PetCareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacinacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacinacaoBindingNavigator)).EndInit();
            this.vacinacaoBindingNavigator.ResumeLayout(false);
            this.vacinacaoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vacinacaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_PetCareDataSet bD_PetCareDataSet;
        private System.Windows.Forms.BindingSource vacinacaoBindingSource;
        private BD_PetCareDataSetTableAdapters.VacinacaoTableAdapter vacinacaoTableAdapter;
        private BD_PetCareDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vacinacaoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vacinacaoBindingNavigatorSaveItem;
        private BD_PetCareDataSetTableAdapters.PerfilTableAdapter perfilTableAdapter;
        private System.Windows.Forms.Label iD_VacinaLabel1;
        private System.Windows.Forms.TextBox iD_PetTextBox;
        private System.Windows.Forms.TextBox nome_VacinaTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.DateTimePicker data_RepetirDateTimePicker;
        private System.Windows.Forms.TextBox veterinarioTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView vacinacaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource perfilBindingSource;
    }
}