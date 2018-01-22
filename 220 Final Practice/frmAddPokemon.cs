using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _220_Final_Practice
{
    public partial class frmAddPokemon : Form
    {
        public frmAddPokemon()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Pokemon newPokemon = new Pokemon();
            newPokemon.Name = txtName.Text;
            newPokemon.Type = txtbxType.Text;
            newPokemon.HP = Convert.ToInt32(txtbxHP.Text);
            newPokemon.Weight = Convert.ToDouble(txtbxWeight.Text);
            newPokemon.Height = Convert.ToDouble(txtbxHeight.Text);

            this.Tag = newPokemon;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
