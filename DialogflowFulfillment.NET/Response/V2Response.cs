﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Dialogflow.NET.Response
{
	public class V2Response
	{
		public V2Response()
		{
			FulfillmentMessages = new List<RichResponse>();
		}

		[JsonProperty(PropertyName = "fulfillmentText", NullValueHandling = NullValueHandling.Ignore)]
		public string FulfillmentText { get; set; }

		[JsonProperty(PropertyName = "fulfillmentMessages", NullValueHandling = NullValueHandling.Ignore)]
		public List<RichResponse> FulfillmentMessages { get; set; }

		[JsonProperty(PropertyName = "source", NullValueHandling = NullValueHandling.Ignore)]
		public string Source { get; set; }

		[JsonProperty(PropertyName = "payload", NullValueHandling = NullValueHandling.Ignore)]
		public Dictionary<string, string> Payload { get; set; }

		[JsonProperty(PropertyName = "outputContexts", NullValueHandling = NullValueHandling.Ignore)]
		public List<Context> OutputContexts { get; set; }

		[JsonProperty(PropertyName = "followupEventInput", NullValueHandling = NullValueHandling.Ignore)]
		public EventInput FollowupEventInput { get; set; }
	}
}
