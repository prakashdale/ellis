using System.Collections.Generic;

namespace ellis.infrastructure
{
    internal sealed class AsyncRoutesOptions
    {
        public bool? Authenticate { get; set; }
        public IDictionary<string, AsyncRouteOptions> Routes { get; set; }
    }
}