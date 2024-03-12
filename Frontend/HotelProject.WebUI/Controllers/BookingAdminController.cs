using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
	public class BookingAdminController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public BookingAdminController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:5283/api/Booking");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
				return View(values);
			}
			return View();
		}
		public async Task<IActionResult> ApprovedReservation(int id, string? name)
		{
			if (name == "Onayla")
			{
				var client = _httpClientFactory.CreateClient();
				var responseMessage = await client.GetAsync($"http://localhost:5283/api/Booking/{id}");

				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<ApprovedReservationDto>(jsonData);
				values.Status = "Onaylandı.";

				var jsonData2 = JsonConvert.SerializeObject(values);
				StringContent stringContent = new StringContent(jsonData2, Encoding.UTF8, "application/json");
				var responseMessage2 = await client.PutAsync("http://localhost:5283/api/Booking", stringContent);
				if (responseMessage2.IsSuccessStatusCode)
				{
					return RedirectToAction("Index", "BookingAdmin");
				}
			}
			if (name == "IptalEt")
			{
				var client = _httpClientFactory.CreateClient();
				var responseMessage = await client.GetAsync($"http://localhost:5283/api/Booking/{id}");

				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<ApprovedReservationDto>(jsonData);
				values.Status = "İptal Edildi.";

				var jsonData2 = JsonConvert.SerializeObject(values);
				StringContent stringContent = new StringContent(jsonData2, Encoding.UTF8, "application/json");
				var responseMessage2 = await client.PutAsync("http://localhost:5283/api/Booking", stringContent);
				if (responseMessage2.IsSuccessStatusCode)
				{
					return RedirectToAction("Index", "BookingAdmin");
				}
			}
			if (name == "Beklet")
			{
				var client = _httpClientFactory.CreateClient();
				var responseMessage = await client.GetAsync($"http://localhost:5283/api/Booking/{id}");

				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<ApprovedReservationDto>(jsonData);
				values.Status = "Bekletiliyor..";

				var jsonData2 = JsonConvert.SerializeObject(values);
				StringContent stringContent = new StringContent(jsonData2, Encoding.UTF8, "application/json");
				var responseMessage2 = await client.PutAsync("http://localhost:5283/api/Booking", stringContent);
				if (responseMessage2.IsSuccessStatusCode)
				{
					return RedirectToAction("Index", "BookingAdmin");
				}
			}
			return RedirectToAction("Index", "BookingAdmin");
		}
	}
}
