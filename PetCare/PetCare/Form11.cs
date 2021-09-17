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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void especieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            int p = especieBindingSource.Position;
            this.Validate();
            this.especieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_PetCareDataSet);
            this.especieTableAdapter.Fill(this.bD_PetCareDataSet.Especie);
            especieBindingSource.Position = p;
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Especie'. Você pode movê-la ou removê-la conforme necessário.
            this.especieTableAdapter.Fill(this.bD_PetCareDataSet.Especie);

        }
    }
}
