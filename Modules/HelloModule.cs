using System;
using Nancy;

namespace hellodocker.Modules
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {
            Get("/hello", args => GetHello());
        }

        private string GetHello()
        {
            Console.WriteLine("Request to /hello");
            return "Hello, it's me!";
        }
    }
}
