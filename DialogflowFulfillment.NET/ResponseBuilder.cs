using Dialogflow.NET.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dialogflow.NET
{
	public class ResponseBuilder
	{
		public V2Response Response;

		private Platform platform;


		public ResponseBuilder(Platform platform = Platform.PLATFORM_UNSPECIFIED)
		{
			Response = new V2Response();
			this.platform = platform;
		}


		public V2Response Reply(string text, string ssml = null)
		{
			if (string.IsNullOrWhiteSpace(Response.FulfillmentText))
			{
				Response.FulfillmentText = text;
			}

			RichResponse richResponse = new RichResponse(platform);

			if (platform == Platform.ACTIONS_ON_GOOGLE)
			{
				richResponse.SimpleResponses = new SimpleResponses();
				richResponse.SimpleResponses.Add(new SimpleResponse(text, ssml));
			}
			else
			{
				richResponse.Text = new Text();
				richResponse.Text.Add(text);
			}

			Response.FulfillmentMessages.Add(richResponse);

			return Response;
		}


		public V2Response ReplyWithCard(string title, string subtitle)
		{
			RichResponse richResponse = new RichResponse(platform);

			if (platform == Platform.ACTIONS_ON_GOOGLE)
			{
				richResponse.BasicCard = new BasicCard
				{
					Title = title,
					SubTitle = subtitle
				};
			}
			else
			{
				richResponse.Card = new Card
				{
					Title = title,
					SubTitle = subtitle
				};
			}

			Response.FulfillmentMessages.Add(richResponse);

			return Response;
		}


		public V2Response ReplyWithImage(string imageUri, string accesibilityText = null)
		{
			RichResponse richResponse = new RichResponse(platform);
			Image image = new Image(imageUri, accesibilityText);

			if (platform == Platform.ACTIONS_ON_GOOGLE)
			{
				// Basic Card with just an image
				richResponse.BasicCard = new BasicCard();
				richResponse.BasicCard.Image.Add(image);
			}
			else
			{
				richResponse.Image = image;
			}

			Response.FulfillmentMessages.Add(richResponse);

			return Response;
		}


		public V2Response ReplyWithImages(List<Image> images)
		{

			if (platform == Platform.ACTIONS_ON_GOOGLE)
			{
				RichResponse richResponse = new RichResponse(platform)
				{
					BasicCard = new BasicCard
					{
						Image = images
					}
				};

				Response.FulfillmentMessages.Add(richResponse);
			}
			else
			{
				foreach (Image image in images)
				{
					RichResponse richResponse = new RichResponse(platform);

					richResponse.BasicCard.Image.Add(image);
					richResponse.Image = image;
					
					Response.FulfillmentMessages.Add(richResponse);
				}
			}

			return Response;
		}


		public V2Response AddSuggestion(string suggestion, string title = null)
		{
			RichResponse richResponse = new RichResponse(platform);

			if (platform == Platform.ACTIONS_ON_GOOGLE)
			{
				richResponse.Suggestions = new Suggestions();
				richResponse.Suggestions.Add(suggestion);
			}
			else
			{
				richResponse = Response.FulfillmentMessages.FirstOrDefault(msg => msg.QuickReplies != null);

				richResponse.QuickReplies = new QuickReplies
				{
					Title = title
				};
				richResponse.QuickReplies.Add(suggestion);
			}

			Response.FulfillmentMessages.Add(richResponse);

			return Response;
		}
	}
}
