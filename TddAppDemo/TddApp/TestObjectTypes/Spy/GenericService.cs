namespace TddApp.TestObjectTypes.Spy
{
    public class GenericService
    {
        private readonly IEmail _emailServer;
        private readonly int _value;

        public GenericService(IEmail emailServer,int value)
        {
            this._value = value;
            this._emailServer = emailServer;
        }
        public void DoStuff()
        {
            if(this.IsEvenNumber())
                this._emailServer.SendEmail("fromMe","toMe","NoSubject","This message");
        }

        private bool IsEvenNumber()
        {
            return this._value % 2 == 0;
        }
    }
}