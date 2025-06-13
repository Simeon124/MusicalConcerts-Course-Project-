using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public static class Business
    {
        public static void Main()
        {

        }

        public static List<Concert> Concerts { get; set; } = new List<Concert>();

        public static List<Concert> GetConcerts()
        {
            using (MusicalConcertAppDbContext dbc = new MusicalConcertAppDbContext())
            {
                Concerts = dbc.Concerts.ToList();
                return Concerts;
            }
        }

        public static List<Concert> GetUserConcertsById(int id)
        {
            using (MusicalConcertAppDbContext dbc = new MusicalConcertAppDbContext())
            {
                var user = dbc.UserConcerts.Include(uc => uc.Concerts).FirstOrDefault(x => x.UserId == id);
                if(user == null)
                {
                    return null;
                }
                {
                    return user.Concerts.ToList();
                }
                
            }
        }

        public static void SignForConcert(Concert currentConcert, User currentUser)
        {
            using (MusicalConcertAppDbContext dbc = new MusicalConcertAppDbContext())
            {
                var concert = dbc.Concerts.Find(currentConcert.Id);
                var user = dbc.Users.Find(currentUser.Id);

                var existingConcertUsers = dbc.ConcertUsers.FirstOrDefault(x => x.Concert == concert);

                if (existingConcertUsers == null)
                {
                    ConcertUsers concertUsers = new ConcertUsers
                    {
                        Concert = concert,
                    };
                    concertUsers.Users.Add(user);

                    dbc.ConcertUsers.Add(concertUsers);
                    dbc.SaveChanges();
                }
                else
                {
                    existingConcertUsers.Users.Add(user);
                    dbc.SaveChanges();
                }


                var existingUserConcerts = dbc.UserConcerts.FirstOrDefault(x => x.User == user);

                if (existingUserConcerts == null)
                {
                    UserConcerts userConcerts = new UserConcerts
                    {
                        User = user,
                    };
                    userConcerts.Concerts.Add(concert);

                    dbc.UserConcerts.Add(userConcerts);
                    dbc.SaveChanges();
                }
                else
                {
                    existingUserConcerts.Concerts.Add(concert);
                    dbc.SaveChanges();
                }

            }
        }

        public static void SignOutFromConcert(Concert currentConcert, User currentUser)
        {
            using (MusicalConcertAppDbContext dbc = new MusicalConcertAppDbContext())
            {
                var concert = dbc.Concerts.Find(currentConcert.Id);
                var user = dbc.Users.Find(currentUser.Id);

                var existingConcertUsers = dbc.ConcertUsers.FirstOrDefault(x => x.Concert == concert);

                if (existingConcertUsers == null)
                {
                    ConcertUsers concertUsers = new ConcertUsers
                    {
                        Concert = concert,
                    };
                    concertUsers.Users.Remove(user);

                    dbc.ConcertUsers.Remove(concertUsers);
                    dbc.SaveChanges();
                }
                else
                {
                    existingConcertUsers.Users.Remove(user);
                    dbc.SaveChanges();
                }


                var existingUserConcerts = dbc.UserConcerts.FirstOrDefault(x => x.User == user);

                if (existingUserConcerts == null)
                {
                    UserConcerts userConcerts = new UserConcerts
                    {
                        User = user,
                    };
                    userConcerts.Concerts.Remove(concert);

                    dbc.UserConcerts.Remove(userConcerts);
                    dbc.SaveChanges();
                }
                else
                {
                    existingUserConcerts.Concerts.Remove(concert);
                    dbc.SaveChanges();
                }

            }
        }
    }
}
