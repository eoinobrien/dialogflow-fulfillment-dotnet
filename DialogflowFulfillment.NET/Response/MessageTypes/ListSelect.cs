﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Dialogflow.NET.Response
{
	public class ListSelect
	{
		[JsonProperty(PropertyName = "title", NullValueHandling = NullValueHandling.Ignore)]
		public string Title { get; set; }


		[JsonProperty(PropertyName = "items", NullValueHandling = NullValueHandling.Ignore)]
		public List<Item> Items { get; set; }
	}
}
