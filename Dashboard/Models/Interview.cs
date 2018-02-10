﻿using MongoDB.Bson.Serialization.Attributes;

namespace Dashboard.Models
{
	[BsonIgnoreExtraElements]
	public class Interview
	{
		public string interviewName { get; set; }
		public string question { get; set; }
		public string answerA { get; set; }
		public string answerB { get; set; }
		public string botAccessToken { get; set; }
	}
}