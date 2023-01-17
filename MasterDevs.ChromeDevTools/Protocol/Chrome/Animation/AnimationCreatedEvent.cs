using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Event for each animation that has been created.
	/// </summary>
	[Event(ProtocolName.Animation.AnimationCreated)]
	[SupportedBy("Chrome")]
	public class AnimationCreatedEvent
	{
		/// <summary>
		/// Gets or sets Id of the animation that was created.
		/// </summary>
		public string Id { get; set; }
	}
}
