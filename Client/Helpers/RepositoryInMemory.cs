using InterviewApp_1.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewApp_1.Client.Helpers
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies()
        {

            return new List<Movie>() { 
            
                new Movie(){ Title= "Spider-Main: Far from Home", ReleaseDate = new DateTime(2019, 7, 12)   },
                new Movie(){ Title= "Ironman", ReleaseDate = new DateTime(2019, 7, 12)   },
                new Movie(){ Title= "King kon vs Godzilla", ReleaseDate = new DateTime(2019, 7, 12)   }

            };


        }
    }
}
