namespace TddApp.TestObjectTypes.Spy
{
    /// <summary>
    /// The DoStuff method send an email only if the supplied number is an even number.
    /// </summary>
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