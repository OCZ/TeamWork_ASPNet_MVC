namespace PhC.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Enums;

    public class RewardStrategy : IContestStrategy<TypeSingleMultiple>
    {
        private ICollection<Prize> _prizes;
        public RewardStrategy(TypeSingleMultiple type)
        {
            this.Type = type;
            if (type == TypeSingleMultiple.Multiple)
            {
                this._prizes = new HashSet<Prize>();
            }
        }

        [Key, ForeignKey("Contest")]
        public int Id { get; set; }

        public virtual Contest Contest { get; set; }
        
        public TypeSingleMultiple Type { get; set; }
        
        public virtual ICollection<Prize> Prizes 
        {
            get { return this._prizes; }
            set { this._prizes = value; }
        }

    }
}
