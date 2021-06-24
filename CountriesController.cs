using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SelfHostedAppNetCore
{
    [Route("countries")]
    public class CountriesController
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new[] {"Japan", "China"};
        }
    }
}
