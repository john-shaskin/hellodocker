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
            Get("/goaway", args => GetGoAway());
        }

        private string GetHello()
        {
            Console.WriteLine("Request to /hello");
            return "Hello, it's me!";
        }

        private string GetGoodbye()
        {
            Console.WriteLine("Request to /goodbye");
            return "Good-bye, you! It's been swell!";
        }

        private string GetGoAway()
        {
            Console.WriteLine("Request to /goaway");
            return "Go away!! Seriously!";
        }
    }
}
