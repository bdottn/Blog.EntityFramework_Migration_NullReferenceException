namespace Repository.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<LabContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    }
}