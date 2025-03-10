using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnection
{
    class Program
    {
        static void Main()
        {
            //if it is SqlConnection
            var sqlConnection = new SqlConnection("Server=serer;Database=DB;");
            var sqlCommand = new DbCommand(sqlConnection, "SELECT * FROM Users");
            sqlCommand.Execute();

            Console.WriteLine();

            // if it is OracleConnection
            var oracleConnection = new OracleConnection("Server=OracleServer;Database=OracleDB;");
            var oracleCommand = new DbCommand(oracleConnection, "SELECT * FROM Customers");
            oracleCommand.Execute();
        }
    }
}
