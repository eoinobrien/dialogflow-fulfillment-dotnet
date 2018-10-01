using Newtonsoft.Json;

namespace Dialogflow.NET.Request
{
	public class Intent
	{
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		[JsonProperty(PropertyName = "displayName")]
		public string DisplayName { get; set; }
	}
}
