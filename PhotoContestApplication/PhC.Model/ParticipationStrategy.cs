namespace PhC.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Enums;

    public class ParticipationStrategy : IContestStrategy<TypeOpenClose>
    {
        private ICollection<User> _allowedUsers;

        public ParticipationStrategy(TypeOpenClose type)
        {
             if (type == TypeOpenClose.Close)
             {
                 this._allowedUsers = new HashSet<User>();
             }
        }

        [Key, ForeignKey("Contest")]
        public int Id { get; set; }

        public virtual Contest Contest { get; set; }
        
        [Required]
        public TypeOpenClose Type { get; set; }

        //Collection of users who are allowed to participate
        public virtual ICollection<User> AllowedUsers
        {
            get { return this._allowedUsers; }
            set { this._allowedUsers = value; }
        }
    }
}
