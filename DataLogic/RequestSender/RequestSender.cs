using DataLogic.Services.Base;
using DataLogic.SingletonBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic.RequestSender
{
    public class RequestSender : SingletonBase<RequestSender>
    {
        private Dictionary<Type, HttpClient> m_CLIENTS;

        public RequestSender()
        {
            m_CLIENTS = new Dictionary<Type, HttpClient>();
        }

        public void AddClient<T>(string baseURI) where T : ServiceBase
        {
            if (m_CLIENTS.ContainsKey(typeof(T)))
            {
                var newClient = new HttpClient
                {
                    BaseAddress = new Uri(baseURI)
                };
                m_CLIENTS.Add(typeof(T), newClient);
            }
        }

        public async Task<string> Get<T>(string parameters) where T : ServiceBase
        {
            var response = await m_CLIENTS[typeof(T)].GetStringAsync(parameters);
            return response;
        }
    }
}
