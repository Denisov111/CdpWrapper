#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Switches script execution in the page.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetScriptExecutionDisabled)]
	[SupportedBy("Chrome")]
	public class SetScriptExecutionDisabledCommandResponse
	{
	}
}
