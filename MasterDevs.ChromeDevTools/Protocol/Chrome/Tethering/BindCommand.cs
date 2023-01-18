#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Tethering
{
	/// <summary>
	/// Request browser port binding.
	/// </summary>
	[Command(ProtocolName.Tethering.Bind)]
	[SupportedBy("Chrome")]
	public class BindCommand: ICommand<BindCommandResponse>
	{
		/// <summary>
		/// Gets or sets Port number to bind.
		/// </summary>
		public long Port { get; set; }
	}
}
