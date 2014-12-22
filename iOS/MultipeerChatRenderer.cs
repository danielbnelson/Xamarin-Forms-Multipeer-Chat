﻿using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;


// This ExportRenderer command tells Xamarin.Forms to use this renderer
// instead of the built-in one for this page
using MonoTouch.UIKit;
using System.Drawing;


[assembly:ExportRenderer(typeof(XamarinFormsMultipeerChat.MultipeerChat), typeof(XamarinFormsMultipeerChat.MultipeerChatRenderer))]

namespace XamarinFormsMultipeerChat
{
	/// <summary>
	/// Render this page using platform-specific UIKit controls
	/// </summary>
	public class MultipeerChatRenderer : PageRenderer
	{
		protected override void OnElementChanged (VisualElementChangedEventArgs e)
		{
			base.OnElementChanged (e);

			var page = e.NewElement as MultipeerChat;

			var hostViewController = ViewController;

			var viewController = new UIViewController ();

			var label = new UILabel (new RectangleF(0, 40, 320, 40));
			label.Text = "3 " + page.Heading;
			viewController.View.Add (label);

			hostViewController.AddChildViewController (viewController);
			hostViewController.View.Add (viewController.View);

			viewController.DidMoveToParentViewController (hostViewController);
		}
	}
}

