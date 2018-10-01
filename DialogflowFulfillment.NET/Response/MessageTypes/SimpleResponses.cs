using Newtonsoft.Json;
using System.Collections.Generic;

namespace Dialogflow.NET.Response
{
	public class SimpleResponses
	{
		public SimpleResponses()
		{
			SimpleResponsesList = new List<SimpleResponse>();
		}


		[JsonProperty(PropertyName = "simpleResponses", NullValueHandling = NullValueHandling.Ignore)]
		public List<SimpleResponse> SimpleResponsesList { get; set; }


		public void Add(SimpleResponse response)
		{
			SimpleResponsesList.Add(response);
		}
	}


	public class SimpleResponse
	{
		public SimpleResponse(string text, string ssml = null)
		{
			if (!string.IsNullOrWhiteSpace(ssml))
			{
				Ssml = ssml;
			}
			else
			{
				TextToSpeech = text;
			}

			DisplayText = text;
		}


		[JsonProperty(PropertyName = "textToSpeech", NullValueHandling = NullValueHandling.Ignore)]
		public string TextToSpeech { get; set; }


		[JsonProperty(PropertyName = "ssml", NullValueHandling = NullValueHandling.Ignore)]
		public string Ssml { get; set; }


		[JsonProperty(PropertyName = "displayText", NullValueHandling = NullValueHandling.Ignore)]
		public string DisplayText { get; set; }
	}
}
