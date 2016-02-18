using System;
using DemoDemo.Core;
using System.Net;

namespace DemoDemo.iOS
{
	public class ImageDataService: IImageDataService
	{
		public ImageDataService ()
		{
		}
		// TODO
		public byte[] DownloadData (string url)
		{
			var wc = new WebClient ();
			return wc.DownloadData (url);
		}
	}
}

