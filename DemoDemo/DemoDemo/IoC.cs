using System;
using Autofac;
using DemoDemo.Core;

namespace DemoDemo.iOS
{
	public static class IoC
	{
		// TODO
		public static void Register (ContainerBuilder builder)
		{
			builder.RegisterType<Splat.PlatformBitmapLoader> ().As<Splat.IBitmapLoader> ();
			builder.RegisterType<ImageDataService> ().As<IImageDataService> ();
		}
	}
}

