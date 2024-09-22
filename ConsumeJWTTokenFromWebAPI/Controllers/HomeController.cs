using ConsumeJWTTokenFromWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;

namespace ConsumeJWTTokenFromWebAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;
        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory; 
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserBE model)
        {
            if (ModelState.IsValid)
            {

                var apiUrl = "https://localhost:44320/api/User/Login";


                var client = _httpClientFactory.CreateClient();


                var jsonData = JsonConvert.SerializeObject(model);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");


                var response = await client.PostAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {

                    var result = await response.Content.ReadAsStringAsync();

                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse>(result);

          
                    HttpContext.Session.SetString("AuthToken", apiResponse.Token);

                    var userId = apiResponse.User.UserID;
                    var userName = apiResponse.User.UserName;

                    return RedirectToAction("Dashboard", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt. Please try again.");
                }
            }

            return View(model);
        }


        public async Task<IActionResult> Dashboard()
        {
            var token = HttpContext.Session.GetString("AuthToken");

            if (string.IsNullOrEmpty(token))
            {
                
            }
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var apiUrl = "https://localhost:44320/api/User/GetUserBook?UserId=1";

            var response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                var books = JsonConvert.DeserializeObject<List<Book>>(data);
                return View(books);
            }

            return View();
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
}
