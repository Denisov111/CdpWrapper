using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.WebAudio{
	/// <summary>
	/// Enum of BaseAudioContext types
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ContextType
	{
			Realtime,
			Offline,
	}
}
