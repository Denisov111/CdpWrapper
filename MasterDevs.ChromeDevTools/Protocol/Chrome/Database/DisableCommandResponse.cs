#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Database
{
	/// <summary>
	/// Disables database tracking, prevents database events from being sent to the client.
	/// </summary>
	[CommandResponse(ProtocolName.Database.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}
