namespace Class_0526_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();

            IGroup g1 = p1;
            Console.WriteLine(g1.GetGroup());
            IData d1 = p1;
            Console.WriteLine(d1.GetData());
            IName n1 = p1;
            Console.WriteLine(n1.GetName());
            Console.WriteLine(n1.GetGroup());
            Console.WriteLine(n1.GetData());

            Student s1 = new Student();
            IData d2 = s1;
            Console.WriteLine(s1.GetData());


        }
    }
}