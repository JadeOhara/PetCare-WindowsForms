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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void pesoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pesoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_PetCareDataSet);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_PetCareDataSet.Peso'. Você pode movê-la ou removê-la conforme necessário.
            this.pesoTableAdapter.Fill(this.bD_PetCareDataSet.Peso);

        }
    }
}
