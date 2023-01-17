using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.Network{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CrossOriginOpenerPolicyValue
	{
			SameOrigin,
			SameOriginAllowPopups,
			RestrictProperties,
			UnsafeNone,
			SameOriginPlusCoep,
			RestrictPropertiesPlusCoep,
	}
}
