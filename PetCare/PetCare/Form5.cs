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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void tratamentosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            int p = tratamentosBindingSource.Position;
            this.Validate();
            this.tratamentosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_PetCareDataSet);
            this.tratamentosTableAdapter.Fill(this.bD_PetCareDataSet.Tratamentos);
            tratamentosBindingSource.Position = p;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Perfil'. Você pode movê-la ou removê-la conforme necessário.
            this.perfilTableAdapter.Fill(this.bD_PetCareDataSet.Perfil);
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Tratamentos'. Você pode movê-la ou removê-la conforme necessário.
            this.tratamentosTableAdapter.Fill(this.bD_PetCareDataSet.Tratamentos);

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
