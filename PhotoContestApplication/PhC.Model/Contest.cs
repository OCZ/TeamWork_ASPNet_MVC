namespace PhC.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Contest
    {
        private ICollection<ContestEntity> _winners;
        private ICollection<ContestEntity> _contestEntities;
        private ICollection<User> _participants;

        public Contest()
        {
            this._winners = new HashSet<ContestEntity>();
            this._contestEntities = new HashSet<ContestEntity>();
            this._participants = new HashSet<User>();
        }

        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string CreatorId { get; set; }
        public virtual User Creator { get; set; }

        [Required]
        public virtual RewardStrategy RewardStrategy { get; set; }

        [Required]
        public virtual VotingStrategy VotingStrategy { get; set; }

        [Required]
        public virtual ParticipationStrategy ParticipationStrategy { get; set; }

        [Required]
        public virtual DeadlineStrategy DeadlineStrategy { get; set; }

        public virtual ICollection<ContestEntity> Winners
        {
            get { return this._winners; }
            set { this._winners = value; }
        }

        public virtual ICollection<ContestEntity> ContestEntities
        {
            get { return this._contestEntities; }
            set { this._contestEntities = value; }
        }


        public virtual ICollection<User> Participants
        {
            get { return this._participants; }
            set { this._participants = value; }
        }

    }
}
