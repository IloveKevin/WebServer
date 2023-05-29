using Microsoft.Extensions.DependencyInjection;
using NLog.Extensions.Logging;
using Zack.Commons;

namespace MyLog
{
	public class MyLog : IModuleInitializer
	{
		public void Initialize(IServiceCollection services)
		{
			services.AddLogging(loggingBuilder =>
			{
				loggingBuilder.AddNLog();
            });
		}
	}
}