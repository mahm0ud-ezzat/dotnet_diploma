namespace task4
{
    class Animal
    {
        int age;
        string name;
        string type;
        bool isMale;
        public Animal(int age, string name, string type, bool isMale)
        {
            this.age = age;
            this.name = name;
            this.type = type;
            this.isMale = isMale;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal(13, "rock", "dog", true);
            Animal animal2 = new Animal(5, "rocka", "dog", false);

        }
    }
}
