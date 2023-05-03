using SuperZapatos.Application.BaseEntity;
using SuperZapatos.Domain.Models;

namespace SuperZapatos.Application.Interfaces
{
    public interface IStoreApplication
    {
        Task<BaseResponse<IEnumerable<Store>>> GetAllStores();
        Task<BaseResponse<Store>> StoreById(int storeId);
        Task<BaseResponse<bool>> RegisterStore(Store store);
        Task<BaseResponse<bool>> EditStore(int storeId, Store store);
        Task<BaseResponse<bool>> RemoveStore(int storeId);
    }
}
