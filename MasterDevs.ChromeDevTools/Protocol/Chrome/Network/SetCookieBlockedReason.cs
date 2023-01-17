using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.Network{
	/// <summary>
	/// Types of reasons why a cookie may not be stored from a response.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SetCookieBlockedReason
	{
			SecureOnly,
			SameSiteStrict,
			SameSiteLax,
			SameSiteUnspecifiedTreatedAsLax,
			SameSiteNoneInsecure,
			UserPreferences,
			SyntaxError,
			SchemeNotSupported,
			OverwriteSecure,
			InvalidDomain,
			InvalidPrefix,
			UnknownError,
			SchemefulSameSiteStrict,
			SchemefulSameSiteLax,
			SchemefulSameSiteUnspecifiedTreatedAsLax,
			SamePartyFromCrossPartyContext,
			SamePartyConflictsWithOtherAttributes,
			NameValuePairExceedsMaxSize,
	}
}
