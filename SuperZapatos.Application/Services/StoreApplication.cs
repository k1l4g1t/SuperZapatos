using SuperZapatos.Application.BaseEntity;
using SuperZapatos.Application.Interfaces;
using SuperZapatos.Domain.Models;
using SuperZapatos.Infraestructure.Interfaces;
using SuperZapatos.Utilities;

namespace SuperZapatos.Application.Services
{
    public class StoreApplication : IStoreApplication
    {
        private readonly IStoreRepository _StoreRepository;
        public StoreApplication(IStoreRepository articlesRepository)
        {
            _StoreRepository = articlesRepository;
        }
        public async Task<BaseResponse<IEnumerable<Store>>> GetAllStores()
        {
            var response = new BaseResponse<IEnumerable<Store>>() { TotalElements = 0 };
            var articlesList = await _StoreRepository.GetAllAsync();
            if (articlesList is not null)
            {
                response.Success = true;
                response.Data = articlesList;
                response.Message = ReplyMessage.MESSAGE_QUERY;
                response.TotalElements = articlesList.Count();
            }
            else
            {
                response.Success = false;
                response.Message = ReplyMessage.MESSAGE_QUERY_EMPTY;
                response.errorCode = (int)EErrorCode.NoContent;
            }
            return response;
        }

        public async Task<BaseResponse<Store>> StoreById(int storeId)
        {
            var response = new BaseResponse<Store>() { TotalElements = 0 };
            var article = await _StoreRepository.GetByIdAsync(storeId);
            if (article is not null)
            {
                response.Success = true;
                response.Data = article;
                response.Message = ReplyMessage.MESSAGE_QUERY;
            }
            else
            {
                response.Success = false;
                response.Message = ReplyMessage.MESSAGE_QUERY_EMPTY;
                response.errorCode = (int)EErrorCode.NoContent;
            }
            return response;
        }

        public async Task<BaseResponse<bool>> RegisterStore(Store store)
        {
            var response = new BaseResponse<bool>();
            try
            {
                response.Data = await _StoreRepository.RegisterAsync(store);
                if (response.Data)
                {
                    response.Success = true;
                    response.Message = ReplyMessage.MESSAGE_SAVE;
                }
                else
                {
                    response.Success = false;
                    response.Message = ReplyMessage.MESSAGE_FAILED;
                    response.errorCode = (int)EErrorCode.NoContent;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ReplyMessage.MESSAGE_FAILED;
                response.errorCode = (int)EErrorCode.InternalError;
            }
            
            return response;
        }

        public async Task<BaseResponse<bool>> EditStore(int storeId, Store store)
        {
            var response = new BaseResponse<bool>();
            var articleEdit = await StoreById(storeId);
            if (articleEdit.Data is null)
            {
                response.Success = false;
                response.Message = ReplyMessage.MESSAGE_QUERY_EMPTY;
                response.errorCode = (int)EErrorCode.InputError;
                return response;
            }
            try
            {
                store.Id = storeId;
                response.Data = await _StoreRepository.EditAsync(store);
                if (response.Data)
                {
                    response.Success = true;
                    response.Message = ReplyMessage.MESSAGE_UPDATE;
                }
                else
                {
                    response.Success = false;
                    response.Message = ReplyMessage.MESSAGE_FAILED;
                    response.errorCode = (int)EErrorCode.InternalError;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ReplyMessage.MESSAGE_FAILED;
                response.errorCode = (int)EErrorCode.InternalError;
            }            
            return response;
        }

        public async Task<BaseResponse<bool>> RemoveStore(int storeId)
        {
            var response = new BaseResponse<bool>();
            var articleDelete = await StoreById(storeId);
            if (articleDelete.Data is null)
            {
                response.Success = false;
                response.Message = ReplyMessage.MESSAGE_QUERY_EMPTY;
                response.errorCode = (int)EErrorCode.NoContent;
                return response;
            }
            try
            {
                response.Data = await _StoreRepository.RemoveAsync(storeId);
                if (response.Data)
                {
                    response.Success = true;
                    response.Message = ReplyMessage.MESSAGE_DELETE;
                }
                else
                {
                    response.Success = false;
                    response.Message = ReplyMessage.MESSAGE_FAILED;
                    response.errorCode = (int)EErrorCode.NoContent;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ReplyMessage.MESSAGE_FAILED;
                response.errorCode = (int)EErrorCode.InternalError;
            }
            
            return response;
        }

        
    }
}
