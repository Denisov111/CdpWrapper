#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Allows overriding user agent with the given string.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetUserAgentOverride)]
	[SupportedBy("Chrome")]
	public class SetUserAgentOverrideCommandResponse
	{
	}
}
