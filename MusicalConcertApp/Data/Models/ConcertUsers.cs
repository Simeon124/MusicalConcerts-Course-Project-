using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ConcertUsers
    {
        public ConcertUsers()
        {
            Users = new List<User>();
        }

        public int Id { get; set; }
        public virtual Concert Concert { get; set; }
        public virtual int ConcertId { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
