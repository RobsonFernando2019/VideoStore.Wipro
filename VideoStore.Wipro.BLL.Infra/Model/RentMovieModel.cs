using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore.Wipro.BLL.Infra.Model
{
    public class RentMovieModel
    {
        public RentMovieModel()
        {
            this.CdRent = NextCd;
        }

        private static int NextCd = 1;
        public int CdRent { get; set; }       
        public string CPFClient { get; set; }       
        public int CdMovie { get; set; }       
        public int DaysRent { get; set; }
        public bool ActiveRent { get; set; } = true;
        public DateTime StartRent { get; set; } 
        public DateTime ReturnDate { get; set; } 

        public static readonly List<RentMovieModel> Rents = new();

        public void SaveRent(RentMovieModel rent)
        {
            RentMovieModel.Rents.Add(rent);
            NextCd++;
        }
        public List<RentMovieModel> GetAllRentMovies()
        {
            return RentMovieModel.Rents;
        }       
    }
}
