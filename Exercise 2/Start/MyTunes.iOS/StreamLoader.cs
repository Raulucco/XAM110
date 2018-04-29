using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using MyTunes.Shared;
using System.IO;

namespace MyTunes
{
	class StreamLoader : IStreamLoader
	{
		Stream IStreamLoader.GetStreamFromFile(string fileName)
		{
			return File.OpenRead(fileName);
		}
	}
}