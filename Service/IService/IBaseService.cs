using MicroServiceAppWeb.Models;

namespace MicroServiceAppWeb.Service.IService
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync(RequestDto requestDto);
        
    }
}
