#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Memory
{
	/// <summary>
	/// Enable/disable suppressing memory pressure notifications in all processes.
	/// </summary>
	[CommandResponse(ProtocolName.Memory.SetPressureNotificationsSuppressed)]
	[SupportedBy("Chrome")]
	public class SetPressureNotificationsSuppressedCommandResponse
	{
	}
}
