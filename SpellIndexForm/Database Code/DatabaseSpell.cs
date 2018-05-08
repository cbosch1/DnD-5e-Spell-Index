using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace SpellIndexForm
{
    //Defines a entity class that is able to match the spell information pulled from the database
    [Table(Name = "Spells")]
    public class DataSpell
    {
        private int _id;
        [Column(IsPrimaryKey = true, Storage = "_id")]
        public int id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        private int _range;
        [Column(IsPrimaryKey = true, Storage = "_range")]
        public int range
        {
            get { return this._range; }
            set { this._range = value; }
        }

        private int _level;
        [Column(IsPrimaryKey = true, Storage = "_level")]
        public int level
        {
            get { return this._level; }
            set { this._level = value; }
        }

        private string _name;
        [Column(Storage = "_name")]
        public string name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        private string _duration;
        [Column(Storage = "_duration")]
        public string duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        private string _castTime;
        [Column(Storage = "_castTime")]
        public string castTime
        {
            get { return this._castTime; }
            set { this._castTime = value; }
        }

        private string _description;
        [Column(Storage = "_description")]
        public string description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        private string _componentType;
        [Column(Storage = "_componentType")]
        public string componentType
        {
            get { return this._componentType; }
            set { this._componentType = value; }
        }

        private string _school;
        [Column(Storage = "_school")]
        public string school
        {
            get { return this._school; }
            set { this._school = value; }
        }

        private Boolean _ritual;
        [Column(Storage = "_ritual")]
        public Boolean ritual
        {
            get { return this._ritual; }
            set { this._ritual = value; }
        }
    }
}
