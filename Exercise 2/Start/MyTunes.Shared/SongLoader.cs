using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;
using System.Reflection;
using MyTunes.Shared;

namespace MyTunes
{
	public static class SongLoader
	{
		public static IStreamLoader streamLoader { get; set; }
		const string Filename = "songs.json";

		public static async Task<IEnumerable<Song>> Load()
		{
			using (var reader = new StreamReader(OpenData())) {
				return JsonConvert.DeserializeObject<List<Song>>(await reader.ReadToEndAsync());
			}
		}

		private static Stream OpenData()
		{
			if (SongLoader.streamLoader == null)
			{
				throw new OperationCanceledException("Missing strem loader instance");
			}
			return streamLoader.GetStreamFromFile(Filename);
		}
	}
}

