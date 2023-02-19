namespace ConsoleApp2
{
    public class Person
    {
        public string FullName; public int Age;
        public Person(string fullname, int age)
        {
            FullName = fullname;
            Age = age;
        }
        public Person()
        {
            return;
        }

        public string Talk(string fullname)
        {
            string FullName = "Такой-то " + fullname + " говорит";
            return FullName;
        }
        public string Move(string fullname)
        {
            string FullName = "Такой-то " + fullname + " говорит";
            return FullName;
        }
        public partial class Program : Person
        {
            static void Main(string[] args)
            {
                Person Вадим = new Person("Вадим", 8);
                Person Богдан = new Person();
                Console.WriteLine(Вадим.Move(Вадим.FullName));
                Console.WriteLine(Вадим.Talk(Вадим.FullName));
            }
        }
    }
}