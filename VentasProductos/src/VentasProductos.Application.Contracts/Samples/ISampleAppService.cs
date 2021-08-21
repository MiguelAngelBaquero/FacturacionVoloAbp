using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace VentasProductos.Samples
{
    public interface ISampleAppService : IApplicationService
    {
        Task<SampleDto> GetAsync();

        Task<SampleDto> GetAuthorizedAsync();
    }
}
