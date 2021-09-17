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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void racaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            int p = racaBindingSource.Position;
            this.Validate();
            this.racaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_PetCareDataSet);
            this.racaTableAdapter.Fill(this.bD_PetCareDataSet.Raca);
            racaBindingSource.Position = p;

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Especie'. Você pode movê-la ou removê-la conforme necessário.
            this.especieTableAdapter.Fill(this.bD_PetCareDataSet.Especie);
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Raca'. Você pode movê-la ou removê-la conforme necessário.
            this.racaTableAdapter.Fill(this.bD_PetCareDataSet.Raca);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {    
                iD_EspecieTextBox.Text = comboBox1.SelectedValue.ToString();
            }
        }
    }
}
