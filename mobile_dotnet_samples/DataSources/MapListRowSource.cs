﻿
using System;
using UIKit;

namespace Shared.iOS
{
	public class MapListRowSource
	{
		public string Title { get; set; }

		public string Description { get; set; }

		public bool IsHeader { get { return Description == "Header"; } }

		public UIViewController Controller { get; set; }
	}
}

