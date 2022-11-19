using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumberLookup.interfaces
{
    public interface IHttpClient
    {
        public Task<string> GetAsync(string requestUri);
    }
}
