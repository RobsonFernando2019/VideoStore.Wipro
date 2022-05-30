using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NSwag.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoStore.Wipro.BLL.Infra;
using VideoStore.Wipro.BLL.Infra.Model;
using VideoStore.Wipro.DTOs.Request;
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
        [OpenApiOperation("Save new client", "")]
        public string RegisterClient([FromQuery] ClientInputModel request)
        {
            var result = _videoStoreBLL.RegisterClient(request);
            return result;
        }

        [HttpGet("get-all-clients")]
        [OpenApiOperation("Get all clients registered", "")]
        public IEnumerable<ClientModel> GetAllRegisteredClients()
        {
            var result = _videoStoreBLL.GetAllClients();

            return result;
        }
        [HttpPost("save-new-movie")]
        [OpenApiOperation("Save new Movie", "")]
        public string RegisterMovie([FromQuery] MovieInputModel request)
        {
            var result = _videoStoreBLL.RegisterMovie(request);
            return result;
        }
        [HttpGet("get-all-movies")]
        [OpenApiOperation("Get all movies registered", "")]
        public IEnumerable<MovieModel> GetAllRegisteredMovies()
        {
            var result = _videoStoreBLL.GetAllMovies();

            return result;
        }
        [HttpPost("rent-movie")]
        [OpenApiOperation("New rent Movie", "")]
        public string RentMovie([FromQuery] RentMovieInputModel request)
        {
            var result = _videoStoreBLL.RentMovie(request);
            return result;
        }

        [HttpGet("get-rent-movies")]
        [OpenApiOperation("Get all rent movies registered", "")]
        public IEnumerable<RentMovieModel> GetAllRentMovies()
        {
            var result = _videoStoreBLL.GetAllRentMovies();

            return result;
        }
    }
}
