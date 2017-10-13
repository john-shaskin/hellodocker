using System;
using Nancy;

namespace hellodocker.Modules
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {
            Get("/hello", args => GetHello());
            Get("/goodbye", args => GetGoodbye());
        }

        private string GetHello()
        {
            Console.WriteLine("Request to /hello");
            return "Hello, it's me!";
        }

        private string GetGoodbye()
        {
            Console.WriteLine("Request to /goodbye");
            return "Good-bye!";
        }
    }
}
