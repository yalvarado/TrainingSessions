namespace TddApp.TestObjectTypes.Spy
{
    public interface IEmail
    {
        void SendEmail(string from, string to, string subject, string message);
    }
}