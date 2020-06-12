namespace TddApp.TestObjectTypes.Fake
{
    public class User
    {
        public int Id { get; }

        public string Name { get; }

        public User(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}