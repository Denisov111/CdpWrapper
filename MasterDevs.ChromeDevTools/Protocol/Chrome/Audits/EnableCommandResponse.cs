using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	/// Enables issues domain, sends the issues collected so far to the client by means of the `issueAdded` event.
	/// </summary>
	[CommandResponse(ProtocolName.Audits.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
