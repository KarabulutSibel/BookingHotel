﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
	public class UpdateRoomDto
	{
		public int RoomId { get; set; }

		[Required(ErrorMessage = "Lütfen oda numarasını giriniz.")]
		public string RoomNumber { get; set; }

		[Required(ErrorMessage = "Lütfen oda görseli ekleyiniz.")]
		public string RoomCoverImage { get; set; }

		[Required(ErrorMessage = "Lütfen fiyat bilgisi giriniz.")]
		public int Price { get; set; }

		[Required(ErrorMessage = "Lütfen oda başlığı bilgisi giriniz.")]
		[StringLength(100, ErrorMessage ="En fazla 100 karakter kullanabilirsiniz.")]
		public string Title { get; set; }

		[Required(ErrorMessage = "Lütfen banyo sayısı giriniz.")]
		public string BathCount { get; set; }

		[Required(ErrorMessage = "Lütfen yatak sayısı giriniz.")]
		public string BedCount { get; set; }
		public string Wifi { get; set; }

		[Required(ErrorMessage = "Lütfen açıklama giriniz.")]
		public string Description { get; set; }
	}
}
