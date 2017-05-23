﻿
using System;
using CoreGraphics;
using Shared.iOS;
using UIKit;

namespace AdvancedMap.iOS
{
	public class PackageManagerMenu : BaseMenu
	{
		public EventHandler<EventArgs> BackgroundClick;

		public PackageManagerListView List;

		public PackageManagerMenu()
		{
			List = new PackageManagerListView();
			AddSubview(List);
		}

		public void SetFrameWithNavigationBar(nfloat navbarHeight)
		{
			nfloat width = UIScreen.MainScreen.Bounds.Size.Width;
			nfloat height = UIScreen.MainScreen.Bounds.Size.Height;

			List.Frame = new CGRect(0, navbarHeight, width, height - navbarHeight);
		}
	}
}
