// This programs goal is to allow me to pratice with classes, datagridviews, lists, forms and SQL connections

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _220_Final_Practice
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private List<Pokemon> _Party; // holds the party list in dgvParty
        private List<Pokemon> _Pokedex; // holds the party list in dgvPokedex

        private void frmMain_Load(object sender, EventArgs e)
        {
            dgvPokedex.DataSource = typeof(Pokemon); //bind the datasources
            dgvPokedex.DataSource = _Pokedex;
            getData(); // grab the sql data
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            addToParty();

        }
        private void label1Refresh()
        {
            int x = _Party.Count();
            label1.Text = (x + " Pokemon in the Party");
        }
        private void pokeGrid()
        {//tie the grids to tthe lists
            dgvParty.DataSource = typeof(List<Pokemon>);
            dgvParty.DataSource = _Party;
            dgvPokedex.DataSource = typeof(List<Pokemon>);
            dgvPokedex.DataSource = _Pokedex;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvParty.SelectedRows.Count > 0)
            {
                //reload the pokemans
                PokeText();
            }
            else //clear the text boxes when clear is selected
            {
                txtbxName.Text = null;
                txtbxType.Text = null;
                txtbxHP.Text = null;
                txtbxHeight.Text = null;
                txtbxWeight.Text = null;
            }
        }
        private void PokeText()
        {//load the selection into the text box
            txtbxName.Text = dgvParty.SelectedRows[0].Cells["Name"].Value.ToString();
            txtbxType.Text = dgvParty.SelectedRows[0].Cells["Type"].Value.ToString();
            txtbxHP.Text = dgvParty.SelectedRows[0].Cells["HP"].Value.ToString();
            txtbxHeight.Text = dgvParty.SelectedRows[0].Cells["Height"].Value.ToString();
            txtbxWeight.Text = dgvParty.SelectedRows[0].Cells["Weight"].Value.ToString();
        }
        private void btnName_Click(object sender, EventArgs e)
        {
            rbName.Checked = true;
            _Pokedex.Sort(delegate (Pokemon x, Pokemon y)
            { return x.Name.CompareTo(y.Name); });
            dgvPokedex.Refresh();
        }//sort by name
        private void btnType_Click(object sender, EventArgs e)
        {
            rbType.Checked = true;
            _Pokedex.Sort(delegate (Pokemon x, Pokemon y)
            { return x.Type.CompareTo(y.Type); });
            dgvPokedex.Refresh();
        }//sort by type
        private void btnHP_Click(object sender, EventArgs e)
        {
            rbHP.Checked = true;
            _Pokedex.Sort(delegate (Pokemon x, Pokemon y)
            { return x.HP.CompareTo(y.HP); });
            dgvPokedex.Refresh();
        }//sort by hp
        private void btnWeight_Click(object sender, EventArgs e)
        {
            rbWeight.Checked = true;
            _Pokedex.Sort(delegate (Pokemon x, Pokemon y)
            { return x.Weight.CompareTo(y.Weight); });
            dgvPokedex.Refresh();
        }//sort by weight
        private void btnHeight_Click(object sender, EventArgs e)
        {
            rbHeight.Checked = true;
            _Pokedex.Sort(delegate (Pokemon x, Pokemon y)
            { return x.Height.CompareTo(y.Height); });
            dgvPokedex.Refresh();
        }//sort by height
        private void addToParty()
        {
            if (_Party == null)
            {
                _Party = new List<Pokemon>(); //instance of a new party list if party is empty
            }
            Pokemon selected = (Pokemon)dgvPokedex.SelectedRows[0].DataBoundItem;
            _Party.Add((Pokemon)selected.Clone());

            dgvParty.DataSource = typeof(Pokemon); //databinding
            dgvParty.DataSource = _Party;
            dgvParty.Refresh();
            label1Refresh();
        }
        private void getData()
        {
            _Pokedex = new List<Pokemon>(); //create a new instance of pokedex
            try
            {
                string connectionString = "Data Source=GREENLAPTOP\\SQLEXPRESS;Initial Catalog=Pokemon;" + "Integrated Security=True"; //connect to localDP
                SqlConnection cn = new SqlConnection(connectionString);
                cn.Open();
                SqlCommand selectCommand = new SqlCommand("SELECT * FROM Pokemon ORDER BY pokemonID", cn);//select statement to 
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    decimal pHeight,pWeight;
                    Pokemon p = new Pokemon();
                    p.Name = (string)reader["pokemonName"];
                    p.Type = (string)reader["pokemonType"];
                    p.HP = (int)reader["pokemonHP"];
                    pHeight = (decimal)reader["pokemonHeight"]; //cannot explicitly convert an object into a double, so we convert twice. Possibly tunqating data
                    pWeight = (decimal)reader["pokemonWeight"];
                    p.Height = (double)pHeight;
                    p.Weight = (double)pWeight;
                    _Pokedex.Add(p);
                    pokeGrid();
                }
                cn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number +
                ": " + ex.Message, ex.GetType().ToString());
            }
        }

        private void btnClearPty_Click(object sender, EventArgs e)
        {
            dgvParty.DataSource = null;
            dgvParty.Rows.Clear();
            dgvParty.Refresh();
            _Party.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvParty.SelectedRows.Count == 1)
            {
                Pokemon selected = (Pokemon)dgvParty.SelectedRows[0].DataBoundItem;
                _Party.Remove(selected);

                // Remeber to rebind the grid since you modified the datasource
                dgvParty.DataSource = typeof(Pokemon);
                dgvParty.DataSource = _Party;
            }
        }

        private void btnAddPokemon_Click(object sender, EventArgs e)
        {
            frmAddPokemon f = new frmAddPokemon();
            if (f.ShowDialog() == DialogResult.OK)
            {
                // Save to DB
                // Reload from DB

                Pokemon p;
                p = (Pokemon)f.Tag;

                // Directly inject into our data for now.
                _Pokedex.Add(p);
                pokeGrid();
            }


        }
    }
}
