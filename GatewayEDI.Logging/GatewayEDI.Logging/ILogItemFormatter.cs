namespace GatewayEDI.Logging
{
    /// <summary> Generates a formatted string-representation of a given <see cref="LogItem" />. </summary>
    public interface ILogItemFormatter
    {
        /// <summary> Creates a string representation of a given <see cref="LogItem" />. </summary>
        /// <param name="item"> The item to be processed. </param>
        /// <returns> A string representation of the submitted <paramref name="item" />. </returns>
        string FormatItem(LogItem item);
    }
}