using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SpellIndexForm
{
    static partial class SpellDatabase
    {
        static public bool Push(Spell pushedSpell)
        {
            bool success;
            try
            {
                // Builds connection string
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "datasource";
                builder.InitialCatalog = "initialcatalog";
                builder.UserID = "userid";
                builder.Password = "password";

                // Connects to SQL
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    try
                    {
                        //TODO: Fill out object info to insert (object name is spell)

                        SqlCommand insertCommand = new SqlCommand($"INSERT INTO Spells (FirstColumn)" +
                            $" VALUES (@0)", connection);
                        insertCommand.Parameters.Add(new SqlParameter("0", pushedSpell.Id));

                        success = true;
                    }
                    catch (Exception e)
                    {
                        //TODO: Post exception e to appilcation display
                        success = false;
                    }
                }
            }
            catch (Exception e)
            {
                //TODO: Post exception e to appilcation display
                success = false;
            }
            return success;
        }
    }
}
