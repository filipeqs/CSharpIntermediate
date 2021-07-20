namespace Inheritance
{
    partial class Program
    {
        public class DbMigrator
        {
            public Logger Logger { get; }

            public DbMigrator(Logger logger)
            {
                Logger = logger;
            }

            public void Migrate()
            {
                Logger.Log("We are migrating...");
            }

        }
    }
}
