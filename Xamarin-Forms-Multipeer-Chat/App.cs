using System;
using Xamarin.Forms;

namespace XamarinFormsMultipeerChat
{
	public class App
	{
		public static Page GetMainPage ()
		{	

			var mainNav = new NavigationPage (new MultipeerChat ()); 

			return mainNav;

		}
	}
}

