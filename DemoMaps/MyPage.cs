using System;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace DemoMaps
{
	public class MyPage : ContentPage
	{
		public MyPage ()
		{
			var map = new Map(
				MapSpan.FromCenterAndRadius(
					new Position(21.103344699999997,-101.64351599999999), Distance.FromMiles(0.3))) {
				IsShowingUser = true,
				HeightRequest = 100,
				WidthRequest = 960,
				VerticalOptions = LayoutOptions.FillAndExpand
			};

			var position = new Position(21.103344699999997,-101.64351599999999); // Latitude, Longitude
			var pin = new Pin {
				Type = PinType.Place,
				Position = position,
				Label = "I'm here"
			};
			map.Pins.Add(pin);

			var stack = new StackLayout { Spacing = 0 };
			stack.Children.Add(map);
			Content = stack;
		}
	}
}


