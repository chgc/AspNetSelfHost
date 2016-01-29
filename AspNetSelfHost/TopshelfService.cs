using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetSelfHost
{
    public class TopshelfService
    {
        private IDisposable _webapp;

        public void start()
        {
            _webapp = WebApp.Start<Startup>(ConfigurationManager.AppSettings["server"]);
        }

        public void stop()
        {
            _webapp?.Dispose();
        }

    }
}
