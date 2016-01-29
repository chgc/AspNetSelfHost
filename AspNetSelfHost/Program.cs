using Microsoft.Owin.Hosting;
using System;
using System.Configuration;
using Topshelf;

namespace AspNetSelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            StartTopshelf();
            // StartConsole();
        }


        static void StartTopshelf()
        {
            HostFactory.Run(x =>
            {
                x.Service<TopshelfService>(s =>
                {
                    s.ConstructUsing(name => new TopshelfService());
                    s.WhenStarted(tc => tc.start());
                    s.WhenStopped(tc => tc.stop());
                });
                x.RunAsLocalSystem();

                x.SetDescription("This is a demo of a Windows Service using Topshelf.");
                x.SetDisplayName("Self Host Web API Demo");
                x.SetServiceName("AspNetSelfHostDemo");
            });
        }

        static void StartConsole()
        {
            using (WebApp.Start<Startup>(ConfigurationManager.AppSettings["server"]))
            {
                Console.WriteLine("Web Server is running.");
                Console.WriteLine("Press any key to quit.");
                Console.ReadLine();
            }
        }
    }
}
