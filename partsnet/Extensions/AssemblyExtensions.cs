using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace PartsNet.Extensions
{
	public static class AssemblyExtensions
	{
		public static void AddAssemblyPart(this ApplicationPartManager manager, Type assemblyType) =>
			manager.ApplicationParts.Add(new AssemblyPart(assemblyType.Assembly));
	}
}
