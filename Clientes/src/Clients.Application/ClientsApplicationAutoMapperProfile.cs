using AutoMapper;
using Clients.Clients;

namespace Clients
{
    public class ClientsApplicationAutoMapperProfile : Profile
    {
        public ClientsApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Client, ClientDto>();
        }
    }
}