using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore.Wipro.BLL.Infra.Model
{
    public class ClientInputModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string CellPhone { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
    }
}
