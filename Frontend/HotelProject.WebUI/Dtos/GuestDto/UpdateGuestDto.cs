using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.GuestDto
{
	public class UpdateGuestDto
	{
		public int GuestId { get; set; }

		[Required(ErrorMessage = "İsim alanı boş bırakılamaz.")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Soyisim alanı boş bırakılamaz.")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "Şehir alanı boş bırakılamaz.")]
		public string City { get; set; }
	}
}
