#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Seeds compilation cache for given url. Compilation cache does not survive cross-process navigation.
	/// </summary>
	[CommandResponse(ProtocolName.Page.AddCompilationCache)]
	[SupportedBy("Chrome")]
	public class AddCompilationCacheCommandResponse
	{
	}
}
