using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GocVisionApi.Models
{
	public class ImageUpload
	{
		public string ImageUri { get; set; }
		public string ThumbnailUri { get; set; }
		public string Caption { get; set; }


	}
}