namespace PhC.Data
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model;


    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public virtual IDbSet<Contest> Contests { get; set; }
        public virtual IDbSet<ContestEntity> ContestEntities { get; set; }
        public virtual IDbSet<Vote> Votes { get; set; }
        public virtual IDbSet<RewardStrategy> RewardStrategies { get; set; }
        public virtual IDbSet<Prize> Prizes { get; set; }
        public virtual IDbSet<VotingStrategy> VotingStrategies { get; set; }
        public virtual IDbSet<ParticipationStrategy> ParticipationStrategies { get; set; }
        public virtual IDbSet<DeadlineStrategy> DeadlineStrategies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Contest>().HasMany(c => c.ContestEntities).WithRequired(ce => ce.Contest).WillCascadeOnDelete(false);
        //    modelBuilder.Entity<Contest>().HasMany(c => c.Winners).WithRequired(w => w.WonContest).WillCascadeOnDelete(false);
            modelBuilder.Entity<ContestEntity>().HasOptional(ce => ce.WonContest);
            modelBuilder.Entity<User>().HasMany(u => u.ContestsCreated).WithRequired(c => c.Creator).WillCascadeOnDelete(false);
            
             modelBuilder.Entity<Contest>()
                   .HasMany<User>(c => c.Participants)
                   .WithMany(p => p.ContestsParticipated)
                   .Map(pc =>
                            {
                                pc.MapLeftKey("ContestId");
                                pc.MapRightKey("UserId");
                                pc.ToTable("ContestsParticipants");
                            });

           
            base.OnModelCreating(modelBuilder);
        }

    }
}
