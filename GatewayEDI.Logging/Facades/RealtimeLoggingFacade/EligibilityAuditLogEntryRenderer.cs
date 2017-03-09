using System.Collections;
using System.IO;
using System.Xml;
using log4net.ObjectRenderer;

namespace RealtimeLoggingFacade
{
    public class EligibilityAuditLogEntryRenderer : IObjectRenderer
    {
        public void RenderObject(RendererMap rendererMap, object obj, TextWriter writer)
        {
            EligibilityAuditLogEntry entry = obj as EligibilityAuditLogEntry;
            if (entry != null)
            {
                AuditHashesToXml(entry.log_hash, entry.AAAs, new XmlTextWriter(writer));
            }
        }

        private static void AuditHashesToXml(Hashtable log_hash, Hashtable aaas, XmlTextWriter xml_writer)
        {
            xml_writer.WriteStartElement("AuditLogEntry");
            foreach (DictionaryEntry entry in log_hash)
            {
                xml_writer.WriteElementString(entry.Key.ToString(), entry.Value == null ? string.Empty : entry.Value.ToString());
            }

            xml_writer.WriteStartElement("RequestValidations");
            foreach (string[] aaa in aaas.Keys)
            {
                xml_writer.WriteStartElement("RequestValidation");
                xml_writer.WriteElementString("ContainingLoop", aaas[aaa].ToString());
                xml_writer.WriteElementString("ValidRequestIndicator", aaa[0]);
                xml_writer.WriteElementString("RejectReasonCode", aaa[1]);
                xml_writer.WriteElementString("FollowupActionCode", aaa[2]);
                //These are left over from when this was in GatewayEDI.Realtile.Logging and had a reference to the X12 Segment class.
                //xml_writer.WriteElementString("ValidRequestIndicator", aaa[1]);
                //xml_writer.WriteElementString("RejectReasonCode", aaa[3]);
                //xml_writer.WriteElementString("FollowupActionCode", aaa[4]);
                xml_writer.WriteEndElement();
            }
            xml_writer.WriteEndElement();

            xml_writer.WriteEndElement();
            xml_writer.Flush();
        }
    }

    internal class EligibilityAuditLogEntry
    {
        public Hashtable log_hash;
        public Hashtable AAAs;
    }
}