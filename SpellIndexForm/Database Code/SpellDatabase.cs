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
        public Table<DataSpell> FullSpellList { get; }
        private IQueryable<DataSpell> CurrentListQuery;
        public string Error { get; set; } //Handles returning exeptions to the user display
        public string SelectedSchool { get; set; }
        public int SelectedLevel { get; set; }

        private static SqlConnection connection = BuildConnection(); //Establishes connection terms with the database
        public static DataContext db = new DataContext(connection);

        public SpellDatabase()
        {
            FullSpellList = db.GetTable<DataSpell>(); //Connects to the Database and fills a list of DataSpell objects for iteration through the search engine
            ResetQuery();
        }

        private static SqlConnection BuildConnection() //Builds Database based on static inputs below (TODO: Enable user input on Database connection)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "datasource";
            builder.InitialCatalog = "initialcatalog";
            builder.UserID = "userid";
            builder.Password = "password";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            return connection;
        }

        public void ResetQuery() //Resets Spell List and search parameters
        {
            CurrentListQuery = FullSpellList;
            SelectedLevel = -1;
            SelectedSchool = null;
        }

        public Table<DataSpell> Pull()
        {
            try
            {
                return FullSpellList;
            }
            catch (Exception e)
            {
                Error = e.ToString();
                return null;
            }
        } //Returns a list of Database objects from the Database

        public DataSpell TextSearchQuery(string search) //Matched user input from current list to select spell
        {
            try
            {
                    DataSpell Selected;
                    var searchQuery =
                    from spell in CurrentListQuery
                    where spell.name.ToString().ToLower() == search.ToLower()
                    select spell;
                    
                    if (searchQuery.Count() == 1)
                    {
                        Selected = searchQuery.First();
                        return Selected;
                    }
                    else if (searchQuery.Count() == 0)
                    {
                        Error = "No Spell Found!";
                        return null;
                    }
                    else
                    {
                        Error = "Multiple Spells Found";
                        return null;
                    }
            }
            catch (Exception e)
            {
                Error = e.ToString();
                return null;
            }
        }

        public IQueryable<DataSpell> SetLevelSearch(int level) //Generates list only matching level
        {
            var levelQuery =
                from spell in CurrentListQuery
                where spell.level == level
                select spell;
            return levelQuery;
        }

        public IQueryable<DataSpell> SetSchoolSearch(string school) //Generates list only matching school
        {
            var schoolQuery =
                from spell in CurrentListQuery
                where spell.school == school
                select spell;
            return schoolQuery;
        }

        public IQueryable<DataSpell> SetMultiSearch(string school, int level) //Generates list matching both school and level
        {
            var multiQuery =
                from spell in CurrentListQuery
                where spell.school == school
                where spell.level == level
                select spell;
            return multiQuery;
        }
        public void SetCurrentList()  //Determines which method to call to generate the current list
        {
            CurrentListQuery = FullSpellList;
            try
            {
                if (SelectedLevel == -1 && SelectedSchool != null)
                {
                    CurrentListQuery = SetSchoolSearch(SelectedSchool);
                }
                if (SelectedLevel != -1 && SelectedSchool == null)
                {
                    CurrentListQuery = SetLevelSearch(SelectedLevel);
                }
                else
                {
                    CurrentListQuery = SetMultiSearch(SelectedSchool, SelectedLevel);
                }
            }
            catch (Exception e)
            {
                Error = e.ToString();
            }
        }
        public string[] GetCurrentList() //Interpolates Spell Object Query into String Array for the dropdown list
        {
            var searchBoxQuery =
            from spell in CurrentListQuery
            select spell.name;

            string[] CurrentList;
            CurrentList = searchBoxQuery.ToArray();
            return CurrentList;

        }
                
        public bool Push(DataSpell pushedSpell) //TODO: Add implementation for adding spells to the Database from the applicaiton
        {
            return false;
        }
    }
}
