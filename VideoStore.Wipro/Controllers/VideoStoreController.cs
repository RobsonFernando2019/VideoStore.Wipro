using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NSwag.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoStore.Wipro.BLL.Infra;
using VideoStore.Wipro.BLL.Infra.Model;
using VideoStore.Wipro.DTOs.Response;

namespace VideoStore.Wipro.Controllers
{
    [ApiController]
    [Route("[controller]")]  
    public class VideoStoreController : ControllerBase
    {
        private readonly IVideoStoreBLL _videoStoreBLL;

        public VideoStoreController(IVideoStoreBLL videoStoreBLL)
        {
            _videoStoreBLL = videoStoreBLL;
        }

        [HttpPost("save-new-client")]     
        public string RegisterClient([FromQuery] ClientInputModel request)
        {
            var result = _videoStoreBLL.RegisterClient(request);
            return result;
        }

        [HttpGet("get-all-clients")] 
        public IEnumerable<ClientModel> GetAllRegisteredClients()
        {
            var result = _videoStoreBLL.GetAllClients();

            return result;
        }
        [HttpPost("save-new-movie")]     
        public string RegisterMovie([FromQuery] MovieInputModel request)
        {
            var result = _videoStoreBLL.RegisterMovie(request);
            return result;
        }
        [HttpGet("get-all-movies")]      
        public IEnumerable<MovieModel> GetAllRegisteredMovies()
        {
            var result = _videoStoreBLL.GetAllMovies();

            return result;
        }
        [HttpPost("rent-movie")]       
        public string RentMovie([FromQuery] RentMovieInputModel request)
        {
            var result = _videoStoreBLL.RentMovie(request);
            return result;
        }

        [HttpGet("get-rent-movies")]    
        public IEnumerable<RentMovieModel> GetAllRentMovies()
        {
            var result = _videoStoreBLL.GetAllRentMovies();

            return result;
        }
        [HttpPost("return-rented-movie")]
        public string ReturnMovie([FromQuery] ReturnMovieInputModel request)
        {
            var result = _videoStoreBLL.ReturnRentedMovie(request);
            return result;
        }
    }
}
