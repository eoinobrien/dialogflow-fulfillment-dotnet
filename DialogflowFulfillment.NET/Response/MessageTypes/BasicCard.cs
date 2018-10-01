using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Dialogflow.NET.Response
{
	public class BasicCard
	{
		[JsonProperty(PropertyName = "title", NullValueHandling = NullValueHandling.Ignore)]
		public string Title { get; set; }


		[JsonProperty(PropertyName = "subtitle", NullValueHandling = NullValueHandling.Ignore)]
		public string SubTitle { get; set; }


		[JsonProperty(PropertyName = "formattedText", NullValueHandling = NullValueHandling.Ignore)]
		public string FormattedText { get; set; }


		[JsonProperty(PropertyName = "image", NullValueHandling = NullValueHandling.Ignore)]
		public List<Image> Image { get; set; }


		[JsonProperty(PropertyName = "buttons", NullValueHandling = NullValueHandling.Ignore)]
		public List<BasicCardButton> Buttons { get; set; }
	}


	public class BasicCardButton
	{
		public BasicCardButton(string title, string uri)
		{
			if (string.IsNullOrWhiteSpace(title))
			{
				throw new ArgumentNullException(nameof(title), string.Format("'{0}' in a BasicCardButton requires a value", nameof(title)));
			}

			if (string.IsNullOrWhiteSpace(uri))
			{
				throw new ArgumentNullException(nameof(uri), string.Format("'{0}' in a BasicCardButton requires a value", nameof(uri)));
			}

			Title = title;
			OpenUriAction = new OpenUriAction(uri);
		}

		[JsonProperty(PropertyName = "title", NullValueHandling = NullValueHandling.Ignore)]
		public string Title { get; set; }


		[JsonProperty(PropertyName = "openUriAction", NullValueHandling = NullValueHandling.Ignore)]
		public OpenUriAction OpenUriAction { get; set; }
	}


	public class OpenUriAction
	{
		public OpenUriAction(string uri)
		{
			if (string.IsNullOrWhiteSpace(uri))
			{
				throw new ArgumentNullException(nameof(uri), string.Format("'{0}' in a OpenUriAction requires a value", nameof(uri)));
			}

			Uri = uri;
		}

		[JsonProperty(PropertyName = "uri", NullValueHandling = NullValueHandling.Ignore)]
		public string Uri { get; set; }
	}
}
