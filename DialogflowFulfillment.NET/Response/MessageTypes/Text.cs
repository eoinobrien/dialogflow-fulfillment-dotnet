using Newtonsoft.Json;
using System.Collections.Generic;

namespace Dialogflow.NET.Response
{
	public class Text
	{
		public Text()
		{
			TextList = new List<string>();
		}


		[JsonProperty(PropertyName = "text", NullValueHandling = NullValueHandling.Ignore)]
		public List<string> TextList { get; set; }


		public void Add(string response)
		{
			TextList.Add(response);
		}
	}
}
