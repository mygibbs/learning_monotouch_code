// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LMT81 {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("MapController")]
	public partial class MapController {
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		private MonoTouch.MapKit.MKMapView __mt_map;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("view")]
		private MonoTouch.UIKit.UIView view {
			get {
				this.__mt_view = ((MonoTouch.UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("map")]
		private MonoTouch.MapKit.MKMapView map {
			get {
				this.__mt_map = ((MonoTouch.MapKit.MKMapView)(this.GetNativeField("map")));
				return this.__mt_map;
			}
			set {
				this.__mt_map = value;
				this.SetNativeField("map", value);
			}
		}
	}
}
