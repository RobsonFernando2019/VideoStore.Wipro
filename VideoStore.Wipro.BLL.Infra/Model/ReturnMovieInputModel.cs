using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore.Wipro.BLL.Infra.Model
{
    public class ReturnMovieInputModel
    {
        [Required]
        public int CdMovie { get; set; }
        [Required]        
        public DateTime ReturnDate { get; set; }
    }
}
