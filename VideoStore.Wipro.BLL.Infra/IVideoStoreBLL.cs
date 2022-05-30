using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VideoStore.Wipro.BLL.Infra.Model;

namespace VideoStore.Wipro.BLL.Infra
{
    public interface IVideoStoreBLL
    {
        string RegisterClient(ClientInputModel request);
        List<ClientModel> GetAllClients();
        string RegisterMovie(MovieInputModel request);
        List<MovieModel> GetAllMovies();
        string RentMovie(RentMovieInputModel request);
        List<RentMovieModel> GetAllRentMovies();
        string ReturnRentedMovie(ReturnMovieInputModel request);
    }
}
