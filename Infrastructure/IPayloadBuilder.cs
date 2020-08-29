using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ellis.infrastructure
{
    internal interface IPayloadBuilder
    {
        Task<T> BuildFromJsonAsync<T>(HttpRequest request) where T : class, new();
    }
}