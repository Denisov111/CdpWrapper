using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.CollectGarbage)]
	[SupportedBy("Chrome")]
	public class CollectGarbageCommand: ICommand<CollectGarbageCommandResponse>
	{
	}
}
