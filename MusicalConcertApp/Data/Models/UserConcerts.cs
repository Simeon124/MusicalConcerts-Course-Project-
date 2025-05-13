using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class UserConcerts
    {
        public UserConcerts()
        {
            Concerts = new List<Concert>();
        }

        public int Id { get; set; }
        public virtual User User { get; set; }
        public virtual int UserId { get; set; }
        public virtual ICollection<Concert> Concerts { get; set; }
    }
}
