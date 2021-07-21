using System;

namespace DatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("conection");
            var dbCommandSql = new DbCommand(sqlConnection, "Add data to DB");
            dbCommandSql.Execute();

            var oracleConnection = new OracleConnection("connection");
            var dbCommandOracle = new DbCommand(oracleConnection, "Remove data from DB");
            dbCommandOracle.Execute();
        }
    }
}
