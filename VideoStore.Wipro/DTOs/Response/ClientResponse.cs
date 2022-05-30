using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoStore.Wipro.DTOs.Response
{
    public class ClientResponse
    {
        public int CdClient { get; set; }
        public string Name { get; set; }
        public string CellPhone { get; set; }
        public string Address { get; set; }
        public string CPF { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
