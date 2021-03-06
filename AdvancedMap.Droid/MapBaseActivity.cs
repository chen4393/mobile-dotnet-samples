﻿using System;
using Android.OS;
using Carto.Layers;
using Carto.PackageManager;
using Carto.Projections;
using Carto.Ui;
using Carto.Utils;
using Shared.Droid;

namespace AdvancedMap.Droid
{
	public class MapBaseActivity : BaseActivity
	{
		protected MapView MapView { get; set; }
		internal Projection BaseProjection { get; set; }
		protected TileLayer BaseLayer { get; set; }

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			MapView = new MapView(this);
			SetContentView(MapView);

			BaseProjection = MapView.Options.BaseProjection;

			Title = GetType().GetTitle();

			if (ActionBar != null)
			{
				ActionBar.Subtitle = GetType().GetDescription();
			}
		}

		protected Carto.Graphics.Bitmap CreateBitmap(int resource)
		{
			return BitmapUtils.CreateBitmapFromAndroidBitmap(Android.Graphics.BitmapFactory.DecodeResource(Resources, resource));
		}

		protected void AddOnlineBaseLayer(CartoBaseMapStyle style)
		{
			// Initialize map
			var baseLayer = new CartoOnlineVectorTileLayer(style);
			MapView.Layers.Add(baseLayer);
		}

		protected void AddOfflineBaseLayer(CartoPackageManager manager, CartoBaseMapStyle style)
		{
			// Initialize map
			var baseLayer = new CartoOfflineVectorTileLayer(manager, style);
			MapView.Layers.Add(baseLayer);
		}
	}
}
