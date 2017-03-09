namespace GatewayEDI.Logging.Formatters
{
    /// <summary> A delegate used to forward formatting requests for a given log item. </summary>
    /// <param name="item"> The item to be formatted. </param>
    /// <returns> A string representation of the item. </returns>
    public delegate string FormatRequestHandler(LogItem item);
}