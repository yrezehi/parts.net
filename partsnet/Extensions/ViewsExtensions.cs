using Microsoft.Extensions.DependencyInjection;

namespace PartsNet.Extensions
{
	public static class ViewsExtensions
	{
		public static void RegisterPart(IMvcBuilder builder, Type partType)
		{
			builder.ConfigureApplicationPartManager(manager =>
			{
				manager.AddAssemblyPart(partType);
			});
		}
	}
}
