using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LsiTest.Infrastructure
{
    public class DatabaseQueryExecutor : IDatabaseQueryExecutor
    {
        readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=true;Database=Lsi-test;";



        public Hashtable Execute(string query)
        {
            var ret = new Hashtable();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand(query, connection);
                var dataReader = command.ExecuteReader();

                int j = 0;
                while (dataReader.Read())
                {
                    var toAdd = new Hashtable();
                    for(int i = 0; i < dataReader.FieldCount; i++)
                    {
                        toAdd.Add(dataReader.GetName(i), dataReader.GetValue(i));
                    }
                    ret.Add(j, toAdd);
                    j++;
                }
            }

            return ret;
        }
    }
}
