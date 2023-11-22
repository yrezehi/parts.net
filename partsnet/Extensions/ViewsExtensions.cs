using Microsoft.Extensions.DependencyInjection;

namespace partsnet.Extensions
{
	public static class ViewsExtensions
	{
		public static void RegisterPart(IMvcBuilder builder, Type partType)
		{
			builder.ConfigureApplicationPartManager(options =>
			{
				options.ApplicationParts.Add();
			});
		}
	}
}
