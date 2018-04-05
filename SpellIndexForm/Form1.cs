using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpellIndexForm
{
    public partial class Form1 : Form
    {
        List<Spell> spells;
        public Form1()
        {
            InitializeComponent();

            spells = new List<Spell>();
            TextDoc gen = new TextDoc();
            spells = gen.Pull();
        }

        private Spell CurrentSpell;

        public void setSpellDisplay()
        {
            if (CurrentSpell is Spell)
            {
                //Name
                lblSpellName.Text = CurrentSpell.Name;

                //Level
                if (CurrentSpell.Level == 0)
                {
                    lblSpellLevel.Text = "Cantrip";
                }
                else
                {
                    string stringSpellLevel = CurrentSpell.Level.ToString();
                    lblSpellLevel.Text = $"Level: {stringSpellLevel}";
                }

                //School
                string stringSpellSchool = CurrentSpell.School.ToString();
                lblSpellSchool.Text = stringSpellSchool;

                //Ritual
                if (CurrentSpell.Ritual == true)
                {
                    lblRitual.Text = "(Ritual)";
                }
                else
                {
                    lblRitual.Text = "";
                }

                //Casting Time
                lblSpellCastingTime.Text = CurrentSpell.CastTime;

                //Range
                if (CurrentSpell.Range != 0)
                {
                    int intSpellRange = CurrentSpell.Range / 5;
                    string stringSpellRange = $"{intSpellRange} sq ({CurrentSpell.Range} ft)";
                    lblSpellRange.Text = stringSpellRange;
                }
                else
                {
                    lblSpellRange.Text = ("Self");
                }

                //SpellComponents
                string stringSpellComponents = CurrentSpell.ComponentType.ToString();
                lblSpellComponents.Text = stringSpellComponents;

                //SpellDuration
                lblSpellDuration.Text = CurrentSpell.Duration;
                

                //SpellDescription
                lblSpellDescription.Text = CurrentSpell.Desctription;
            }
            else
            {
                lblSpellName.Text = "No Spell Found";
            }
        }

        public void boxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string searchText = boxSearch.Text;

            CurrentSpell = spells.Find(p => p.Name.Equals(searchText, StringComparison.InvariantCultureIgnoreCase));

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
    }    
}
