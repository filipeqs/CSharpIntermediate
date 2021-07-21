using System;
namespace DatabaseConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Opening Oracle Connection");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing Oracle Connection");
        }
    }
}
