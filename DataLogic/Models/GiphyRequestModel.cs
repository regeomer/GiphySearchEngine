using DataLogic.Enums.GiphyEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic.Models
{
    public class GiphyRequestModel
    {
        public E_OperationType Operation { get; set; }
        public string Criteria { get; set; }
    }
}
