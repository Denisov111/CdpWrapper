#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Returns present frame / resource tree structure.
	/// </summary>
	[Command(ProtocolName.Page.GetResourceTree)]
	[SupportedBy("Chrome")]
	public class GetResourceTreeCommand: ICommand<GetResourceTreeCommandResponse>
	{
	}
}
