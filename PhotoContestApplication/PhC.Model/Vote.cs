namespace PhC.Model
{
    using System;

    public class Vote
    {
        public int Id { get; set; }
        
        //VOTED FROM
        public string AuthorId { get; set; }
        public virtual User Author { get; set; }

        //VOTED FOR
        public int ContestEntityId { get; set; }
        public virtual ContestEntity ContestEntity { get; set; }

    }
}
