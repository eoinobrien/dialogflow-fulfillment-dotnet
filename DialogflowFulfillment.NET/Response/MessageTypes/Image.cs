using Newtonsoft.Json;

namespace Dialogflow.NET.Response
{
	public class Image
	{
		public Image(string uri, string accessibilityText = null)
		{
			ImageUri = uri;
			AccessibilityText = accessibilityText;
		}

		[JsonProperty(PropertyName = "imageUri", NullValueHandling = NullValueHandling.Ignore)]
		public string ImageUri { get; set; }


		[JsonProperty(PropertyName = "accessibilityText", NullValueHandling = NullValueHandling.Ignore)]
		public string AccessibilityText { get; set; }
	}
}
