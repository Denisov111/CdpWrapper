#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Enables reporting of execution contexts creation by means of `executionContextCreated` event. When the reporting gets enabled the event will be sent immediately for each existing execution context.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
