#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Capture page screenshot.
	/// </summary>
	[CommandResponse(ProtocolName.Page.CaptureScreenshot)]
	[SupportedBy("Chrome")]
	public class CaptureScreenshotCommandResponse
	{
		/// <summary>
		/// Gets or sets Base64-encoded image data. (Encoded as a base64 string when passed over JSON)
		/// </summary>
		public string Data { get; set; }
	}
}
