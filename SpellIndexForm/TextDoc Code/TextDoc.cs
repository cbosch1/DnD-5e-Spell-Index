using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SpellIndexForm
{
    //Reads a formated text document and imports the contained spells.
    class TextDoc
    {
        public List<Spell> Pull()
        {
            List<Spell> spells = pull();
            return spells;
        }

        private List<Spell> pull()
        {
            List<Spell> spells = new List<Spell>();

            int spellID = 0;
            int parseRange;
            int spellLevel;
            string currentLine = "";

            //Regex for removal of unused text in each line.
            var regexNumbers = new Regex(@"\D");
            var regexCastingTime = new Regex(@"Casting Time: ");
            var regexComponents = new Regex(@"Components: ");
            var regexDuration = new Regex(@"Duration: ");
            var regexSchool = new Regex(@".*((abjuration)|(conjuration)|(divination)|(enchantment)|(evocation)|(illusion)|(necromancy)|(transmutation)).*");
            var regexDescription1 = new Regex(@"[\r\n]");
            var regexDescription2 = new Regex(@"  ");

            //Opens text document
            using (var file = new System.IO.StreamReader(@"C:\Users\Conner\Dropbox\Programming\C#\D&D\Spell Index\SpellIndexForm\SpellIndexBaseText.txt"))
            {
                //creates a new spell to add to the list through each iteration
                do
                {
                    Spell importedSpell = new Spell();

                    //Name
                    importedSpell.Name = file.ReadLine();
                    currentLine = file.ReadLine().ToLower();

                    //Ritual
                    currentLine = file.ReadLine().ToLower();
                    if (currentLine.Contains("ritual"))
                    {
                        importedSpell.Ritual = true;
                    }
                    else
                    {
                        importedSpell.Ritual = false;
                    }

                    //School
                    string currentLineFull = currentLine;
                    currentLine = regexSchool.Replace(currentLine, "$1").ToLower();
                    switch (currentLine)
                    {
                        case ("abjuration") :
                            importedSpell.School = ArcaneTradition.Abjuration;
                            break;
                        case ("conjuration"):
                            importedSpell.School = ArcaneTradition.Conjuration;
                            break;
                        case ("divination"):
                            importedSpell.School = ArcaneTradition.Divination;
                            break;
                        case ("enchantment"):
                            importedSpell.School = ArcaneTradition.Enchantment;
                            break;
                        case ("evocation"):
                            importedSpell.School = ArcaneTradition.Evocation;
                            break;
                        case ("illusion"):
                            importedSpell.School = ArcaneTradition.Illusion;
                            break;
                        case ("necromancy"):
                            importedSpell.School = ArcaneTradition.Necromancy;
                            break;
                        case ("transmutation"):
                            importedSpell.School = ArcaneTradition.Transmutation;
                            break;
                    }

                    //Level (accounting for Cantrips)
                    bool notCantrip = Int32.TryParse(regexNumbers.Replace(currentLineFull, ""), out spellLevel);
                    if (notCantrip)
                    {
                        importedSpell.Level = spellLevel;
                    }
                    else
                    {
                        importedSpell.Level = 0;
                    }
                    currentLine = file.ReadLine();

                    //Casting Time
                    importedSpell.CastTime = regexCastingTime.Replace(file.ReadLine(), "");

                    //Range
                    currentLine = file.ReadLine();
                    bool rangeResult = Int32.TryParse(regexNumbers.Replace(currentLine, ""), out parseRange);
                    if (rangeResult)
                    {
                        importedSpell.Range = parseRange;
                    }
                    else
                    {
                        importedSpell.Range = 0;
                    }

                    //Components
                    importedSpell.ComponentType = regexComponents.Replace(file.ReadLine(), "");

                    //Duration
                    importedSpell.Duration = regexDuration.Replace(file.ReadLine(), "");

                    //Concentration
                    if (currentLine.Contains("concentration"))
                    {
                        importedSpell.Concentration = true;
                    }
                    else
                    {
                        importedSpell.Concentration = false;
                    }
                    currentLine = file.ReadLine();
                    currentLine = file.ReadLine(); //double line accounting for blank space

                    //Description 
                    List<string> description = new List<string>();
                    bool exit;
                    do
                    {
                        //Compiles lines into one paragraph string.
                        List<string> paragraph = new List<string>();
                        string currentParagraph = "";
                        do
                        {
                            exit = false;
                            paragraph.Add(currentLine);
                            currentLine = file.ReadLine();
                            switch (currentLine) //Breaks if reaches end of paragraph accounting for end of spell and end of document
                            {
                                case "" :
                                    exit = true;
                                    break;
                                case "---" : //end of spell symbol
                                    exit = true;
                                    break;
                                case "***" : //end of document symbol
                                    exit = true;
                                    break;
                                default :
                                    break;
                            }
                        }
                        while (exit != true); //Loops if it is not the end of the paragraph

                        foreach (string p in paragraph) //Compiles the string list into one paragraph
                        {
                            currentParagraph += p;
                        }
                        //Adds the paragraph to the spell description
                        importedSpell.Desctription += (currentParagraph + Environment.NewLine + Environment.NewLine);
                    }
                    //Breaks if it is the end of the spell
                    while (currentLine != ("---"));

                    //Adds spell to the main list and sets up for the next spell
                    spellID++;
                    importedSpell.Id = spellID;
                    spells.Add(importedSpell);
                    currentLine = file.ReadLine();
                }
                //Breaks at the end of the document
                while (currentLine != ("***"));
            }
            return spells;
        }
    }
}
