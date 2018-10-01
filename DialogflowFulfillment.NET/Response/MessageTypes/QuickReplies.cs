using Newtonsoft.Json;
using System.Collections.Generic;

namespace Dialogflow.NET.Response
{
	public class QuickReplies
	{
		[JsonProperty(PropertyName = "title", NullValueHandling = NullValueHandling.Ignore)]
		public string Title { get; set; }


		[JsonProperty(PropertyName = "quickReplies", NullValueHandling = NullValueHandling.Ignore)]
		public List<string> QuickRepliesList { get; set; } = new List<string>();


		public void Add(string quickReply)
		{
			QuickRepliesList.Add(quickReply);
		}
	}
}
