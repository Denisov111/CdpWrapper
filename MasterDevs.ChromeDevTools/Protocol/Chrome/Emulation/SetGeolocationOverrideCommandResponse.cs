#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Overrides the Geolocation Position or Error. Omitting any of the parameters emulates position unavailable.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetGeolocationOverride)]
	[SupportedBy("Chrome")]
	public class SetGeolocationOverrideCommandResponse
	{
	}
}
