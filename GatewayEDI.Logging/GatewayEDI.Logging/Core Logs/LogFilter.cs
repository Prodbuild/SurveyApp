namespace GatewayEDI.Logging
{
    /// <summary> A function that can be used to filter and/or transform a given log item. </summary>
    /// <param name="item"> The log entry to process. </param>
    /// <returns> True if the item should be forwarded to the underlying <see cref="ILog" />. </returns>
    public delegate bool LogFilter(LogItem item);
}