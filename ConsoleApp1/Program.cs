// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /*Console.WriteLine("Hello Earth");
            Console.WriteLine("Local Changes");
            Console.WriteLine("Conflict creation Sample");*/
            //object creatio of human class
            //className objectCariable=newClassName();
            Human human = new Human();
            Console.WriteLine("Please enter your name");
            human.name = Console.ReadLine();
            Console.WriteLine("Please enter your height");
            //string height = Console.ReadLhine();
            human.height = Convert.ToSingle(Console.ReadLine());
            human.phoneNumber = Convert.ToInt64(Console.ReadLine());
            human.Talk();
            human.HumanDetails();
            Console.ReadLine();
        }
    }
}