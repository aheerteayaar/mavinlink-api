using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using datajson.Models;
using System.Net;

namespace datajson.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var url = "https://api.mavenlink.com/api/v1/example.json";
        var httpRequest = (HttpWebRequest)WebRequest.Create(url);
        var response = new Welcome();
        httpRequest.Accept = "application/json";
        httpRequest.Headers["Authorization"] = "Bearer 7********";

        var httpResponse = (HttpWebResponse)httpRequest.GetResponse();

        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        {
            var result = streamReader.ReadToEnd();

            response = Welcome.FromJson(result);
        }
        return View(response);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

