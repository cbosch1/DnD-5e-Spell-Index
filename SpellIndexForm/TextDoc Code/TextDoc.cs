using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SpellIndexForm
{
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

            var regexNumbers = new Regex(@"\D");
            var regexCastingTime = new Regex(@"Casting Time: ");
            var regexComponents = new Regex(@"Components: ");
            var regexDuration = new Regex(@"Duration: ");
            var regexSchool = new Regex(@".*((abjuration)|(conjuration)|(divination)|(enchantment)|(evocation)|(illusion)|(necromancy)|(transmutation)).*");
            var regexDescription1 = new Regex(@"[\r\n]");
            var regexDescription2 = new Regex(@"  ");

            using (var file = new System.IO.StreamReader(@"C:\Users\Conner\Dropbox\Programming\C#\D&D\Spell Index\SpellIndexForm\SpellIndexBaseText.txt"))
            {

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

                    //Level
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
                    currentLine = file.ReadLine();

                    //Description
                    List<string> description = new List<string>();
                    bool exit;
                    do
                    {
                        List<string> paragraph = new List<string>();
                        string currentParagraph = "";
                        do
                        {
                            exit = false;
                            paragraph.Add(currentLine);
                            currentLine = file.ReadLine();
                            switch (currentLine)
                            {
                                case "" :
                                    exit = true;
                                    break;
                                case "---" :
                                    exit = true;
                                    break;
                                case "***" :
                                    exit = true;
                                    break;
                                default :
                                    break;
                            }
                        }
                        while (exit != true);

                        foreach (string p in paragraph)
                        {
                            currentParagraph += p;
                        }
                        importedSpell.Desctription += (currentParagraph + Environment.NewLine + Environment.NewLine);
                    }
                    while (currentLine != ("---"));

                    spellID++;
                    importedSpell.Id = spellID;
                    spells.Add(importedSpell);
                    currentLine = file.ReadLine();
                }
                while (currentLine != ("***"));
            }
            return spells;
        }
    }
}
