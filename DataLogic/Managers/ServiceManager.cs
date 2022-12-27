using DataLogic.Enums;
using DataLogic.Interfaces;
using DataLogic.Services.Base;
using DataLogic.Services.MicroServices;
using System;
using System.Collections.Generic;

namespace DataLogic
{
    public class ServiceManager : IServiceManager
    {
        #region members
        private Dictionary<E_ServiceType, ServiceOperations<ServiceBase>> m_ServicesContainer;

        #endregion

        #region ctor
        public ServiceManager()
        {
            BuildContainer();
        }
        #endregion

        #region implementation
        public ServiceBase GetServiceOperations(E_ServiceType service_type) => m_ServicesContainer[service_type].Operations;
        #endregion

        #region private methods

        private void BuildContainer()
        {
            m_ServicesContainer = new Dictionary<E_ServiceType, ServiceOperations<ServiceBase>>
            {
                { E_ServiceType.GiphyFetcher, new ServiceOperations<ServiceBase>(new GiphyFetcherService(), E_ServiceType.GiphyFetcher) }

            };
        }
        #endregion
    }
}
