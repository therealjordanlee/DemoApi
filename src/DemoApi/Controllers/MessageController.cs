using DemoApi.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DemoApi.Controllers
{
    [Route("message")]
    public class MessageController : ControllerBase
    {
        private readonly IOptionsMonitor<MessageSettings> _messageSettings;

        public MessageController(IOptionsMonitor<MessageSettings> messageSettings)
        {
            _messageSettings = messageSettings;
        }

        [HttpGet("normal")]
        public IActionResult GetHelloMessage()
        {
            return Ok(_messageSettings.CurrentValue.HelloMessage);
        }

        [HttpGet("secret")]
        public IActionResult GetSecretMessage()
        {
            return Ok(_messageSettings.CurrentValue.SecretMessage);
        }
        
        [HttpGet("blah")]
        public IActionResult GetSecretMessage()
        {
            return Ok("blah");
        }
    }
}
