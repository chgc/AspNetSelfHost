using Owin;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;
using System.Web.Http;
using System.Configuration;

namespace AspNetSelfHost
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            app.UseWebApi(config);

            var options = new FileServerOptions
            {
                EnableDirectoryBrowsing = true,
                EnableDefaultFiles = true,
                DefaultFilesOptions = { DefaultFileNames = { "index.html" } },
                FileSystem = new PhysicalFileSystem(ConfigurationManager.AppSettings["wwwroot"]),
                StaticFileOptions = { ContentTypeProvider = new CustomContentTypeProvider() }
            };
            app.UseFileServer(options);
        }
    }
}
