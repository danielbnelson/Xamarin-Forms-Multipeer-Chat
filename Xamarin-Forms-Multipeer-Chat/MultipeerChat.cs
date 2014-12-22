using System;
using Xamarin.Forms;

namespace XamarinFormsMultipeerChat
{
	public class MultipeerChat : ContentPage
	{
		public String Heading;


		/*
		 * 
		 * Monkey app
		 * https://github.com/mikebluestein/FindTheMonkey/blob/master/FindTheMonkey/FindTheMonkeyViewController.cs
		 * 
		 * [12/22/14, 11:32:52 AM] Tri Nguyen: OK - so the idea
[12/22/14, 11:32:55 AM] Tri Nguyen: 1 - Form
[12/22/14, 11:33:05 AM] Tri Nguyen: 2 - Xamarin.iOS Renderer
[12/22/14, 11:33:10 AM] Tri Nguyen: -------
[12/22/14, 11:34:03 AM] Tri Nguyen: On Forms: You will need to clone the same Delegate, let us call that CustomMCSessionDelgate.

[12/22/14, 11:34:41 AM] Tri Nguyen: On Form, you will need to have a Custom Page, work with CustomMCSessionDelegate.
[12/22/14, 11:35:11 AM] Tri Nguyen: ---- Now. we have 2 classes on Form, CustomMCSessionDelgate and Custom Page.

Move to Xamarin.iOS Render, you will need a Page Renderer class for implementing Custom Page and input CustomMCSessionDelegate.

[12/22/14, 11:37:23 AM] Tri Nguyen: we copy all FindTheMonkeyViewController.cs to this Page Renderer
(need some customizes for getting it works, like PayAnyWhere). 
Then when any function of MySessionDelegate is fired, we fire CustomMCSessionDelgate
[12/22/14, 11:37:26 AM] Tri Nguyen: That's all.

Connect CustomMCSessionDelgate (from Xamarin.Form) to MySessionDelegate : MCSessionDelegate (Xamarin.iOS Renderer). 
Everytime  MCSessionDelegate fire event, we fire the same event (cloned) of CustomMCSesionDelegate


Requirements:

1 - Have discover button which searches other devices
	Can select device to pair the device"

2 - have textfield and submit button
	When text is entered, that text is then a pop up on the other device(s)

*/
	


		public MultipeerChat ()
		{
			Content = new StackLayout {
				Children = {
					new Label {
						Text = "Howdy.",
					}, 
		
				},
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};
		}



	}


}

