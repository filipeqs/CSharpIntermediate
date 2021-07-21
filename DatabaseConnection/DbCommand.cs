using System;
namespace DatabaseConnection
{
    public class DbCommand
    {
        public DbConnection DbConnection { get; set; }
        public string Instruction { get; set; }

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null)
                throw new InvalidOperationException("Dbconnection can not be null");

            if (string.IsNullOrEmpty(instruction))
                throw new InvalidOperationException("Instruction can not be null or empty");

            DbConnection = dbConnection;
            Instruction = instruction;
        }

        public void Execute()
        {
            DbConnection.OpenConnection();

            Console.WriteLine(Instruction);

            DbConnection.CloseConnection();
        }
    }
}
