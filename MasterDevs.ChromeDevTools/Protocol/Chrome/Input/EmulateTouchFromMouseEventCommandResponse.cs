#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	/// Emulates touch event from the mouse event parameters.
	/// </summary>
	[CommandResponse(ProtocolName.Input.EmulateTouchFromMouseEvent)]
	[SupportedBy("Chrome")]
	public class EmulateTouchFromMouseEventCommandResponse
	{
	}
}
