using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Stops on the next JavaScript statement.
	/// </summary>
	[Command(ProtocolName.Debugger.Pause)]
	[SupportedBy("Chrome")]
	public class PauseCommand: ICommand<PauseCommandResponse>
	{
	}
}
