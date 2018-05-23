using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace SpellIndexForm
{
    public partial class Form1 : Form
    {
        SpellDatabase db = new SpellDatabase(); //TODO: Allow Database communications to be Asyncronous
        Table<DataSpell> SpellTable;
        private DataSpell CurrentSpell;

        public Form1()
        {
            InitializeComponent();
            try //Sets spell list to variable in scope
            {
                SpellTable = db.FullSpellList;
                if (SpellTable != null)
                {
                    lblSpellDescription.Text = "Spell Database Accessed Successfully";
                }
                else
                {
                    lblSpellDescription.Text = db.Error;
                }
            }
            catch (Exception ex)
            {
                lblSpellDescription.Text = ex.ToString();
            }
        }

        public void setSpellDisplay() //Method to display the currently selected spell
        {
            if (CurrentSpell is DataSpell)
            {
                //Name
                lblSpellName.Text = CurrentSpell.name;

                //Level
                if (CurrentSpell.level == 0)
                {
                    lblSpellLevel.Text = "Cantrip";
                }
                else
                {
                    string stringSpellLevel = CurrentSpell.level.ToString();
                    lblSpellLevel.Text = $"Level: {stringSpellLevel}";
                }

                //School
                lblSpellSchool.Text = CurrentSpell.school;

                //Ritual
                if (CurrentSpell.ritual == true)
                {
                    lblRitual.Text = "(Ritual)";
                }
                else
                {
                    lblRitual.Text = "";
                }

                //Casting Time
                lblSpellCastingTime.Text = CurrentSpell.castTime;

                //Range
                if (CurrentSpell.range != 0)
                {
                    int intSpellRange = CurrentSpell.range / 5;
                    string stringSpellRange = $"{intSpellRange} sq ({CurrentSpell.range} ft)";
                    lblSpellRange.Text = stringSpellRange;
                }
                else
                {
                    lblSpellRange.Text = ("Self");
                }

                //SpellComponents
                lblSpellComponents.Text = CurrentSpell.componentType;

                //SpellDuration
                lblSpellDuration.Text = CurrentSpell.duration;


                //SpellDescription
                lblSpellDescription.Text = CurrentSpell.description;
            }
            else
            {
                lblSpellName.Text = "No Spell Found";
            }
        }

        public void boxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e) //Uses search box text to find and display a spell
        {
            string searchText = boxSearch1.Text;
            try
            {
                CurrentSpell = db.TextSearchQuery(searchText);
                if (CurrentSpell == null)
                {
                    lblSpellDescription.Text = db.Error;
                }
            }
            catch (Exception ex)
            {
                lblSpellDescription.Text = ($"Error!: " + (db.Error) + "Exception!: " + ex.ToString());
            }
            setSpellDisplay();
        }

        private void btnGetSpells_Click(object sender, EventArgs e)
        {

        }

        private void lblComponents_Click(object sender, EventArgs e)
        {

        }

        private void lblSpellName_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblSpellDescription_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drdnLevel.SelectedItem != null) //Level selection filter
            {
                int levelSelected;
                bool isLevelSelected = Int32.TryParse(drdnLevel.SelectedItem.ToString().Remove(0, 6), out levelSelected);
                try
                {
                    if (isLevelSelected)
                    {
                        db.SelectedLevel = levelSelected;
                        db.SetCurrentList();
                        boxSearch1.Items.Clear();
                        boxSearch1.Items.AddRange(db.GetCurrentList());
                    }
                    else //Catched the "Cantrip" option as 0
                    {
                        db.SelectedLevel = 0;
                        db.SetCurrentList();
                        boxSearch1.Items.Clear();
                        boxSearch1.Items.AddRange(db.GetCurrentList());
                    }
                }
                catch (Exception ex)
                {
                    lblSpellDescription.Text = ($"Error: " + db.Error + "Exception: " + ex.ToString());
                }

            }
        }

        private void boxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void drdnLevel_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void btnPull_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e) //Clear's out filter parameters
        {
            db.ResetQuery();
            drdnLevel.ClearSelected();
            drdnSchool.ClearSelected();
            boxSearch1.Items.Clear();
            boxSearch1.Text = "";
        }

        private void drdnSchool_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (drdnSchool.SelectedItem != null) //School selection filter
            {
                string schoolSelected = drdnSchool.SelectedItem.ToString();
                try
                {
                    db.SelectedSchool = schoolSelected;
                    db.SetCurrentList();
                    boxSearch1.Items.Clear();
                    boxSearch1.Items.AddRange(db.GetCurrentList());
                }
                catch (Exception ex)
                {
                    lblSpellDescription.Text = ($"Error: " + db.Error + "Exception: " + ex.ToString());
                }
            }
        }
    }
}
