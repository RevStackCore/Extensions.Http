using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
namespace RevStackCore.Extensions.Http
{
	
	public class UrlUtility
	{
		private readonly string SCHEME_DELIMITER = "://";
		private HttpRequest _request;
		private string _host = null;
		public UrlUtility(HttpRequest request)
		{
			_request = request;
		}
		public UrlUtility(HttpRequest request,string host)
		{
			_request = request;
			_host = host;
		}
		public string Host
		{
			get
			{
				if (!string.IsNullOrEmpty(_host))
				{
					return _host;
				}
				else
				{
                    string result = _request.Scheme + SCHEME_DELIMITER + _request.Host.ToString();
					return result;
				}
			}
		}

		public string Path
		{
			get
			{
				return _request.Path;
			}
		}

		public IRequestCookieCollection Cookies
		{
			get
			{
				return _request.Cookies;
			}
		}

		public bool IsSecure
		{
			get
			{
				return _request.IsHttps;
			}
		}

		public IQueryCollection Query
		{
			get
			{
				return _request.Query;
			}
		}

		public string Method
		{
			get
			{
				return _request.Method;
			}
		}

		public string Protocol
		{
			get
			{
				return _request.Scheme;
			}
		}

		public string QueryString
		{
			get
			{
				return _request.QueryString.Value;
			}
		}

		public string SchemeDelimiter
		{
			get
			{
				return SCHEME_DELIMITER;
			}
		}

		public string Url
		{
			get
			{
				return _request.GetDisplayUrl();
			}
		}

		public string EncodedUrl
		{
			get
			{
				return _request.GetEncodedUrl();
			}
		}
	}
}
