namespace PhC.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Enums;

    public class VotingStrategy: IContestStrategy<TypeOpenClose>
    {
        private ICollection<User> _commettee;

        public VotingStrategy(TypeOpenClose type)
        {
            if (type == TypeOpenClose.Close)
            {
                this._commettee = new HashSet<User>();    
            }
            
        }
        [Key, ForeignKey("Contest")]
        public int Id { get; set; }

        [Required]
        public TypeOpenClose Type { get; set; }

        public virtual Contest Contest { get; set; }

        //Collection of users who are allowed to vote
        public virtual ICollection<User> Commettee {
            get { return this._commettee; }
            set { this._commettee = value; }
        }
    }
}
