using DataLogic.Enums;
using DataLogic.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic.Interfaces
{
    public interface IServiceManager
    {
        ServiceBase GetServiceOperations(E_ServiceType service_type);
    }
}
