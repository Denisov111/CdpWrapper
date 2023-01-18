#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Tethering
{
	/// <summary>
	/// Request browser port unbinding.
	/// </summary>
	[Command(ProtocolName.Tethering.Unbind)]
	[SupportedBy("Chrome")]
	public class UnbindCommand: ICommand<UnbindCommandResponse>
	{
		/// <summary>
		/// Gets or sets Port number to unbind.
		/// </summary>
		public long Port { get; set; }
	}
}
