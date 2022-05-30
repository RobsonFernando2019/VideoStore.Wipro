using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore.Wipro.BLL.Infra.Model
{
    public class MovieModel
    {
        public MovieModel()
        {
            this.CdMovie = NextCd;
        }
        
        private static int NextCd = 1;
        public int CdMovie { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }     
        public string Modality { get; set; }
        public DateTime DateRegister { get; set; }

        private static readonly List<MovieModel> Movies = new();

        public void SaveMovie(MovieModel movie)
        {
            MovieModel.Movies.Add(movie);
            NextCd++;
        }
        public List<MovieModel> GetAllMovies()
        {
            return MovieModel.Movies;
        }
    }
}
