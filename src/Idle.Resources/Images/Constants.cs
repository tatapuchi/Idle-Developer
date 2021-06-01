using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Idle.Resources.Images
{
	internal static class Constants
	{
		internal static System.Reflection.Assembly ResourcesAssembly { get; } = typeof(Assembly).Assembly;
		internal static string AssemblyName { get; } = ResourcesAssembly.GetName().Name;

	}
}
