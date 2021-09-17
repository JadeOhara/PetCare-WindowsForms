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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void vermifugacaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            int p = vermifugacaoBindingSource.Position;
            this.Validate();
            this.vermifugacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_PetCareDataSet);
            this.vermifugacaoTableAdapter.Fill(this.bD_PetCareDataSet.Vermifugacao);
            vermifugacaoBindingSource.Position = p;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Perfil'. Você pode movê-la ou removê-la conforme necessário.
            this.perfilTableAdapter.Fill(this.bD_PetCareDataSet.Perfil);
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Vermifugacao'. Você pode movê-la ou removê-la conforme necessário.
            this.vermifugacaoTableAdapter.Fill(this.bD_PetCareDataSet.Vermifugacao);

        }

        private void vermifugacaoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
