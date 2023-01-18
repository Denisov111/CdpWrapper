#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Sets given cookies.
	/// </summary>
	[Command(ProtocolName.Network.SetCookies)]
	[SupportedBy("Chrome")]
	public class SetCookiesCommand: ICommand<SetCookiesCommandResponse>
	{
		/// <summary>
		/// Gets or sets Cookies to be set.
		/// </summary>
		public CookieParam[] Cookies { get; set; }
	}
}
