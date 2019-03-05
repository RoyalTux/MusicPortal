using Microsoft.Owin;
using MusicPortal.Models;
using Owin;
using System.Data.Entity;
using MusicPortal.Data;
using MusicPortal.Migrations;

[assembly: OwinStartupAttribute(typeof(MusicPortal.Startup))]
namespace MusicPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<MusicStationDbContext, Configuration>());

            ConfigureAuth(app);
        }
    }
}
