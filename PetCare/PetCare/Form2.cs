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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void perfilBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if ( (nomeTextBox.Text != "") && (especieTextBox.Text != "") && (racaTextBox.Text != "") && (sexoTextBox.Text != "") && (corTextBox.Text != "") )
            {
                int posicao = perfilBindingSource.Position;
                this.Validate();
                this.perfilBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bD_PetCareDataSet);
                this.perfilTableAdapter.Fill(this.bD_PetCareDataSet.Perfil);
                perfilBindingSource.Position = posicao;
            }
        }

        private void perfilBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.perfilBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_PetCareDataSet);

        }

        private void perfilBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.perfilBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_PetCareDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Sexo'. Você pode movê-la ou removê-la conforme necessário.
            this.sexoTableAdapter.Fill(this.bD_PetCareDataSet.Sexo);
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Raca'. Você pode movê-la ou removê-la conforme necessário.
            this.racaTableAdapter.Fill(this.bD_PetCareDataSet.Raca);
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Especie'. Você pode movê-la ou removê-la conforme necessário.
            this.especieTableAdapter.Fill(this.bD_PetCareDataSet.Especie);
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Perfil'. Você pode movê-la ou removê-la conforme necessário.
            this.perfilTableAdapter.Fill(this.bD_PetCareDataSet.Perfil);

        }

        private void iD_RacaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iD_EspecieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void especieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void racaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sexoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1AddEspecie_Click(object sender, EventArgs e)
        {
            Form11 F11 = new Form11();
            F11.Show();
        }

        private void button2AddRaca_Click(object sender, EventArgs e)
        {
            Form12 F12 = new Form12();
            F12.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void especieComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void especieComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (especieComboBox1.SelectedIndex > -1)
            {
                especieTextBox.Text = especieComboBox1.Text;
                iD_EspecieTextBox.Text = especieComboBox1.SelectedValue.ToString();
            }
        }

        private void racaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (racaComboBox2.SelectedIndex > -1)
            {
                racaTextBox.Text = racaComboBox2.Text;
                iD_RacaTextBox.Text = racaComboBox2.SelectedValue.ToString();
            }
        }

        private void RacaComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void sexoComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sexoComboBox3.SelectedIndex > -1)
            {
                sexoTextBox.Text = sexoComboBox3.Text;
                iD_SexoTextBox.Text = sexoComboBox3.SelectedValue.ToString();
            }
        }
    }
}
