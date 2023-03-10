#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Terminate current or next JavaScript execution. Will cancel the termination when the outer-most script execution ends.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.TerminateExecution)]
	[SupportedBy("Chrome")]
	public class TerminateExecutionCommandResponse
	{
	}
}
