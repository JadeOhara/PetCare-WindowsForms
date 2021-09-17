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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void banho_TosaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            int p = banho_TosaBindingSource.Position;
            this.Validate();
            this.banho_TosaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_PetCareDataSet);
            this.banho_TosaTableAdapter.Fill(this.bD_PetCareDataSet.Banho_Tosa);
            banho_TosaBindingSource.Position = p;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Perfil'. Você pode movê-la ou removê-la conforme necessário.
            this.perfilTableAdapter.Fill(this.bD_PetCareDataSet.Perfil);
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Outros_Remédios'. Você pode movê-la ou removê-la conforme necessário.
            this.outros_RemédiosTableAdapter.Fill(this.bD_PetCareDataSet.Outros_Remédios);
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Banho_Tosa'. Você pode movê-la ou removê-la conforme necessário.
            this.banho_TosaTableAdapter.Fill(this.bD_PetCareDataSet.Banho_Tosa);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex > -1)
            {
                iD_PetTextBox.Text = comboBox2.SelectedValue.ToString();
            }
        }

        private void banho_TosaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
