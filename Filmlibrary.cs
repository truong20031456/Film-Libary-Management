using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_22
{
    public class xFilmlibrary
    {
       
            public List<Clients> CustomerList { get; set; }
            public List<Cinema> CinemaList { get; set; }
            public List<Book> BookingList { get; set; }

            public static Filmlibrary instance = null;

            private xFilmlibrary()
            {
                CustomerList = new List<Clients>();
                CinemaList = new List<Cinema>();
                BookingList = new List<Book>();
            }

            public static Filmlibrary getInstance(Filmlibrary instance)
            {
                if (instance == null)
                {
                  }
            return instance;
            }

            public Cinema Cinemafilm(string hotelNo)
            {
                foreach (Cinema cinema in CinemaList)
                {
                    if (cinema.No == hotelNo)
                    {
                        return cinema;
                    }
                }
                return null;
            }
        }

    public class Filmlibrary
    {
       
        
        public List<Clients> CustomerList { get; set; }
        public List<Cinema> CinemaList { get; set; }
        public List<Book> BookingList { get; set; }

        public static Filmlibrary instance = null;
    

        private Filmlibrary()
        {
            CustomerList = new List<Clients>();
            CinemaList = new List<Cinema>();
            BookingList = new List<Book>();
        }

        public static Filmlibrary getInstance()
        {
            if (instance == null)
            {
                instance = new Filmlibrary();
            }
            return instance;
        }

        public Cinema Cinemafilm(string hotelNo)
        {
            foreach (Cinema cinema in CinemaList)
            {
                if (cinema.No == hotelNo)
                {
                    return cinema;
                }
            }
            return null;
        }
        }
    }


