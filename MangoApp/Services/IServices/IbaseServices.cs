using FrondEnd.MangoApp.Models;
using MangoApp.Models;
using System;
using System.Threading.Tasks;

namespace MangoApp.Services.IServices
{
    public interface IbaseServices : IDisposable
    {
        ResponseDto responseModel { get; set; }

        Task<T> SendingAsync<T>(APIRequest aPIRequest);
    }
}
