using System;
using Autofac;
using DemoDemo.Api;

namespace DemoDemo.Core
{
	public static class IoC
	{
		public static IContainer Container{ get; set; }

		public static void Register (ContainerBuilder builder)
		{
			builder.RegisterType<ApiClient> ().AsSelf ().SingleInstance ();
			builder.RegisterType<PlayerService> ().AsSelf ().SingleInstance ();
		}
	}
}

