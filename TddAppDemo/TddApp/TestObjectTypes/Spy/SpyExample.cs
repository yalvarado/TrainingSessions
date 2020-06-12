namespace TddApp.TestObjectTypes.Spy
{
    /// <summary>
    /// Spies are stubs that also record some information based on how they were called. One form of
    /// this might be an email service that records how many messages it was sent.
    /// </summary>
    public class SpyExample: IEmail
    {
        
        private static int _emailCount;
        private readonly IEmail _emailServer;

        public SpyExample(IEmail emailServer)
        {
            this._emailServer = emailServer;
        }
        public void SendEmail(string from, string to, string subject, string message)
        {
            this._emailServer.SendEmail(from,to,subject,message);
            _emailCount++;
        }

        public int GetEmailCount()
        {
            return _emailCount;
        }
    }
}
