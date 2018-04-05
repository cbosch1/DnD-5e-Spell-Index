using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellIndexForm
{
        public class Spell
        {
            public int Id { get; set; }
            public int Range { get; set; }
            public int Level { get; set; }

            public string Name { get; set; }
            public string Duration { get; set; }
            public string CastTime { get; set; }
            public string Desctription { get; set; }
            public string OverchargeDescr { get; set; }
            public string PermanentDescr { get; set; }
            public string PlayerClass { get; set; }
            public string ComponentType { get; set; }

            public ArcaneTradition School { get; set; }

            public bool Concentration { get; set; }
            public bool spellCanOvercharge { get; set; }
            public bool Ritual { get; set; }
            public bool AreaOfEffect { get; set; }
            public bool IsPermanent { get; set; }
            public bool DamageOverTime { get; set; }
        }
}