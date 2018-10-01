using Newtonsoft.Json;

namespace Dialogflow.NET.Request
{
	public class OriginalDetectIntentRequest
	{
		[JsonProperty(PropertyName = "payload")]
		public object Payload { get; set; }
	}
}
