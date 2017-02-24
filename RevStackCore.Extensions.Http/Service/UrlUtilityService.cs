using System;
using Microsoft.AspNetCore.Http;

namespace RevStackCore.Extensions.Http
{
	public class UrlUtilityService : IUrlUtilityService
	{
		private readonly HostDbContext _dbContext;
		public UrlUtilityService(HostDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public UrlUtility Get(HttpRequest request)
		{
			if (string.IsNullOrEmpty(_dbContext.Host))
			{
				return new UrlUtility(request);
			}
			else
			{
				return new UrlUtility(request, _dbContext.Host);
			}
		}
	}
}
