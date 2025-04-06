using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployees.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private readonly IRepositoryManager _repository;

        public WeatherForecastController(ILoggerManager logger, IRepositoryManager repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            _logger.LogInfo("��� �������������� ��������� �� ������ ����������� ��������.");
            _logger.LogDebug("��� ���������� ��������� �� ������ ����������� ��������.");
            _logger.LogWarn("��� ��������� �������������� �� ������ ����������� ��������.");
            _logger.LogError("��� ��������� �� ������ �� ������ ����������� ��������.");

            return new string[] { "value1", "value2" };
        }
    }
}