using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Overlay
{
	[CommandResponse(ProtocolName.Overlay.SetPausedInDebuggerMessage)]
	[SupportedBy("Chrome")]
	public class SetPausedInDebuggerMessageCommandResponse
	{
	}
}
