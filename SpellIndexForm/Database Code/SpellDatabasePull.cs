using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;

namespace SpellIndexForm
{
    //Class for handling Database interations
    public class SpellDatabase
    {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

        public SpellDatabase()
        {
            //Sets connection data upon instantiation (TODO: Add overloads so you can build a different connection)
            builder.DataSource = "datasource";
            builder.InitialCatalog = "SpellDatabase";
            builder.UserID = "userid";
            builder.Password = "password";
        }

        //Connects to the Database and fills a list of DataSpell objects for iteration through the search engine
        public List<DataSpell> Pull()
        {
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                DataContext db = new DataContext(connection);

                try
                {
                    Table<DataSpell> tableSpells = db.GetTable<DataSpell>();
                    List<DataSpell> spells = new List<DataSpell>();

                    foreach (DataSpell spell in tableSpells)
                    {
                        spells.Add(spell);
                    }
                    return spells;
                }
                catch  //TODO: Add better exception handling
                {
                    return null;
                }
            }
        }

        //TODO: Add implementation for adding spells to the Database from the applicaiton
        public bool Push(DataSpell pushedSpell)
        {
            return false;
        }
    }
}
