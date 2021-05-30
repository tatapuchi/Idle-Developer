using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Idle.DataAccess.Images
{
	internal static class Constants
	{
		internal static Assembly ResourcesAssembly { get; } = typeof(Idle.Resources.Assembly).Assembly;
		internal static string AssemblyName { get; } = ResourcesAssembly.GetName().Name;

	}
}
