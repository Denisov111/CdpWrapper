#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Console
{
	/// <summary>
	/// Enables console domain, sends the messages collected so far to the client by means of the `messageAdded` notification.
	/// </summary>
	[CommandResponse(ProtocolName.Console.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
