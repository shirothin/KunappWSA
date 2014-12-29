using System.Collections.Generic;
using Windows.UI.Xaml.Controls;using System;
using Syndication;

namespace SDKTemplate
{
	public partial class MainPage : Page
	{
		public const string FEATURE_NAME = "KunappWSA";

		List<Scenario> scenarios = new List<Scenario>
		{
			new Scenario() { Title = "Home", ClassType = typeof(S0_Welcome) },
			new Scenario() { Title = "Feed", ClassType = typeof(S1_GetAFeed) },
			new Scenario() { Title = "Tweet", ClassType = typeof(S2_Tweet) },
		};
			
	}

	public class Scenario
	{
		public string Title { get; set; }

		public Type ClassType { get; set; }

		public override string ToString()
		{
			return Title;
		}
	}
}
