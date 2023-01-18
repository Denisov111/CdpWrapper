#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.SystemInfo{
	/// <summary>
	/// YUV subsampling type of the pixels of a given image.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SubsamplingFormat
	{
			Yuv420,
			Yuv422,
			Yuv444,
	}
}
