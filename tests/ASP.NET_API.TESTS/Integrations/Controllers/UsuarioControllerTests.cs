using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using ASP.NET_API.Models.Usuarios;
using Newtonsoft.Json;
using Xunit;

namespace ASP.NET_API.TESTS.Integrations.Controllers
{
    public class UsuarioControllerTests
    {
        private readonly WebApplicationFactory<Startup> _factory;
        private readonly HttpClient _httpClient;
        public UsuarioControllerTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
            _httpClient = _factory.CreateClient();
        }
        
        [Fact]
        public void Logar()
        {
            var loginViewModelInput = new LoginViewModelInput
            {
                Login = "jeferson",
                Senha = "pass"
            };
            StringContent content = new StringContent(JsonConvert.SerializeObject(loginViewModelInput));
            var httpClientRequest = _httpClient.PostAsync("api/v1/usuario/logar", content).GetAwaiter().GetResult();
            
            Assert.Equal(System.Net.HttpStatusCode.OK, httpClientRequest.StatusCode);
        }
    }
}
