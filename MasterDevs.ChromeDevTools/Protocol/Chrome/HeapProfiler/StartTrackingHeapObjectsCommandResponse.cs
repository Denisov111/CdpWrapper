#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[CommandResponse(ProtocolName.HeapProfiler.StartTrackingHeapObjects)]
	[SupportedBy("Chrome")]
	public class StartTrackingHeapObjectsCommandResponse
	{
	}
}
