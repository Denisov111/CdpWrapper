#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Cast
{
	/// <summary>
	/// Stops observing for sinks and issues.
	/// </summary>
	[Command(ProtocolName.Cast.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
