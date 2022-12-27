using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic.Globals
{
    public static class Globals
    {
        // In real life this key will be encrypted
        public const string URL = "https://api.giphy.com/v1/gifs/search?api_key=";
        public const string KEY = "qyGDnhVSCubHVMxhuR83oAoQVFnl31xk";
        public const string QUERY = "q=";
        public const string RESTRICTIONS = "&limit=25&offset=0&rating=g&lang=en";
    }
}
