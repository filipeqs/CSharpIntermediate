using System;

namespace Inheritance
{
    partial class Program
    {
        static void Main(string[] args)
        {
            UseComposition();
        }

        static void UseInheritance()
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();
        }

        static void UseComposition()
        {
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
