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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void consultasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            int p = consultasBindingSource.Position;
            this.Validate();
            this.consultasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_PetCareDataSet);
            this.consultasTableAdapter.Fill(this.bD_PetCareDataSet.Consultas);
            consultasBindingSource.Position = p;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Perfil'. Você pode movê-la ou removê-la conforme necessário.
            this.perfilTableAdapter.Fill(this.bD_PetCareDataSet.Perfil);
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Consultas'. Você pode movê-la ou removê-la conforme necessário.
            this.consultasTableAdapter.Fill(this.bD_PetCareDataSet.Consultas);

        }

        private void diagnosticoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void diagnosticoLabel_Click(object sender, EventArgs e)
        {

        }

        private void tratamentoLabel_Click(object sender, EventArgs e)
        {

        }

        private void tratamentoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultadoLabel_Click(object sender, EventArgs e)
        {

        }

        private void resultadoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void observacaoLabel_Click(object sender, EventArgs e)
        {

        }

        private void observacaoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                iD_PetTextBox.Text = comboBox1.SelectedValue.ToString();
            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
    }
}
