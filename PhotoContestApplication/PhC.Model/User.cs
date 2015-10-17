namespace PhC.Model
{
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class User : IdentityUser
    {

        private ICollection<Contest> _contestsCreated;
        private ICollection<Contest> _contestsParticipated;
        private ICollection<ContestEntity> _contestEntities;
        private ICollection<Vote> _votes;
        private ICollection<VotingStrategy> _votingStrategiesCommette;
        private ICollection<ParticipationStrategy> _participationStrategies;


        public User()
        {
            this._contestsParticipated = new HashSet<Contest>();
            this._contestsCreated = new HashSet<Contest>();
            this._contestEntities = new HashSet<ContestEntity>();
            this._votes = new HashSet<Vote>();
            this._votingStrategiesCommette = new HashSet<VotingStrategy>();
            this._participationStrategies = new HashSet<ParticipationStrategy>();
        }

        
        public virtual ICollection<Contest> ContestsCreated 
        {
            get { return this._contestsCreated; }
            set { this._contestsCreated = value; }
        }

        
        public virtual ICollection<ContestEntity> ContestEntities
        {
            get { return this._contestEntities; }
            set { this._contestEntities = value; }
        }
        
        //votes given by the user
        public virtual ICollection<Vote> Votes
        {
            get { return this._votes; }
            set { this._votes = value; }
        }

        //contests in which participated
        public virtual ICollection<Contest> ContestsParticipated
        {
            get { return this._contestsParticipated; }
            set { this._contestsParticipated = value; }
        }

        //Collection ot strategy/contest in which user is allowed to vote by the owner 
        public virtual ICollection<VotingStrategy> VotingStrategiesCommette 
        {
            get { return this._votingStrategiesCommette; }
            set { this._votingStrategiesCommette = value; } 
        }
        
        //Collection ot strategy/contest in which user is allowed to participate by the owner 
        public virtual ICollection<ParticipationStrategy> ParticipationStrategies
        {
            get { return this._participationStrategies; }
            set { this._participationStrategies = value; }
        } 
      







        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
