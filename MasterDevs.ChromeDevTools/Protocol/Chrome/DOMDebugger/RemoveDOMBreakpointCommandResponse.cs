#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOMDebugger
{
	/// <summary>
	/// Removes DOM breakpoint that was set using `setDOMBreakpoint`.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.RemoveDOMBreakpoint)]
	[SupportedBy("Chrome")]
	public class RemoveDOMBreakpointCommandResponse
	{
	}
}
