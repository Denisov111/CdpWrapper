#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	/// Enables the WebAudio domain and starts sending context lifetime events.
	/// </summary>
	[CommandResponse(ProtocolName.WebAudio.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
