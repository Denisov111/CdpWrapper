using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Highlights owner element of all frames detected to be ads.
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.SetShowAdHighlights)]
	[SupportedBy("Chrome")]
	public class SetShowAdHighlightsCommandResponse
	{
	}
}
