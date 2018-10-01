using Newtonsoft.Json;

namespace Dialogflow.NET.Response
{
	public class LinkOutSuggestion
	{
		[JsonProperty(PropertyName = "destinationName", NullValueHandling = NullValueHandling.Ignore)]
		public string DestinationName { get; set; }


		[JsonProperty(PropertyName = "uri", NullValueHandling = NullValueHandling.Ignore)]
		public string Uri { get; set; }
	}
}
