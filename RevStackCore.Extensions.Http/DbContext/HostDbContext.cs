using System;
namespace RevStackCore.Extensions.Http
{
	public class HostDbContext
	{
		private string _host = null;
		public HostDbContext()
		{
		}
		public HostDbContext(string host)
		{
			_host = host;
				
		}
		public string Host
		{
			get
			{
				return _host;
			}
		}
	}
}
