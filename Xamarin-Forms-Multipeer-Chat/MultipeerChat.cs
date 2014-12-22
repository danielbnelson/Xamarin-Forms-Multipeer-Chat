using System;
using Xamarin.Forms;

namespace XamarinFormsMultipeerChat
{
	public class MultipeerChat : ContentPage
	{
		public String Heading;

		public MultipeerChat ()
		{
			Title = "Third Page";

			Heading = "This is the third page";

			// rendering of this page is done natively on each platform, otherwise it will just be blank
		}
	}
}

