namespace JustPlay.Web
{
    using Data;
    using Data.Migrations;
    using System.Data.Entity;

    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<JustPlayDbContext, Configuration>());
            JustPlayDbContext.Create().Database.Initialize(true);
        }
    }
}