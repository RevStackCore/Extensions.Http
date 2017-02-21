using System;
namespace RevStackCore.Extensions.Http
{
	public static class Extensions
	{
		public static string ToContentTypeString(this ContentType src)
		{
			switch (src)
			{
				case ContentType.Gif:
					return "image/gif";
				case ContentType.Jpg:
					return "image/jpeg";
				case ContentType.Mp4:
					return "video/mp4";
				case ContentType.Mp3:
					return "audio/mpeg";
				case ContentType.Mpeg:
					return "video/mpeg";
				case ContentType.Pdf:
					return "application/pdf";
				case ContentType.Png:
					return "image/png";
				case ContentType.Html:
					return "text/html";
				case ContentType.Zip:
					return "application/zip";
				case ContentType.Log:
					return "text/plain";
				case ContentType.Svg:
					return "image/svg+xml";
				case ContentType.Txt:
					return "text/plain";
				default:
					return "";
			}
		}
	}
}
