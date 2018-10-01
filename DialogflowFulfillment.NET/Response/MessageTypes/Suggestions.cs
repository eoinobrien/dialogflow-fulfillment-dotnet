using Newtonsoft.Json;
using System.Collections.Generic;

namespace Dialogflow.NET.Response
{
	public class Suggestions
	{
		[JsonProperty(PropertyName = "suggestions", NullValueHandling = NullValueHandling.Ignore)]
		public List<Suggestion> SuggestionsList { get; set; } = new List<Suggestion>();


		public void Add(string suggestion)
		{
			SuggestionsList.Add(new Suggestion(suggestion));
		}
	}


	public class Suggestion
	{
		public Suggestion(string title)
		{
			Title = title;
		}
		

		[JsonProperty(PropertyName = "title", NullValueHandling = NullValueHandling.Ignore)]
		public string Title { get; set; }
	}
}
