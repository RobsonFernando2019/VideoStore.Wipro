using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore.Wipro.BLL.Infra.Model
{
    public class ClientModel       
    {
        public ClientModel() {
            this.CdClient = NextCd;
        }      
        private static int NextCd = 1;     
        public int CdClient { get; set; }
        public string Name { get; set; }
        public string CellPhone { get; set; }
        public string Address { get; set; }
        public string CPF { get; set; }
        public DateTime BirthDate { get; set; }

        private static readonly List<ClientModel> Clients = new();
        
        public void SaveClient(ClientModel client)
        {
            ClientModel.Clients.Add(client);
            NextCd++;
        }
        public List<ClientModel> GetAllClients()
        {
            return ClientModel.Clients;
        }
      
    }
}
