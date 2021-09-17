using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetCare
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void vacinacaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            int p = vacinacaoBindingSource.Position;
            this.Validate();
            this.vacinacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_PetCareDataSet);
            this.vacinacaoTableAdapter.Fill(this.bD_PetCareDataSet.Vacinacao);
            vacinacaoBindingSource.Position = p;
        }

        private void vacinacaoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.vacinacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_PetCareDataSet);

        }

        private void vacinacaoBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.vacinacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_PetCareDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Perfil'. Você pode movê-la ou removê-la conforme necessário.
            this.perfilTableAdapter.Fill(this.bD_PetCareDataSet.Perfil);
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Vacinacao'. Você pode movê-la ou removê-la conforme necessário.
            this.vacinacaoTableAdapter.Fill(this.bD_PetCareDataSet.Vacinacao);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                iD_PetTextBox.Text = comboBox1.SelectedValue.ToString();
            }
        }
    }
}
