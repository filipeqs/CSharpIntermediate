using System;
namespace DatabaseConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) :
            base(connectionString)
        {
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing SQL Connection");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Opening SQL Connection");
        }
    }
}
