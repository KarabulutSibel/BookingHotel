using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using System.Net.Http.Headers;

namespace RapidApiConsume.Controllers
{
	public class SearchLocationIdController : Controller
	{
		public async Task<IActionResult> Index(string cityName)
		{
			if (!string.IsNullOrEmpty(cityName))
			{
				List<BookingApiLocationSearchViewModel> bookingApiLocationSearchViewModels = new List<BookingApiLocationSearchViewModel>();
				var client = new HttpClient();
				var request = new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={cityName}&locale=en-gb"),
					Headers =
	{
		{ "X-RapidAPI-Key", "9750e9cd8dmshc86145235ace13fp1cf35djsn5bf48b4d5959" },
		{ "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
	},
				};
				using (var response = await client.SendAsync(request))
				{
					response.EnsureSuccessStatusCode();
					var body = await response.Content.ReadAsStringAsync();
					bookingApiLocationSearchViewModels = JsonConvert.DeserializeObject<List<BookingApiLocationSearchViewModel>>(body);
					return View(bookingApiLocationSearchViewModels.Take(1).ToList());
				}
			}
			else
			{
				List<BookingApiLocationSearchViewModel> bookingApiLocationSearchViewModels = new List<BookingApiLocationSearchViewModel>();
				var client = new HttpClient();
				var request = new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/locations?name=Paris&locale=en-gb"),
					Headers =
	{
		{ "X-RapidAPI-Key", "9750e9cd8dmshc86145235ace13fp1cf35djsn5bf48b4d5959" },
		{ "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
	},
				};
				using (var response = await client.SendAsync(request))
				{
					response.EnsureSuccessStatusCode();
					var body = await response.Content.ReadAsStringAsync();
					bookingApiLocationSearchViewModels = JsonConvert.DeserializeObject<List<BookingApiLocationSearchViewModel>>(body);
					return View(bookingApiLocationSearchViewModels.Take(1).ToList());
				}
			}
		}
	}
}
