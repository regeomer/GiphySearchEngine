using DataLogic.Interfaces;
using System.Threading.Tasks;

namespace DataLogic.Services.Base
{
    public abstract class ServiceBase : IService
    {
        #region Properties
        public Enums.E_ServiceType TheServiceType { get; set; }
        #endregion

        #region IDisposable implementation
        public abstract void Dispose();
        #endregion

        #region IService implementation
        public abstract void InitializeParameters();
        public abstract Task<object> GetData<T>(T data_request) where T : new();
        #endregion
    }
}
