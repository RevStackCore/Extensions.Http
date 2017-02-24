using System;
using Microsoft.AspNetCore.Http;

namespace RevStackCore.Extensions.Http
{
	public interface IUrlUtilityService
	{
		UrlUtility Get(HttpRequest request);
	}
}
