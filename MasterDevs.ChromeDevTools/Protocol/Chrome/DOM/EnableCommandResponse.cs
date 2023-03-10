#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Enables DOM agent for the given page.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
