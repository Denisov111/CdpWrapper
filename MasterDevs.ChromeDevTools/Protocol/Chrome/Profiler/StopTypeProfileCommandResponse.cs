#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Disable type profile. Disabling releases type profile data collected so far.
	/// </summary>
	[CommandResponse(ProtocolName.Profiler.StopTypeProfile)]
	[SupportedBy("Chrome")]
	public class StopTypeProfileCommandResponse
	{
	}
}
