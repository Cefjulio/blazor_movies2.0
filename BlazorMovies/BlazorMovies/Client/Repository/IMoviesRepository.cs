using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Repository
{
    public interface IMoviesRepository
    {
        Task<int> CreateMovie(Movie movie);
        Task DeleteMovie(int Id);

        Task UpdateMovie(Movie movie);

    }
}
