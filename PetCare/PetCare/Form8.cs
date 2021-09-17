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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void outros_RemédiosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            int p = outros_RemédiosBindingSource.Position;
            this.Validate();
            this.outros_RemédiosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_PetCareDataSet);
            this.outros_RemédiosTableAdapter.Fill(this.bD_PetCareDataSet.Outros_Remédios);
            outros_RemédiosBindingSource.Position = p;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Perfil'. Você pode movê-la ou removê-la conforme necessário.
            this.perfilTableAdapter.Fill(this.bD_PetCareDataSet.Perfil);
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Outros_Remédios'. Você pode movê-la ou removê-la conforme necessário.
            this.outros_RemédiosTableAdapter.Fill(this.bD_PetCareDataSet.Outros_Remédios);

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
