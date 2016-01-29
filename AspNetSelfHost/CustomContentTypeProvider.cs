using Microsoft.Owin.StaticFiles.ContentTypes;

namespace AspNetSelfHost
{
    public class CustomContentTypeProvider : FileExtensionContentTypeProvider
    {
        /// <summary>
        /// Default ContentType
        /// </summary>
        /// <see cref="https://github.com/aspnet/StaticFiles/blob/dev/src/Microsoft.AspNetCore.StaticFiles/FileExtensionContentTypeProvider.cs "/>        
        public CustomContentTypeProvider()
        {            
        }
    }
}
