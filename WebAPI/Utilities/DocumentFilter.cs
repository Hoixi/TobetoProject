using Microsoft.OpenApi.Models;
using Swashbuckle.Swagger;
using System.Web.Http.Description;

namespace WebAPI.Utilities
{
    public class MyDocumentFilter : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, SchemaRegistry schemaRegistry, IApiExplorer apiExplorer)
        {
            swaggerDoc.host = "some-url-that-is-hosted-on-azure.azurewebsites.net";
            swaggerDoc.schemes = new List<string> { "http" };
            
        }

        
    }
}
