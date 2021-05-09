using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Idle.Resources.Common
{
	internal static class Constants
	{
		internal static string AssemblyName { get; } = Assembly.GetAssembly(typeof(Constants)).GetName().Name;

	}
}
