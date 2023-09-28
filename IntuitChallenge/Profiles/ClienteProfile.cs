using AutoMapper;
using Intuit.Challenge.Core.Models;
using IntuitChallenge.DTOs.Request;
using IntuitChallenge.DTOs.Response;

namespace IntuitChallenge.Profiles
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<Cliente, ClienteResponse>();
            CreateMap<ClienteRequest, Cliente>();
        }
    }
}
