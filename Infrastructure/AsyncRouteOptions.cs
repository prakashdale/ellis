namespace ellis.infrastructure
{
    internal sealed class AsyncRouteOptions
    {
        public bool? Authenticate { get; set; }
        public string Exchange { get; set; }
        public string RoutingKey { get; set; }
    }
}