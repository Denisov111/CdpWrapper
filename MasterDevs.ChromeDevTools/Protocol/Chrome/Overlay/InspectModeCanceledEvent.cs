#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Fired when user cancels the inspect mode.
	/// </summary>
	[Event(ProtocolName.Overlay.InspectModeCanceled)]
	[SupportedBy("Chrome")]
	public class InspectModeCanceledEvent
	{
	}
}
