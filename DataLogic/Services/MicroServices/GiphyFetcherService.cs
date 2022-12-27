using DataLogic.Services.Base;
using System;
using System.Threading.Tasks;

namespace DataLogic.Services.MicroServices
{
    public class GiphyFetcherService : ServiceBase
    {
        #region Members
        #endregion

        public GiphyFetcherService()
        {
            InitializeParameters();
        }

        public override async Task<object> GetData<T>(T data_request)
        {
            try
            {
                #region Set Request's Properties
                Models.GiphyRequestModel op = data_request as Models.GiphyRequestModel;
                #endregion

                switch (op.Operation)
                {
                    case Enums.GiphyEnums.E_OperationType.GetAllTrendingGifs:

                        return await GetAllTrendingGifs();

                    case Enums.GiphyEnums.E_OperationType.SearchSpecificGif:

                        var res = await GetByCriteria(op.Criteria);
                        return res;

                    default:
                        return default(object);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Message: {0}", ex.InnerException.Message));
            }
        }


        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        public override void InitializeParameters()
        {
            RequestSender.RequestSender.Instance.AddClient<GiphyFetcherService>(Globals.Globals.URL);
        }

        private async Task<dynamic> GetAllTrendingGifs()
        {
            return await RequestSender.RequestSender.Instance.Get<GiphyFetcherService>("");
        }

        private async Task<dynamic> GetByCriteria(string criteria)
        {
            return await RequestSender.RequestSender.Instance.Get<GiphyFetcherService>(criteria);
        }
    }
}
