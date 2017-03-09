namespace RealtimeLoggingFacade
{
    public class BBInfo
    {
        public Status _status;
        public string _msg;

        public BBInfo(Status status, string msg)
        {
            this._status = status;
            this._msg = msg;
        }
    }
}
