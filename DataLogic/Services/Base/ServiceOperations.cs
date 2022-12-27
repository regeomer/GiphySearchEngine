using DataLogic.Enums;
namespace DataLogic.Services.Base
{
    public class ServiceOperations<T> where T : ServiceBase
    {
        private T m_Operations;

        public T Operations => m_Operations;

        public E_ServiceType TheServiceType => Operations.TheServiceType;

        public ServiceOperations(T operations, E_ServiceType service_type)
        {
            m_Operations = operations;
            Operations.TheServiceType = service_type;
        }

        public void InitializeParameters()
        {
            Operations.InitializeParameters();
        }
    }
}
