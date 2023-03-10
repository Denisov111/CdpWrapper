#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Searches for given string in resource content.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SearchInResource)]
	[SupportedBy("Chrome")]
	public class SearchInResourceCommandResponse
	{
		/// <summary>
		/// Gets or sets List of search matches.
		/// </summary>
		public Debugger.SearchMatch[] Result { get; set; }
	}
}
