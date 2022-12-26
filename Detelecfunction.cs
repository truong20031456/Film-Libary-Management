using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static assignment_22.Filmlibrary;

namespace assignment_22
{
     public class Detelecfunction
    {
        public  Detelecfunction(String CinemaID) 
        {
            
            
                foreach (Cinema cinema in Filmlibrary.getInstance().CinemaList)
                {
                    if (CinemaID.Equals(cinema.No))
                    {
                        Filmlibrary.getInstance().CinemaList.Remove(cinema);
                    }
                }
            
        }
            
    }
}
