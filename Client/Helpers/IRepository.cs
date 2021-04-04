using InterviewApp_1.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewApp_1.Client.Helpers
{
     public   interface IRepository
    {

        List<Movie> GetMovies();

    }
}
