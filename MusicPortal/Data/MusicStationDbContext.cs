using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MusicPortal.Data
{

    public class MusicStationDbContext : IdentityDbContext<User>
    {
        public MusicStationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Song> Songs { get; set; }

        public static MusicStationDbContext Create()
        {
            return new MusicStationDbContext();
        }
    }
}