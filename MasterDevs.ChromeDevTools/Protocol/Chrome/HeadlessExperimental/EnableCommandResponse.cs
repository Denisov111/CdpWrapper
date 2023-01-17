using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.HeadlessExperimental
{
	/// <summary>
	/// Enables headless events for the target.
	/// </summary>
	[CommandResponse(ProtocolName.HeadlessExperimental.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
