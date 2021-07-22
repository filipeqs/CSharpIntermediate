using System;

namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger Logger;

        public DbMigrator(ILogger logger)
        {
            Logger = logger;
        }


        public void Migrate()
        {
            Logger.LogInfo($"Migration started at {DateTime.Now}");

            // Details of migrating the database

            Logger.LogInfo($"Migration ended at {DateTime.Now}");
        }
    }
}
