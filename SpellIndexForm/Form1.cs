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
        List<DataSpell> SpellList = new List<DataSpell>();
        SpellDatabase db = new SpellDatabase(); //TODO: Allow Database communications to be Asyncronous
        private DataSpell CurrentSpell;

        public Form1()
        {
            InitializeComponent();
            try
            {
                //Generates a list of Database objects from the Database
                SpellList = db.Pull();
                if (SpellList != null)
                {
                    lblSpellDescription.Text = "Spell Database Accessed Successfully";
                }
                else
                {
                    lblSpellDescription.Text = "Error! Spell List Not Pulled!";
                }
            }
            catch (Exception ex)
            {
                lblSpellDescription.Text = ex.ToString();
            }
        }

        //Method to display the currently selected spell
        public void setSpellDisplay()
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

        //Takes the text from the search box then attempts to find and display a corresponding spell
        private void btnGo_Click(object sender, EventArgs e)
        {
            string searchText = boxSearch1.Text;
            if (drdnClass.SelectedItem == null & drdnLevel.SelectedItem == null)
            {
                CurrentSpell = SpellList.Find(s => s.name.Equals(searchText, StringComparison.InvariantCultureIgnoreCase));
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

        }

        private void boxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void drdnLevel_SelectedItemChanged(object sender, EventArgs e)
        {
            //TODO: Fix so the Level selection filter displays the filtered spells in the search drop down.

            /* bool isLevelSelected = Int32.TryParse(drdnLevel.Text, out levelSelected);
            if (isLevelSelected)
            {
                var levelSpells = spells.Where(s => int.Equals(s.Level, levelSelected)).Select(s => s);
                foreach (var s in levelSpells)
                {
                    boxSearch1.Items.Add(s);
                }
            }
            else
            {
                levelSelected = 0;
                var levelSpells = spells.Where(s => int.Equals(s.Level, levelSelected)).Select(s => s);

                foreach (var s in levelSpells)
                {
                    boxSearch1.Items.Add(s);
                }
            } */
        }

        private void btnPull_Click(object sender, EventArgs e)
        {

        }
    }
}
