// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LMT71 {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("LocationTableViewController")]
	public partial class LocationTableViewController {
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		private MonoTouch.UIKit.UIBarButtonItem __mt_startLocation;
		
		private MonoTouch.UIKit.UIBarButtonItem __mt_stopLocation;
		
		private MonoTouch.UIKit.UITableView __mt_locationTable;
		
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
		
		[MonoTouch.Foundation.Connect("startLocation")]
		private MonoTouch.UIKit.UIBarButtonItem startLocation {
			get {
				this.__mt_startLocation = ((MonoTouch.UIKit.UIBarButtonItem)(this.GetNativeField("startLocation")));
				return this.__mt_startLocation;
			}
			set {
				this.__mt_startLocation = value;
				this.SetNativeField("startLocation", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("stopLocation")]
		private MonoTouch.UIKit.UIBarButtonItem stopLocation {
			get {
				this.__mt_stopLocation = ((MonoTouch.UIKit.UIBarButtonItem)(this.GetNativeField("stopLocation")));
				return this.__mt_stopLocation;
			}
			set {
				this.__mt_stopLocation = value;
				this.SetNativeField("stopLocation", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("locationTable")]
		private MonoTouch.UIKit.UITableView locationTable {
			get {
				this.__mt_locationTable = ((MonoTouch.UIKit.UITableView)(this.GetNativeField("locationTable")));
				return this.__mt_locationTable;
			}
			set {
				this.__mt_locationTable = value;
				this.SetNativeField("locationTable", value);
			}
		}
	}
}
