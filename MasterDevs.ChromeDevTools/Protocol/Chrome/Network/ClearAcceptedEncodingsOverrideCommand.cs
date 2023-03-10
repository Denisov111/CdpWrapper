#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Clears accepted encodings set by setAcceptedEncodings
	/// </summary>
	[Command(ProtocolName.Network.ClearAcceptedEncodingsOverride)]
	[SupportedBy("Chrome")]
	public class ClearAcceptedEncodingsOverrideCommand: ICommand<ClearAcceptedEncodingsOverrideCommandResponse>
	{
	}
}
