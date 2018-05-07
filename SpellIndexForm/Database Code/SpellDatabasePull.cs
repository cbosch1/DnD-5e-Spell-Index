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
        static public Spell Pull()
        {
            Spell pulledSpell = new Spell();
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
                        //TODO: Modify insertCommand to pull a spell from SQL Database that matches the input
                        SqlCommand insertCommand = new SqlCommand($"INSERT INTO Spells (FirstColumn)" +
                            $" VALUES (@0)", connection);
                        
                        //TODO: Build spell object from SQL Connection's returned data
                        //TODO: Set built spell object to pulledSpell
                    }
                    catch (Exception e)
                    {
                        //Post exception e to appilcation display
                    }
                }
            }
            catch (Exception e)
            {
                //Post exception e to appilcation display
            }
            return pulledSpell;
        }
}
