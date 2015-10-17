namespace PhC.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Model;
    using Model.Enums;

    public sealed class Configuration : DbMigrationsConfiguration<PhC.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true; // TODO FALSE IN PRODUCTION
            ContextKey = "PhC.Data.ApplicationDbContext"; 
            
        }

        protected override void Seed(PhC.Data.ApplicationDbContext context)
        {
            
            //if (context.Users.Count() == 3)
            //{
            //    var user1 = context.Users.First(u => u.UserName == "user1@user.com");
            //    var user2 = context.Users.First(u => u.UserName == "user2@user.com");
            //    var user3 = context.Users.First(u => u.UserName == "user3@user.com");
            //    this.SeedDB(context, user1, user2, user3);
            //}

        }

        //private void SeedDB(ApplicationDbContext context, User user1, User user2, User user3)
        //{
        //    User[] users = new[] {user1, user2, user3};
        //    var contestsDB = context.Contests;

        //    //Seed Contests
        //    if (!context.Contests.Any())
        //    {
        //        var contest1 = new Contest()
        //        {
        //            Title = "Photo of the week",
        //            Description = "Contest best photo for current week",
        //            Creator = user1,
                   
        //        };
        //        var contest2 = new Contest()
        //        {
        //            Title = "Photo of the month",
        //            Description = "Contest best photo for current month",
        //            Creator = user1
        //        };
        //        var contest3 = new Contest()
        //        {
        //            Title = "Photo of the day",
        //            Description = "Contest best photo of the day",
        //            Creator = user2
        //        };
        //        context.Contests.Add(contest1);
        //        context.Contests.Add(contest2);
        //        context.Contests.Add(contest3);
        //        context.SaveChanges();

        //        //Add some Contest.Participants
        //        var contests = contestsDB.ToList();
        //        foreach (Contest t in contests)
        //        {
        //            t.Participants.Add(user1);
        //        }

        //        foreach (Contest t in contests)
        //        {
        //          user2.ContestsParticipated.Add(t);
        //        }

        //    }

        //    //seed Contest Entities
        //    if (!context.ContestEntities.Any())
        //    {
        //        var contests = contestsDB.ToList();
        //        for (int i = 0; i < 3; i++)
        //        {
        //            var user = users[i];
        //            for (int c = 0; c < contests.Count; c++)
        //            {
        //                var contest = contests[c];
        //                var ce = new ContestEntity()
        //                {
        //                    Title = "title" + i + c,
        //                    Author = user,
        //                    Contest = contest,

        //                    PhotoUrl = "https://pbs.twimg.com/profile_images/960696059/PIC_logo.jpg",
        //                    Upploaded = DateTime.Now
        //                };
        //                context.ContestEntities.Add(ce);
        //                context.SaveChanges();
        //            }
                    
        //        }
        //    }

        //    //seed some votes
        //    if (!context.Votes.Any())
        //    {
        //        context.Votes.Add(new Vote()
        //        {
        //            Author = user1,
        //            ContestEntityId = 1
        //        });
        //    }

        //    //Add some Contest.Participants
            



       // }
    }
}
