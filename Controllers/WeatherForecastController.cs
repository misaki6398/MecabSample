using MecabSample.Models;
using MecabSample.Utilitys;
using Microsoft.AspNetCore.Mvc;

namespace MecabSample.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    [HttpGet("AA")]
    public ActionResult<IEnumerable<JapaneseNlpModel>> Get2()
    {
        var sentence = "行く川のながれは絶えずして、しかももとの水にあらず。";
        return MeCabUtility.AnalysisSentnece(sentence);
    }
}
