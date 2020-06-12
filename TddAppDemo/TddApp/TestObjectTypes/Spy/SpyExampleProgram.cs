namespace TddApp.TestObjectTypes.Spy
{
    public class SpyExampleProgram
    {
        private readonly IEmail _emailServer;

        public SpyExampleProgram(IEmail emailServer)
        {
            this._emailServer = emailServer;
        }
        public void DoSomething()
        {            
            var serviceA = new GenericService(this._emailServer,10 );
            var serviceB = new GenericService(this._emailServer, 3 );
            var serviceC = new GenericService(this._emailServer, 6 );

            serviceA.DoStuff();
            serviceB.DoStuff();
            serviceC.DoStuff();

        }

    }
}