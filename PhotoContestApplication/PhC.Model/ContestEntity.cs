namespace PhC.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class ContestEntity
    {
        private ICollection<Vote> _votes;

        public ContestEntity()
        {
            this.IsWinner = false;
            this.WinningPlase = null;
            this._votes = new HashSet<Vote>();
        }

        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        
        [Required]
        public DateTime Upploaded { get; set; }
        
        [Required]
        public string PhotoUrl { get; set; }
        
        
        [Required]
        public string AuthorId { get; set; }
        public virtual User Author { get; set; }

        [Required]
        public int ContestId { get; set; }
        public virtual Contest Contest { get; set; }

        public int? WonContestId { get; set; }
        public virtual Contest WonContest { get; set; }

        public virtual ICollection<Vote> Votes 
        {
            get { return this._votes; }
            set { this._votes = value; }
        }

        public bool IsWinner { get; private set; }

        public int? WinningPlase { get; private set; }


        public void Win(int? winingPlace = null )
        {
            this.IsWinner = true;
            this.WinningPlase = winingPlace;
        }
    }
}
