namespace GatewayEDI.Logging.Resolver
{
    /// <summary> A resolver function that returns a given factory that creates a named log. </summary>
    /// <param name="name"> The name of the requested log. Used to determine the correct factory. </param>
    /// <returns> A factory which in turn creates an instance of the requested named log. </returns>
    public delegate ILogFactory FactoryRequestHandler(string name);
}