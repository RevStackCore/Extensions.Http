using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
namespace RevStackCore.Extensions.Http
{
	public static class ResponseStream
	{
		public static void Write(HttpResponse response, string contentType, byte[] buffer)
		{
			response.ContentType = contentType;
			response.Body.Write(buffer, 0, buffer.Length);
		}

		public static void Write(HttpResponse response, ContentType contentType, byte[] buffer)
		{
			string strType = contentType.ToContentTypeString();
			Write(response, strType, buffer);
		}

		public static void Write(HttpResponse response, string contentType, KeyValuePair<string, StringValues> headerValue, byte[] buffer)
		{
			response.ContentType = contentType;
			response.Headers.Add(headerValue);
			response.Body.Write(buffer, 0, buffer.Length);
		}

		public static void Write(HttpResponse response, ContentType contentType, KeyValuePair<string,StringValues> headerValue, byte[] buffer)
		{
			string strType = contentType.ToContentTypeString();
			Write(response, strType, headerValue, buffer);
		}

		public static Task WriteAsync(HttpResponse response, ContentType contentType, byte[] buffer)
		{
			return Task.Run(() => Write(response, contentType, buffer));
		}

		public static Task WriteAsync(HttpResponse response, string contentType, byte[] buffer)
		{
			return Task.Run(() => Write(response, contentType, buffer));
		}

		public static Task WriteAsync(HttpResponse response, ContentType contentType,KeyValuePair<string, StringValues> headerValue, byte[] buffer)
		{
			return Task.Run(() => Write(response, contentType, headerValue, buffer));
		}

		public static Task WriteAsync(HttpResponse response, string contentType, KeyValuePair<string, StringValues> headerValue, byte[] buffer)
		{
			return Task.Run(() => Write(response, contentType, headerValue, buffer));
		}
			
	}
}
