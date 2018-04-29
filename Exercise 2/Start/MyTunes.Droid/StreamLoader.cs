using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MyTunes.Shared;

namespace MyTunes
{
	class StreamLoader : IStreamLoader
	{
		private readonly Context context;

		public StreamLoader(Context context)
		{
			this.context = context;
		}

		public Stream GetStreamFromFile(string filename)
		{
			return context.Assets.Open(filename);
		}
	}
}