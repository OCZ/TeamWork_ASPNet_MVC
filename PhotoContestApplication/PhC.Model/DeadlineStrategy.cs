namespace PhC.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Enums;

    public class DeadlineStrategy : IContestStrategy<TypeTimeCount>
    {
        [Key, ForeignKey("Contest")]
        public int Id { get; set; }

        public virtual Contest Contest { get; set; }
        
        [Required]
        public TypeTimeCount Type { get; set; }
        
        public TimeSpan TimeSpan { get; set; }
        
        public int? ParticipantCount { get; set; }
    }
}
