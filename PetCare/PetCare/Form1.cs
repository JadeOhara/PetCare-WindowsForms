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
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {


                consultasTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM Consultas WHERE ID_Pet = " + comboBox1.SelectedValue;
                this.consultasTableAdapter.Fill(this.bD_PetCareDataSet.Consultas);

                tratamentosTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM Tratamentos WHERE ID_Pet = " + comboBox1.SelectedValue;
                this.tratamentosTableAdapter.Fill(this.bD_PetCareDataSet.Tratamentos);

                pesoTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM Peso WHERE ID_Pet = " + comboBox1.SelectedValue;
                this.pesoTableAdapter.Fill(this.bD_PetCareDataSet.Peso);

                vacinacaoTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM Vacinacao WHERE ID_Pet = " + comboBox1.SelectedValue;
                this.vacinacaoTableAdapter.Fill(this.bD_PetCareDataSet.Vacinacao);

                vermifugacaoTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM Vermifugacao WHERE ID_Pet = " + comboBox1.SelectedValue;
                this.vermifugacaoTableAdapter.Fill(this.bD_PetCareDataSet.Vermifugacao);

                outros_RemédiosTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM Outros_Remédios WHERE ID_Pet = " + comboBox1.SelectedValue;
                this.outros_RemédiosTableAdapter.Fill(this.bD_PetCareDataSet.Outros_Remédios);

                banho_TosaTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM Banho_Tosa WHERE ID_Pet = " + comboBox1.SelectedValue;
                this.banho_TosaTableAdapter.Fill(this.bD_PetCareDataSet.Banho_Tosa);
            }
        }

        private void button1AddPet_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
        }

        private void button1AddConsulta_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.Show();
        }

        private void button2AddTrat_Click(object sender, EventArgs e)
        {
            Form5 F5 = new Form5();
            F5.Show();
        }

        private void button3AddPeso_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            F4.Show();
        }

        private void button4RelatorioPeso_Click(object sender, EventArgs e)
        {
            Form10 F10 = new Form10();
            F10.Show();
        }

        private void button2AddVacin_Click(object sender, EventArgs e)
        {
            Form6 F6 = new Form6();
            F6.Show();
        }

        private void button3AddVermif_Click(object sender, EventArgs e)
        {
            Form7 F7 = new Form7();
            F7.Show();
        }

        private void button4AddOutrosTrat_Click(object sender, EventArgs e)
        {
            Form8 F8 = new Form8();
            F8.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 F9 = new Form9();
            F9.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Banho_Tosa'. Você pode movê-la ou removê-la conforme necessário.
            this.banho_TosaTableAdapter.Fill(this.bD_PetCareDataSet.Banho_Tosa);
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Outros_Remédios'. Você pode movê-la ou removê-la conforme necessário.
            this.outros_RemédiosTableAdapter.Fill(this.bD_PetCareDataSet.Outros_Remédios);
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Vacinacao'. Você pode movê-la ou removê-la conforme necessário.
            this.vacinacaoTableAdapter.Fill(this.bD_PetCareDataSet.Vacinacao);
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Vermifugacao'. Você pode movê-la ou removê-la conforme necessário.
            this.vermifugacaoTableAdapter.Fill(this.bD_PetCareDataSet.Vermifugacao);
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Vermifugacao'. Você pode movê-la ou removê-la conforme necessário.
            this.vermifugacaoTableAdapter.Fill(this.bD_PetCareDataSet.Vermifugacao);
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Peso'. Você pode movê-la ou removê-la conforme necessário.
            this.pesoTableAdapter.Fill(this.bD_PetCareDataSet.Peso);
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Peso'. Você pode movê-la ou removê-la conforme necessário.
            this.pesoTableAdapter.Fill(this.bD_PetCareDataSet.Peso);
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Tratamentos'. Você pode movê-la ou removê-la conforme necessário.
            this.tratamentosTableAdapter.Fill(this.bD_PetCareDataSet.Tratamentos);
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Consultas'. Você pode movê-la ou removê-la conforme necessário.
            this.consultasTableAdapter.Fill(this.bD_PetCareDataSet.Consultas);

            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Perfil'. Você pode movê-la ou removê-la conforme necessário.
            this.perfilTableAdapter.Fill(this.bD_PetCareDataSet.Perfil);

        }

        private void iD_PetLabel1_Click(object sender, EventArgs e)
        {
            iD_PetLabel1.Text = comboBox1.SelectedValue.ToString();
        }

        private void iD_PetLabel3_Click(object sender, EventArgs e)
        {
 
        }

        private void consultasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
