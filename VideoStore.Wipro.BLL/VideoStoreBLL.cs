using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoStore.Wipro.BLL.Infra;
using VideoStore.Wipro.BLL.Infra.Model;

namespace VideoStore.Wipro.BLL
{
    public class VideoStoreBLL : IVideoStoreBLL
    {
        private  ClientModel _clientModel = new();
        private  MovieModel _movieModel = new();
        private  RentMovieModel _rentMovieModel = new();
        private readonly IMapper _mapper;
        public VideoStoreBLL (IMapper mapper)
        {
            _mapper = mapper;
        }
        public string RegisterClient(ClientInputModel request)
        {
            try
            {
                CheckIfClientExists(request.CPF);
                CheckDate(request.BirthDate);
                _clientModel = _mapper.Map<ClientModel>(request);          
                _clientModel.SaveClient(_clientModel);  
                
                return "Client successfully saved";
               
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }
            
        }

        private void CheckIfClientExists(string cpf)
        {
            var ListClient = _clientModel.GetAllClients();         
            if (ListClient.Any())
            {
                var verifyList = ListClient.Where(x => x.CPF == cpf);
                if (verifyList.Any())
                {
                     throw new Exception(message: "Unable to register, client already registered");
                }              
            }        
        }

        private void CheckDate(DateTime date)
        {
            int result = DateTime.Compare(date, DateTime.Now);
            if(result > 0)
            {
                throw new Exception(message: "Invalid date, date cannot be greater than the current one");
            }
        }

        public string RegisterMovie(MovieInputModel request)
        {
            try
            {
               
                _movieModel = _mapper.Map<MovieModel>(request);
                _movieModel.DateRegister = DateTime.Now;
                _movieModel.SaveMovie(_movieModel);
               
                return "Movie successfully saved";

            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }

        }

        public string RentMovie(RentMovieInputModel request)
        {
            try
            {

                CheckIfClientNotExists(request.CPFClient);
                CheckIfMovieNotExists(request.CdMovie);
                CheckMovieAvailability(request.CdMovie);
                CheckDate(request.StartRent);

                _rentMovieModel = _mapper.Map<RentMovieModel>(request);
                _rentMovieModel.SaveRent(_rentMovieModel);
                return "Movie successfully rent";

            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }

        }

        private void CheckIfClientNotExists(string cpf)
        {
            var ListClient = _clientModel.GetAllClients();
            if (ListClient.Any())
            {
                var verifyList = ListClient.Where(x => x.CPF == cpf);
                if (!verifyList.Any())
                {
                    throw new Exception(message: "Unable to rent, client not found");
                }
            }
            else
            { 
                throw new Exception(message: "Unable to rent, client not found");
            }
        }
        private void CheckIfMovieNotExists(int cdMovie)
        {
            var ListMovies = _movieModel.GetAllMovies();
            if (ListMovies.Any())
            {
                var verifyList = ListMovies.Where(x => x.CdMovie == cdMovie);
                if (!verifyList.Any())
                {
                    throw new Exception(message: "Unable to rent, movie not found");
                }
            }
            else
            {
                throw new Exception(message: "Unable to rent, movie not found");
            }
        }
        private void CheckMovieAvailability(int cdMovie)
        {
            var ListRentMovies = _rentMovieModel.GetAllRentMovies();
            if (ListRentMovies.Any())
            {
                var verifyList = ListRentMovies.Where(x => x.CdMovie == cdMovie && x.ActiveRent == true);
                if (verifyList.Any())
                {
                    throw new Exception(message: "Unable to rent, movie already rented");
                }
            }           
        }
        public List<ClientModel> GetAllClients()
        {           
            return _clientModel.GetAllClients();
        }
        public List<MovieModel> GetAllMovies()
        {
            return _movieModel.GetAllMovies();
        }
        public List<RentMovieModel> GetAllRentMovies()
        {
            return _rentMovieModel.GetAllRentMovies();
        }


    }
}
