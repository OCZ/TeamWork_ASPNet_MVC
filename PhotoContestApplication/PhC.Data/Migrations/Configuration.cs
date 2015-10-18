namespace PhC.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true; // TODO FALSE IN PRODUCTION
            ContextKey = "PhC.Data.ApplicationDbContext"; 
            
        }

        protected override void Seed(ApplicationDbContext context)
        {
        }
    }
}
