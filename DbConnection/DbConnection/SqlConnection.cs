using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString) { }

        public override void Open()
        {
            Console.WriteLine("Opening SQL Database Connection...");
        }

        public override void Close()
        {
            Console.WriteLine("Closing SQL Database Connection...");
        }
    }
}
