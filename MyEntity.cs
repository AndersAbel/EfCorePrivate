namespace ConsoleApp3
{
    public class MyEntity
    {
        private MyEntity() { }

        public MyEntity(string name)
        {
            Name = name;
        }


        public int Id { get; private set; }

        public string Name { get; private set; }

        public void Rename(string newName)
        {
            Name = newName;
        }
    }
}