using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore.Wipro.BLL.Infra.Model
{
    public class RentMovieInputModel
    {
        [Required]
        public string CPFClient { get; set; }
        [Required]
        public int CdMovie{ get; set; }
        [Required]
        public int DaysRent { get; set; }
        public DateTime StartRent { get; set; } = DateTime.Now;      
    }
}
