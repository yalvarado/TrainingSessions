namespace TddApp.TestObjectTypes.Spy
{
    public class EmailServer: IEmail
    {
        public void SendEmail(string from, string to, string subject, string message)
        {
            // code to send email
        }
    }
}