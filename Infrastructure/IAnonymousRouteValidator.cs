namespace ellis.infrastructure
{
    internal interface IAnonymousRouteValidator
    {
        bool HasAccess(string path);
    }
}