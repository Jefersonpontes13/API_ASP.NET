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
using Xunit.Abstractions;

namespace ASP.NET_API.TESTS.Integrations.Controllers
{
    public class UsuarioControllerTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;
        private readonly ITestOutputHelper _output;
        private readonly HttpClient _httpClient;
        public UsuarioControllerTests(WebApplicationFactory<Startup> factory, ITestOutputHelper output)
        {
            _factory = factory;
            _output = output;
            _httpClient = _factory.CreateClient();
        }
        
        //WhenGivenThen
        
        [Fact]
        public async Task Logar_InformandoUsuarioESenhaExistentes_DeveRetornarSucesso()
        {
            // AAA
            
            // Arrange
            var loginViewModelInput = new LoginViewModelInput
            {
                Login = "jeferson",
                Senha = "pass"
            };
            StringContent content = new StringContent(JsonConvert.SerializeObject(loginViewModelInput), Encoding.UTF8, "application/json");
            
            // Action
            var httpClientRequest = await _httpClient.PostAsync("api/v1/usuario/logar", content);
            var loginViewModelOutput = JsonConvert.DeserializeObject<LoginViewModelOutput>(await httpClientRequest.Content.ReadAsStringAsync());
            
            // Assert
            Assert.Equal(System.Net.HttpStatusCode.OK, httpClientRequest.StatusCode);
            Assert.NotNull(loginViewModelOutput.Token);
            Assert.Equal(loginViewModelInput.Login, loginViewModelOutput.Usuario.Login);
            _output.WriteLine(loginViewModelOutput.Token);
        }
        
        //WhenGivenThen
        
        [Fact]
        public void Registrar_InformandoUsuarioEmailSenhaExistente_DeveRetornarBadRequest()
        {
            // AAA
            
            // Arrange
            var registroViewModelInput = new RegistroViewModelInput
            {
                Login = "jeferson",
                Email = "jefersonpontes@alu.ufc.br",
                Senha = "pass"
            };
            StringContent content = new StringContent(JsonConvert.SerializeObject(registroViewModelInput), Encoding.UTF8, "application/json");
            
            // Action
            var httpClientRequest = _httpClient.PostAsync("api/v1/usuario/registrar", content).GetAwaiter().GetResult();
            
            // Assert
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, httpClientRequest.StatusCode);
        }

    }
}
