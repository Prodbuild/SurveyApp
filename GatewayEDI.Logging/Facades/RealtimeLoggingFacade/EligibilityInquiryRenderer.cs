using System.IO;
using GatewayEDI.Realtime;
using log4net.ObjectRenderer;

namespace RealtimeLoggingFacade
{
    /// <summary>
    /// Used by log4net to write <see cref="EligibilityInquiry"/> objects to a log in a customized fashion.
    /// This allows us to write:
    /// <code>
    /// EligibilityInquiry ei = new EligibilityInquiry();
    /// // do stuff with ei...
    /// Log.Info(ei);
    /// </code>
    /// and the log4net framework will write a customized entry, just for this object type.
    /// Each key/value pair is written on it's own line.
    /// </summary>
    public class EligibilityInquiryRenderer : IObjectRenderer
    {
        // MW - Created because IObjectRenderer requires it.  Patterned after RenderObject
        public string DoRender(RendererMap rendererMap, object obj)
        {
            string retVal = "";
            EligibilityInquiry inq = obj as EligibilityInquiry;
            if (inq != null)
            {
                retVal += "Inquiry: ";
                foreach (MyNameValue nv in inq.Parameters)
                {
                    retVal += string.Format("{0}={1}\r\n", nv.Name, nv.Value);
                }
                retVal += string.Format("Requested response type: {0}", inq.ResponseDataType);
            }
            return retVal;
        }

        public void RenderObject(RendererMap rendererMap, object obj, TextWriter writer)
        {
            EligibilityInquiry inq = obj as EligibilityInquiry;
            if (inq != null)
            {
                writer.Write("Inquiry: ");
                foreach (MyNameValue nv in inq.Parameters)
                {
                    writer.Write("{0}={1}\r\n", nv.Name, nv.Value);
                }
                writer.Write("Requested response type: {0}", inq.ResponseDataType);
            }
        }
    }
}
