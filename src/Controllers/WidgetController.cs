namespace TonysPortsAndAdapters.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using TonysPortsAndAdapters.Core.Ports.Incoming;
    using TonysPortsAndAdapters.Domain;

    [ApiController]
    [Route("[controller]")]
    public class WidgetsController : ControllerBase
    {
        private readonly IGetWidget _getWidget;
        private readonly ILogger<WidgetsController> _logger;

        public WidgetsController(IGetWidget getWidget, ILogger<WidgetsController> logger)
        {
            _getWidget = getWidget;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Widget> Get()
        {
            return _getWidget.GetWidgets();
        }

        [HttpGet("{id:int}")]
        public Widget GetById(int id)
        {
            return _getWidget.GetWidget(id);
        }
    }
}