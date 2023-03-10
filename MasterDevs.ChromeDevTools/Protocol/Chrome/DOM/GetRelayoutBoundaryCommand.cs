#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns the id of the nearest ancestor that is a relayout boundary.
	/// </summary>
	[Command(ProtocolName.DOM.GetRelayoutBoundary)]
	[SupportedBy("Chrome")]
	public class GetRelayoutBoundaryCommand: ICommand<GetRelayoutBoundaryCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the node.
		/// </summary>
		public long NodeId { get; set; }
	}
}
