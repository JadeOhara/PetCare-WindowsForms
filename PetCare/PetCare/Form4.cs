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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pesoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            int p = pesoBindingSource.Position;
            this.Validate();
            this.pesoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_PetCareDataSet);
            this.pesoTableAdapter.Fill(this.bD_PetCareDataSet.Peso);
            pesoBindingSource.Position = p;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Perfil'. Você pode movê-la ou removê-la conforme necessário.
            this.perfilTableAdapter.Fill(this.bD_PetCareDataSet.Perfil);
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Peso'. Você pode movê-la ou removê-la conforme necessário.
            this.pesoTableAdapter.Fill(this.bD_PetCareDataSet.Peso);

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
