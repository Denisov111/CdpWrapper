#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Profiler
{
	[Command(ProtocolName.Profiler.Stop)]
	[SupportedBy("Chrome")]
	public class StopCommand: ICommand<StopCommandResponse>
	{
	}
}
